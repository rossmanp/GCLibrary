using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    public class Book
    {
        public string title { get; private set; }
        public bool checkedOut { get; set; }

        public Book(string title, bool checkedOut)
        {
            this.title = title;
            this.checkedOut = checkedOut;
        }

    }
}
