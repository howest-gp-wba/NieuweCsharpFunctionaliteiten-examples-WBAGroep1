using System;
using System.Collections.Generic;
using System.Text;

namespace NieuweCsharpFunctionaliteiten.Domain
{
    public class Book
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public Book Sequel { get; set; }
        
    }
}
