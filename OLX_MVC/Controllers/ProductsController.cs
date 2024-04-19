using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OLX_MVC.Data;
using Microsoft.EntityFrameworkCore;
using OLX_MVC.Data.Entities;
using AutoMapper;
using OLX_MVC.Models;

namespace OLX_MVC.Controllers
{
    public class ProductsController : Controller
    {
        private ShopDbContext context;
        private readonly IMapper mapper;


        public ProductsController(ShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var products = context.Products.Include(x => x.Category).ToList();

            LoadCategories();

            return View(products);
        }
        public IActionResult Filter(int? categoryId)
        {
            if (categoryId == null)
                return RedirectToAction("Index");

            var products = context.Products
                            .Include(x => x.Category)
                            .Where(x => x.CategoryId == categoryId)
                            .ToList();

            LoadCategories();
            return View("Index", products);
        }


        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.Creation = true;
            LoadCategories();

            return View("Upsert");
        }


        [HttpPost]
        public IActionResult Create(ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                ViewBag.Creation = true;
                return View("Upsert", model);
            }

            var entity = mapper.Map<Product>(model);

            context.Products.Add(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var item = context.Products.Find(id);
            if (item == null) return NotFound();

            ViewBag.Creation = false;
            LoadCategories();

            var model = mapper.Map<ProductFormModel>(item);

            return View("Upsert", model);
        }

        [HttpPost]
        public IActionResult Edit(ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                ViewBag.Creation = false;
                return View("Upsert", model);
            }

            var entity = mapper.Map<Product>(model);

            context.Products.Update(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var item = context.Products.Find(id);

            if (item == null) return NotFound();

            context.Products.Remove(item);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Info(int id)
        {
            var product = context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }

        private void LoadCategories()
        {
            var categories = new SelectList(context.Categories.ToList(), nameof(Product.Id), nameof(Product.Name));
            ViewBag.Categories = categories;
        }
    }
}
