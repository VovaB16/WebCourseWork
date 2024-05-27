using OLX_MVC.Data.Entities;

namespace OLX_MVC.Models
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        public List<Product> OtherProducts { get; set; }
    }
}
