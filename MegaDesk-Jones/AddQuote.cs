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
    public partial class AddQuote : Form
    {
        Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            // var mainMenu = (MainMenu)this.Tag;
            //mainMenu.Show();
            _mainMenu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            //create a new desk
            var desk = new Desk();

            //assign desk properties
            desk.width = nudWidth.Value;

            var deskQuote = new DeskQuote();

            //set desk quote properties
            deskQuote.CustomerName = txtbxCustomerName.Text;

            //...

            //set quote price
            deskQuote.QuotePrice = deskQuote.GetQuotePrice();
            //
        }
    }
}
