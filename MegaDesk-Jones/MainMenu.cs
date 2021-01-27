using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Jones
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

       

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            //create addquote form
            var frmAddQuote = new AddQuote(this);
            
            //add reference to MainMenu
            //frmAddQuote.Tag = this;
            
            //show new Addquote Form
            frmAddQuote.Show();
            
            //hide mainmenu
            this.Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var frmViewAllQuotes = new ViewAllQuotes(this);

            frmViewAllQuotes.Show();

            this.Hide();

        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var frmSearchQuotes = new SearchQuotes(this);

            frmSearchQuotes.Show();

            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
