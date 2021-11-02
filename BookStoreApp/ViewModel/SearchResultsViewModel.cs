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
    class SearchResultsViewModel : ViewModelBase
    {
        public readonly ObservableCollection<BookViewModel> Book;
        public ICommand SearchCommand { get; }

        public ICommand AddCommand { get; }

        public SearchResultsViewModel()
        {
            Book = new ObservableCollection<BookViewModel>();
        }
    }
}
