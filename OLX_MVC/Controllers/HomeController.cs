using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLX_MVC.Data;
using OLX_MVC.Data.Entities;
using OLX_MVC.Models;
using System.Diagnostics;

namespace OLX_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopDbContext context;
        public HomeController(ShopDbContext context)
        {
            this.context = context;
        }
        
        public IActionResult ProductsDetails(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        public IActionResult Index()
        {
            var items = context.Products.Include(x => x.Category).ToList();
            return View(items); // ~/Views/Home/Index.cshtml
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
