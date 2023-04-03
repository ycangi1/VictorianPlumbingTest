using System.ComponentModel.DataAnnotations;

namespace VictorianPlumbingTest.Dto
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Summary { get; set; }
        [Range(1, 9999)]
        public decimal Price { get; set; }
    }
}
