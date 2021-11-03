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
         //public IEnumerable<Book> GetBookRecordForUser(string title, string author, string keyword, int ISBN)
        {
           // return Inventory.GetBookByTitle(title) + Inventory.GetBookByAuthor(author) + Inventory.GetBookByKeyword(keyword) + Inventory.GetBookByISBN(ISBN);
            return _inventory.GetBookByTitle(title);
        }

        public void CreateBookRecord(Book newBook)
        {
            _inventory.AddBook(newBook);
        }

    }
}
