using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.ShoppingCartService.Models;

namespace MyBlazor.Libraries.ShoppingCart
{
    public class ShoppingCartItemModel : ShoppingCartItemService
    {
        public ShoppingCartItemModel(ProductModel product, int quantity) : base(product, quantity)
        {
        }
    }
}