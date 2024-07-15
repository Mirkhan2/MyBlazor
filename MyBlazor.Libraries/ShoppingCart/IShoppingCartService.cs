using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.ShoppingCart.Models;
using MyBlazor.Libraries.ShoppingCartService.Models;

namespace MyBlazor.Libraries.ShoppingCart
{
	public interface IShoppingCartService
	{
		ShoppingCartModel Get();
		void AddProduct(ProductModel product, int quantity);
		void DeleteProduct(ShoppingCartItemModel item);
		int Count();
		bool HasProduct(string sku);
	}
}
