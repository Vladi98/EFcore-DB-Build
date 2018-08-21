using AutoMapper;
using ProductShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop
{
    public class ProductShopProfile:Profile
    {
        public ProductShopProfile()
        {
            CreateMap<UserDto, Users>();
        }
    }
}
