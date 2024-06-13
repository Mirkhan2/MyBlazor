using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.Product
{
	public interface IProductService
	{
		ProductModel? GetProduct(string sku);
		ProductModel? GetProductBySlug(string slug);
		IList<ProductModel> GetAll();
	}
}
