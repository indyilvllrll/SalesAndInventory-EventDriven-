using MySql.Data.MySqlClient;
using System.Data;

namespace SalesAndInventory
{
    public partial class productsshoes : Form
    {
        private Form currentForm;
        private readonly DatabaseConnector dbConnector;
        public productsshoes()
        {
            InitializeComponent();
            currentForm = this;
            currentForm.Show();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
            PopulateBrandComboBox();
            LoadProductsData();
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

        private void PopulateBrandComboBox()
        {
            try
            {
                // Fetch distinct brands from the products_table
                string query = "SELECT DISTINCT Brand FROM products_table";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string brand = reader["Brand"].ToString();
                    _ = brandcmb.Items.Add(brand);
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }
        private void LoadProductsData()
        {
            try
            {
                // Fetch all data from products_table
                string query = "SELECT * FROM products_table";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataAdapter adapter = new(command);
                // Create a DataTable to hold the data
                DataTable dataTable = new();
                _ = adapter.Fill(dataTable);

                // Bind the data to the dataGridView1
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }






        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect values from the form
                string brand = brandcmb.Text; // Selected or entered brand
                string productName = prn.Text;
                decimal basePrice = decimal.Parse(basep.Text);
                decimal retailPrice = decimal.Parse(retailp.Text);

                // Insert data into products_table
                string insertQuery = "INSERT INTO products_table (ProductName, Brand, BasePrice, RetailPrice) " +
                                     "VALUES (@ProductName, @Brand, @BasePrice, @RetailPrice)";

                using MySqlCommand command = new(insertQuery, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                _ = command.Parameters.AddWithValue("@ProductName", productName);
                _ = command.Parameters.AddWithValue("@Brand", brand);
                _ = command.Parameters.AddWithValue("@BasePrice", basePrice);
                _ = command.Parameters.AddWithValue("@RetailPrice", retailPrice);

                _ = command.ExecuteNonQuery();
                LoadProductsData();
                _ = MessageBox.Show("Shoes added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void brandcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
