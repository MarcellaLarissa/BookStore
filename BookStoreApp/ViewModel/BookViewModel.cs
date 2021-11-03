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
        private readonly Book _book; 
        //binding with values in SearchResults.xaml ~ line 83
        public string ISBN => _book.ISBN.ToString();
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
