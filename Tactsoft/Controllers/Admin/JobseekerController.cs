using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class JobseekerController : Controller
    {
        private readonly IJobseekerService _jobseekerService;
        private readonly IJobCategoryService _jobCategoryService;
        public JobseekerController(IJobseekerService jobseekerService, IJobCategoryService jobCategoryService)
        {
            _jobseekerService = jobseekerService;
            _jobCategoryService = jobCategoryService;
        }

        public async Task<IActionResult> Index()
        {


            var Result = await _jobseekerService.GetAllAsync(x=>x.JobCategory);
            return View(Result);
        }


        public async Task<IActionResult> Details(long id)
        {
            var Result = await _jobseekerService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Jobseeker jobseeker)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _jobseekerService.InsertAsync(jobseeker);
                    TempData["successAlert"] = "District Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                return View(jobseeker);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: DistrictController/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                var Result = await _jobseekerService.FindAsync(id);
                return View(Result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: DistrictController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Jobseeker jobseeker)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _jobseekerService.FindAsync(jobseeker.Id);
                    if (Result != null)
                    {

                        await _jobseekerService.UpdateAsync(Result);
                        TempData["successAlert"] = "District Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
                ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                return View(jobseeker);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                var Result = await _jobseekerService.FindAsync(x => x.Id == id);
                return View(Result);
               

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: DistrictController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCon(int id)
        {
            try
            {
                ViewData["JobCategoryId"] = _jobCategoryService.Dropdown();
                var Result = await _jobseekerService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _jobseekerService.DeleteAsync(Result);
                TempData["successAlert"] = "District Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
