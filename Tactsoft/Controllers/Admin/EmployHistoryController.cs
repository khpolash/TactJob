using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class EmployHistoryController : Controller
    {
        private readonly IEmployHistoryService _employHistoryService;
        public EmployHistoryController(IEmployHistoryService employHistoryService)
        {
            _employHistoryService = employHistoryService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _employHistoryService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _employHistoryService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployHistory employHistory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _employHistoryService.InsertAsync(employHistory);
                    TempData["successAlert"] = "Employ History Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(employHistory);

            }
            catch
            {
                return View(employHistory);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _employHistoryService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployHistory employHistory)
        {
            try
            {
                var Result = await _employHistoryService.FindAsync(employHistory.Id);
                if (Result != null)
                {
                  
                    await _employHistoryService.UpdateAsync(Result);
                    TempData["successAlert"] = "Employ History Update Successfull.";
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View(employHistory);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _employHistoryService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _employHistoryService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _employHistoryService.DeleteAsync(Result);
                TempData["successAlert"] = "Employ History Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
