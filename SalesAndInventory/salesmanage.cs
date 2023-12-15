using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndInventory
{


    public partial class salesmanage : Form
    {
        private DatabaseConnector dbConnector;
        private DataTable dataTable;
        private Form currentForm;
        public salesmanage()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
            currentForm = this;
            currentForm.Show();
            PopulateDataGridView();
            PopulateDataGridView2();



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

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SwitchForm(new salesmanage());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SwitchForm(new products());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwitchForm(new sales());
        }

        private void salesmanage_Load(object sender, EventArgs e)
        {

        }

        private void PopulateDataGridView()
        {
            try
            {
                dbConnector.OpenConnection(); // Open the connection using the DatabaseConnector

                // Execute the SQL query to retrieve data
                string query = "SELECT * FROM customers_table";
                MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection());
                using MySqlDataAdapter adapter = new(command);
                DataTable dataTable = new();
                _ = adapter.Fill(dataTable);

                // Bind the data to the dataGridView1
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection(); // Close the connection using the DatabaseConnector
            }
        }

        private void PopulateDataGridView2()
        {
            try
            {
                dbConnector.OpenConnection(); // Open the connection using the DatabaseConnector

                string strSQL = "SELECT orders_table.OrderID, orders_table.CustomerID, " +
                                "customers_table.FirstName, customers_table.LastName, " +
                                "orders_table.OrderList, orders_table.Courier, orders_table.Payment, " +
                                "orders_table.Total, orders_table.Status " +
                                "FROM orders_table " +
                                "JOIN customers_table ON orders_table.CustomerID = customers_table.CustomerID";
                MySqlCommand command = new MySqlCommand(strSQL, dbConnector.GetConnection());
                DataTable dataTable = dbConnector.ExecuteQueryDataTable(strSQL);

                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
