using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tactsoft.Core.Entities;
using Tactsoft.Service.Services;

namespace Tactsoft.Controllers.Admin
{
    public class PhotographyController : Controller
    {
        private readonly IPhotographyService _photographyService;
        public PhotographyController(IPhotographyService photographyService)
        {
            _photographyService= photographyService;
        }
        public async Task< IActionResult> Index()
        {
            var result= await _photographyService.GetAllAsync();
            return View(result);
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        [HttpPost]
        public async Task<ActionResult> Create(Photography photography ,IFormFile pictureFile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (pictureFile != null && pictureFile.Length > 0)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Photography", pictureFile.Name);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            pictureFile.CopyTo(stream);
                        }
                        photography.PhotoPath = $"{pictureFile.FileName}";

                    }
                    await _photographyService.InsertAsync(photography);
                    TempData["successAlert"] = "Photo save successfull.";
                    return RedirectToAction(nameof(Index));
                }
                TempData["errorAlert"] = "Operation failed.";
                return View(photography);

            }
            catch 
            {
                return View("Create", photography);
            }
            

        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Photography  photography, IFormFile pictureFile)
        {
            if (ModelState.IsValid)
            {

                var emp = await _photographyService.FindAsync(photography.Id);
                if (pictureFile != null && pictureFile.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Photography", pictureFile.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        pictureFile.CopyTo(stream);
                    }
                    photography.PhotoPath = $"{pictureFile.FileName}";
                }
                else
                {
                    photography.PhotoPath = emp.PhotoPath;
                }
                await _photographyService.UpdateAsync(photography);
                TempData["successAlert"] = "Photo update successfull.";

                return RedirectToAction(nameof(Index));

            }
            
            TempData["errorAlert"] = "Operation failed.";
            return View(photography);
        }
    }
}
