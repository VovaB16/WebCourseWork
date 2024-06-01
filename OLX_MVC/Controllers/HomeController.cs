using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OLX_MVC.Data;
using OLX_MVC.Models;

namespace OLX_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopDbContext _context;

        public HomeController(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString, int? category)
        {
            var items = _context.Products.Include(x => x.Category).AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(p => p.Name.Contains(searchString));
            }

            if (category.HasValue)
            {
                items = items.Where(p => p.CategoryId == category);
            }

            ViewBag.Categories = await _context.Categories.ToListAsync();

            var cookieValue = Request.Cookies["RecentlyViewed"];
            List<int> recentlyViewedIds = string.IsNullOrEmpty(cookieValue) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(cookieValue);

            ViewBag.RecentlyViewedProducts = await _context.Products
                .Where(p => recentlyViewedIds.Contains(p.Id))
                .ToListAsync();

            return View(await items.ToListAsync());
        }

        public async Task<IActionResult> ProductsDetails(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            
            List<int> recentlyViewed;
            var cookieValue = Request.Cookies["RecentlyViewed"];
            if (string.IsNullOrEmpty(cookieValue))
            {
                recentlyViewed = new List<int>();
            }
            else
            {
                recentlyViewed = JsonConvert.DeserializeObject<List<int>>(cookieValue);
            }

            if (recentlyViewed.Contains(id))
            {
                recentlyViewed.Remove(id);
            }
            recentlyViewed.Insert(0, id);
            if (recentlyViewed.Count > 5)
            {
                recentlyViewed.RemoveAt(5);
            }

            Response.Cookies.Append("RecentlyViewed", JsonConvert.SerializeObject(recentlyViewed), new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7)
            });

            var viewModel = new ProductDetailsViewModel
            {
                Product = product,
                Reviews = _context.Reviews.Where(r => r.ProductId == id).ToList(),
                OtherProducts = await _context.Products.Where(p => p.Id != id).ToListAsync()
            };

            return View(viewModel);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
