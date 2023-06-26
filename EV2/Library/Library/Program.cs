namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("Abuelito dime tu", "El Abuelo", 1978);
            Book book2 = new Book("La leyenda de Zemuria", "Thomas Lissander", 2016);
            Book book3 = new Book("Mort", "Terry Prattchet", 1987);
            Book book4 = new Book("Mortadelo y Filemon El Sulfato Atomico", "Francisco Ibañez", 1988);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Console.WriteLine("En la biblioteca existen este numero de libros: " + library.BooksNumn);

            Console.WriteLine("La biblioteca tiene el libro 'Mort': " + library.ItHasBook("Mort"));
            Console.WriteLine("La biblioteca tiene el libro '1984': " + library.ItHasBook("1984"));

            library.DeleteBook("Mortadelo y Filemon El Sulfato Atomico");
            Console.WriteLine("Número de libros en la biblioteca después de eliminar el deseado: " + library.BooksNumn);

            library.DeleteBook("Mort", "Terry Prattchet");
            Console.WriteLine("Número de libros en la biblioteca después de eliminar 'Mort': " + library.BooksNumn);

            library.DeleteBooks("La Leyenda de Zemuria", "Thomas Lissander");
            Console.WriteLine("Número de libros en la biblioteca después de eliminar 'La Leyenda de Zemuria': " + library.BooksNumn);

            // Eliminar todos los libros de la biblioteca
            library.DeleteAll();
            Console.WriteLine("Número de libros en la biblioteca después de eliminar todos: " + library.BooksNumn);


            library.AddBook(book2);
            library.AddBook(book4);
            library.AddBook(book1);
            library.AddBook(book3);

            Library clonedLibrary = library.CloneLibrary();
            Console.WriteLine("Número de libros en la biblioteca clonada: " + clonedLibrary.BooksNumn);

            Console.WriteLine("La biblioteca tiene el libro 'Mort': " + clonedLibrary.ItHasBook("Mort"));
            Console.WriteLine("La biblioteca tiene el libro '1984': " + clonedLibrary.ItHasBook("1984"));

        }
    }
}