using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class TrainingSummaryController : Controller
    {
        private readonly ITrainingSummaryService _trainingSummaryService;
        private readonly IYearOfPassingService _yearOfPassingService;
        private readonly ICountryService _countryService;
        public TrainingSummaryController(ITrainingSummaryService trainingSummaryService, IYearOfPassingService yearOfPassingService, ICountryService countryService)
        {
            _trainingSummaryService = trainingSummaryService;
            _yearOfPassingService = yearOfPassingService;
            _countryService = countryService;
        }


        public async Task<IActionResult> Index()
        {


            var Result = await _trainingSummaryService.GetAllAsync();
            return View(Result);
        }


        public async Task<IActionResult> Details(long id)
        {
            var Result = await _trainingSummaryService.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
        //    ViewData["CountryId"] = _countryService.Dropdown();
        //    ViewData["YearId"] = _yearOfPassingService.Dropdown();
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TrainingSummary trainingSummary)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _trainingSummaryService.InsertAsync(trainingSummary);
                    TempData["successAlert"] = "Training Summary Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["YearId"] = _yearOfPassingService.Dropdown();
                return View(trainingSummary);
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
                ViewData["YearId"] = _yearOfPassingService.Dropdown();
                var Result = await _trainingSummaryService.FindAsync(id);
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
        public async Task<IActionResult> Edit(TrainingSummary  trainingSummary)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Result = await _trainingSummaryService.FindAsync(trainingSummary.Id);
                    if (Result != null)
                    {

                        await _trainingSummaryService.UpdateAsync(Result);
                        TempData["successAlert"] = "District Update Successfull.";
                        return RedirectToAction(actionName: nameof(Index));

                    }
                    else
                    {
                        return NotFound();
                    }
                }
                ViewData["CountryId"] = _countryService.Dropdown();
                ViewData["YearId"] = _yearOfPassingService.Dropdown();
                return View(trainingSummary);

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
                ViewData["YearId"] = _yearOfPassingService.Dropdown();
                var Result = await _trainingSummaryService.FindAsync(x => x.Id == id);
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
                
                var Result = await _trainingSummaryService.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _trainingSummaryService.DeleteAsync(Result);
                TempData["successAlert"] = "Training Summary Delete Successfull.";
                return RedirectToAction(actionName: nameof(Index));


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
