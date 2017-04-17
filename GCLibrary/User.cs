using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    class User
    {
        public bool CheckoutBook(Book book)
        {
            return book.IsCheckedOut = true;
        }

        public bool ReturnBook(Book book)
        {
            return book.IsCheckedOut = false;
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
