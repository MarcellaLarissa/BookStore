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
        public readonly ObservableCollection<BookViewModel> Book;
        public IEnumerable<SearchResultsViewModel> SearchResults => (IEnumerable<SearchResultsViewModel>)Book; //remove cast?? this needs to point to the correct field timestamp 9:30 ViewModels
        public ICommand SearchCommand { get; }

        public ICommand AddCommand { get; }

        public SearchResultsViewModel(long ISBN, string title, string author, string description, int count)
        {
            Book = new ObservableCollection<BookViewModel>();

            //Book.Add(new SearchResultsViewModel(new Book(0000234235445, "Sherlock Holmes", "Arthur Conan Doyle", "Baker St.", 1)));
            //Book.Add(myBook);
        }
    }
}
