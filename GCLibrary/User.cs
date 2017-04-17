using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    class User
    {
        public User() { }

        public void ListBooks(List<Book> books)
        {
            Console.WriteLine("\nAvailable Titles:");
            Console.WriteLine("===============================");
            for (int i = 0; i < books.Count; i++)
            {
                string title = books[i].GetTitle();
                string author = books[i].GetAuthor();
                string checkoutStatus;
                string dueDate;

                bool isCheckedOut = books[i].GetStatus();

                //Set values of checkoutStatus and dueDate strings
                if (isCheckedOut == true)
                {
                    checkoutStatus = "Checked out";
                    dueDate = books[i].GetDue().ToString("MM/dd/yyyy");
                }
                else
                {
                    checkoutStatus = "Available";
                    dueDate = "N/A";
                }

                //Display book information (Shelf index, Title, Author, Checkout status, Due Date)
                Console.WriteLine("#" + (i + 1) + ":");

                //Warn user if checked out book is overdue
                if (isCheckedOut == true && DateTime.Now > books[i].GetDue())
                {
                    Console.WriteLine("***This book is overdue! Please return as soon as possible!***");
                }

                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Status: " + checkoutStatus);
                Console.WriteLine("Due Date: " + dueDate + "\n");
            }
        }
    }
}
