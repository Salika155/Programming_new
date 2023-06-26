using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        private List<Book> _books;

        public int BooksNumn { get { return _books.Count; }}

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public bool ItHasBook(string title)
        {
            foreach (Book book in _books)
            {
                if (book.Title == title)
                    return true;
            }
            return false;
        }

        public bool ItHasBook(string title, string author)
        {
            foreach (Book book in _books)
            {
                if (book.Title == title && book.Author == author)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteBook(string title)
        {
            for (int i = _books.Count - 1; i >= 0; i--)
            {
                if (_books[i].Title == title)
                {
                    _books.RemoveAt(i);
                }
            }
        }

        public void DeleteBook(string title, string author)
        {
            for(int i = _books.Count - 1; i >= 0; i--)
            {
                if (_books[i].Title == title && _books[i].Author == author)
                {
                    _books.RemoveAt(i);
                }
            }

        }

        public void DeleteBooks(string title, string author)
        {
            List<Book> booksToDelete = new List<Book>();

            foreach (Book book in _books)
            {
               if(book.Title == title && book.Author == author)
                {
                    booksToDelete.Add(book);
                }
            }

            foreach (Book book in booksToDelete)
            {
                _books.Remove(book);
            }
            
        }

        public Library DeleteAll()
        {
            _books.Clear();
            return new Library();
        }

        public Library CloneLibrary()
        {
            List<Book> booksCopy = new List<Book>(_books); 
            Library newLibrary = new Library();

            foreach (Book book in booksCopy)
            {
                newLibrary.AddBook(book);
            }
            return newLibrary;
        }
    }
}
