using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorainPlumbing.Domain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Summary    { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }

        [NotMapped]
        public List<ProductOrder> ProductOrders { get; set; }

        [NotMapped]
        public List<Order> Orders { get; set; }
    }
}
