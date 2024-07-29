using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class PreferredAreasController : Controller
    {
        private readonly IPreferredAreasService _preferredAreasService;
        private readonly IJobCategoryService _jobCategoryService;
        private readonly IDistrictService _districtService;
        private readonly ICountryService _countryService;
        private readonly ISpecialSkillsService _specialSkillsService;
        private readonly IOrganizationTypeService _organizationTypeService;
        public PreferredAreasController(IPreferredAreasService preferredAreasService, IJobCategoryService jobCategoryService, IDistrictService districtService, ICountryService countryService, ISpecialSkillsService specialSkillsService, IOrganizationTypeService organizationTypeService)
        {
            _preferredAreasService = preferredAreasService;
            _jobCategoryService = jobCategoryService;
            _districtService = districtService;
            _countryService = countryService;
            _specialSkillsService = specialSkillsService;
            _organizationTypeService = organizationTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _preferredAreasService.GetAllAsync(x=>x.Country, x => x.District, x => x.JobCategory, x => x.SpecialSkills, x => x.Organization );
            return View(Result);
        }




        public async Task<IActionResult> Details(int id)
        {
            var Result = await _preferredAreasService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
        //    ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
        //    ViewData["SpecialSkillsId"] = _specialSkillsService.Dropdown();
        //    ViewData["DistrictId"] = _districtService.Dropdown();
        //    ViewData["CountryId"] = _countryService.Dropdown();
        //    ViewData["OrganizationId"] = _organizationTypeService.Dropdown();

        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PreferredAreas preferredAreas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _preferredAreasService.InsertAsync(preferredAreas);
                    TempData["successAlert"] = "Preferred Areas Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                ViewData["SpecialSkillsId"] = _specialSkillsService.Dropdown();
                ViewData["DistrictId"] = _districtService.Dropdown();
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["OrganizationId"] = _organizationTypeService.Dropdown();
                return View(preferredAreas);

            }
            catch
            {
                return View("Create", preferredAreas);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
            ViewData["SpecialSkillsId"] = _specialSkillsService.Dropdown();
            ViewData["DistrictId"] = _districtService.Dropdown();
            ViewData["CountryId"] = _countryService.Dropdown();
            ViewData["OrganizationId"] = _organizationTypeService.Dropdown();
            var Result = await _preferredAreasService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PreferredAreas preferredAreas)
        {
            try
            {
                var Result = await _preferredAreasService.FindAsync(preferredAreas.Id);
                if (Result != null)
                {

                    await _preferredAreasService.UpdateAsync(Result);
                    TempData["successAlert"] = "Preferred Areas Update Successfull.";
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                ViewData["SpecialSkillsId"] = _specialSkillsService.Dropdown();
                ViewData["DistrictId"] = _districtService.Dropdown();
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["OrganizationId"] = _organizationTypeService.Dropdown();
                return View(preferredAreas);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
            ViewData["SpecialSkillsId"] = _specialSkillsService.Dropdown();
            ViewData["DistrictId"] = _districtService.Dropdown();
            ViewData["CountryId"] = _countryService.Dropdown();
            ViewData["OrganizationId"] = _organizationTypeService.Dropdown();
            var Result = await _preferredAreasService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _preferredAreasService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _preferredAreasService.DeleteAsync(Result);
                TempData["successAlert"] = "Preferred Areas Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
