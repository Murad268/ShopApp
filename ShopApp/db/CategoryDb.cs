using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.models;
namespace ShopApp.db
{
    internal class CategoryDb
    {
        private static List<Category> data = new List<Category>
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Home Appliances" },
            new Category { Id = 3, Name = "Clothing" },
            new Category { Id = 4, Name = "Books" },
            new Category { Id = 5, Name = "Furniture" },
            new Category { Id = 6, Name = "Toys" },
            new Category { Id = 7, Name = "Sports Equipment" },
            new Category { Id = 8, Name = "Beauty Products" },
            new Category { Id = 9, Name = "Automotive" },
            new Category { Id = 10, Name = "Garden Supplies" }
        };

        public List<Category> All()
        {
            return data;
        }

        public static string getCategory(int id)
        {
            foreach (var item in data)
            {
                if(id ==  item.Id) return item.Name;
            }
            return "Category not found";
        }
    }
}
