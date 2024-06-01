using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OLX_MVC.Data;
using RozetkaMVC.Data;
using RozetkaMVC.Data.Entities;
using RozetkaMVC.Models;
using System;

namespace RozetkaMVC.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ShopDbContext _context;

        public ReviewsController(ShopDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateReview(ReviewViewModel model)
        {
            if (ModelState.IsValid)
            {
                var review = new Review
                {
                    ProductId = model.ProductId,
                    UserName = model.UserName,
                    Content = model.Content,
                    Rating = model.Rating,
                    CreatedAt = DateTime.Now
                };

                _context.Reviews.Add(review);
                _context.SaveChanges();

                return RedirectToAction("ProductsDetails", "Home", new { id = model.ProductId });
            }

            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteReview(int id)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                _context.SaveChanges();
                return RedirectToAction("ProductsDetails", "Home", new { id = review.ProductId });
            }

            return NotFound();
        }
    }
}
