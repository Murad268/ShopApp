using ShopApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.db;
using ShopApp.controllers;

namespace ShopApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();

            List<Product> products = ProductDb.All();
        Start:
          
            Console.WriteLine("Select 1 for Show all products, 2 Show products by category, 3 Show total company price, 4 for Show total price for category 5 for Add product, 6 for Sell product\r\n ");
            var seletectedVariant = Console.ReadLine();
            if (seletectedVariant == "1")
            {
                productController.getAllProducts(products);
                goto Start;
            } 
            
            else if(seletectedVariant == "2")
            {
                productController.getProductsByCategory(products);
                goto Start;
            }
            else if (seletectedVariant == "3")
            {
                productController.showAllCompanyTotalPrice(products);
                goto Start;
            }
            else if (seletectedVariant == "4")
            {
                productController.showAllCompanyTotalPriceByCategory(products);
                goto Start;
            }
            else if (seletectedVariant == "5")
            {
                productController.addProduct(ref products);
                goto Start;
            }
            else if (seletectedVariant == "6")
            {
                productController.getAllProducts(products);
                Console.WriteLine("Select product id for sell");
                var selectedId = Console.ReadLine();   
                productController.sellProduct(ref products, selectedId);
                goto Start;
            } else
            {
                Console.WriteLine("Invalid select");
                goto Start;
            }
            Console.ReadKey();
           
        }
    }
}
