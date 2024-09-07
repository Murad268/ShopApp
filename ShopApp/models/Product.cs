using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public uint Quantity { get; set; }
        public decimal Price { get; set; }
        public int Category { get; set; }
    }
}
