using NieuweCsharpFunctionaliteiten.Domain;
using System;
using System.Collections.Generic;

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
            string title = null;
           

            
            Console.WriteLine(cheese?.Sequel?.Title);
            //get all books in Db
            List<Book> books = Bookrepository.GetBooks();
            string result = "";
            
            foreach(Book book in books)
            {
                //string interpolatie+null coalesence + conditional operator
                result = $"Title: " +
                    $"{book?.Title??"<NoTitle>\n"}" +
                    $"Id: {book?.Id ?? 0}\n";
                Console.WriteLine(result);
            }
        }
    }
}
