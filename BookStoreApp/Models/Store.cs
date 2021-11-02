using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Store
    {
        public Inventory Inventory;//might need to be private readonly

        public string Name { get; }

        public Store(string name)
        {
            Name = name;

            Inventory = new Inventory();
        }
    }
}
