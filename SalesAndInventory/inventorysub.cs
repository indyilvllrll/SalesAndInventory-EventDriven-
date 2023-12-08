using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndInventory
{
    public partial class inventorysub : Form
    {
        private Form currentForm;

        public inventorysub()
        {
            InitializeComponent();
            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();
        }
        private void SwitchForm(Form newForm)
        {
            // Set the location of the new form to match the main form
            newForm.Location = this.Location;

            // Hide the current form
            currentForm.Hide();

            // Show the new form
            newForm.Show();

            // Update the currentForm reference
            currentForm = newForm;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();  // hide the login form
            inventory inventoryForm = new inventory();
            inventoryForm.Location = this.Location;
            inventoryForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SwitchForm(new dashboard());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            SwitchForm(new inventory());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SwitchForm(new sales());
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            SwitchForm(new purchases());
        }



        private void btnUpdateStocks_Click(object sender, EventArgs e)
        {

        }
    }
}
