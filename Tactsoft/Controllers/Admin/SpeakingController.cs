using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class SpeakingController : Controller
    {
        private readonly ISpeakingService _speakingService;
        public SpeakingController(ISpeakingService speakingService)
        {
            _speakingService = speakingService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _speakingService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _speakingService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Speaking speaking)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _speakingService.InsertAsync(speaking);
                    TempData["successAlert"] = "Speaking Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(speaking);

            }
            catch
            {
                return View("Create", speaking);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _speakingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Speaking  speaking)
        {
            try
            {
                var Result = await _speakingService.FindAsync(speaking.Id);
                if (Result != null)
                {
                    Result.SpeakingName = speaking.SpeakingName;
                    await _speakingService.UpdateAsync(Result);
                    TempData["successAlert"] = "Speaking Update Successfull.";
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View(speaking);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _speakingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _speakingService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _speakingService.DeleteAsync(Result);
                TempData["successAlert"] = "Speaking Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
