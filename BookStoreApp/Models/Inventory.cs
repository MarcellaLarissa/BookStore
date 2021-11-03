using BookStoreApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    //data structure to hold books
    public class Inventory
    {
        public List<Book> BookList;

        public Inventory()
        {
            BookList = new List<Book>();
        }

        public IEnumerable<Book> GetBookByTitle(string title)
        {
            return BookList.Where(b => b.Title == title); 
        }

        public IEnumerable<Book> GetBookByAuthor(string author)
        {
            return BookList.Where(b => b.Author == author);
        }

        public IEnumerable<Book> GetBookByKeyword(string keyword)
        {
            return BookList.Where(b => b.Description == keyword);
        }

        public IEnumerable<Book> GetBookByISBN(int bookISBN)
        {
            return BookList.Where(b => b.ISBN == bookISBN); 
        }

        public void AddBook(Book _book)
        {
            foreach (Book bookRecord in BookList)
            {
                if (bookRecord.Conflicts(_book))
                {
                    throw new BookRecordConflictException(bookRecord, _book);
                }
            }
              BookList.Add(_book);
        }
    }
}
