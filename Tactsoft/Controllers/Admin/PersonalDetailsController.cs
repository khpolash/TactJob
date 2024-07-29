using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class PersonalDetailsController : Controller
    {
        private readonly IPersonalDetailsService _personalDetailsService;
        private readonly IBloodGroupService _bloodGroupService;

		private readonly IJobseekerService _jobseekerService;
		public PersonalDetailsController(IPersonalDetailsService personalDetailsService, IJobseekerService jobseekerService, IBloodGroupService bloodGroupService)
        {
            _personalDetailsService = personalDetailsService;
            _bloodGroupService = bloodGroupService;
            _jobseekerService = jobseekerService;

		}

        public async Task<IActionResult> Index()
        {
            var Result = await _personalDetailsService.GetAllAsync(x=>x.BloodGroup);
			TempData["jobseekerId"] = _jobseekerService.GetIdByUeseName(User.Identity.Name);
			ViewData["jobseekerId"] = _jobseekerService.GetIdByUeseName(User.Identity.Name);


			return View(Result);
        }

        [HttpGet]
        public async Task<IActionResult> AddorEdit(int id = 0)
        {
			ViewData["BloodGroupId"] = _bloodGroupService.Dropdown();
			if (id == 0)
            {
                return View(new PersonalDetails());
            }
            else
            {
                var personalDetails = await _personalDetailsService.FindAsync(x => x.JobseekerId == id);


                if (personalDetails == null)
                {
                    return NotFound();
                }
                return View(personalDetails);
            }
        }


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddorEdit(long id, PersonalDetails personalDetails)
        {

          
            //Save Data
            if (id == 0)
			{
                
                await _personalDetailsService.InsertAsync(personalDetails);
				return RedirectToAction("Index", "JobSeekerDashboard");
			}
			else
			{
                var loggedInUserName = HttpContext.Session.GetString("UserName");
                var jobSeekerId = _jobseekerService.GetJobseekerByUserName(loggedInUserName).Id;
                personalDetails.JobseekerId = jobSeekerId;

                await _personalDetailsService.UpdateAsync(personalDetails);
				return RedirectToAction("Index", "JobSeekerDashboard");

			}
			return View(new PersonalDetails());
		}









		public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _personalDetailsService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _personalDetailsService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _personalDetailsService.DeleteAsync(Result);
                TempData["successAlert"] = "Personal Details Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }



		public async Task<IActionResult> Details(long id)

		{

            var deatisl= await _personalDetailsService.FindAsync(x => x.JobseekerId == id);

			var val = await _personalDetailsService.FindAsync(m => m.Id == deatisl.Id, i => i.BloodGroup);
			return View(val);


		}
	}
}
