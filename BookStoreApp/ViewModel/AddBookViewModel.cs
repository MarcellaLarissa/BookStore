using BookStoreApp.Commands;
using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStoreApp.ViewModel
{
    public class AddBookViewModel : ViewModelBase
    {
        //property change for ISBN
        private long _ISBN;

        public long ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                _ISBN = ISBN;
                //OnPropertyChanged(nameof(ISBN));
            }
        }

        //property change for title
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = Title;
                //OnPropertyChanged(nameof(Title));
            }
        }

        //property change for author
        private string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = Author;
                //OnPropertyChanged(nameof(Author));
            }
        }

        //property change for description
        private string _desctiption;
        public string Description
        {
            get
            {
                return _desctiption;
            }
            set
            {
                _desctiption = Description;
                //OnPropertyChanged(nameof(Description));
            }
        }

        //property change for count
        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = Count;
                //OnPropertyChanged(nameof(Count));
            }
        }
        public ICommand SubmitCommand { get; }
       // public ICommand CancelCommand { get; }

        public AddBookViewModel(Store store)
        {
            SubmitCommand = new AddBookCommand(this, store);
            //CancelCommand = new AddBookCommand(this, store);
        }
    }

}
