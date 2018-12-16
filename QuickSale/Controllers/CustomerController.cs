using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickSale.Data;
using QuickSale.Models.BusinessModels;
using QuickSale.Models.ViewModels;

namespace QuickSale.Controllers
{
    public class CustomerController : Controller
    {
        public  ApplicationDbContext _db { get; set; }

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            CustomerCategoryItemViewModel CustomerCategory = new CustomerCategoryItemViewModel();
           
            List<CategoryItemViewModel> CategoryItemList = new List<CategoryItemViewModel>();

            List<Category> CategoryList = _db.Categories.ToList();

            foreach (var item in CategoryList)
            {
                CategoryItemViewModel CategoryItem = new CategoryItemViewModel();

                CategoryItem.Category = item;

                CategoryItem.Items   = _db.Items.Where(x => x.CategoryId == item.CategoryId).ToList();

               
                CategoryItemList.Add(CategoryItem);

            }

            CustomerCategory.Customer = new Customer();
            CustomerCategory.CategoryItemViewModel = CategoryItemList;



            return View(CustomerCategory);
        }
    }
}