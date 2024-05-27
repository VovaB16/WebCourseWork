using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                if (!string.IsNullOrEmpty(searchString))
                {
                    items = items.Where(p => p.Name.Contains(searchString) && p.CategoryId == category);
                }
                else
                {
                    items = items.Where(p => p.CategoryId == category);
                }
            }

            ViewBag.Categories = await _context.Categories.ToListAsync();

            return View(await items.ToListAsync());
        }

        public async Task<IActionResult> ProductsDetails(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            var otherProducts = await _context.Products
                .Where(p => p.Id != id)
                .Take(30)
                .ToListAsync();

            var viewModel = new ProductDetailsViewModel
            {
                Product = product,
                OtherProducts = otherProducts
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
