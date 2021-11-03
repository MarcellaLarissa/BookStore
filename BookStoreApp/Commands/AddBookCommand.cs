using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApp.Models;
using BookStoreApp.ViewModel;

namespace BookStoreApp.Commands
{
    public class AddBookCommand : CommandBase
    {
        private readonly AddBookViewModel _addBookViewModel;
  
        public AddBookCommand(AddBookViewModel addBookViewModel, Store store)
        {
            _addBookViewModel = addBookViewModel;
            //_store = store;
        }
        public override void Execute(object parameter)
        {
            Book newBook = new Book(_addBookViewModel.ISBN, _addBookViewModel.Title, _addBookViewModel.Author, _addBookViewModel.Description, _addBookViewModel.Count);
            //_store.CreateBookRecord(newBook);
        }
    }
}
