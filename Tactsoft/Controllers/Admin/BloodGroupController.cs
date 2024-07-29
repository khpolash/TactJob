using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class BloodGroupController : Controller
    {
        private readonly IBloodGroupService _bloodGroupService;
        public BloodGroupController(IBloodGroupService bloodGroupService)
        {
            _bloodGroupService = bloodGroupService;
        }
        public async Task<IActionResult> Index()
        {
            var Result = await _bloodGroupService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _bloodGroupService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BloodGroup bloodGroup)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _bloodGroupService.InsertAsync(bloodGroup);
                    
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(bloodGroup);

            }
            catch
            {
                return View("Create", bloodGroup);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _bloodGroupService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BloodGroup bloodGroup)
        {
            try
            {
                var Result = await _bloodGroupService.FindAsync(bloodGroup.Id);
                if (Result != null)
                {
                    
                    await _bloodGroupService.UpdateAsync(Result);
                   
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View(bloodGroup);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _bloodGroupService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _bloodGroupService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _bloodGroupService.DeleteAsync(Result);
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
