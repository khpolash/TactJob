using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class SpecialSkillsController : Controller
    {
        private readonly ISpecialSkillsService _specialSkillsService;
        public SpecialSkillsController(ISpecialSkillsService specialSkillsService)
        {
            _specialSkillsService = specialSkillsService;
        }


        public async Task<IActionResult> Index()
        {
            var Result = await _specialSkillsService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _specialSkillsService.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialSkills specialSkills)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _specialSkillsService.InsertAsync(specialSkills);
                    TempData["successAlert"] = "Special Skills Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(specialSkills);

            }
            catch
            {
                return View("Create", specialSkills);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _specialSkillsService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SpecialSkills specialSkills)
        {
            try
            {
                var Result = await _specialSkillsService.FindAsync(specialSkills.Id);
                if (Result != null)
                {
                    
                    await _specialSkillsService.UpdateAsync(Result);
                    TempData["successAlert"] = "Special Skills Update Successfull.";
                    return RedirectToAction(actionName: nameof(Index));

                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View(specialSkills);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _specialSkillsService.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _specialSkillsService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _specialSkillsService.DeleteAsync(Result);
                TempData["successAlert"] = "Special Skills Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
