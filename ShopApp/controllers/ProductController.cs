using System;using System.Collections.Generic;using System.Diagnostics;using System.Linq;using ShopApp.db;using ShopApp.models;using ShopApp.controllers;namespace ShopApp.controllers{    internal class ProductController    {        CategoryDb category = new CategoryDb();        List<Category> categories;             public ProductController()        {             categories = category.All();        }              public void getAllProducts(List<Product> products) {            foreach (var productItem in products)             {                Console.WriteLine($"ID: {productItem.Id}, Name: {productItem.Name}, Model: {productItem.Model}, Quantity: {productItem.Quantity}, Category: {CategoryDb.getCategory(productItem.Category)}");            }        }        public void getProductsByCategory(List<Product> products)        {        Start:            CategoriesList();            var selectedId = Console.ReadLine();            List<Product> ProductList = new List<Product>();            foreach (var productItem in products)            {                if(Convert.ToString(productItem.Category) == selectedId)                {                    ProductList.Add(productItem);                }            }            if (ProductList.Count > 0)            {                foreach (var productItem in ProductList)                {                    Console.WriteLine($"ID: {productItem.Id}, Name: {productItem.Name}, Model: {productItem.Model}, Quantity: {productItem.Quantity}, Category: {CategoryDb.getCategory(productItem.Category)}");                }            } else            {                Console.WriteLine("No matching products found");                goto Start;            }        }               public void addProduct(ref List<Product> products)        {        SelectName:            Console.WriteLine("Insert Product Name");            string name = Console.ReadLine();            if (string.IsNullOrEmpty(name))            {                Console.WriteLine("The name field cannot be empty");                goto SelectName;            }        SelectModel:            Console.WriteLine("Insert Product Model");            string model = Console.ReadLine();            if (string.IsNullOrEmpty(model))            {                Console.WriteLine("The model field cannot be empty");                goto SelectModel;            }        SelectQuantity:            Console.WriteLine("Insert Product Quantity");            string quantity = Console.ReadLine();            if (!int.TryParse(quantity, out int number) || number < 0)            {                Console.WriteLine("Invalid format for quantity");                goto SelectQuantity;            }        SelectPrice:            Console.WriteLine("Insert Product Price");            string price = Console.ReadLine();            if (!int.TryParse(price, out int priceNumber) || priceNumber < 0)            {                Console.WriteLine("Invalid format for price");                goto SelectPrice;            }            CategoriesList();        SelectCategory:            Console.WriteLine("Insert Product Category id");            string category_id = Console.ReadLine();            if (!SearchCategory(category_id))            {                goto SelectCategory;            }            Console.WriteLine($"A product called {name} has been added to the store.");            int LastId = products.Count > 0 ? products[products.Count - 1].Id + 1 : 1;            products.Add(new Product { Id = LastId, Name = name, Model = model, Quantity = Convert.ToUInt32(quantity), Price = Convert.ToInt32(price), Category = Convert.ToInt32(category_id) });                  }        public void sellProduct(ref List<Product> products, string id)
        {
            // Məhsul mövcuddurmu yoxlayırıq
            var product = products.FirstOrDefault(p => Convert.ToString(p.Id) == id);

            if (product == null)
            {
                Console.WriteLine("No matching products found");
                return;
            }

            int quantityToSell;
        SellQuantity:
            Console.WriteLine($"Enter the quantity to sell for product {product.Name} (Available: {product.Quantity})");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out quantityToSell) || quantityToSell <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a valid positive number.");
                goto SellQuantity;
            }

            if (quantityToSell > product.Quantity)
            {
                Console.WriteLine($"Not enough products in stock. Available quantity: {product.Quantity}");
                goto SellQuantity;
            }

            if (quantityToSell == product.Quantity)
            {
                products = products.Where(p => p.Id != product.Id).ToList();
                Console.WriteLine($"Product with id {id} has been completely sold and removed from the inventory.");
            }
            else
            {
                product.Quantity -= Convert.ToUInt32(quantityToSell);
                Console.WriteLine($"{quantityToSell} units of product {product.Name} have been sold. Remaining quantity: {product.Quantity}");
            }
        }
        public void CategoriesList()        {            foreach (var category in categories)            {                Console.WriteLine($"ID: {category.Id}, Name: {category.Name}");            }            Console.WriteLine("Select category id");        }        public bool SearchCategory(string selectedId) {            List<Category> filteredCategories = category.All().Where(category => Convert.ToString(category.Id) == selectedId).ToList();            if (filteredCategories.Count < 1)            {                Console.WriteLine("No matching products found");                return false;            }            return true;        }        public bool checkProductId(List<Product> products, string id)        {            foreach (var item in products)            {                if(Convert.ToString(item.Id) == id)                {                    return true;                }            }            return false;        }

        public void showAllCompanyTotalPrice(List<Product> products)        {            Console.WriteLine($"Total price of company: {products.Sum(product => product.Price)} AZN");        }        public void showAllCompanyTotalPriceByCategory(List<Product> products)        {        Start:            CategoriesList(); // Bu metod haradan çağırılır?
            var selectedId = Console.ReadLine();            if (!SearchCategory(selectedId)) // Bu metod haradan çağırılır?
            {                goto Start;            }            Console.WriteLine($"Total price of company: {products.Sum(product => product.Id == Convert.ToInt32(selectedId) ? product.Price : 0)} AZN");        }    }}