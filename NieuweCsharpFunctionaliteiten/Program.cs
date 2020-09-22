using NieuweCsharpFunctionaliteiten.Domain;
using NieuweCsharpFunctionaliteiten.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

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
            //Extension methods
            int numberToDivide = 5;
            
            Console.WriteLine($"{numberToDivide}/2=" +
                $"{numberToDivide.DivideByNumber(2)}");
            string input = "zes";
            Console.WriteLine(input.CountChars());


            //synchronous pattern
            //Console.WriteLine("Calculating...");
            //long result = Calculate();
            //Console.WriteLine("in the meantime, what's your name?");
            //string userInput = Console.ReadLine();
            ////print output
            //Console.WriteLine($"Hello {userInput}");
            //Console.WriteLine($"Result={result}");
            //asynchronous pattern
            Console.WriteLine("Calculating...");
            //call method async
            //receive Task object
            var result = CalculateAsync();
            //wait for it!
            while(result.IsCompleted == false)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            //print output
            Console.WriteLine($"\nResult={result.Result}");

            //asynchronous api call
            Console.WriteLine("Fetching quote..");
            var apiResult = GetQuote();
            while (apiResult.IsCompleted == false)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.WriteLine($"\nQuote:{apiResult.Result}");
        }

        
        private static long Calculate()
        {
            long sum = 0;
            for(long i=0;i<100000000;i++)
            {
                sum += i;
            }
            return sum;
        }
        private async static Task<long> CalculateAsync()
        {
            return await Task.Run(() => {
                long sum = 0;
                for (long i = 0; i < 1000000000; i++)
                {
                    sum += i;
                }
                return sum;
            });
            
        }
        //api call
        private static async Task<string> GetQuote()
        {
            string url = "https://breaking-bad-quotes.herokuapp.com/v1/quotes";
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            return content;

        }


        //filter function
        private static bool FilterBooksWithC(Book book)
        {
            if (book?.Title.Contains("C") == true)
                return true;
            else
                return false;
        }
    }
}
