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
}
