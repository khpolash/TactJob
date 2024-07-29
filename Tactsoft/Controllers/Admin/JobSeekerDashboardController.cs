using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using Tactsoft.Core.Entities;
using Tactsoft.Core.ViewModel;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
	[Authorize(Roles = "Jobseeker,Company")]
    public class JobSeekerDashboardController : Controller
    {
        private readonly IBloodGroupService _bloodGroupService;
        private readonly IBoardService _boardService;
        private readonly IYearOfPassingService _yearOfPassingService;
        private readonly ICountryService _countryService;
        private readonly IThanaService _ThanaService;
        private readonly IDistrictService _DistrictService;
        private readonly IResultService _ResultService;
        private readonly ILevelofEducationService _LevelofEducationService;
        private readonly IDegreeTitleService _DegreeTitleService;
        private readonly IPersonalDetailsService _personalDetailsService;

		private readonly ISpeakingService _speakingService;
		private readonly IWritingService _writingService;
		private readonly IReadingService _readingService;

		private readonly IRelativeService _relativeService;

		private readonly IJobseekerService _jobseekerService;


		public JobSeekerDashboardController(IBloodGroupService bloodGroupService, IJobseekerService jobseekerService, IBoardService boardService, IDistrictService districtService, ICountryService countryService, IThanaService thanaService, IYearOfPassingService yearOfPassingService, IResultService resultService, IDegreeTitleService degreeTitleService, ILevelofEducationService levelofEducationService, IPersonalDetailsService personalDetailsService,ISpeakingService speakingService, IWritingService writingService, IReadingService readingService, IRelativeService relativeService)
		{
			_bloodGroupService = bloodGroupService;
			_jobseekerService = jobseekerService;
			_boardService = boardService;
			_countryService = countryService;
			_yearOfPassingService = yearOfPassingService;
			_ThanaService = thanaService;
			_DistrictService = districtService;
			_ResultService = resultService;
			_DegreeTitleService = degreeTitleService;
			_LevelofEducationService = levelofEducationService;
			_personalDetailsService = personalDetailsService;
			_speakingService = speakingService;
			_writingService = writingService;
			_readingService = readingService;
			_relativeService = relativeService;
		}

		public async Task<IActionResult> Index()
        {

			ViewData["BloodGroupId"] = _bloodGroupService.Dropdown();
			ViewData["boardId"] = _boardService.Dropdown();
			ViewData["LevelofEducationId"] = _LevelofEducationService.Dropdown();
			ViewData["ResultId"] = _ResultService.Dropdown();
			ViewData["YearOfPassingId"] = _yearOfPassingService.Dropdown();
			ViewData["degreeTitleId"] = _DegreeTitleService.Dropdown();

			ViewData["CountryId"] = _countryService.Dropdown();
			ViewData["YearId"] = _yearOfPassingService.Dropdown();

			ViewData["SpeakingId"] = _speakingService.Dropdown();
			ViewData["WritingId"] = _writingService.Dropdown();
			ViewData["ReadingId"] = _readingService.Dropdown();

			ViewData["RelativeId"] = _relativeService.Dropdown();

			TempData["jobseekerId"] = _jobseekerService.GetIdByUeseName(User.Identity.Name);

			ViewData["jobseekerId"] = _jobseekerService.GetIdByUeseName(User.Identity.Name);

			var userid = @User.Identity.Name;

			var Jobseer = await _jobseekerService.FindAsync(x => x.UserName == userid);

		
			long SeekerId = Jobseer.Id;

			var vm = new FrontendViewModel();

			vm.JobSeekerInfo = _jobseekerService.Jobseekerinfo(SeekerId);
			



			return View();




			
		}


		
	}
}
