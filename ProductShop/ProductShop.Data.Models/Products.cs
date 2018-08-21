using System;
using System.Collections.Generic;

namespace ProductShop.Data.Models
{
    public class Products
    {
        public Products()
        {
            this.CategoryProducts = new List<Models.CategoryProducts>();
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
        
        public int? BuyerId { get; set; }
        public Users Buyer { get; set; }

        public int SellerId { get; set; }
        public Users Seller { get; set; }

        public ICollection<CategoryProducts> CategoryProducts { get; set; }


    }
}
