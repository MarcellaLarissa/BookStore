using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApp.ViewModel;
using BookStoreApp.Models;

namespace BookStoreApp.Commands
{
    public class SearchCommand : CommandBase
    {
        private readonly SearchResultsViewModel _searchResultsViewModel;

        public SearchCommand(SearchResultsViewModel searchResultsViewModel, Store store, Book book)
        {
            _searchResultsViewModel = searchResultsViewModel;
            // _store = store;
        }
        public override void Execute(object parameter)
        {
           // Book returnedBook = _inventory.GetBookByTitle(_searchResultsViewModel._book.Title);// _store.SearchForBook(_test);incorrect access of store/inventory/booklist
        }
    }
}
