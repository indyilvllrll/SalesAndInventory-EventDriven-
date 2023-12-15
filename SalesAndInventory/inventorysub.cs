using MySql.Data.MySqlClient;

namespace SalesAndInventory
{
    public partial class inventorysub : Form
    {
        private Form currentForm;
        private readonly DatabaseConnector dbConnector;

        public inventorysub()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateComboBox();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();  // hide the login form
            inventory inventoryForm = new()
            {
                Location = Location
            };
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


        private void PopulateComboBox()
        {

            try
            {
                string query = "SELECT DISTINCT Brand FROM products_table";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string selectedBrand = reader["Brand"].ToString();
                    _ = comboBox1.Items.Add(selectedBrand);
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













        private void btnUpdateStocks_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items in the ListBox
            listBox1.Items.Clear();
            colorwaycmb.SelectedIndex = -1;

            // Get the selected item from the ComboBox
            string selectedBrand = comboBox1.SelectedItem?.ToString();

            if (selectedBrand != null)
            {
                // Populate the ListBox based on the selected item
                PopulateListBox(selectedBrand);
            }
        }

        private void PopulateListBox(string selectedBrand)
        {
            colorwaycmb.Items.Clear();
            try
            {
                // Modify the query based on your database structure
                string query = $"SELECT ProductName FROM products_table WHERE Brand = '{selectedBrand}'";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    _ = listBox1.Items.Add(productName);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ListBox
            string selectedProduct = listBox1.SelectedItem?.ToString();

            // Update the shoesLabel with the selected product
            shoeslabel.Text = selectedProduct;
            colorwaycmb.Text = "";


            // Populate the colorwayComboBox based on the selected product
            PopulateColorwayComboBox(selectedProduct);
        }



        private void PopulateColorwayComboBox(string selectedProduct)
        {
            colorwaycmb.Items.Clear();
            colorwaycmb.Text = "";
            try
            {
                // Modify the query based on your database structure
                string query = $"SELECT DISTINCT colorway.ColorwayName FROM inventory " +
                               $"JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                               $"JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                               $"WHERE products_table.ProductName = '{selectedProduct}';";

                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string colorwayName = reader["ColorwayName"].ToString();
                    _ = colorwaycmb.Items.Add(colorwayName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchForm(new products());
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void colorwaycmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }



        private void PopulateDataGridView()
        {
            try
            {
                // Clear existing data in the DataGridView
                dataGridView1.Rows.Clear();

                // Get the selected product name and colorway
                string productName = shoeslabel.Text;
                string colorwayName = colorwaycmb.SelectedItem.ToString();

                // SQL query to retrieve ShoeSize and QuantityInStock
                string query = @"SELECT sizes.ShoeSize, inventory.QuantityInStock
                         FROM inventory
                         JOIN products_table ON inventory.ProductID = products_table.ProductID
                         JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID
                         JOIN sizes ON inventory.SizeID = sizes.SizeID
                         WHERE products_table.ProductName = @productName
                         AND colorway.ColorwayName = @colorwayName";

                using MySqlCommand command = new(query, dbConnector.GetConnection());
                // Add parameters to the query
                _ = command.Parameters.AddWithValue("@productName", productName);
                _ = command.Parameters.AddWithValue("@colorwayName", colorwayName);

                // Open the database connection
                dbConnector.OpenConnection();

                using MySqlDataReader reader = command.ExecuteReader();
                // Check if there are rows returned
                if (reader.HasRows)
                {
                    // Loop through the result set and populate the DataGridView
                    while (reader.Read())
                    {
                        string shoeSize = reader["ShoeSize"].ToString();
                        int quantityInStock = Convert.ToInt32(reader["QuantityInStock"]);

                        // Add a new row to the DataGridView
                        _ = dataGridView1.Rows.Add(shoeSize, quantityInStock);
                    }
                }
                else
                {
                    _ = MessageBox.Show("No data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                dbConnector.CloseConnection();
            }
        }







    }





}

