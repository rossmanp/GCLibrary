using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GCLibrary
{ //This is the Midterm Project for Group 2
  //Othelle McMaster
  //Derek Wolters
  //Mike Spisich
  //Pete Rossman
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Library!");
            Shelf s = new Shelf();
            List<Book> shelf = s.GetBooks();
            bool run = true;
            int choice = 0;
            bool IsNotInt = true;
            while (run)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Display book list \n2 - Search for a book by author");
                Console.WriteLine("3 - Search for a book by title \n4 - Check out a book");
                Console.WriteLine("5 - Return a book \n6 - Exit the library \n7 - Save the book list");
                Console.WriteLine("6 - Load the book list");
                Console.WriteLine("Choice (1-8):");
                while (IsNotInt)
                {
                    IsNotInt = false;
                    try
                    {
                        choice = int.Parse(Console.ReadLine());                       
                    }                 
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid input. Please enter a number from 1 to 8:");
                        IsNotInt = true;
                    }                    
                }
                IsNotInt = true;                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Display book list");
                        User.ListBooks(shelf);
                        break;
                    case 2:
                        Console.WriteLine("Search for a book by author");                             
                        break;
                    case 3:
                        Console.WriteLine("Search for a book by title");
                        break;
                    case 4:
                        Console.WriteLine("Check out a book");
                        User.CheckoutBook(shelf);
                        break;
                    case 5:
                        Console.WriteLine("Return a book");
                        User.ReturnBook(shelf);                       
                        break;
                    case 6:
                        run = Continue();
                        break;
                    case 7:
                        Console.WriteLine("Book list saved");
                        FileIO.exportShelf(shelf);
                        break;
                    case 8:
                        Console.WriteLine("Book list loaded");
                        //need to load the book list
                        break;
                    default:
                        Console.WriteLine("Error, you did not input a number from 1-8. Please try again.");
                        break;
                }                        
            }
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Are you sure you want to exit? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            if (input.Equals("y"))
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input.Equals("n"))
            {
                run = true;
            }
            else
            {
              Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
              run = Continue();
            }

            return run;
        }
    }
}
