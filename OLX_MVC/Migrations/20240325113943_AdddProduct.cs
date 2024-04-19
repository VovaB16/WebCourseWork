using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OLX_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AdddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 15, 1, null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", "iPhone X", 650m },
                    { 16, 1, null, 5, "https://ocs-pl.oktawave.com/v1/AUTH_2887234e-384a-4873-8bc5-405211db13a2/spidersweb/2020/01/samsung-galaxy-s20-ultra.jpeg", "Samsung Galaxy S20", 700m },
                    { 17, 1, null, 15, "https://th.bing.com/th/id/OIP.Op8FrM2h2IsLHbOF7vugMQHaEw?rs=1&pid=ImgDetMain", "Google Pixel 5", 600m },
                    { 18, 1, null, 0, "https://www.bhphotovideo.com/images/images1000x1000/sony_3005718_playstation_5_gaming_console_1595083.jpg", "Sony PlayStation 5", 500m },
                    { 19, 1, null, 0, "https://th.bing.com/th/id/OIP.LQLFfy7eO2Fhd8SP7MZYawAAAA?rs=1&pid=ImgDetMain", "Xbox Series X", 550m },
                    { 20, 1, null, 8, "https://th.bing.com/th/id/OIP.XCCok6ApjGjDhiGkxt7wsQHaEF?rs=1&pid=ImgDetMain", "Nintendo Switch", 300m },
                    { 21, 1, null, 12, "https://cdn.alzashop.com/ImgW.ashx?fd=f16&cd=NTB1437b7", "Dell XPS 15", 1500m },
                    { 22, 1, null, 5, "https://th.bing.com/th/id/R.9e3e3086076d38809dd5a3feed484642?rik=lxRJJxWFP9OsRw&pid=ImgRaw&r=0", "MacBook Pro 13", 1300m },
                    { 23, 1, null, 0, "https://th.bing.com/th/id/OIP.aFywxx2DuURHemZu4OMUtAHaHa?rs=1&pid=ImgDetMain", "HP Pavilion", 700m },
                    { 24, 1, null, 20, "https://th.bing.com/th/id/R.f0fc7ff5e2b4879ffdd3054ed24ddb2b?rik=goSia%2fJ52988FA&pid=ImgRaw&r=0", "Canon EOS Rebel T7", 500m },
                    { 25, 1, null, 15, "https://th.bing.com/th/id/OIP.CYyUZ9iZjK1CRk42jHG6agHaHM?rs=1&pid=ImgDetMain", "Nikon D3500", 450m },
                    { 26, 1, null, 8, "https://i5.walmartimages.com/asr/42bd7af9-778b-4230-ba72-0c9190fc2b2d_8.f32f9b5a271d0921e874b2c94e83a245.jpeg", "Samsung 55'' 4K TV", 800m },
                    { 27, 1, null, 0, "https://i5.walmartimages.com/asr/8286b014-1ded-41f6-8b28-20feff59a374_1.47a679080c03b1c78e2e685f15b6e6fc.jpeg", "LG 65'' OLED TV", 2000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", "iPhone X", 650m },
                    { 2, 1, null, 5, "https://ocs-pl.oktawave.com/v1/AUTH_2887234e-384a-4873-8bc5-405211db13a2/spidersweb/2020/01/samsung-galaxy-s20-ultra.jpeg", "Samsung Galaxy S20", 700m },
                    { 3, 1, null, 15, "https://th.bing.com/th/id/OIP.Op8FrM2h2IsLHbOF7vugMQHaEw?rs=1&pid=ImgDetMain", "Google Pixel 5", 600m },
                    { 4, 1, null, 0, "https://www.bhphotovideo.com/images/images1000x1000/sony_3005718_playstation_5_gaming_console_1595083.jpg", "Sony PlayStation 5", 500m },
                    { 5, 1, null, 0, "https://th.bing.com/th/id/OIP.LQLFfy7eO2Fhd8SP7MZYawAAAA?rs=1&pid=ImgDetMain", "Xbox Series X", 550m },
                    { 6, 1, null, 8, "https://th.bing.com/th/id/OIP.XCCok6ApjGjDhiGkxt7wsQHaEF?rs=1&pid=ImgDetMain", "Nintendo Switch", 300m },
                    { 7, 1, null, 12, "https://cdn.alzashop.com/ImgW.ashx?fd=f16&cd=NTB1437b7", "Dell XPS 15", 1500m },
                    { 8, 1, null, 5, "https://th.bing.com/th/id/R.9e3e3086076d38809dd5a3feed484642?rik=lxRJJxWFP9OsRw&pid=ImgRaw&r=0", "MacBook Pro 13", 1300m },
                    { 9, 1, null, 0, "https://th.bing.com/th/id/OIP.aFywxx2DuURHemZu4OMUtAHaHa?rs=1&pid=ImgDetMain", "HP Pavilion", 700m },
                    { 10, 1, null, 20, "https://th.bing.com/th/id/R.f0fc7ff5e2b4879ffdd3054ed24ddb2b?rik=goSia%2fJ52988FA&pid=ImgRaw&r=0", "Canon EOS Rebel T7", 500m },
                    { 11, 1, null, 15, "https://th.bing.com/th/id/OIP.CYyUZ9iZjK1CRk42jHG6agHaHM?rs=1&pid=ImgDetMain", "Nikon D3500", 450m },
                    { 12, 1, null, 8, "https://i5.walmartimages.com/asr/42bd7af9-778b-4230-ba72-0c9190fc2b2d_8.f32f9b5a271d0921e874b2c94e83a245.jpeg", "Samsung 55'' 4K TV", 800m },
                    { 13, 1, null, 0, "https://i5.walmartimages.com/asr/8286b014-1ded-41f6-8b28-20feff59a374_1.47a679080c03b1c78e2e685f15b6e6fc.jpeg", "LG 65'' OLED TV", 2000m }
                });
        }
    }
}
