using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCLibrary
{
    public partial class fMain : Form
    {
        public fMain(List<Book> shelf)
        {
            InitializeComponent();

            for (int i = 0; i < shelf.Count; i++)
            {
                lbAvailableBooks.Items.Add(shelf.ElementAt(i).getTitle());
            }

            //lbAvailableBooks.Items.AddRange(shelf.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
