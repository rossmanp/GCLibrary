using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    public class Book
    {

        private string title;
        private string author;
        private bool checkedOut; 
        private DateTime? due;

        public Book(string t, string a)
        {
            this.title = t;
            this.author = a;
            this.checkedOut = false;
            this.due = null;
        }

        public Book(string t, string a, bool c, DateTime? d)
        {
            this.title = t;
            this.author = a;
            this.checkedOut = c;
            this.due = d;
        }

        //get book's title
        public string getTitle()
        {
            return this.title;
        }

        //get book's author
        public string getAuthor()
        {
            return this.author;
        }

        //get book's availability
        public bool getCheckedOut()
        {
            return this.checkedOut;
        }

        public void setCheckedOut(bool checkout)
        {
            this.checkedOut = checkout;
        }

        //retreive due date of checked out book if its checked out
        public DateTime? getDue()
        {
            if(due == null)
            {
                Console.WriteLine("Book is not checked out!");
                return null;
            }
            else
            {
                return this.due;
            }            
        }

        //set due date of checked out book
        public void setDue(DateTime d)
        {
            this.due = d;
            Console.WriteLine("Your due date is: " + due.Value.ToString("d") + ".");
        }

        //create string to output to file
        public string toExportString()
        {
            string outputString = "";

            outputString = string.Format("{0},{1},{2},{3}", 
                            this.title, this.author, this.checkedOut, this.due);

            return outputString;
        }

    }
}
