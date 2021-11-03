using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStoreApp.ViewModel
{
    public class SearchResultsViewModel : ViewModelBase
    {
        //private readonly Store _store;
        public Book aTestBook;

        public readonly ObservableCollection<BookViewModel> _books;
        public IEnumerable<BookViewModel> Books => _books; //remove cast?? this needs to point to the correct field timestamp 9:30 ViewModels
        public ICommand SearchCommand { get; }

        public ICommand AddCommand { get; }

        public SearchResultsViewModel(ObservableCollection<BookViewModel> myBooks)
        {
            _books = new ObservableCollection<BookViewModel>();

            myBooks.Add(new BookViewModel(aTestBook));

            //myBooks.Add(new SearchResultsViewModel(myBooks));
            //Book.Add(myBooks);
        }
    }
}
