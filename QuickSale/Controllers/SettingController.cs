using Microsoft.AspNetCore.Mvc;
using QuickSale.Data;
using QuickSale.Models.BusinessModels;
using QuickSale.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace QuickSale.Controllers
{
    public class SettingController : Controller
    {
        public ApplicationDbContext _db { get; set; }

        public SettingController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CategoryViewModel CategoryViewModel = new CategoryViewModel();
            CategoryViewModel.Category = new Category();

            List<Category> CategoryList = _db.Categories.ToList();
            List<CategoryItemViewModel> CategoryItemList = new List<CategoryItemViewModel>();

            foreach (var item in CategoryList)
            {
                CategoryItemViewModel CategoryItem = new CategoryItemViewModel();

                CategoryItem.Category = item;

                CategoryItem.Items = _db.Items.Where(x => x.CategoryId == item.CategoryId).ToList();


                CategoryItemList.Add(CategoryItem);
            }

            CategoryViewModel.CategoryItemViewModel = CategoryItemList;
            return View(CategoryViewModel);
        }

        [HttpPost]
        public IActionResult Index(Category Category)
        {
            CategoryViewModel CategoryViewModel = new CategoryViewModel();
            CategoryViewModel.Category = new Category();

            List<Category> CategoryList = _db.Categories.ToList();
            List<CategoryItemViewModel> CategoryItemList = new List<CategoryItemViewModel>();
            if (ModelState.IsValid)
            {
                _db.Categories.Add(Category);
                _db.SaveChanges();
                
                foreach (var item in CategoryList)
                {
                    CategoryItemViewModel CategoryItem = new CategoryItemViewModel();

                    CategoryItem.Category = item;

                    CategoryItem.Items = _db.Items.Where(x => x.CategoryId == item.CategoryId).ToList();


                    CategoryItemList.Add(CategoryItem);
                }

                CategoryViewModel.CategoryItemViewModel = CategoryItemList;
            }
            return View(CategoryViewModel);
        }
    }
}