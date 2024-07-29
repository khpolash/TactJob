using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class DisabilityInformationController : Controller
    {
        private readonly IDisabilityInformationService _disabilityInformationService;
        public DisabilityInformationController(IDisabilityInformationService disabilityInformationService)
        {
            _disabilityInformationService = disabilityInformationService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _disabilityInformationService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _disabilityInformationService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DisabilityInformation disability)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _disabilityInformationService.InsertAsync(disability);
                    TempData["successAlert"] = "Country Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(disability);

            }
            catch
            {
                return View("Create", disability);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _disabilityInformationService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DisabilityInformation disability)
        {
            try
            {
                var Result = await _disabilityInformationService.FindAsync(disability.Id);
                if (Result != null)
                {
                    
                    await _disabilityInformationService.UpdateAsync(Result);
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
                return View(disability);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _disabilityInformationService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _disabilityInformationService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _disabilityInformationService.DeleteAsync(Result);
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
