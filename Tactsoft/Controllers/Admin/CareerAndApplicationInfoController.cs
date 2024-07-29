using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class CareerAndApplicationInfoController : Controller
    {
        private readonly ICareerAndApplicationInfoService _careerAndApplicationInfoService;
        public CareerAndApplicationInfoController(ICareerAndApplicationInfoService careerAndApplicationInfoService)
        {
            _careerAndApplicationInfoService = careerAndApplicationInfoService;
        }

        public async Task<IActionResult> Index()
        {


            var Result = await _careerAndApplicationInfoService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(long id)
        {
            var Result = await _careerAndApplicationInfoService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
            
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CareerAndApplicationInfo applicationInfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _careerAndApplicationInfoService.InsertAsync(applicationInfo);
                    TempData["successAlert"] = "District Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
              
                return View(applicationInfo);
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
               
                var Result = await _careerAndApplicationInfoService.FindAsync(id);
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
        public async Task<IActionResult> Edit(CareerAndApplicationInfo applicationInfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _careerAndApplicationInfoService.FindAsync(applicationInfo.Id);
                    if (Result != null)
                    {

                        await _careerAndApplicationInfoService.UpdateAsync(Result);
                        TempData["successAlert"] = "District Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
               
                return View(applicationInfo);

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
                var Result = await _careerAndApplicationInfoService.FindAsync(x => x.Id == id);
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
               
                var Result = await _careerAndApplicationInfoService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _careerAndApplicationInfoService.DeleteAsync(Result);
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
