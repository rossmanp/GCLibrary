using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    class User
    {
        static string bookCheck;
        static string bookCheckKeepCase;

        public User() { }


        public static void ListBooks(List<Book> books)
        {
            Console.WriteLine("\nAvailable Titles:");
            Console.WriteLine("===============================");
            for (int i = 0; i < books.Count; i++)
            {
                string title = books[i].getTitle();
                string author = books[i].getAuthor();
                string checkoutStatus;
                string dueDate;

                bool isCheckedOut = books[i].getCheckedOut();

                //Set values of checkoutStatus and dueDate strings
                if (isCheckedOut == true)
                {
                    checkoutStatus = "Checked out";
                    if (books[i].getDue() != null)
                    {
                        dueDate = books[i].getDue().Value.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        dueDate = "N/A";
                    }
                }
                else
                {
                    checkoutStatus = "Available";
                    dueDate = "N/A";
                }

                //Display book information (Shelf index, Title, Author, Checkout status, Due Date)
                Console.WriteLine("#" + (i + 1) + ":");

                //Warn user if checked out book is overdue
                if (isCheckedOut == true && DateTime.Now > books[i].getDue())
                {
                    Console.WriteLine("***This book is overdue! Please return as soon as possible!***");
                }

                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Status: " + checkoutStatus);
                Console.WriteLine("Due Date: " + dueDate + "\n");
            }

        }

        public static void CheckoutBook(List<Book> shelf, string query)
        {           
            bookCheck = query;
            bookCheckKeepCase = bookCheck;
            bookCheck = bookCheck.ToLower();
            //This loop checks each book in the shelf, and if the book is not checked out
            //and the user input matches the book's title, the book is checked out.

            foreach (Book b in shelf)
            {
                if (b.getCheckedOut() == false)
                {
                    if (bookCheck.Equals(b.getTitle().ToLower()))
                    {
                        Console.WriteLine("\nYou have checked out " + bookCheckKeepCase + ".");
                        b.setCheckedOut(true);
                        DateTime d = DateTime.Now.AddDays(14);
                        b.setDue(d);                       
                        return;
                    }
                }
            }
            Console.WriteLine("\nI'm sorry, we could not find " + bookCheckKeepCase + " in the library.");
        }

        public static void ReturnBook(List<Book> shelf)
        {
            Console.WriteLine("\nWhich book would you like to return?");
            bookCheck = Console.ReadLine();
            bookCheckKeepCase = bookCheck;
            bookCheck = bookCheck.ToLower();

            //This loop checks each book in the shelf, and if the book is checked out
            //and the user input matches the book's title, the book is returned.

            foreach (Book b in shelf)
            {
                if (b.getCheckedOut() == true)
                {
                    if (bookCheck.Equals(b.getTitle().ToLower()))
                    {
                        Console.WriteLine("\nYou have returned " + bookCheckKeepCase + ".");
                        b.setCheckedOut(false);
                        return;
                    }
                }
            }
            Console.WriteLine("\nI'm sorry, we don't have a record of " + bookCheckKeepCase + " in our library.");
        }
        //string s is or search
        //b for book
        public static void SearchAuthor(string s, List<Book> bookshelf)
        {
            int found = 0;
            foreach (Book book in bookshelf)
            {
                string author = book.getAuthor().ToLower();
                if (s.Equals(author))
                {
                    Console.WriteLine(book.getTitle() + " by " + book.getAuthor());
                    found++;
                }
            }
            Console.WriteLine(found + " matches for your search.");

        }
        public static void SearchTitle(string s, List<Book> bookshelf)
        {
            int found = 0;
            foreach (Book book in bookshelf)
            {
                string title = book.getTitle().ToLower();
                if (s.Equals(title))
                {
                    Console.WriteLine(book.getTitle() + " by " + book.getAuthor());
                }
            }
            Console.WriteLine(found + " matches for your search.");
        }

    }
}
