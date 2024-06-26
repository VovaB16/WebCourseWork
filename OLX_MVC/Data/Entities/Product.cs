﻿using OLX_MVC.Data.Entities;

namespace OLX_MVC.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Discount { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}