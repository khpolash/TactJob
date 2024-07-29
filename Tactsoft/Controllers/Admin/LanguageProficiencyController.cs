using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
	public class LanguageProficiencyController : Controller
	{
		private readonly ILanguageProficiencyService _languageProficiencyService;
        public LanguageProficiencyController(ILanguageProficiencyService languageProficiencyService)
        {
			_languageProficiencyService = languageProficiencyService;

		}

		public async Task<IActionResult> Index()
		{
			var Result = await _languageProficiencyService.GetAllAsync();
			return View(Result);
		}


		public async Task<IActionResult> Details(int id)
		{
			var Result = await _languageProficiencyService.FindAsync(id);
			return View(Result);
		}


		//public ActionResult Create()
		//{
		//	return View();
		//}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(LanguageProficiency languageProficiency)
		{
			try
			{
				if (ModelState.IsValid)
				{
					await _languageProficiencyService.InsertAsync(languageProficiency);
					TempData["successAlert"] = "Country Save Successfull.";
					return RedirectToAction(actionName: nameof(Index));
				}
				return View(languageProficiency);

			}
			catch
			{
				return View("Create", languageProficiency);
			}
		}


		public async Task<ActionResult> Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var Result = await _languageProficiencyService.FindAsync(id);
			return View(Result);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(LanguageProficiency languageProficiency)
		{
			try
			{
				var Result = await _languageProficiencyService.FindAsync(languageProficiency.Id);
				if (Result != null)
				{

					await _languageProficiencyService.UpdateAsync(Result);
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
				return View(languageProficiency);
			}
		}


		public async Task<IActionResult> Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var Result = await _languageProficiencyService.FindAsync(id);
			return View(Result);
		}


		[HttpPost]
		[ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Deletecon(int id)
		{
			try
			{
				var Result = await _languageProficiencyService.FindAsync(id);
				if (Result == null)
				{
					return NotFound();
				}
				await _languageProficiencyService.DeleteAsync(Result);
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
