using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace GCLibrary
{
    
    public partial class fMain : Form
    {
        List<Book> shelf = new List<Book>();        
        public fMain(List<Book> shelf)
        {           
            InitializeComponent();            
            for (int i = 0; i < shelf.Count; i++)
            {
                lbAvailableBooks.Items.Add(shelf.ElementAt(i).getTitle());
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            FileIO.exportShelf(shelf);
            MessageBox.Show("The book list has been saved.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = lbAvailableBooks.SelectedItem.ToString();
            shelf = Shelf.GetBooks();
            User.ReturnBook(shelf, select);
            FileIO.exportShelf(shelf);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bCheckout_Click(object sender, EventArgs e)
        {
            string select = lbAvailableBooks.SelectedItem.ToString();
            shelf = Shelf.GetBooks();
            User.CheckoutBook(shelf, select);
            FileIO.exportShelf(shelf);                                  
        }
    }
}
