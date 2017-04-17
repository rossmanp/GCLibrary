using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    class Shelf
    {
        private List<Book> books;

        public Shelf()
        {
            books = new List<Book>()
            {
                new Book("1984", "George Orwell"),
                new Book("Animal Farm", "George Orwell"),
                new Book("The Lord of the Rings: The Fellowship of the Ring", "J.R.R. Tolkien"),
                new Book("The Lord of the Rings: The Two Towers", "J.R.R. Tolkien"),
                new Book("The Lord of the Rings: The Return of the King", "J.R.R. Tolkien"),
                new Book("Musashi", "Eli Yoshikawa"),
                new Book("The Heike Story", "Eli Yoshikawa"),
                new Book("Taiko", "Eli Yoshikawa"),
                new Book("Dune", "Frank Herbert"),
                new Book("Dune Messiah", "Frank Herbert"),
                new Book("Children of Dune", "Frank Herbert"),
                new Book("The Scarlet Letter", "Nathaniel Hawthorne")
            };
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
