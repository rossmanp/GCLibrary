using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    class Shelf
    {
        private static List<Book> books;

        public Shelf()
        {
            books = new List<Book>();         
        }

        public static List<Book> GetBooks()
        {
            List<Book> aisle = new List<Book>();
            FileIO.importShelf(aisle);
            return aisle;
        }

        public void AddBook(Book b)
        {
            books.Add(b);
        }
    }
}
