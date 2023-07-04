using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Store
{
    public class Item
    {

        private static int nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Double Price { get; set; }

        public Item(string name, int quantity, double price)
        {
            Id = nextId++;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
