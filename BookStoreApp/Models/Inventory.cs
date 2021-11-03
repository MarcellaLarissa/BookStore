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
            return BookList.Where(b => b.Title == title); //update this to search for substrings
        }

        public IEnumerable<Book> GetBookByAuthor(string author)
        {
            return BookList.Where(b => b.Author == author);//update this to search for substrings
        }

        public IEnumerable<Book> GetBookByKeyword(string keyword)
        {
            return BookList.Where(b => b.Description == keyword);//update this to search for substrings
        }

        public IEnumerable<Book> GetBookByISBN(int bookISBN)
        {
            return BookList.Where(b => b.ISBN == bookISBN); 
        }

        public void AddBook(Book _book)// need to implement messages as a popup?
        {
            //string errorMessage = myBook.Title + " is already in the book store inventory.";
            //string successMessage = myBook.Title + " has been added to the book store inventory.";

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
