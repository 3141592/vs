using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://msdn.microsoft.com/en-us/library/aa288459%28v=vs.71%29.aspx
namespace gunter.roy.msdn.microsoft.delegatetutorial
{
    class PriceTotaler
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;

        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }

        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }
    }

    class BookTestClient
    {
        static void PrintTitle(Book b)
        {
            Console.WriteLine("    {0}", b.Title);
        }

        static void Main(string[] args)
        {
            BookDB bookDB = new BookDB();
            AddBooks(bookDB);
            Console.WriteLine("Paperback Book Tites:");
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));
            PriceTotaler totaller = new PriceTotaler();
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(totaller.AddBookToTotal));
            Console.WriteLine("Average Paperback Book Price: ${0:#.##}", totaller.AveragePrice());
            Console.ReadKey();
        }

        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Language",
            "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0",
               "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia",
               "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless",
               "Scott Adams", 12.00m, true);
        }
    }
}
