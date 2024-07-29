using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class OtherRelevantInformationController : Controller
    {
        private readonly IOtherRelevantInformationService _otherRelevantInformationService;
        public OtherRelevantInformationController(IOtherRelevantInformationService otherRelevantInformationService)
        {
            _otherRelevantInformationService = otherRelevantInformationService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _otherRelevantInformationService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(long id)
        {
            var Result = await _otherRelevantInformationService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
            
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OtherRelevantInformation otherRelevant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _otherRelevantInformationService.InsertAsync(otherRelevant);
                    TempData["successAlert"] = "Other Relevant Information Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
               
                return View(otherRelevant);
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
               
                var Result = await _otherRelevantInformationService.FindAsync(id);
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
        public async Task<IActionResult> Edit(OtherRelevantInformation otherRelevant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _otherRelevantInformationService.FindAsync(otherRelevant.Id);
                    if (Result != null)
                    {

                        await _otherRelevantInformationService.UpdateAsync(Result);
                        TempData["successAlert"] = "Other Relevant Information Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
              
                return View(otherRelevant);

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
                var Result = await _otherRelevantInformationService.FindAsync(x => x.Id == id);
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
               
                var Result = await _otherRelevantInformationService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _otherRelevantInformationService.DeleteAsync(Result);
                TempData["successAlert"] = "Other Relevant Information Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
