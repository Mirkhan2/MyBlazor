using MyBlazor.Libraries.Product.Models;


namespace MyBlazor.Libraries.Product
{
    public interface IProductService
    {
        ProductModel? GetProduct(string sku);
        ProductModel? GetProductBySlug(string slug);
        IList<ProductModel> GetAll();
        int GetTotalPageCount(int size,int page=1);
    }
}
