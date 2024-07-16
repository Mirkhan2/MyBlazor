﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Libraries.Product.Models
{
    public class ProductAddToCartModel
    {
        [Required(ErrorMessage ="quantity send")]
        public int? Quantity { get; set; }
    }
}
