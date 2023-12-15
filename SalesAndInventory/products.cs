namespace SalesAndInventory
{
    public partial class products : Form
    {
        private Form currentForm;
        private readonly DatabaseConnector dbConnector;
        public products()
        {
            InitializeComponent();
            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();
        }

        private void SwitchForm(Form newForm)
        {
            // Set the location of the new form to match the main form
            newForm.Location = Location;

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

        private void addcolorways_Click(object sender, EventArgs e)
        {
            SwitchForm(new productscolorway());
        }

        private void addshoes_Click(object sender, EventArgs e)
        {
            SwitchForm(new productsshoes());
        }

        private void editexisting_Click(object sender, EventArgs e)
        {
            SwitchForm(new productsedit());
        }
    }
}
