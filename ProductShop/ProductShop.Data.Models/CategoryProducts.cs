using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.Data.Models
{
    public class CategoryProducts
    {
 
        public int ProductId { get; set; }
        public Products Products { get; set; }

        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
    }
}
