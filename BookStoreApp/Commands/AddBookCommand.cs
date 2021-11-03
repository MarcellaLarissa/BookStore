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
        private readonly AddBookViewModel myAddBookViewModel;
        private readonly Store myStore;
  
        public AddBookCommand(AddBookViewModel addBookViewModel, Store store)
        {
            myAddBookViewModel = addBookViewModel;
            myStore = store;

           
        }

        //public override bool CanExecute(object parameter)
        //{
        //    return !string.IsNullOrEmpty(myAddBookViewModel.Title) && base.CanExecute(parameter);
        //}
        public override void Execute(object parameter)
        {
            Book newBook = new Book(myAddBookViewModel.ISBN, myAddBookViewModel.Title, myAddBookViewModel.Author, myAddBookViewModel.Description, myAddBookViewModel.Count);
            myStore.CreateBookRecord(newBook);
        }

        //cancel command if there is time 13:20
    }
}
