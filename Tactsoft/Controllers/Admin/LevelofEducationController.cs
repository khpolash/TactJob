using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class LevelofEducationController : Controller
    {
        private readonly ILevelofEducationService _levelofEducationService;
        public LevelofEducationController(ILevelofEducationService levelofEducationService)
        {
            _levelofEducationService = levelofEducationService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _levelofEducationService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _levelofEducationService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LevelofEducation levelofEducation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _levelofEducationService.InsertAsync(levelofEducation);
                    TempData["successAlert"] = "Country Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(levelofEducation);

            }
            catch
            {
                return View("Create", levelofEducation);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _levelofEducationService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LevelofEducation levelofEducation)
        {
            try
            {
                var Result = await _levelofEducationService.FindAsync(levelofEducation.Id);
                if (Result != null)
                {
                    
                    await _levelofEducationService.UpdateAsync(Result);
                    TempData["successAlert"] = "Country Update Successfull.";
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View(levelofEducation);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _levelofEducationService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _levelofEducationService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _levelofEducationService.DeleteAsync(Result);
                TempData["successAlert"] = "Country Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}

