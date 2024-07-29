using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class OrganizationTypeController : Controller
    {
        private readonly IOrganizationTypeService  _organizationType;
        public OrganizationTypeController(IOrganizationTypeService organizationType  )
        {
            this._organizationType = organizationType;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _organizationType.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _organizationType.FindAsync(id);
            return View(Result);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrganizationType organization)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _organizationType.InsertAsync(organization);
                    TempData["successAlert"] = "Country Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                return View(organization);

            }
            catch
            {
                return View("Create", organization);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _organizationType.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(OrganizationType  organization)
        {
            try
            {
                var Result = await _organizationType.FindAsync(organization.Id);
                if (Result != null)
                {
                    Result.OrganizationName = organization.OrganizationName;
                    await _organizationType.UpdateAsync(Result);
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
                return View(organization);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var Result = await _organizationType.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _organizationType.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _organizationType.DeleteAsync(Result);
                TempData["successAlert"] = "Organization Type Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
