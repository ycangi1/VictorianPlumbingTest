using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VictorianPlumbingTest.Dto
{
    public class OrderDto
    {
        [Required]
        public string CustomerName { get; set; }

        public List<ProductOrderDto> Products { get; set; }
    }
}
