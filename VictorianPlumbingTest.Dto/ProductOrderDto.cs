using System.ComponentModel.DataAnnotations;

namespace VictorianPlumbingTest.Dto
{
    public class ProductOrderDto
    {
        [Required]
        public string Name { get; set; }
        [Range(1, 999)]
        public int Quantity { get; set; }
    }
}
