using System.Data.Common;

namespace SalesAndInventory
{
    public partial class dashboard : Form
    {
        private Form currentForm;

        private readonly DatabaseConnector dbConnector;

        public dashboard()
        {
            InitializeComponent();

            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
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

/*        private void totalsales_Click(object sender, EventArgs e)
        {

        }


        private void UpdateStatusLabel()
        {
            // Get the number of orders with status 'Packed'
            int packedCount = GetStatusCount("Packed");
            packed.Text = packedCount.ToString();

            // Get the number of orders with status 'Shipped'
            int shippedCount = GetStatusCount("Shipped");
            shipped.Text = shippedCount.ToString();

            // Get the number of orders with status 'Completed'
            int completedCount = GetStatusCount("Completed");
            completed.Text = completedCount.ToString();

            // Get the total sales (sum of 'Total' where status is 'Delivered')
            double totalSales = GetTotalSales();
            totalsales.Text = totalSales.ToString("C"); // Assuming you want to display currency

            // Get the total quantity in stock
            int totalQuantityInStock = GetTotalQuantityInStock();
            inventory.Text = totalQuantityInStock.ToString();
        }

        private int GetStatusCount(string status)
        {
            // Construct the SQL query to count orders with the specified status
            string strSQL = $"SELECT COUNT(*) FROM orders_table WHERE Status = '{status}'";

            // Execute the query and return the count
            long result = dbConnector.ExecuteQueryScalar<long>(strSQL);
            return (int)result;
        }

        private long GetTotalSales()
        {
            // Construct the SQL query to sum the 'Total' where status is 'Delivered'
            string strSQL = "SELECT SUM(Total) FROM orders_table WHERE Status = 'Delivered'";

            // Execute the query and return the total sales
            decimal result = dbConnector.ExecuteQueryScalar<decimal>(strSQL);
            return (long)result;
        }

        private int GetTotalQuantityInStock()
        {
            // Construct the SQL query to sum all the 'QuantityInStock' in inventory
            string strSQL = "SELECT SUM(QuantityInStock) FROM inventory";

            // Execute the query and return the total quantity in stock
            long result = dbConnector.ExecuteQueryScalar<long>(strSQL);
            return (int)result;
        }*/
    }
}
