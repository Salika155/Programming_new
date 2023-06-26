using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _dateOfPublication;

        public string Title { get => _title; set => _title = value;}
        public string Author { get => _author; set => _author = value;}
        public int DateOfPublication { get => _dateOfPublication; set => _dateOfPublication = value;}

        public Book() 
        {

        }

        public Book(string title, string author, int dateOfPublication)
        {
            Title = title;
            Author = author;
            DateOfPublication = dateOfPublication;
            
        }

        public bool IsOld(Book book)
        {
            if (book.DateOfPublication < 1500)
                return true;
            return false;
        }

        public bool IsValid(Book book) 
        {
            if (Title== null || Author == null || DateOfPublication > 0) 
                return false;
            return true;
        }

        public Book CloneBook()
        {
            return new Book(Title, Author, DateOfPublication);
        }

    }

}
