using System.ComponentModel.DataAnnotations;

namespace MangoServices.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int MyProperty { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,10000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl{ get; set; }

    }
}
