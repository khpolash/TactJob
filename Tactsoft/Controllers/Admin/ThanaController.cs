using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class ThanaController : Controller
    {
        private readonly IThanaService _thanaService;
        private readonly IDistrictService _DistrictService;
        public ThanaController(IThanaService thanaService, IDistrictService districtService)
        {
            _thanaService = thanaService;
            _DistrictService = districtService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Result = await _thanaService.GetAllAsync(x => x.District);
            return View(Result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["DistrictId"] = _DistrictService.Dropdown();
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Thana thana)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _thanaService.InsertAsync(thana);
                    TempData["successAlert"] = "Thana Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                ViewData["DistrictId"] = _DistrictService.Dropdown();
                return View(thana);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                ViewData["DistrictId"] = _DistrictService.Dropdown();
                var Result = await _thanaService.FindAsync(id);
                return View(Result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Thana thana)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _thanaService.FindAsync(thana.Id);
                    if (Result != null)
                    {
                        Result.DistrictId = thana.DistrictId;
                        Result.ThanaName = thana.ThanaName;
                        await _thanaService.UpdateAsync(Result);
                        TempData["successAlert"] = "Thana Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
                ViewData["DistrictId"] = _DistrictService.Dropdown();
                return View(thana);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                var Result = await _thanaService.FindAsync(x => x.Id == id, x => x.District);
                return View(Result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }
                var Result = await _thanaService.FindAsync(x => x.Id == id, x => x.District);
                return View(Result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCon(int id)
        {
            try
            {

                var Result = await _thanaService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _thanaService.DeleteAsync(Result);
                TempData["successAlert"] = "Thana Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
