﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OLX_MVC.Data;

#nullable disable

namespace OLX_MVC.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20240325113943_AdddProduct")]
    partial class AdddProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OLX_MVC.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fashion"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Home & Garden"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Transport"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Toys & Hobbies"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Musical Instruments"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("OLX_MVC.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 15,
                            CategoryId = 1,
                            Discount = 10,
                            ImageUrl = "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png",
                            Name = "iPhone X",
                            Price = 650m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 1,
                            Discount = 5,
                            ImageUrl = "https://ocs-pl.oktawave.com/v1/AUTH_2887234e-384a-4873-8bc5-405211db13a2/spidersweb/2020/01/samsung-galaxy-s20-ultra.jpeg",
                            Name = "Samsung Galaxy S20",
                            Price = 700m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 1,
                            Discount = 15,
                            ImageUrl = "https://th.bing.com/th/id/OIP.Op8FrM2h2IsLHbOF7vugMQHaEw?rs=1&pid=ImgDetMain",
                            Name = "Google Pixel 5",
                            Price = 600m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 1,
                            Discount = 0,
                            ImageUrl = "https://www.bhphotovideo.com/images/images1000x1000/sony_3005718_playstation_5_gaming_console_1595083.jpg",
                            Name = "Sony PlayStation 5",
                            Price = 500m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 1,
                            Discount = 0,
                            ImageUrl = "https://th.bing.com/th/id/OIP.LQLFfy7eO2Fhd8SP7MZYawAAAA?rs=1&pid=ImgDetMain",
                            Name = "Xbox Series X",
                            Price = 550m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 1,
                            Discount = 8,
                            ImageUrl = "https://th.bing.com/th/id/OIP.XCCok6ApjGjDhiGkxt7wsQHaEF?rs=1&pid=ImgDetMain",
                            Name = "Nintendo Switch",
                            Price = 300m
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 1,
                            Discount = 12,
                            ImageUrl = "https://cdn.alzashop.com/ImgW.ashx?fd=f16&cd=NTB1437b7",
                            Name = "Dell XPS 15",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 1,
                            Discount = 5,
                            ImageUrl = "https://th.bing.com/th/id/R.9e3e3086076d38809dd5a3feed484642?rik=lxRJJxWFP9OsRw&pid=ImgRaw&r=0",
                            Name = "MacBook Pro 13",
                            Price = 1300m
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 1,
                            Discount = 0,
                            ImageUrl = "https://th.bing.com/th/id/OIP.aFywxx2DuURHemZu4OMUtAHaHa?rs=1&pid=ImgDetMain",
                            Name = "HP Pavilion",
                            Price = 700m
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 1,
                            Discount = 20,
                            ImageUrl = "https://th.bing.com/th/id/R.f0fc7ff5e2b4879ffdd3054ed24ddb2b?rik=goSia%2fJ52988FA&pid=ImgRaw&r=0",
                            Name = "Canon EOS Rebel T7",
                            Price = 500m
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 1,
                            Discount = 15,
                            ImageUrl = "https://th.bing.com/th/id/OIP.CYyUZ9iZjK1CRk42jHG6agHaHM?rs=1&pid=ImgDetMain",
                            Name = "Nikon D3500",
                            Price = 450m
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 1,
                            Discount = 8,
                            ImageUrl = "https://i5.walmartimages.com/asr/42bd7af9-778b-4230-ba72-0c9190fc2b2d_8.f32f9b5a271d0921e874b2c94e83a245.jpeg",
                            Name = "Samsung 55'' 4K TV",
                            Price = 800m
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 1,
                            Discount = 0,
                            ImageUrl = "https://i5.walmartimages.com/asr/8286b014-1ded-41f6-8b28-20feff59a374_1.47a679080c03b1c78e2e685f15b6e6fc.jpeg",
                            Name = "LG 65'' OLED TV",
                            Price = 2000m
                        });
                });

            modelBuilder.Entity("OLX_MVC.Data.Entities.Product", b =>
                {
                    b.HasOne("OLX_MVC.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OLX_MVC.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}