using System.ComponentModel.DataAnnotations;

namespace OLX_MVC.Models
{
    public class ProductFormModel
    {
        public int Id { get; set; }
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters.")]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(4000, MinimumLength = 10)]
        public string? Description { get; set; }

        [Range(0, 100)]
        public int Discount { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }
    }
}
