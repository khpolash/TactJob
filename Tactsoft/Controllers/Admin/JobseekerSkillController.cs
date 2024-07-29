using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class JobseekerSkillController : Controller
    {
        private readonly IJobseekerSkillService _jobseekerSkillService;
        public JobseekerSkillController(IJobseekerSkillService jobseekerSkillService)
        {
            _jobseekerSkillService = jobseekerSkillService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _jobseekerSkillService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _jobseekerSkillService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobseekerSkill jobseekerSkill)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _jobseekerSkillService.InsertAsync(jobseekerSkill);
                    TempData["successAlert"] = "Job Seeker Skill Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(jobseekerSkill);

            }
            catch
            {
                return View("Create", jobseekerSkill);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _jobseekerSkillService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(JobseekerSkill jobseekerSkill)
        {
            try
            {
                var Result = await _jobseekerSkillService.FindAsync(jobseekerSkill.Id);
                if (Result != null)
                {

                    await _jobseekerSkillService.UpdateAsync(Result);
                    TempData["successAlert"] = "Job Seeker Skill Update Successfull.";
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View(jobseekerSkill);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _jobseekerSkillService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _jobseekerSkillService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _jobseekerSkillService.DeleteAsync(Result);
                TempData["successAlert"] = "Job Seeker Skill Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
