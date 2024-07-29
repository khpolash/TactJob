using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class PostingJobsController : Controller
    {
        private readonly IPostingJobsService _postingJobsService;
        private readonly IJobCategoryService _jobCategoryService;
        private readonly IIndustryTypeService _industryTypeService;

		private readonly ICompanyService _companyService;
		private readonly IServiceTypeService _serviceTypeService;
        private readonly IResumeReceivingOptionService _resumeReceivingOptionService;

        public PostingJobsController(IPostingJobsService postingJobsService, ICompanyService companyService, IJobCategoryService jobCategoryService, IIndustryTypeService industryTypeService, IServiceTypeService serviceTypeService, IResumeReceivingOptionService resumeReceivingOptionService)
        {
            _postingJobsService = postingJobsService;
            _jobCategoryService = jobCategoryService;
            _industryTypeService = industryTypeService;
            _companyService = companyService;
			_serviceTypeService = serviceTypeService;
            _resumeReceivingOptionService = resumeReceivingOptionService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _postingJobsService.GetAllAsync(i => i.JobCategory, x => x.ServiceType, x => x.ResumeReceivingOption, x => x.IndustryType);

            return View(Result);
        }
        public IActionResult Create()
        {
            ViewData["JobCategoryeId"] = _jobCategoryService.Dropdown();
            ViewData["IndustryTypeId"] = _industryTypeService.Dropdown();
            ViewData["ServiceTypeId"] = _serviceTypeService.Dropdown();
            ViewData["ResumeReceivingOptionId"] = _resumeReceivingOptionService.Dropdown();
			TempData["CompanyId"] = _companyService.GetIdByUeseName(User.Identity.Name);

			return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(PostingJobs postingJobs, IFormFile pictureFile)
		{
			try
			{
				if (ModelState.IsValid)
				{
					if (pictureFile != null && pictureFile.Length > 0)
					{
						var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/PostingJobs", pictureFile.FileName);
						using (var stream = new FileStream(path, FileMode.Create))
						{
							pictureFile.CopyTo(stream);
						}
						postingJobs.CompanyLogo = $"{pictureFile.FileName}";
					}
					await _postingJobsService.InsertAsync(postingJobs);
					TempData["successAlert"] = "Posting Jobs save successfull.";
					return RedirectToAction("Index", "CompanyDashboard");
				}
				ViewData["JobCategoryeId"] = _jobCategoryService.Dropdown();
				ViewData["IndustryTypeId"] = _industryTypeService.Dropdown();

				ViewData["ServiceTypeId"] = _serviceTypeService.Dropdown();
				ViewData["ResumeReceivingOptionId"] = _resumeReceivingOptionService.Dropdown();
				TempData["CompanyId"] = _companyService.GetIdByUeseName(User.Identity.Name);

				TempData["errorAlert"] = "Operation failed.";
				return View(postingJobs);
			}
			catch
			{
				return View("Create", postingJobs);
			}
		}




		public async Task<IActionResult> Edit(int id)
        {
            var val = await _postingJobsService.FindAsync(id);
            if (val == null)
            {
                return NotFound();
            }
			ViewData["JobCategoryeId"] = _jobCategoryService.Dropdown();
			ViewData["IndustryTypeId"] = _industryTypeService.Dropdown();

			ViewData["ServiceTypeId"] = _serviceTypeService.Dropdown();
			ViewData["ResumeReceivingOptionId"] = _resumeReceivingOptionService.Dropdown();
			TempData["CompanyId"] = _companyService.GetIdByUeseName(User.Identity.Name);


			return View(val);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PostingJobs postingJobs, IFormFile pictureFile)
        {
            if (ModelState.IsValid)
            {

                var emp = await _postingJobsService.FindAsync(postingJobs.Id);



                if (pictureFile != null && pictureFile.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/PostingJobs", pictureFile.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        pictureFile.CopyTo(stream);
                    }
                    postingJobs.CompanyLogo = $"{pictureFile.FileName}";
                }
                else
                {
                    postingJobs.CompanyLogo = emp.CompanyLogo;
                }
                await _postingJobsService.UpdateAsync(postingJobs);
                TempData["successAlert"] = "company update successfull.";

				return RedirectToAction("Index", "CompanyDashboard");

			}
			ViewData["JobCategoryeId"] = _jobCategoryService.Dropdown();
			ViewData["IndustryTypeId"] = _industryTypeService.Dropdown();

			ViewData["ServiceTypeId"] = _serviceTypeService.Dropdown();
			ViewData["ResumeReceivingOptionId"] = _resumeReceivingOptionService.Dropdown();
			TempData["CompanyId"] = _companyService.GetIdByUeseName(User.Identity.Name);

			TempData["errorAlert"] = "Operation failed.";
            return View(postingJobs);
        }

        public async Task<IActionResult> Details(int id)
        {
            var val = await _postingJobsService.FindAsync(m => m.Id == id, i => i.JobCategory, x => x.ServiceType, x => x.ResumeReceivingOption, x => x.IndustryType);
            return View(val);
        }

        //public async Task<IActionResult> Delete(int id)
        //{
        //    var val = await _jobsService.FindAsync(m => m.Id == id, i => i.JobCategory, x => x.ServiceType, x => x.ResumeReceivingOption, x => x.IndustryType);

        //    if (val == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["JobCategoryeId"] = _jobCategoryService.Dropdown();
        //    ViewData["IndustryTypeId"] = _industryTypeService.Dropdown();

        //    ViewData["ServiceTypeId"] = _serviceTypeService.Dropdown();
        //    ViewData["ResumeReceivingOptionId"] = _resumeReceivingOptionService.Dropdown();

        //    return View(val);
        //}
        //[HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            try
            {
                var dc = await _postingJobsService.FindAsync(id);
                if (dc != null)
                {
                    await _postingJobsService.DeleteAsync(dc);
                }
                TempData["successAlert"] = "Posting Jobs delete successfully.";
				//return RedirectToAction(nameof(Index));
				return RedirectToAction("Index", "CompanyDashboard");
			}
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

    }
}
