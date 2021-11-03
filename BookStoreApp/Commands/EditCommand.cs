using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApp.ViewModel;
using BookStoreApp.Models;

namespace BookStoreApp.Commands
{
    public class EditCommand : CommandBase
    {
        private readonly SearchResultsViewModel _searchResultsViewModel;

        public EditCommand(SearchResultsViewModel searchResultsViewModel, Store store, Book book)
        {
            _searchResultsViewModel = searchResultsViewModel;
            //_store = store;
        }
        public override void Execute(object parameter)
        {
            //Book selectedBook = //implement edit of selected book item
        }
    }
}
