using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Libraries.ShoppingCartService.Models
{
    public class ShoppingCartModel
    {
        public IList<ShoppingCartItemService> Items { get; }

        public ShoppingCartModel() 
        {
            Items = new List<ShoppingCartItemService>();

        }
    }
}
