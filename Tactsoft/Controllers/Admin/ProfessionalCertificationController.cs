using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class ProfessionalCertificationController : Controller
    {
        private readonly IProfessionalCertificationService _professionalCertificationService;
        public ProfessionalCertificationController(IProfessionalCertificationService professionalCertificationService)
        {
            _professionalCertificationService = professionalCertificationService;
        }

        public async Task<IActionResult> Index()
        {


            var Result = await _professionalCertificationService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(long id)
        {
            var Result = await _professionalCertificationService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{

        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProfessionalCertificationSummary certificationSummary)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _professionalCertificationService.InsertAsync(certificationSummary);
                    TempData["successAlert"] = "District Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                
                return View(certificationSummary);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: DistrictController/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
         
                var Result = await _professionalCertificationService.FindAsync(id);
                return View(Result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: DistrictController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProfessionalCertificationSummary certificationSummary)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _professionalCertificationService.FindAsync(certificationSummary.Id);
                    if (Result != null)
                    {

                        await _professionalCertificationService.UpdateAsync(Result);
                        TempData["successAlert"] = "District Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
               
                return View(certificationSummary);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                var Result = await _professionalCertificationService.FindAsync(x => x.Id == id);
                return View(Result);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: DistrictController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCon(int id)
        {
            try
            {
                
                var Result = await _professionalCertificationService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _professionalCertificationService.DeleteAsync(Result);
                TempData["successAlert"] = "District Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
