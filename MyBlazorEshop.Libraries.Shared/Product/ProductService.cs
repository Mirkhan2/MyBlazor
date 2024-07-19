using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.Storage;

namespace MyBlazor.Libraries.Product
{
    public class ProductService : IProductService
    {
        private readonly IStorgeService _storageService;

        public ProductService(IStorageService storageService)
        {
            this._storageService = storageService;
        }
        public IList<ProductModel> GetAll(int size , int page =1)
        {
            var skip = size * (page - 1);
            return _storageService.Products.Skip(skip).Take(size).ToList();
        }
       
        public ProductModel? GetProduct(string sku)
        {
            return _storageService.Products.FirstOrDefault(x => x.Sku == sku);
        }

        public ProductModel? GetProductBySlug(string slug)
        {
            return _storageService.Products.FirstOrDefault(x => x.Slug == slug);
        }

        public IList<ProductModel> GetAll()
        {
            return _storageService.Products.ToList();
        }

        public int GetTotalPageCount(int size, int page = 1)
        {
            var count = _storageService.Products.Count();
            return count > 0 ? (int)Math.Ceiling((decimal)count / size) : 1;

        }
    }
}
