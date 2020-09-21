using System;
using System.Collections.Generic;
using System.Text;

namespace NieuweCsharpFunctionaliteiten.Domain
{
    public static class Bookrepository
    {
        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            Book lotr = new Book();
            Book lotr2 = new Book();
            Book lotr3 = new Book();
            Book lotr4 = null;
            lotr.Title = "Fellowship of the ring";
            lotr.Id = null;
            lotr.Sequel = lotr2;
            lotr2.Id = 2;
            lotr2.Sequel = lotr3;
            lotr2.Title 
                = "The two towers";
            lotr3.Title = "return of the king";
            lotr3.Id = 3;
            lotr3.Sequel = lotr4;
            
            //add to list
            books.Add(lotr);         
            books.Add(lotr2);         
            books.Add(lotr3);
            books.Add(lotr4);
            return books;
        }
    }
}
