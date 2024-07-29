using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
	public class ReferenceController : Controller
	{
		private readonly IReferenceService _referenceService;
        public ReferenceController(IReferenceService referenceService)
        {
			_referenceService = referenceService;

		}
		public async Task<IActionResult> Index()
		{
			var Result = await _referenceService.GetAllAsync();
			return View(Result);
		}


		public async Task<IActionResult> Details(int id)
		{
			var Result = await _referenceService.FindAsync(id);
			return View(Result);
		}


		//public ActionResult Create()
		//{
		//	return View();
		//}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Reference reference)
		{
			try
			{
				if (ModelState.IsValid)
				{
					await _referenceService.InsertAsync(reference);
					TempData["successAlert"] = "Country Save Successfull.";
					return RedirectToAction(actionName: nameof(Index));
				}
				return View(reference);

			}
			catch
			{
				return View("Create", reference);
			}
		}


		public async Task<ActionResult> Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var Result = await _referenceService.FindAsync(id);
			return View(Result);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Reference reference)
		{
			try
			{
				var Result = await _referenceService.FindAsync(reference.Id);
				if (Result != null)
				{

					await _referenceService.UpdateAsync(Result);
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
				return View(reference);
			}
		}


		public async Task<IActionResult> Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var Result = await _referenceService.FindAsync(id);
			return View(Result);
		}


		[HttpPost]
		[ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Deletecon(int id)
		{
			try
			{
				var Result = await _referenceService.FindAsync(id);
				if (Result == null)
				{
					return NotFound();
				}
				await _referenceService.DeleteAsync(Result);
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
