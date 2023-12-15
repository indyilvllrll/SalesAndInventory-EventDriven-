﻿namespace SalesAndInventory
{
    public partial class dashboard : Form
    {
        private Form currentForm;


        public dashboard()
        {
            InitializeComponent();

            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();
        }

        private void SwitchForm(Form newForm)
        {
            // Center the new form relative to the main form
            newForm.Location = Location;


            // Set the main form as the owner of the new form
            newForm.Owner = this;

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

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchForm(new products());
        }
    }
}
