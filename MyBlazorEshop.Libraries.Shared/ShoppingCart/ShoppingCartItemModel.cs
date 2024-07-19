using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.ShoppingCartService.Models;

namespace MyBlazor.Libraries.ShoppingCart
{
    internal class ShoppingCartItemModel : ShoppingCartItemService
    {
        public ShoppingCartItemModel(ProductModel product, int quantity) : base(product, quantity)
        {
        }
    }
}