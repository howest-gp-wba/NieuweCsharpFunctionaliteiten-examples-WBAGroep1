using System;
using System.Collections.Generic;
using System.Text;

namespace NieuweCsharpFunctionaliteiten.Domain
{
    public static class Bookrepository
    {
        public static List<Book> GetBooks()
        {
            //object initializer
            Book lotr = new Book
            {
                Id = 0,
                Title = "fellowship of the ring,",
                Sequel = null
            };
            //make new list of books
            List<Book> books = new List<Book>();
            //make new books
            Book lotr2 = new Book();
            Book lotr3 = new Book();
            Book lotr4 = null;
            //fill the data
            lotr2.Id = 2;
            lotr2.Sequel = lotr3;
            lotr2.Title 
                = "The two towers";
            lotr3.Title = "return of the king";
            lotr3.Id = 3;
            lotr3.Sequel = lotr4;
            
            //add to list
            books.Add(lotr2);         
            books.Add(lotr3);
            books.Add(lotr4);
            return books;
        }
    }
}
