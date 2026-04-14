using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    //Class Book that inheret from LibraryContent and implement the IBorrowable interface
    class Book : LibraryContent, IBorrowable
    {
        public string Author { get; set; }

        public Book(string Name, string Description, string PublicationYear) : base(Name, Description, PublicationYear)
        {

            this.Author = "Unknown";

        }

        //Method for Display Availability
        public override void DisplayAvailability()
        {
            Console.WriteLine("This book can be borrowed or read in the library");
        }

        //Implement the interface
        public void Borrow(bool isBorrowed)
        {

            Console.WriteLine(isBorrowed ? "Item is now borrowed." : "This book is NOT available for borrowing right now.");
        }
    }
}