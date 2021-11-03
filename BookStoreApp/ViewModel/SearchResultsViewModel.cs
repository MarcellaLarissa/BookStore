using BookStoreApp.Commands;
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
        public Book _book;
        public readonly ObservableCollection<BookViewModel> _books;
        public IEnumerable<BookViewModel> Books => _books; 

        //commands
        public ICommand SearchCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public SearchResultsViewModel(ObservableCollection<BookViewModel> myBooks, Store store)
        {
            _books = new ObservableCollection<BookViewModel>();

            myBooks.Add(new BookViewModel(_book));

            SearchCommand = new SearchCommand(this, store, _book);
            EditCommand = new EditCommand(this, store, _book);
            DeleteCommand = new DeleteCommand(this, store, _book);
        }
    }
}
