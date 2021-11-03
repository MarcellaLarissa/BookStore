using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Store
    {
        public Inventory _inventory;//might need to be private readonly
        public string Name { get; }

        public Store(string name)
        {
            Name = name;
            _inventory = new Inventory();
        }

        public IEnumerable<Book> SearchForBook(string title)
        {
            return _inventory.GetBookByTitle(title); //expand implementation after successful testing
        }

        public void CreateBookRecord(Book newBook)
        {
            _inventory.AddBook(newBook);
        }
    }
}
