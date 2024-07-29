 using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
	public class ExpertiseController : Controller
	{
		private readonly IExpertiseService _expertiseService;
        public ExpertiseController(IExpertiseService expertiseService)
        {
			_expertiseService = expertiseService;

		}

        public async Task<IActionResult> Index()
		{
			var Result = await _expertiseService.GetAllAsync();
			return View(Result);
		}


		public async Task<IActionResult> Details(int id)
		{
			var Result = await _expertiseService.FindAsync(id);
			return View(Result);
		}


		public ActionResult Create()
		{
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Expertise expertise)
		{
			try
			{
				if (ModelState.IsValid)
				{
					await _expertiseService.InsertAsync(expertise);
					TempData["successAlert"] = "Expertise Save Successfull.";
					return RedirectToAction(actionName: nameof(Index));
				}
				return View(expertise);

			}
			catch
			{
				return View("Create", expertise);
			}
		}


		public async Task<ActionResult> Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var Result = await _expertiseService.FindAsync(id);
			return View(Result);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Expertise  expertise)
		{
			try
			{
				var Result = await _expertiseService.FindAsync(expertise.Id);
				if (Result != null)
				{

					await _expertiseService.UpdateAsync(Result);
					TempData["successAlert"] = "Expertise Update Successfull.";
					return RedirectToAction(actionName: nameof(Index));

				}
				else
				{
					return NotFound();
				}
			}
			catch
			{
				return View(expertise);
			}
		}


		public async Task<IActionResult> Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var Result = await _expertiseService.FindAsync(id);
			return View(Result);
		}


		[HttpPost]
		[ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Deletecon(int id)
		{
			try
			{
				var Result = await _expertiseService.FindAsync(id);
				if (Result == null)
				{
					return NotFound();
				}
				await _expertiseService.DeleteAsync(Result);
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
