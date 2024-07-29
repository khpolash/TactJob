using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tactsoft.Core.Entities;
using Tactsoft.Core.ViewModel;
using Tactsoft.Service.Services;
using BC = BCrypt.Net.BCrypt;

namespace Tactsoft.Controllers
{
    public class AccountController : Controller
    {
        private readonly IJobCategoryService _jobCategoryService;
        private readonly IAccountService _accountService;
        private readonly ICountryService _countryService;
        private readonly IDistrictService _districtService;
        private readonly IThanaService _thanaService;
        private readonly IIndustryTypeService _industryTypeService;
        private readonly ICompanySizeService _companySizeService;
        private readonly ICompanyService _companyService;

        public AccountController(IJobCategoryService jobCategoryService, IAccountService accountService, ICountryService countryService, IDistrictService districtService, IThanaService thanaService, IIndustryTypeService industryTypeService, ICompanySizeService companySizeService, ICompanyService companyService)
        {
            this._jobCategoryService = jobCategoryService;
            this._accountService = accountService;
            this._countryService = countryService;
            this._districtService = districtService;
            this._thanaService = thanaService;
            this._industryTypeService = industryTypeService;
            this._companySizeService = companySizeService;
            _companyService = companyService;
        }

        public IActionResult Register()
        {
            ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var userNameExists = _accountService.All().Any(x => x.UserName == registerViewModel.UserName);
                var emailExists = _accountService.All().Any(x => x.EmailAddress == registerViewModel.EmailAddress);
                if (userNameExists)
                {
                    ModelState.AddModelError(string.Empty, registerViewModel.UserName + "Alrready exists");
                    ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                }
                else if (emailExists)
                {
                    ModelState.AddModelError(string.Empty, registerViewModel.EmailAddress + "Alrready exists");
                    ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                    return View(registerViewModel);
                }

                var user = new Jobseeker
                {
                    JobseekerName = registerViewModel.JobseekerName,
                    UserName = registerViewModel.UserName,
                    JobCategoryId = registerViewModel.JobCategoryId,
                    Gender = registerViewModel.Gender,
                    EmailAddress = registerViewModel.EmailAddress,
                    PhoneNumber = registerViewModel.PhoneNumber,
                    Password = BCrypt.Net.BCrypt.HashPassword(registerViewModel.Password),
                    Agree = registerViewModel.Agree,
                    Subscribe = registerViewModel.Subscribe,
                    User_type = "Jobseeker",
                };
                await _accountService.InsertAsync(user);
                return RedirectToAction("Index", "JobSeekerDashboard");
            }

            ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
            return View(registerViewModel);

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _accountService.All().Where(x => x.UserName == model.UserName).FirstOrDefault();
                if (user != null)
                {
                    bool verified = BC.Verify(model.Password, user.Password);

                    if (verified)
                    {
                        var identity = new ClaimsIdentity(new[] {
                            new Claim(ClaimTypes.Name, user.UserName),
                       
                            new Claim(ClaimTypes.Role,user.User_type),
                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString("UserName", user.UserName);
                        HttpContext.Session.SetString("UserEmail", user.EmailAddress);
                        return RedirectToAction("Index", "JobSeekerDashboard");
                    }
                    else
                    {
                        TempData["Message"] = "Invalid Password";
                        return RedirectToAction("Login", "Account");
                    }
                }
                else
                {
                    TempData["Message"] = "Sorry Uesr not found";
                    return RedirectToAction("Login", "Account");
                }
            }
            return View();
        }


        public IActionResult CompanyRegister()
        {
            ViewData["CountryId"] = _countryService.Dropdown();
            ViewData["DistrictId"] = _districtService.Dropdown();
            ViewData["ThanaId"] = _thanaService.Dropdown();
            ViewData["IndustialTypeId"] = _industryTypeService.Dropdown();
            ViewData["CompanySizeId"] = _companySizeService.Dropdown();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CompanyRegister(CompanyRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var companyuser = _companyService.All().Any(x => x.UserName == model.UserName);
                if (companyuser)
                {
                    ModelState.AddModelError(string.Empty, model.UserName + "Alrready exists");
                    ViewData["CountryId"] = _countryService.Dropdown();
                    ViewData["DistrictId"] = _districtService.Dropdown();
                    ViewData["ThanaId"] = _thanaService.Dropdown();
                    ViewData["IndustialTypeId"] = _industryTypeService.Dropdown();
                    ViewData["CompanySizeId"] = _companySizeService.Dropdown();
                }

                var comuser = new Company
                {
                    UserName = model.UserName,
                    Entrepreneur = model.Entrepreneur,
                    CountryId = model.CountryId,
                    ThanaId = model.ThanaId,
                    CompanyAddressBangla = model.CompanyAddressBangla,
                    CompanyAddressEnglish = model.CompanyAddressEnglish,
                    CompanyEmailAdress = model.CompanyEmailAdress,
                    CompanySizeId = model.CompanySizeId,
                    CompanyNameBanglaName = model.CompanyNameBanglaName,
                    CompanyNameEnglishName = model.CompanyNameEnglishName,
                    ContactPersonDesignation = model.ContactPersonDesignation,
                    ContactPersonEmail = model.ContactPersonEmail,
                    ContactPersonMobile = model.ContactPersonMobile,
                    ContactPersonName = model.ContactPersonName,
                    BusinessDescription = model.BusinessDescription,
                    DistrictId = model.DistrictId,
                    BusinessTradeLicienceNo = model.BusinessTradeLicienceNo,
                    RLNO = model.RLNO,
                    Password = BC.HashPassword(model.Password),
                    IndustialTypeId = model.IndustialTypeId,
                    WebsiteUrl = model.WebsiteUrl,
                    User_type = "Company"

                };
                await _companyService.InsertAsync(comuser);
                return RedirectToAction("CompanyLogin", "Account");

            }
            ViewData["CountryId"] = _countryService.Dropdown();
            ViewData["DistrictId"] = _districtService.Dropdown();
            ViewData["ThanaId"] = _thanaService.Dropdown();
            ViewData["IndustialTypeId"] = _industryTypeService.Dropdown();
            ViewData["CompanySizeId"] = _companySizeService.Dropdown();
            return View(model);

        }




        public IActionResult CompanyLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CompanyLogin(CompanyLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _companyService.All().Where(x => x.UserName == model.UserName).FirstOrDefault();
                if (user != null)
                {
                    bool verified = BC.Verify(model.Password, user.Password);

                    if (verified)
                    {
                        var Identity = new ClaimsIdentity(new[] {

                            new Claim(ClaimTypes.Name, user.UserName),
                            new Claim(ClaimTypes.Role,user.User_type)

                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(Identity);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString("UserName", user.UserName);
                        return RedirectToAction("Index", "CompanyDashboard");
                    }
                    else
                    {
                        TempData["Message"] = "Invalid Password";
                        return RedirectToAction("Login", "Account");
                    }
                }
                else
                {
                    TempData["Message"] = "Sorry Uesr not found";
                    return RedirectToAction("Login", "Account");
                }
            }
            return View();

        }



        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
