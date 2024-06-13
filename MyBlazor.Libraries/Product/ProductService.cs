using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.Storge;

namespace MyBlazor.Libraries.Product
{
	public class ProductService : IProductService
	{
		private readonly IStorgeService _storgeService;

		public ProductService(IStorgeService storgeService)
        {
			this._storgeService = storgeService;
		}
        public IList<ProductModel> GetAll()
		{
			return _storgeService.products.ToList();
		}

		public ProductModel? GetProduct(string sku)
		{
			return _storgeService.products.FirstOrDefault(x => x.Sku == sku);

		}

		public ProductModel? GetProductBySlug(string slug)
		{
			return _storgeService.products.FirstOrDefault(x =>x.Slug == slug);
		}
	}
}
