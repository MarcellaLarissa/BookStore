using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Book
    {
        public long ISBN { get; }
        public string Title { get; }
        public string Author { get; }
        public string Description { get; }
        public int Count { get; }

        public Book(long bookISBN, string title, string author, string description, int count)
        {
            ISBN = bookISBN;
            Title = title;
            Author = author;
            Description = description;
            Count = count;
        }

        public bool Conflicts(Book myBook)
        {
            if (myBook.ISBN != ISBN)
            {
                return false; // no error
            }

            return true; // matching record
        }
    }
}
