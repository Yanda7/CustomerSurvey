using ForekBase.Application.Common.Interfaces;
using ForekBase.Domain.Entities;
using ForekBase.Domain.Entities.Enums;
using ForekBase.Infrastructure.Data;
using ForekBase.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Dynamic;

namespace ForekBase.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;




        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
       
        [HttpGet] 
        public async Task<IActionResult> AddCategory(Guid CategoryId)
        {
            var category = _unitOfWork.Category.GetAll();

            dynamic catModel = new ExpandoObject();


            catModel.CatList = category.ToList();

            ViewData["Id"] = CategoryId;



            if (CategoryId == Guid.Empty)
            {
                ViewData["Action"] = "Add";
            }
            else
            {
                ViewData["Action"] = "Update";


                var existingCategories = category.Where(q => q.CategoryId == CategoryId).SingleOrDefault();

                catModel.ExistingCategory = existingCategories;

                ViewData["CategoryName"] = $"{existingCategories.CategoryName}";

                ViewData["CategoryDescription"] = $"{existingCategories.CategoryDescription}";

                return View(catModel);

            }


            return View(catModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryVM categoryVM)
        {
            if(categoryVM == null)
            {
                TempData["error"] = "Error: Model Error...!!!";

                return View();
            }

            if(!ModelState.IsValid)
            {
                Category category = new()
                {
                    CategoryId = Guid.NewGuid(),

                    IsActive = true,

                    CreateBy = " Ayanda ",

                    CreatedOn = DateTime.Now,

                    CategoryName = categoryVM.CategoryName,

                    CategoryDescription = categoryVM.CategoryDescription,

                };
                try
                {

                    _unitOfWork.Category.Add(category);

                     _unitOfWork.Category.Save(category);

                    TempData["success"] = "Category Successfully Created";

                    return RedirectToAction("AddCategory");

                }
                catch(Exception)
                {
                    throw new Exception("Error: Category Couldnt be saved!");
                }
            }
            else
            {
                TempData["Error"] = "Category cannot be Created";

            }

            return View(categoryVM);
        }


        public async Task<ActionResult> OnRemoveCategory(Guid CategoryId)
        {
            if(CategoryId == Guid.Empty)
            {
                return NotFound();
            }

            return View();
        }
    }
}
