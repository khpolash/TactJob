using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class ReadingController : Controller
    {
        private readonly IReadingService _readingService;
        public ReadingController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _readingService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _readingService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reading reading )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _readingService.InsertAsync(reading);
                    TempData["successAlert"] = "Reading Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(reading);

            }
            catch
            {
                return View("Create", reading);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _readingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Reading reading)
        {
            try
            {
                var Result = await _readingService.FindAsync(reading.Id);
                if (Result != null)
                {
                    Result.ReadingName = reading.ReadingName;
                    await _readingService.UpdateAsync(Result);
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
                return View(reading);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _readingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _readingService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _readingService.DeleteAsync(Result);
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
