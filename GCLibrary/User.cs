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

        public static void CheckoutBook(List<Book> shelf)
        {
            Console.WriteLine("Which book would you like to checkout?");

            bookCheck = Console.ReadLine();
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
                        Console.WriteLine("You have checked out " + bookCheckKeepCase + ".");
                        b.setCheckedOut(true);
                        DateTime d = DateTime.Now.AddDays(14);
                        b.setDue(d);
                        return;
                    }
                }
            }
            Console.WriteLine("I'm sorry, we could not find " + bookCheck + " in the library.");
        }

        public static void ReturnBook(List<Book> shelf)
        {
            Console.WriteLine("Which book would you like to return?");
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
                        Console.WriteLine("You have returned " + bookCheckKeepCase + ".");
                        b.setCheckedOut(false);
                        return;
                    }
                }
            }
            Console.WriteLine("I'm sorry, we don't have a record of " + bookCheckKeepCase + " in our library.");
        }
        //this method compares user input to every author in book
        //also, user doesnt have to input entire title or even entire word
        //displays number of matches as well
        public static void SearchAuthor(string s, List<Book> bookshelf)
        {
            int found = 0;
            foreach (Book book in bookshelf)
            {
                string author = book.getAuthor().ToLower();
                if (author.Contains(s))
                {
                    
                    Console.WriteLine(book.getTitle() + " by " + book.getAuthor());
                    found++;
                }   
            }
                Console.WriteLine(found + " matches found.\n");
        }
        //this method compares user input to every title in book list
        //and returns title and author
        //also, user doesnt have to input entire title or een entire word
        //displays number of matches as well
        public static void SearchTitle(string s, List<Book> bookshelf)
        {
            int found = 0;
            foreach (Book book in bookshelf)
            {
                string title = book.getTitle().ToLower();
                if (title.Contains(s))
                {
                    Console.WriteLine(book.getTitle() + " by\n " + book.getAuthor());
                    found++;
                }
            }
            
            Console.WriteLine(found + " matches found.\n");

        }
    }
}
