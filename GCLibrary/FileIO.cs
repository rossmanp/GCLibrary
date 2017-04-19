using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System;

namespace GCLibrary
{
    class FileIO
    {
        static string filePath = @"..\..\library.txt";

        public static void exportShelf(List<Book> shelf)
        {
            var csv = new StringBuilder();            
       
            //keep adding each book's information to a list line by line
            //seperated by commas
            foreach (Book b in shelf)
            {                
                csv.AppendLine(b.toExportString());                
            }

            //write to a file, create the file if needed

            File.WriteAllText(filePath, String.Empty);
            File.WriteAllText(filePath, csv.ToString());           
        }

        public static void importShelf(List<Book> shelf)
        {
            string importString = string.Empty;
            string title;
            string author;
            bool checkedOut;
            DateTime? date;
            DateTime result;

            //open file to read data into program
            System.IO.StreamReader reader = new System.IO.StreamReader(filePath);
            
            //go though file line by line        
            while ((importString = reader.ReadLine()) != null)
            {
                List<string> parseString = 
                                importString.Split(',').ToList<string>();

                title = parseString[0];
                author = parseString[1];
                checkedOut = Convert.ToBoolean(parseString[2]);

                if(DateTime.TryParse(parseString[3], out result))
                {
                    date = (DateTime?)result;
                }
                else
                {
                    date = null;
                }                

                Book book = new Book(title, author, checkedOut, date);
                shelf.Add(book);
            }
            reader.Close();
        }
    }
}
