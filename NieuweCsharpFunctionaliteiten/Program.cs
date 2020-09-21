using NieuweCsharpFunctionaliteiten.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NieuweCsharpFunctionaliteiten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conan the librarian");
            Book cheese = new Book();
            cheese.Title = "Kaas";
            cheese.Id = 1;
            cheese.Sequel = null;
            

            Console.WriteLine(cheese?.Sequel?.Title);
            //get all books in Db
            IEnumerable<Book> books =
                Bookrepository.GetBooks();
            books = Bookrepository.GetBooksFromarray();
            //find books with letter C

            //use Where with named function
            IEnumerable<Book> booksWithC
                = books.Where(FilterBooksWithC);
            //use with anonymous
            booksWithC = books.Where(
                b => b.Title.Contains("C")
            );
            foreach(Book book in booksWithC)
            {
                Console.WriteLine(book?.Title);
            }
        }

        private static bool FilterBooksWithC(Book book)
        {
            if (book?.Title.Contains("C") == true)
                return true;
            else
                return false;
        }
    }
}
