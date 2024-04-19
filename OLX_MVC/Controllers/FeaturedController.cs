using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLX_MVC.Data;
using OLX_MVC.Extentions;
using OLX_MVC.Models;

namespace OLX_MVC.Controllers
{
    public class FeaturedController : Controller
    {
        private readonly ShopDbContext context;
        private readonly IMapper mapper;

        public FeaturedController(ShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);
            if (ids == null) ids = new List<int>();

            var entities = context.Products
                                    .Include(x => x.Category)
                                    .Where(x => ids.Contains(x.Id))
                                    .ToList();
            var list = mapper.Map<List<ProductFeaturedModel>>(entities);

            return View(list);
        }

        public IActionResult Append(int id)
        {
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);
            if (ids == null) ids = new List<int>();
            ids.Add(id);

            HttpContext.Session.Set(WebConstants.CART_KEY, ids);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(int id)
        {
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);

            if (ids != null) ids.Remove(id);
            HttpContext.Session.Set(WebConstants.CART_KEY, ids);

            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove(WebConstants.CART_KEY);

            return RedirectToAction("Index");
        }
    }
}
