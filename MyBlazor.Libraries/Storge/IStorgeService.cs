using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.Storge
{
	public interface IStorgeService
	{
		IList<ProductModel> products { get; }
	}
}
