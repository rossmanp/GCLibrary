using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    class User
    {
        static string bookCheck;
        static string bookCheckKeepCase;

        public static bool CheckoutBook(List<Book> shelf)
        {           
            Console.WriteLine("Which book would you like to checkout?");
           
            bookCheck = Console.ReadLine();
            bookCheckKeepCase = bookCheck;
            bookCheck = bookCheck.ToLower();
            //This loop checks each book in the shelf, and if the book is not checked out
            //and the user input matches the book's title, the book is checked out.

            foreach (Book b in shelf)
            {
                if (b.checkedOut == false)
                {
                    if (bookCheck.Equals(b.title.ToLower()))
                    {
                        Console.WriteLine("You have checked out " + bookCheckKeepCase + ".");
                        return b.checkedOut = true;
                    }
                }          
            }
           Console.WriteLine("I'm sorry, we could not find " + bookCheck + " in the library.");
           return false;
        }

        public static bool ReturnBook(List<Book> shelf)
        {
            Console.WriteLine("Which book would you like to return?");
            bookCheck = Console.ReadLine();
            bookCheckKeepCase = bookCheck;
            bookCheck = bookCheck.ToLower();

            //This loop checks each book in the shelf, and if the book is checked out
            //and the user input matches the book's title, the book is returned.

            foreach (Book b in shelf)
            {
                if (b.checkedOut == true)
                {
                    if (bookCheck.Equals(b.title.ToLower()))
                    {
                        Console.WriteLine("You have returned " + b.title + ".");
                        return b.checkedOut = false;
                    }
                }
            }
            Console.WriteLine("I'm sorry, we don't have a record of " + bookCheckKeepCase + " in our library.");
            return true;
        }
    }
}
