using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorainPlumbing.Domain
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderedAt { get; set; }
        public DateTime? CancelledDate { get; set; }

        [NotMapped]
        public List<ProductOrder> ProductOrders { get; set; }
        [NotMapped]
        public List<Product> Products { get; set; }
    }
}
