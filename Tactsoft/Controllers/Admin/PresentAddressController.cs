using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class PresentAddressController : Controller
    {
        private readonly IPresentAddressesService _presentAddressesService;
        private readonly ICountryService _countryService;
        private readonly IThanaService _ThanaService;
        private readonly IDistrictService _DistrictService;
        private readonly IBoardService _BoardService;
        public PresentAddressController(IPresentAddressesService presentAddressesService, ICountryService countryService, IThanaService thanaService, IDistrictService districtService, IBoardService boardService)
        {
            _presentAddressesService = presentAddressesService;
            _countryService = countryService;
            _ThanaService = thanaService;
            _DistrictService = districtService;
            _BoardService = boardService;
        }

        public async Task<IActionResult> Index()
        {


            var Result = await _presentAddressesService.GetAllAsync(x => x.Country, x => x.Thana, x => x.District, x => x.Board);
            return View(Result);
        }


        public async Task<IActionResult> Details(long id)
        {
            var Result = await _presentAddressesService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
        //    ViewData["CountryId"] = _countryService.Dropdown();
        //    ViewData["DistrictId"] = _DistrictService.Dropdown();
        //    ViewData["ThanaId"] = _ThanaService.Dropdown();
        //    ViewData["BoardId"] = _BoardService.Dropdown();

        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PresentAddress presentAddress)
        {
            try
            {
                


                if (ModelState.IsValid)
                {
                    await _presentAddressesService.InsertAsync(presentAddress);
                    TempData["successAlert"] = "District Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["DistrictId"] = _DistrictService.Dropdown();
                ViewData["ThanaId"] = _ThanaService.Dropdown();
                ViewData["BoardId"] = _BoardService.Dropdown();
                return View(presentAddress);
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
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["DistrictId"] = _DistrictService.Dropdown();
                ViewData["ThanaId"] = _ThanaService.Dropdown();
                ViewData["BoardId"] = _BoardService.Dropdown();
                var Result = await _presentAddressesService.FindAsync(id);
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
        public async Task<IActionResult> Edit(PresentAddress presentAddress)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _presentAddressesService.FindAsync(presentAddress.Id);
                    if (Result != null)
                    {

                        await _presentAddressesService.UpdateAsync(Result);
                        TempData["successAlert"] = "District Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["DistrictId"] = _DistrictService.Dropdown();
                ViewData["ThanaId"] = _ThanaService.Dropdown();
                ViewData["BoardId"] = _BoardService.Dropdown();
                return View(presentAddress);

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
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["DistrictId"] = _DistrictService.Dropdown();
                ViewData["ThanaId"] = _ThanaService.Dropdown();
                ViewData["BoardId"] = _BoardService.Dropdown();
                var Result = await _presentAddressesService.FindAsync(x => x.Id == id);
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

                var Result = await _presentAddressesService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _presentAddressesService.DeleteAsync(Result);
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
