using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.Data.Models
{
    public class Categories
    {

        public Categories()
        {
            this.CategoryProducts = new List<CategoryProducts>();
        }
        public int Id { get; set; }

        public string Name { get; set; }


        public ICollection<CategoryProducts> CategoryProducts { get; set; }

    }
}
