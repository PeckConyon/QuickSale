﻿using QuickSale.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.ViewModels
{
    public class OrderCategoryItemViewModel
    {
        public List<PaymentMethod> PaymentMethod { get; set; }
        public List<CategoryItemViewModel> CategoryItemViewModel { get;set;}
        public Customer Customer { get; set; }
    }
}
