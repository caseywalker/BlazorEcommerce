using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}
		[HttpGet]
		public async Task<ActionResult<List<Product>>> GetAllProducts()
		{
			var result = await _productService.GetProductAsync();
			return Ok(result);
		}
	}
}
