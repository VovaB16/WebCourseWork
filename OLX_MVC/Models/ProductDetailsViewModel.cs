using OLX_MVC.Data.Entities;
using RozetkaMVC.Data.Entities;

namespace OLX_MVC.Models
{
    public class ProductDetailsViewModel
    {
        public ProductDetailsViewModel()
        {
            Reviews = new List<Review>();
        }

        public Product Product { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Product> OtherProducts { get; set; }

    }
}
