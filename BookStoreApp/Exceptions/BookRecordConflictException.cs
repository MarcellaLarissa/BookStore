using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Exceptions
{
    class BookRecordConflictException : Exception //extend???
    {
        public Book ExistingBook { get; }
        public Book NewBook { get; }
        public BookRecordConflictException(Book existingBook, Book newBook)
        {
            ExistingBook = existingBook;
            NewBook = newBook;
        }

        public BookRecordConflictException(string message, Book existingBook, Book newBook) : base(message)
        {
            ExistingBook = existingBook;
            NewBook = newBook;
        }

        public BookRecordConflictException(string message, Exception innerException, Book existingBook, Book newBook) : base(message, innerException)
        {
            ExistingBook = existingBook;
            NewBook = newBook;
        }

        protected BookRecordConflictException(SerializationInfo info, StreamingContext context, Book existingBook, Book newBook) : base(info, context)
        {
            ExistingBook = existingBook;
            NewBook = newBook;
        }
    }
}
