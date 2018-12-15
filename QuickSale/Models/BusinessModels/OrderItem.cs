using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.BusinessModels
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public int ItemId { get; set; }

        public decimal Quantity { get; set; }

        public Order Order { get; set; }

        public int OrderId { get; set; }

    }
}
