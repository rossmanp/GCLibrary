using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    class User
    {
<<<<<<< HEAD
        public bool CheckoutBook(Book book)
        {
            return book.IsCheckedOut = true;
||||||| merged common ancestors

        public bool CheckoutBook(Book book)
        {
            return book.IsCheckedOut = true;
=======
        static string bookCheck;
        static string bookCheckKeepCase;

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
                        return;
                    }
                }          
            }
           Console.WriteLine("I'm sorry, we could not find " + bookCheck + " in the library.");         
>>>>>>> d36a4478eecb0ad02711d0fa4f0bf4d9726e0de9
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
    }
     public class Search
    {
        public string name;
        public int id;
        public string title;

        public Search(string name, int id, string title)
        {
            this.name = name;
            this.id = id;
            this.title = title;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
    }
    


}
