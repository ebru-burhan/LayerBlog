using LayerBlog.Business.Abstracts;
using LayerBlog.Models.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayerBlog.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //test için adımlar
            // Add one

            // Get all
            var categorylist = _categoryService.GetCategories();

            // Update first
            var updatelenecek = categorylist.FirstOrDefault();
            updatelenecek.Name = "xxx";
            _categoryService.UpdateCategory(updatelenecek);

            // Get all
            categorylist = _categoryService.GetCategories();
            // Delete first
            var silinecek = categorylist.FirstOrDefault();
            _categoryService.DeleteCategory(silinecek.CategoryID);
            // Get all
            categorylist = _categoryService.GetCategories();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            CategoryDTO categoryDto = new CategoryDTO("oyun");
            _categoryService.AddCategory(categoryDto);

            return View();
        }
    }
}
