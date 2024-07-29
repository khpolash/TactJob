using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class ResultController : Controller
    {
        private readonly IResultService   _resultService;
        public ResultController(IResultService resultService)
        {
            _resultService = resultService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _resultService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _resultService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Result result)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _resultService.InsertAsync(result);
                    TempData["successAlert"] = "Country Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(result);

            }
            catch
            {
                return View("Create", result);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _resultService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Result result)
        {
            try
            {
                var Result = await _resultService.FindAsync(result.Id);
                if (Result != null)
                {

                    await _resultService.UpdateAsync(Result);
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
                return View(result);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _resultService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _resultService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _resultService.DeleteAsync(Result);
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
