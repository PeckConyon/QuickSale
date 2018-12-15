using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.BusinessModels
{
    public class ItemAmount
    {
        public int ItemAmountId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public int ItemId { get; set; }

        public string ItemAmountDescription { get; set; }


    }
}
