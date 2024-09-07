using ShopApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.db
{
    internal class ProductDb
    {
        private static List<Product> data = new List<Product>
        {
            new Product { Id = 1, Name = "iPhone 13", Model = "Pro Max", Quantity = 50, Price = 1099.99m, Category = 1 },
            new Product { Id = 2, Name = "Samsung Galaxy S21", Model = "Ultra", Quantity = 25, Price = 999.99m, Category = 1 },
            new Product { Id = 3, Name = "Sony Headphones", Model = "WH-1000XM4", Quantity = 100, Price = 349.99m, Category = 1 },

            new Product { Id = 4, Name = "Dyson Vacuum Cleaner", Model = "V11", Quantity = 20, Price = 599.99m, Category = 2 },
            new Product { Id = 5, Name = "LG Washing Machine", Model = "TWINWash", Quantity = 15, Price = 899.99m, Category = 2 },
            new Product { Id = 6, Name = "Samsung Refrigerator", Model = "Family Hub", Quantity = 10, Price = 1499.99m, Category = 2 },

            new Product { Id = 7, Name = "Men's T-Shirt", Model = "Cotton", Quantity = 200, Price = 19.99m, Category = 3 },
            new Product { Id = 8, Name = "Women's Jacket", Model = "Leather", Quantity = 50, Price = 99.99m, Category = 3 },
            new Product { Id = 9, Name = "Men's Jeans", Model = "Slim Fit", Quantity = 100, Price = 49.99m, Category = 3 },

            new Product { Id = 10, Name = "The Catcher in the Rye", Model = "Paperback", Quantity = 80, Price = 9.99m, Category = 4 },
            new Product { Id = 11, Name = "1984 by George Orwell", Model = "Hardcover", Quantity = 50, Price = 14.99m, Category = 4 },
            new Product { Id = 12, Name = "To Kill a Mockingbird", Model = "Paperback", Quantity = 70, Price = 12.99m, Category = 4 },

            new Product { Id = 13, Name = "Dining Table", Model = "Wooden", Quantity = 20, Price = 299.99m, Category = 5 },
            new Product { Id = 14, Name = "Sofa", Model = "Leather", Quantity = 10, Price = 799.99m, Category = 5 },
            new Product { Id = 15, Name = "Bookshelf", Model = "Modern", Quantity = 25, Price = 89.99m, Category = 5 },

            new Product { Id = 16, Name = "Lego Set", Model = "Star Wars", Quantity = 60, Price = 49.99m, Category = 6 },
            new Product { Id = 17, Name = "Barbie Doll", Model = "Princess", Quantity = 100, Price = 19.99m, Category = 6 },
            new Product { Id = 18, Name = "Remote Control Car", Model = "Racer", Quantity = 30, Price = 29.99m, Category = 6 },

            new Product { Id = 19, Name = "Basketball", Model = "Spalding", Quantity = 50, Price = 29.99m, Category = 7 },
            new Product { Id = 20, Name = "Tennis Racket", Model = "Wilson", Quantity = 40, Price = 69.99m, Category = 7 },
            new Product { Id = 21, Name = "Yoga Mat", Model = "Eco-Friendly", Quantity = 70, Price = 19.99m, Category = 7 },

            new Product { Id = 22, Name = "Lipstick", Model = "Matte", Quantity = 100, Price = 14.99m, Category = 8 },
            new Product { Id = 23, Name = "Foundation", Model = "Liquid", Quantity = 80, Price = 29.99m, Category = 8 },
            new Product { Id = 24, Name = "Perfume", Model = "Eau de Parfum", Quantity = 60, Price = 59.99m, Category = 8 },

            new Product { Id = 25, Name = "Car Tires", Model = "All-Season", Quantity = 50, Price = 199.99m, Category = 9 },
            new Product { Id = 26, Name = "Car Battery", Model = "12V", Quantity = 40, Price = 149.99m, Category = 9 },
            new Product { Id = 27, Name = "Car Wax", Model = "Premium", Quantity = 80, Price = 19.99m, Category = 9 },

            new Product { Id = 28, Name = "Garden Hose", Model = "Expandable", Quantity = 50, Price = 29.99m, Category = 10 },
            new Product { Id = 29, Name = "Lawn Mower", Model = "Electric", Quantity = 15, Price = 399.99m, Category = 10 },
            new Product { Id = 30, Name = "Garden Shears", Model = "Stainless Steel", Quantity = 70, Price = 24.99m, Category = 10 }
        };

        public static List<Product> All()
        {
            return data;
        }
    }



}
