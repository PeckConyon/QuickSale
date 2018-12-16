using QuickSale.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.ViewModels
{
    public class CategoryViewModel
    {
        public List<CategoryItemViewModel> CategoryItemViewModel { get; set; }

        public Category Category { get; set; }
    }
}
