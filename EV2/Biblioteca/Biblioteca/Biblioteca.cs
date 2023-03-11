using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Library
    {
        private List<Book> _books = new List<Book>();
        
        public int NumberBooks { get { return _books.Count; } }
    
        public void AñadirLibro(Book book)
        {
            if (book == null)
                return;
            _books.Add(book);
        }

        public bool contieneLibro(string title)
        {
            //if (title == null)
            //return false;
            //for (int i = 0; i <= _bookList.Count; i++)
            //{
            //if (-bookList[i].Title==Title)
            //return true;
            //}
            //return false;
            return _books.Any(book => book.Title == title);
        }

        public bool contieneLibro(string title, string author)
        {
            //if (title == null && author == null)
            //return false;
            //foreach (book b in _bookList)
            //if (author != null && title!= null && b.author == author && b.title == title)
            //return true;
            //else if (author != null & title == null && b.author == authhor)
            //return true;
            //return false;

            //otra solucion
            //foreach (book b in _bookList)
            //if (author!= null && title !=null)
            //if (b.a=a b.t = t)
            //return true;
            //si quieres devolver la posicion obligatoriamente tiene que ser por medio del for y recorrerla entera
            return _books.Any(book => book.Title == title && book.Author == author);
        }


        public Book GetOldestBook()
        {
            double yearpublication = _books[0].PublicationYear;
            double oldestYear = _books[0].PublicationYear;
            Book oldestBook = _books[0];
            foreach (var book in _books)
            {
                if (book.PublicationYear < oldestYear)
                {
                    oldestYear = book.PublicationYear;
                    oldestBook = book;
                }
            }
            return oldestBook;
        }



        public double GetAverageYear()
        {
            if (_books.Count == 0)
            {
                return 0;
            }
            double yearsAv = 0.0;
            for (int i = 0; i < _books.Count; i++)
            {
                Book b = _books[i];
                yearsAv += b.PublicationYear;
            }
            yearsAv /= _books.Count;
            return yearsAv;
        }

        //{
        //int totalYears = 0;
        //int numberOfBooks = _books.Count;
        //foreach (var book in _books)
        //{
        //totalYears += book.PublicationYear;
        //}
        //if (numberOfBooks > 0)
        //{
        //return (totalYears / numberOfBooks).ToString();
        //}
        //else
        //{
        //return null;
        //}
        //}

        //funcion book GetOldestBook()
        //{
        //int oldestYear = _bookList[].Year;
        //for
        //{
        //if b.year < oldest.year)
        //oldestyear = b.year;

        //funcion que devuelva el año medio de todos los libros en la library
        public bool borrarLibro(string title)
        {
            {
                foreach (Book book in _books)
                {
                    if (book.Title == title)
                    {
                        _books.Remove(book);
                        return true;
                    }
                }
                return false;
            }
        }

        public bool borrarLibro(string title, string author)
        {
            foreach (Book book in _books)
            {
                if (book.Title == title && book.Author == author)
                {
                    _books.Remove(book);
                    return true;
                }
            }
            return false;
        }

        public int BorrarLibros(string title, string author)
        {
            int count = 0;
            for (int i = 0; i < _books.Count; i++)
            {
                if (_books[i].Title == title && _books[i].Author == author)
                {
                    _books.RemoveAt(i);
                    count++;
                    i--;
                }
            }
            return count;
        }
    

        public void borrar()
        {
            _books.Clear();
        }

        public Library clonar()
        {
            var library = new Library();
            library._books = _books.Select(book => book.clonar()).ToList();
            return library;
        }
    }
    
}




    
