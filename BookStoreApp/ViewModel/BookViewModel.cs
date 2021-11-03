using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApp.Models;

namespace BookStoreApp.ViewModel
{
    public class BookViewModel : ViewModelBase
    {
        private readonly Book _book; //is this supposed to be coming from the main?? if not, this needs to change
        //public string ISBN { get; }
        //public string ISBN => _book.ISBN.ToString();
        public string ISBN { get; }
        public string Title => _book.Title.ToString();
        public string Author => _book.Author.ToString();
        public string Description => _book.Description.ToString();
        public string Count => _book.Count.ToString();
        public BookViewModel(Book book)
        {
            _book = book;
        }

    }
}
