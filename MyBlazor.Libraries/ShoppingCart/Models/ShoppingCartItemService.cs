using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.ShoppingCartService.Models
{
    public class ShoppingCartItemService
    {
        public ProductModel Product { get; }
        public int Price { get; protected set; }
        public int Quantity { get; protected set; }
        public int TotalPrice
        {
            get 
            {
                return Price * Quantity;
            }
        }
        public ShoppingCartItemService(ProductModel product,int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            Quantity = quantity;
        }
        public void UpdateQuantity(ProductModel product, int quantity)
        {
            Price = product.Price;
            Quantity = quantity;

        }

    }
}
