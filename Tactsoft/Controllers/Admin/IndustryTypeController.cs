using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class IndustryTypeController : Controller
    {
        private readonly IIndustryTypeService _industialTypeService;

        public IndustryTypeController(IIndustryTypeService industialTypeService)
        {
            this._industialTypeService = industialTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var Inds = await _industialTypeService.GetAllAsync();
            return View(Inds);
        }

       
        public async Task<IActionResult> Details(int id)
        {
            var Inds = await _industialTypeService.FindAsync(id);
            return View(Inds);
        }

       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IndustryType industialType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _industialTypeService.InsertAsync(industialType);
                }
                TempData["successAlert"] = "Industry Type  save successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public async Task<IActionResult> Edit(int id)
        {
            var Inds = await _industialTypeService.FindAsync(id);
            return View(Inds);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IndustryType industialType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _industialTypeService.UpdateAsync(industialType);
                }

                TempData["successAlert"] = "Industry Type update successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var Inds = await _industialTypeService.FindAsync(id);
            return View(Inds);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            try
            {
                var Inds = await _industialTypeService.FindAsync(id);
                if (Inds != null)
                {
                    await _industialTypeService.DeleteAsync(Inds);
                }
                TempData["successAlert"] = "Industry Type delete successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
