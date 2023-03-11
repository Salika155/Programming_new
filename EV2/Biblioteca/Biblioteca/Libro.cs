using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Book
    {
        private string _title;
        private string _author;
        private double _publicationYear;

        //propiedades
        public string Title { get => Title; set => Title = value; }
        public string Author { get => Author; set => Author = value; }
        public double PublicationYear { get => PublicationYear; set => PublicationYear = value; }


        //constructores: uno con parametros y otro vacio
        public Book(string title, string author, double publicationYear)
        {
            _title = title;
            _author = author;
            _publicationYear = publicationYear;
        }

        public Book()
        { 
        }

        //metodos

        public bool esAntiguo(double _publicationYear)
        {
            return _publicationYear < 1500;
        }

        public bool esValido()
        {
            if (_title != null && _author != null && _publicationYear != null)
                return false;
            return true;

            
        }

        public Book clonar()
        {
            return new Book(_title, _author, _publicationYear);
        }
        //return new book()
        //{
        //Author = This.Author,
        //Title = This.Title,
        //......
        //};
    }

}
