using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GCLibrary
{
    class FileIO
    {
        public static void exportShelf(List<Book> shelf)
        {
            var csv = new StringBuilder();
            var filePath = @"..\..\library.txt";

            //keep adding each book's information to a list line by line
            //seperated by commas
            foreach (Book b in shelf)
            {                
                csv.AppendLine(b.toExportString());                
            }

            //write to a file, create the file if needed
            File.WriteAllText(filePath, csv.ToString());
        }

        public static void importShelf(List<Book> shelf)
        {
            //import file to program's shelf
        }
    }
}
