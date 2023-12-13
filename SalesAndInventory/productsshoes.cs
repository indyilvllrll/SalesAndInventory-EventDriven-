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
    public partial class productsshoes : Form
    {
        private Form currentForm;
        private DatabaseConnector dbConnector;
        public productsshoes()
        {
            InitializeComponent();
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


        private void back_Click(object sender, EventArgs e)
        {
            SwitchForm(new products());
        }

        private void addshoes_Click(object sender, EventArgs e)
        {
            SwitchForm(new productsshoes());
        }

        private void addcolorways_Click(object sender, EventArgs e)
        {
            SwitchForm(new productscolorway());
        }

        private void editexisting_Click(object sender, EventArgs e)
        {
            SwitchForm(new productsedit());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchForm(new products());
        }
    }
}
