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
            FileIO.importShelf(shelf);
            for (int i = 0; i < shelf.Count; i++)
            {
                lbAvailableBooks.Items.Add(shelf.ElementAt(i).getTitle());
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bCheckout_Click(object sender, EventArgs e)
        {
            string select = lbAvailableBooks.SelectedItem.ToString();
            //FileIO.importShelf(shelf);
            User.CheckoutBook(shelf, select);
            //FileIO.exportShelf(shelf);                                  
        }
    }
}
