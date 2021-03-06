﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GCLibrary
{ //This is the Midterm Project for Group 2
  //Othelle McAllister
  //Derek Wolters
  //Mike Spisich
  //Pete Rossman

    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Console.WriteLine("Welcome to the Grand Circus Library!");
            List<Book> shelf = new List<Book>(); 
            FileIO.importShelf(shelf);
            Application.Run(new fMain(shelf));
            bool run = true;
            int choice = 0;
            bool IsNotInt = true;

            while (run)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1 - Display book list \n2 - Search for a book by author");
                Console.WriteLine("3 - Search for a book by title \n4 - Check out a book");
                Console.WriteLine("5 - Return a book \n6 - Load the book list \n7 - Save the book list");
                Console.WriteLine("8 - Exit the library");
                Console.Write("Choice (1-8):");
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
                        Console.WriteLine("Book list:");
                        User.ListBooks(shelf);
                        break;
                    case 2:
                        Console.WriteLine("Search for a book by author");
                        string writer = Console.ReadLine().ToLower();
                        User.SearchAuthor(writer, shelf);                      
                        break;
                    case 3:
                        Console.WriteLine("Search for a book by title");
                        string title = Console.ReadLine().ToLower();
                        User.SearchTitle(title, shelf);
                        break;
                    case 4:
                        Console.WriteLine("\nCheck out a book");
                        Console.WriteLine("\nWhich book would you like to check out?");
                        string query = Console.ReadLine();
                        User.CheckoutBook(shelf, query);
                        break;
                    case 5:
                        Console.WriteLine("Return a book");
                        Console.WriteLine("\nWhich book would you like to return?");
                        query = Console.ReadLine();
                        User.ReturnBook(shelf, query);                       
                        break;
                    case 6:
                        Console.WriteLine("Book list loaded");
                        FileIO.importShelf(shelf);
                        break;
                    case 7:
                        Console.WriteLine("Book list saved");
                        FileIO.exportShelf(shelf);
                        break;
                    case 8:
                        run = Continue();
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
