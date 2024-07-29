using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class CompanySizeController : Controller
    {
        private readonly ICompanySizeService _companySizeService;

        public CompanySizeController(ICompanySizeService companySizeService)
        {
            this._companySizeService = companySizeService;
        }

        public async Task<IActionResult> Index()
        {
            var val = await _companySizeService.GetAllAsync();
            return View(val);
        }


        public async Task<IActionResult> Details(int id)
        {
            var val = await _companySizeService.FindAsync(id);
            return View(val);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CompanySize companySize)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _companySizeService.InsertAsync(companySize);
                }
                TempData["successAlert"] = "eyntrepreneur  save successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public async Task<IActionResult> Edit(int id)
        {
            var val = await _companySizeService.FindAsync(id);
            return View(val);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CompanySize companySize)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _companySizeService.UpdateAsync(companySize);
                }

                TempData["successAlert"] = "companySize update successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            var val = await _companySizeService.FindAsync(id);
            return View(val);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            try
            {
                var val = await _companySizeService.FindAsync(id);
                if (val != null)
                {
                    await _companySizeService.DeleteAsync(val);
                }
                TempData["successAlert"] = "companySize delete successfully.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
