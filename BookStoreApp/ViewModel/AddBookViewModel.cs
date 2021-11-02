using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStoreApp.ViewModel
{
    class AddBookViewModel : ViewModelBase
    {
        //property change for ISBN
        private long myISBN;

        public long ISBN
        {
            get
            {
                return myISBN;
            }
            set
            {
                myISBN = ISBN;
                OnPropertyChanged(nameof(ISBN));
            }
        }

        //property change for title
        private string myTitle;

        public string Title
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = Title;
                OnPropertyChanged(nameof(Title));
            }
        }

        //property change for author
        private string myAuthor;
        public string Author
        {
            get
            {
                return myAuthor;
            }
            set
            {
                myAuthor = Author;
                OnPropertyChanged(nameof(Author));
            }
        }

        //property change for description
        private string myDesctiption;
        public string Description
        {
            get
            {
                return myDesctiption;
            }
            set
            {
                myDesctiption = Description;
                OnPropertyChanged(nameof(Description));
            }
        }

        //property change for count
        private int myCount;
        public int Count
        {
            get
            {
                return myCount;
            }
            set
            {
                myCount = Count;
                OnPropertyChanged(nameof(Count));
            }
        }
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public AddBookViewModel()
        {

        }
    }

}
