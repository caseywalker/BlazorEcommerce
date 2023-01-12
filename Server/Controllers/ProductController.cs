using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
		private static List<Products> products = new List<Products>
	{
		new Products
		{
			Id = 1,
			Title = "Game",
			Description = "A video game.",
			ImageUrl = "https://m.media-amazon.com/images/I/517pFeCNrJL._AC_SY1000_.jpg",
			Price = 59.99m
		},
		new Products
		{
			Id = 2,
			Title = "DVD",
			Description = "A movie.",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/Web_of_Spider-Man_Vol_1_129-1.png",
			Price = 19.99m
		},
		new Products
		{
			Id = 3,
			Title = "Book",
			Description = "A best selling novel.",
			ImageUrl = "http://prodimage.images-bn.com/pimages/9780345806796_p0_v1_s1200x630.jpg",
			Price = 9.99m
		},
		new Products
		{
			Id = 4,
			Title = "Hockey Stick",
			Description = "A wooden stick.",
			ImageUrl = "https://images.purehockey.com/img.aspx?pic_id=95558&pic_type=4",
			Price = 99.99m
		},
		new Products
		{
			Id = 5,
			Title = "Dog Food",
			Description = "Food for good dogs.",
			ImageUrl = "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2019_27/2918166/190701-dog-food-eating-bowl-ac-527p.jpg",
			Price = 39.99m
		},
	};

		[HttpGet]
		public async Task<IActionResult> GetAllProducts()
        {
			return Ok(products);
        }
	}
}
