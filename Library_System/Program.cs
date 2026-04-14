using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make list for items
            List<LibraryContent> library = new List<LibraryContent>();

            library.Add(new Book("Harry_Potter", "This book is a fictional book", "2001"));
            library.Add(new Magazine("PC Magazine", "Latest Tech", "2024"));
            library.Add(new Book("Data Structures", "Advanced topics", "2022"));

            Console.WriteLine("------------------Library system output------------------");

            Console.WriteLine();

            //Display information about the items
            foreach (var item in library)
            {
                item.DisplayAvailability();

                //Check if it a book
                if (item is Book myBook)
                {
                    if (myBook.Name == "Harry_Potter")
                    {
                        myBook.Borrow(true);
                    }
                    else
                    {
                        myBook.Borrow(false);
                    }

                    Console.WriteLine("------------------");
                }
                else
                {
                    Console.WriteLine("------------------");
                }
            }

            Console.ReadKey();
        }
    }
}
