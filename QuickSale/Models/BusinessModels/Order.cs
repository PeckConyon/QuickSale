using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.BusinessModels
{
    public class Order
    {
        public int OrderId { get; set; }

        public decimal NetTotal { get; set; }

        [ForeignKey("PaymentMethodId")]
        public PaymentMethod PaymentMethod { get; set; }

        public int PaymentMethodId { get; set; }


    }
}
