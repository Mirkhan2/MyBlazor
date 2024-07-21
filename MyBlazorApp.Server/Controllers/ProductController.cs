using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlazor.Libraries.Product;
using MyBlazor.Libraries.Product.Models;

namespace MyBlazorApp.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IList<ProductModel> GetAll(int? size = null, int page = 1)
        {
            if (!size.HasValue)
            {
                return _productService.GetAll();

            }
            return _productService.GetAll(size.Value, page);
        }
        [HttpGet("total-page-count")]
        public int GetTotalCount(int size)
        {
            return _productService.GetTotalPageCount(size);
        }
        [HttpGet("by-/sku{slug}")]
        public IActionResult GetBySlug(string slug)
        {
            var product = _productService.GetProductBySlug(slug);
            if (product == null)
            {
                return NotFound(string.Format("The Slug '{} could not be found  ", slug));
            }
            return Ok(product);
        }
        [HttpGet("by-sku/{sku}")]
        public IActionResult GetBySku(string sku)
        {
            var product = _productService.Get(sku);
            if (product == null) 
            { 
                return NotFound(string.Format("The Sku '{} could not be found ", sku));
            }
            return Ok(product);
        }

    }
}
