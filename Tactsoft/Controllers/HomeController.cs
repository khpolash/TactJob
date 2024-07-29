using Tactsoft.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tactsoft.Service.Services;
using Microsoft.EntityFrameworkCore;
using Tactsoft.Core.ViewModel;
using Tactsoft.Core.Entities;

namespace Tactsoft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDistrictService _districtService;
        private readonly IAccountService _accountService;
        private readonly IJobApplicationService _JobApplicationService;
        private readonly IJobServices _IJobServices;
        private readonly ICountryService _countryService;
        private readonly IPostingJobsService _postingJobsService;
        public HomeController(ILogger<HomeController> logger, IAccountService accountService, IDistrictService districtService, IJobApplicationService jobApplicationService, IJobServices iJobServices, ICountryService countryService, IPostingJobsService postingJobsService)
        {
            _logger = logger;
            _districtService = districtService;
            _IJobServices = iJobServices;
            _accountService = accountService;

            _JobApplicationService = jobApplicationService;
            _countryService = countryService;
            _postingJobsService = postingJobsService;
        }

        public IActionResult Index()
        {
            FrontendViewModel vm = new FrontendViewModel();
            vm.JobViewModels = _IJobServices.GetJobByCategory();
            vm.NumberOfJobs = _IJobServices.NumberOfJobs();
            vm.NumberOfNewJobs = _IJobServices.NumberOfNewJobs();
            vm.NumberOfCompanies = _IJobServices.NumberOfCompanies();
            vm.NumberOfVacancies = _IJobServices.NumberOfVacancies();
            vm.HotJobsView= _IJobServices.HotJobsView();
            //vm.TotalJobTiltles =_IJobServices.TotalJobTiltleView();
            return View(vm);
        }

        public IActionResult AllJobByCategory(long id)
        {
            var data = _postingJobsService.All().Where(x=>x.JobCategoryeId==id)
                .Include(x=>x.JobCategory)
                .ToList();
            return View(data);
        }
        
        public async Task<IActionResult> JobDetails(long id)
        {
            var data = await _postingJobsService.FindAsync(x => x.Id == id, i => i.JobCategory, x => x.ServiceType, x => x.ResumeReceivingOption, x => x.IndustryType);
            return View(data);
        }




        public ActionResult JobApp()
        {


            var logincheck = @User.Identity.Name;

            if (logincheck!= null)

            {
                return View();

            }


            return RedirectToAction("Login", "Account");




        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> JobApp(long id ,JobApplication jobApplication)
        {

            var userid = @User.Identity.Name;
            var jobseekers = await _accountService.FindAsync(x => x.JobseekerName == userid);

            var user = new JobApplication
            {
                JobseekerId = jobseekers.Id,
             //,
                PostingJobsId = id,
                ApplyingDate = DateTime.Now,
                ExptedSalary = jobApplication.ExptedSalary,
            };
            await _JobApplicationService.InsertAsync(user);


            TempData["successAlert"] = "Applyed Successfull.";


            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search(string JobTittle, string JobLocation, string IndustryType)
        {

            var data = _IJobServices.Searchvaleu(JobTittle, JobLocation, IndustryType);
            return View(data);
        }




    }
}