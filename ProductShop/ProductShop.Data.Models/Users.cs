using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductShop.Data.Models
{
   public class Users
    {
        public Users()
        {
           this.ProductsSold = new List<Models.Products>();
           this.ProductsBougth = new List<Models.Products>();


        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        [MinLength(3)]
        public string LastName { get; set; }

        public int? Age { get; set; }

       
        public ICollection<Products> ProductsSold { get; set; }

      
        public ICollection<Products> ProductsBougth { get; set; }







    }
}
