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
        private readonly Store _store;
  
        public AddBookCommand(AddBookViewModel addBookViewModel, Store store)
        {
            _addBookViewModel = addBookViewModel;
            _store = store;

           
        }

        //public override bool CanExecute(object parameter)
        //{
        //    return !string.IsNullOrEmpty(myAddBookViewModel.Title) && base.CanExecute(parameter);
        //}
        public override void Execute(object parameter)
        {
            Book newBook = new Book(_addBookViewModel.ISBN, _addBookViewModel.Title, _addBookViewModel.Author, _addBookViewModel.Description, _addBookViewModel.Count);
            _store.CreateBookRecord(newBook);
        }

        //cancel command if there is time 13:20
    }
}
