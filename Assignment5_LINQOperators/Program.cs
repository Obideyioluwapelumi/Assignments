


// LINQ Operators
// These operators include filtering, sorting, grouping, and joining operations.

// Where, Select, OrderBy/OrderByDescending, GroupBy, Join
// Any/All, First/FirstOrDefault, Count, Skip/Take, Sum/Min/Max/Average

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAssignment
{
    class Program
    {
        public class Book
        {
            public string Title { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            
            var myBook = new List<Book>
            {
                new Book() {Title = "C# for Beginners", Price = 10.5},
                new Book() {Title = "Intermediate of C#", Price = 20.5},
                new Book() {Title = "Unknown Category in Coding", Price = 30.5},
                new Book() {Title = "Advanced C#", Price = 50.5},
            };

            var myNewBooks = myBook.Where(b => b.Title.Contains("C#"));

            foreach(var book in myNewBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}