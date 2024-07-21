using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlazor.Libraries.Product;
using MyBlazor.Libraries.ShoppingCart;
using MyBlazor.Libraries.ShoppingCartService.Models;
using MyBlazorEshop.Sharedd.Shared.Models;

namespace MyBlazorApp.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ShoppingCartController : ControllerBase
	{
		IShoppingCartService _shoppingCartService;
		IProductService _productService;
        public ShoppingCartController(IShoppingCartService shoppingCartService,IProductService productService)
        {
            _productService = productService;
			_shoppingCartService = shoppingCartService;
        }
		[HttpGet]
		public ShoppingCartModel GetCartModel()
		{
			return _shoppingCartService.Get();
		}
		[HttpGet("count")]
		public int GetCount()
		{
			return _shoppingCartService.Count();
		}
		[HttpGet("has-product/{sku}")]
		public bool HasProduct(string sku)
		{
			return _shoppingCartService.HasProduct(sku);
		}
        [HttpPost]
        public IActionResult AddProduct(ShoppingCartAddModel shoppingCartAdd)
        {
            var product = !string.IsNullOrWhiteSpace(shoppingCartAdd.ProductSku)
                ? _productService.Get(shoppingCartAdd.ProductSku) : null;
            if (product == null)
            {
                return NotFound();


            }
            _shoppingCartService.AddProduct(product, shoppingCartAdd.Quantity);
            return Ok(new { Success = true });
        }
        [HttpPut]
		public IActionResult UpdateProduct(ShoppingCartAddModel shoppingCartAdd)
		{
			var product =!string.IsNullOrWhiteSpace(shoppingCartAdd.ProductSku)
				? _productService.GetProduct.Get(shoppingCartAdd.ProductSku) : null;
			if (product == null)
			{
				return NotFound();
			}
			_shoppingCartService.AddProduct(product, shoppingCartAdd.Quantity);
			return Ok(new { Success = true });
		}
		[HttpDelete]
		public IActionResult DeleteProduct(string sku)
		{
			var cart = _shoppingCartService.Get();
			if (cart?.Items == null || !cart.Items.Any(s => s.Product.Sku == sku))
			{
				return NotFound();

			}
			var product = cart?.Items.First(p => p.Product.Sku
			 == sku);
			_shoppingCartService.DeleteProduct(product);
			return Ok(new { Success = true });
		}


    }
}
