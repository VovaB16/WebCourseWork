using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OLX_MVC.Data.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace OLX_MVC.Data
{
    public class ShopDbContext : IdentityDbContext<User>
    {
        public ShopDbContext()
        {
            //this.Database.EnsureCreated();    
        }

        public ShopDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Sport" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Home & Garden" },
                new Category() { Id = 5, Name = "Transport" },
                new Category() { Id = 6, Name = "Toys & Hobbies" },
                new Category() { Id = 7, Name = "Musical Instruments" },
                new Category() { Id = 8, Name = "Art" },
                new Category() { Id = 9, Name = "Other" }
            });
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product() { Id = 1, Name = "iPhone X", CategoryId = 1, Discount = 10, Price = 650, ImageUrl = "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png" },
                new Product() { Id = 2, Name = "Samsung Galaxy S20", CategoryId = 1, Discount = 5, Price = 700, ImageUrl = "https://ocs-pl.oktawave.com/v1/AUTH_2887234e-384a-4873-8bc5-405211db13a2/spidersweb/2020/01/samsung-galaxy-s20-ultra.jpeg" },
                new Product() { Id = 3, Name = "Google Pixel 5", CategoryId = 1, Discount = 15, Price = 600, ImageUrl = "https://th.bing.com/th/id/OIP.Op8FrM2h2IsLHbOF7vugMQHaEw?rs=1&pid=ImgDetMain" },
                new Product() { Id = 4, Name = "Sony PlayStation 5", CategoryId = 1, Discount = 0, Price = 500, ImageUrl = "https://www.bhphotovideo.com/images/images1000x1000/sony_3005718_playstation_5_gaming_console_1595083.jpg" },
                new Product() { Id = 5, Name = "Xbox Series X", CategoryId = 1, Discount = 0, Price = 550, ImageUrl = "https://th.bing.com/th/id/OIP.LQLFfy7eO2Fhd8SP7MZYawAAAA?rs=1&pid=ImgDetMain" },
                new Product() { Id = 6, Name = "Nintendo Switch", CategoryId = 1, Discount = 8, Price = 300, ImageUrl = "https://th.bing.com/th/id/OIP.XCCok6ApjGjDhiGkxt7wsQHaEF?rs=1&pid=ImgDetMain" },
                new Product() { Id = 8, Name = "MacBook Pro 13", CategoryId = 1, Discount = 5, Price = 1300, ImageUrl = "https://th.bing.com/th/id/R.9e3e3086076d38809dd5a3feed484642?rik=lxRJJxWFP9OsRw&pid=ImgRaw&r=0" },
                new Product() { Id = 9, Name = "HP Pavilion", CategoryId = 1, Discount = 0, Price = 700, ImageUrl = "https://th.bing.com/th/id/OIP.aFywxx2DuURHemZu4OMUtAHaHa?rs=1&pid=ImgDetMain" },
                new Product() { Id = 10, Name = "Canon EOS Rebel T7", CategoryId = 1, Discount = 20, Price = 500, ImageUrl = "https://th.bing.com/th/id/R.f0fc7ff5e2b4879ffdd3054ed24ddb2b?rik=goSia%2fJ52988FA&pid=ImgRaw&r=0" },
                new Product() { Id = 11, Name = "Nikon D3500", CategoryId = 1, Discount = 15, Price = 450, ImageUrl = "https://th.bing.com/th/id/OIP.CYyUZ9iZjK1CRk42jHG6agHaHM?rs=1&pid=ImgDetMain" },
                new Product() { Id = 12, Name = "Samsung 55'' 4K TV", CategoryId = 1, Discount = 8, Price = 800, ImageUrl = "https://i5.walmartimages.com/asr/42bd7af9-778b-4230-ba72-0c9190fc2b2d_8.f32f9b5a271d0921e874b2c94e83a245.jpeg" },
                new Product() { Id = 13, Name = "LG 65'' OLED TV", CategoryId = 1, Discount = 0, Price = 2000, ImageUrl = "https://i5.walmartimages.com/asr/8286b014-1ded-41f6-8b28-20feff59a374_1.47a679080c03b1c78e2e685f15b6e6fc.jpeg" },
            });

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
