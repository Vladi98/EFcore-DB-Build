using AutoMapper;
using ProductShop;
using ProductShop.Data;
using ProductShop.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ProductsShop
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var xmlString = File.ReadAllText("Xml/users.xml");
            var context = new ProductShopDbContext();

            var config = new MapperConfiguration(cfg=> 
            {
                cfg.AddProfile<ProductShopProfile>();

            });
            var mapper = config.CreateMapper();

            var serializer = new XmlSerializer(typeof(UserDto[]), new XmlRootAttribute("users"));

            var desirializedUser = (UserDto[])serializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();

            List<Users> users = new List<Users>();

            foreach (var userdto in desirializedUser)
            {
                if (!IsValid(userdto))
                {
                    sb.AppendLine("Invalid data");
                    continue;
                }

                var userMap = mapper.Map<Users>(userdto);

                users.Add(userMap);

                sb.AppendLine("Success");
            }
            context.Users.AddRange(users);
            context.SaveChanges();
            

           
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);

            var validationResults = new List<ValidationResult>();

            return System.ComponentModel.DataAnnotations.Validator.TryValidateObject(obj,validationContext, validationResults, true);
        }
    }
}
