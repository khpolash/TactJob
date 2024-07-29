using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class DegreeTitleController : Controller
    {
        private readonly IDegreeTitleService _degreeTitleService;
        public DegreeTitleController(IDegreeTitleService degreeTitleService)
        {
            _degreeTitleService = degreeTitleService;
                
        }
        public async Task<IActionResult> Index()
        {
            var Result = await _degreeTitleService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _degreeTitleService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DegreeTitle degreeTitle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _degreeTitleService.InsertAsync(degreeTitle);
                    TempData["successAlert"] = "Country Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(degreeTitle);

            }
            catch
            {
                return View("Create", degreeTitle);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _degreeTitleService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DegreeTitle degreeTitle)
        {
            try
            {
                var Result = await _degreeTitleService.FindAsync(degreeTitle.Id);
                if (Result != null)
                {

                    await _degreeTitleService.UpdateAsync(Result);
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
                return View(degreeTitle);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _degreeTitleService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _degreeTitleService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _degreeTitleService.DeleteAsync(Result);
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
