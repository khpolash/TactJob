using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class YearOfPassingController : Controller
    {
       private readonly IYearOfPassingService _yearOfPassingService;
        public YearOfPassingController(IYearOfPassingService yearOfPassingService)
        {
            _yearOfPassingService = yearOfPassingService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _yearOfPassingService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _yearOfPassingService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(YearOfPassing yearOfPassing)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _yearOfPassingService.InsertAsync(yearOfPassing);
                    TempData["successAlert"] = "Country Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(yearOfPassing);

            }
            catch
            {
                return View("Create", yearOfPassing);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _yearOfPassingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(YearOfPassing yearOfPassing)
        {
            try
            {
                var Result = await _yearOfPassingService.FindAsync(yearOfPassing.Id);
                if (Result != null)
                {

                    await _yearOfPassingService.UpdateAsync(Result);
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
                return View(yearOfPassing);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _yearOfPassingService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _yearOfPassingService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _yearOfPassingService.DeleteAsync(Result);
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
