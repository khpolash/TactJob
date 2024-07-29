using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class DistrictController : Controller
    {
        private readonly IDistrictService _districtService; 
        private readonly IJobServices _IJobServices;
        private readonly ICountryService _countryService;
        public DistrictController(IDistrictService districtService, IJobServices iJobServices, ICountryService countryService)
        {
            _districtService = districtService;
            _countryService = countryService;
            _IJobServices = iJobServices;
        }

        
        public async Task< IActionResult> Index()
        {
           

            var Result=await _districtService.GetAllAsync(i =>i.Countrys);
            return View(Result);
        }

        
        public async Task< IActionResult> Details(int id)
        {
            var Result=await _districtService.FindAsync(id);
            return View(Result);
        }

        
        public ActionResult Create()
        {
            ViewData["CountryId"] = _countryService.Dropdown();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> Create(District district)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _districtService.InsertAsync(district);
                    TempData["successAlert"] = "District Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                ViewData["CountryId"] = _countryService.Dropdown();
                return View(district);
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: DistrictController/Edit/5
        public async Task< IActionResult> Edit(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                ViewData["CountryId"] = _countryService.Dropdown();
                var Result = await _districtService.FindAsync(id);
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
        public async Task <IActionResult> Edit(District district)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _districtService.FindAsync(district.Id);
                    if (Result != null)
                    {
                        Result.CountryId = district.CountryId;
                        Result.DistrictName = district.DistrictName;
                        await _districtService.UpdateAsync(Result);
                        TempData["successAlert"] = "District Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
                ViewData["CountryId"] = _countryService.Dropdown();
                return View(district);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        public async Task <IActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                var Result = await _districtService.FindAsync(x => x.Id == id, x => x.Countrys);
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
        public async Task< IActionResult >DeleteCon(int id )
        {
            try
            {

                var Result = await _districtService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _districtService.DeleteAsync(Result);
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
