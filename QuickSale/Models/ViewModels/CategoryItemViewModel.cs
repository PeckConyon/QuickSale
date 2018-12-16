using QuickSale.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.ViewModels
{
    public class CategoryItemViewModel
    {
        public Category Category { get; set; }

        public List<Item> Items { get; set; }

    }
}
