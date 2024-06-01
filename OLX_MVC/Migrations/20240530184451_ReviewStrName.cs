using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLX_MVC.Migrations
{
    /// <inheritdoc />
    public partial class ReviewStrName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reviews",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Reviews",
                newName: "UserId");
        }
    }
}
