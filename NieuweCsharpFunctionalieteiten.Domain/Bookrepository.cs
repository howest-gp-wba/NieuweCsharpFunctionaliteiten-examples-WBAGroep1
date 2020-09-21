using System;
using System.Collections.Generic;
using System.Text;

namespace NieuweCsharpFunctionaliteiten.Domain
{
    public static class Bookrepository
    {
        public static Book[] GetBooksFromarray()
        {
            return new Book[]
            {
                new Book{
                    Id=1,
                    Title="C# .Net Core",
                    Publisher="Microsoft Media Ltd"
                },
                new Book{
                    Id=2,
                    Title="PHP MV Laravel",
                    Publisher="O'Reilly"
                },
            };
        }
        //returns a List<book>
        public static List<Book> GetBooks()
        {
            //make everything with initializer
            return new List<Book>
            {
                new Book{Id=1,Title="Rambo",Sequel =
                new Book{Id = 2,Title="Rambo2"}},
                new Book
                {
                    Id=3,Title="De Bijbel",Sequel = null
                },
                null,
                new Book{Id=5,Title="Book of death", Sequel= null}
            };
            ////object initializer
            //Book lotr = new Book
            //{
            //    Id = 1,
            //    Title = "fellowship of the ring,"
            //};
            //Book lotr2 = new Book
            //{
            //    Id = 2,
            //    Title = "two towers"
            //};
            //Book lotr3 = new Book
            //{
            //    Id = 3,
            //    Title = "return of the king"
            //};
            ////make book list with collection initializer
            //List<Book> books = new List<Book> 
            //{
            //    lotr,lotr2,lotr3
            //};

            //return books2;





            ////make new list of books
            //List<Book> books = new List<Book>();
            ////make new books
            //Book lotr2 = new Book();
            //Book lotr3 = new Book();
            //Book lotr4 = null;
            ////fill the data
            //lotr2.Id = 2;
            //lotr2.Sequel = lotr3;
            //lotr2.Title 
            //    = "The two towers";
            //lotr3.Title = "return of the king";
            //lotr3.Id = 3;
            //lotr3.Sequel = lotr4;
            //lotr.Sequel = lotr2;

            ////add to list
            //books.Add(lotr);
            //books.Add(lotr2);         
            //books.Add(lotr3);
            //books.Add(lotr4);
            //return books;
        }
    }
}
