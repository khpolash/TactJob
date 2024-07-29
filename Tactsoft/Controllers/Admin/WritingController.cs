using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class WritingController : Controller
    {
        private readonly IWritingService _writingService;
        public WritingController(IWritingService writingService)
        {
            _writingService = writingService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _writingService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _writingService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Writing writing)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _writingService.InsertAsync(writing);
                    TempData["successAlert"] = "Writing Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(writing);

            }
            catch
            {
                return View("Create", writing);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _writingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Writing  writing)
        {
            try
            {
                var Result = await _writingService.FindAsync(writing.Id);
                if (Result != null)
                {
                    Result.WritingName = writing.WritingName;
                    await _writingService.UpdateAsync(Result);
                    TempData["successAlert"] = "Writing Update Successfull.";
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View(writing);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _writingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _writingService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _writingService.DeleteAsync(Result);
                TempData["successAlert"] = "Writing Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
