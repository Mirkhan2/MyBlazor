using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.Storge
{
	public class StorgeService : IStorgeService
	{
		public IList<ProductModel> products { get; private set; }

        public StorgeService()
        {
            
        }
        private void AddProduct(ProductModel product)
        {
           //his.products.Add(product);
            if (!products.Any(p  => p.Sku == product.Sku))
            {
                products.Add(product);
            }
          

        }
    }
}
