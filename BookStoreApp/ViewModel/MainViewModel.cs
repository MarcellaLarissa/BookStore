using GalaSoft.MvvmLight;
using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public ViewModelBase CurrentViewModel { get; }
        public ViewModelBase CurrentViewModel2 { get; }
        public MainViewModel(Store _store)
        {
            CurrentViewModel = new AddBookViewModel(_store);
            
            //how to get _books here?
            //CurrentViewModel2 = new SearchResultsViewModel(_books);
        }
    }
}