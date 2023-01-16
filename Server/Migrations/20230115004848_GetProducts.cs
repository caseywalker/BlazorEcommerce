using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class GetProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A video game.", "https://m.media-amazon.com/images/I/517pFeCNrJL._AC_SY1000_.jpg", 59.99m, "Game" },
                    { 2, "A movie.", "https://upload.wikimedia.org/wikipedia/en/2/21/Web_of_Spider-Man_Vol_1_129-1.png", 19.99m, "DVD" },
                    { 3, "A best selling novel.", "http://prodimage.images-bn.com/pimages/9780345806796_p0_v1_s1200x630.jpg", 9.99m, "Book" },
                    { 4, "A wooden stick.", "https://images.purehockey.com/img.aspx?pic_id=95558&pic_type=4", 99.99m, "Hockey Stick" },
                    { 5, "Food for good dogs.", "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2019_27/2918166/190701-dog-food-eating-bowl-ac-527p.jpg", 39.99m, "Dog Food" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
