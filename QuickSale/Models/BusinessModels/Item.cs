using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.BusinessModels
{
    public class Item
    {
        public int ItemId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public decimal ItemPrice { get; set; }

        public string PriceDescription { get; set; }

        public string  ImagePath { get; set; }

    }
}
