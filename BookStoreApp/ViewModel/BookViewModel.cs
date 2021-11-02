using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApp.Models;

namespace BookStoreApp.ViewModel
{
    public class BookViewModel
    {
        private readonly Book myBook1; //is this supposed to be coming from the main?? if not, this needs to change
        //public string ISBN { get; }
        public string ISBN => myBook1.ISBN.ToString();
        public string Title => myBook1.Title.ToString();
        public string Author => myBook1.Author.ToString();
        public string Description => myBook1.Description.ToString();
        public string Count => myBook1.Count.ToString();
        public BookViewModel(Book book)
        {
            myBook1 = book;
        }

    }
}
