using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Book
    {
        public int ISBN { get; }
        public string Title { get; }
        public string Author { get; }
        public string Description { get; }
        public int NumberInStock { get; }

        public Book(int bookISBN, string title, string author, string description, int numberInStock)
        {
            //Book = new Book();

            ISBN = bookISBN;
            Title = title;
            Author = author;
            Description = description;
            NumberInStock = numberInStock;

        }
    }
}
