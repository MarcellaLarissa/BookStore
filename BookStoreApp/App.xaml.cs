using BookStoreApp.Models;
using BookStoreApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BookStoreApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly Store _store;
        public App()
        {
            _store = new Store("Little Book Shop");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                //this.DataContext = new MainViewModel(_store)
                DataContext = new MainViewModel(_store)
            };
            MainWindow.Show();
           // Store myStore = new Store("MP Book Shop");

            Inventory inventory = new Inventory();//double check

            ////create books
            Book _book1 = new Book(9780441172719, "dune", "frank herbert", "the spice", 4);

            Book _book2 = new Book(9781411433465, "the war of the worlds", "h.g. wells", "martian invasion", 2);

            Book _book3 = new Book(9780062276285, "hogfather", "terry pratchett", "hogswatchnight", 4);

            ////add to booklist
            _store.CreateBookRecord(_book1);
            _store.CreateBookRecord(_book2);
            _store.CreateBookRecord(_book3);

            IEnumerable<Book> BookList = _store.SearchForBook("dune"); //returns dune as result, still listed as null?

            base.OnStartup(e);
        }
       
    }
}
