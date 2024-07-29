using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Service.Services;
using Microsoft.EntityFrameworkCore;
using Tactsoft.Core.ViewModel;
using Tactsoft.Core.Entities;


namespace Tactsoft.Controllers.Admin
{
    [Authorize(Roles = "Company")]
    public class CompanyDashboardController : Controller
	{
		private readonly IAccountService _accountService;
		private readonly IJobApplicationService _JobApplicationService;
		private readonly IJobServices _IJobServices;
		private readonly ICompanyService _CompanyService;
        private readonly IJobseekerService _JobseekerService;

        private readonly ICountryService _countryService;

		private readonly IPostingJobsService _postingJobsService;
		public CompanyDashboardController(IJobseekerService jobseekerService, IAccountService accountService, ICompanyService companyService, IDistrictService districtService, IJobApplicationService jobApplicationService, IJobServices iJobServices, ICountryService countryService, IPostingJobsService postingJobsService)
		{
			
			_IJobServices = iJobServices;
            _JobseekerService = jobseekerService;
            _accountService = accountService;
			_CompanyService = companyService;

			_JobApplicationService = jobApplicationService;
			_countryService = countryService;
			_postingJobsService = postingJobsService;
		}
		public async Task<IActionResult> Index()

		{
			//var userid = "srajdip";
			var userid = @User.Identity.Name;

			var compan = await _CompanyService.FindAsync(x => x.UserName == userid);
		

			long companyId = compan.Id;

			var vm = new FrontendViewModel();

			vm.Companyjobs = _IJobServices.Companyjobs(companyId);
			vm.CountOfJobs=_IJobServices.CountOfJobs(companyId);


			//vm.NumberOfItJob = _IJobServices.NumberOfItJob();
			vm.VmApplyingJobseekers = _IJobServices.VmApplyingJobseekers(companyId);





            return View(vm);
		}
	}
}
