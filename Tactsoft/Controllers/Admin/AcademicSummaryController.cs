using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    [Authorize]
    public class AcademicSummaryController : Controller
    {
        private readonly IAcademicSummaryService _service;

        private readonly IResultService _resultService;
        private readonly IYearOfPassingService _yearOfPassingService;
        private readonly IBoardService _boardService;
        private readonly ILevelofEducationService _levelofEducationService;
        private readonly IDegreeTitleService _degreeTitleService;
        public AcademicSummaryController(IAcademicSummaryService service, IResultService resultService, IYearOfPassingService yearOfPassingService, IBoardService boardService, ILevelofEducationService levelofEducationService, IDegreeTitleService degreeTitleService)
        {
            _service = service;
            _resultService = resultService;
            _yearOfPassingService = yearOfPassingService;
            _boardService = boardService;
            _levelofEducationService = levelofEducationService;
            _degreeTitleService = degreeTitleService;
        }

        public async Task<IActionResult> Index()
        {
            var Result = await _service.GetAllAsync(x=>x.Result, x => x.YearOfPassing, x => x.board, x => x.LevelofEducation, x => x.degreeTitle);
            return View(Result);
        }


        public async Task<IActionResult> Details(int id)
        {
            var Result = await _service.FindAsync(id);
            return View(Result);
        }


        //public ActionResult Create()
        //{
        //    ViewData["boardId"] = _boardService.Dropdown();
        //    ViewData["LevelofEducationId"] = _levelofEducationService.Dropdown();
        //    ViewData["ResultId"] = _resultService.Dropdown();
        //    ViewData["YearOfPassingId"] = _yearOfPassingService.Dropdown();
        //    ViewData["degreeTitleId"] = _degreeTitleService.Dropdown();

        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AcademicSummary academicSummary)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.InsertAsync(academicSummary);
                    TempData["successAlert"] = "Academic Summary Save Successfull.";
                    return RedirectToAction(actionName: nameof(Index));
                }
                ViewData["boardId"] = _boardService.Dropdown();
                ViewData["LevelofEducationId"] = _levelofEducationService.Dropdown();
                ViewData["ResultId"] = _resultService.Dropdown();
                ViewData["YearOfPassingId"] = _yearOfPassingService.Dropdown();
                ViewData["degreeTitleId"] = _degreeTitleService.Dropdown();
                return View(academicSummary);

            }
            catch
            {
                return View("Create", academicSummary);
            }
        }


        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            ViewData["boardId"] = _boardService.Dropdown();
            ViewData["LevelofEducationId"] = _levelofEducationService.Dropdown();
            ViewData["ResultId"] = _resultService.Dropdown();
            ViewData["YearOfPassingId"] = _yearOfPassingService.Dropdown();
            ViewData["degreeTitleId"] = _degreeTitleService.Dropdown();

            var Result = await _service.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AcademicSummary academicSummary)
        {
            try
            {
                var Result = await _service.FindAsync(academicSummary.Id);
                if (Result != null)
                {

                    await _service.UpdateAsync(Result);
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
                ViewData["boardId"] = _boardService.Dropdown();
                ViewData["LevelofEducationId"] = _levelofEducationService.Dropdown();
                ViewData["ResultId"] = _resultService.Dropdown();
                ViewData["YearOfPassingId"] = _yearOfPassingService.Dropdown();
                ViewData["degreeTitleId"] = _degreeTitleService.Dropdown();
                return View(academicSummary);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            ViewData["boardId"] = _boardService.Dropdown();
            ViewData["LevelofEducationId"] = _levelofEducationService.Dropdown();
            ViewData["ResultId"] = _resultService.Dropdown();
            ViewData["YearOfPassingId"] = _yearOfPassingService.Dropdown();
            ViewData["degreeTitleId"] = _degreeTitleService.Dropdown();
            var Result = await _service.FindAsync(id);
            return View(Result);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletecon(int id)
        {
            try
            {
                var Result = await _service.FindAsync(id);
                if (Result == null)
                {
                    return NotFound();
                }
                await _service.DeleteAsync(Result);
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
