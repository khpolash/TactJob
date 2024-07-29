using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class RelativeController : Controller
    {
        private readonly IRelativeService _service;
        public RelativeController(IRelativeService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _service.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _service.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Relative relative)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.InsertAsync(relative);
                    TempData["successAlert"] = "Relative Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(relative);

            }
            catch
            {
                return View("Create", relative);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _service.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Relative relative)
        {
            try
            {
                var Result = await _service.FindAsync(relative.Id);
                if (Result != null)
                {
                    Result.RelativeName = relative.RelativeName;
                    await _service.UpdateAsync(Result);
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
                return View(relative);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _service.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _service.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _service.DeleteAsync(Result);
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
