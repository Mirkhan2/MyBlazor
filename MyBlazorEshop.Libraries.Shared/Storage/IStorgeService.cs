
using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.ShoppingCartService.Models;

namespace MyBlazor.Libraries.Storage
{
    public interface IStorgeService
    {
        IList<ProductModel> Products { get; }

        ShoppingCartModel ShoppingCart { get; }
    }
}
