using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApplication.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
    public class ProductResponse
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }

        public string? Description { get; set; }
        public decimal? Price { get; set; }

        public decimal? Normalize(decimal? value)
        {
            return value / 1.000000000000000000000000000000000m;
        }

        public ProductResponse(Product product)
        {
            ProductId = product.ProductId;
            Name = product.Name;
            ImageUrl = product.ImageUrl;
            Description = product.Description;
            Price = Normalize(product.Price);
        }


    }
}
