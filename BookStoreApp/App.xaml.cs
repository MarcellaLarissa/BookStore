using BookStoreApp.Models;
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
        protected override void OnStartup(StartupEventArgs e)
        {
            Store myStore = new Store("MP Book Shop");

            Inventory inventory = new Inventory();//double check

            //create books
            Book myBook1 = new Book(9780441172719, "Dune", "Frank Herbert", "The Spice", 4);

            Book myBook2 = new Book(9781411433465, "The War of the Worlds", "H.G. Wells", "Martian invasion", 2);

            Book myBook3 = new Book(9780062276285, "Hogfather", "Terry Pratchett", "Hogswatchnight", 4);

            //add to booklist
            myStore.CreateBookRecord(myBook1);
            myStore.CreateBookRecord(myBook2);
            myStore.CreateBookRecord(myBook3);

            

           IEnumerable<Book> BookList = myStore.SearchForBook("Dune");//wut?

            base.OnStartup(e);
        }
       
    }
}
