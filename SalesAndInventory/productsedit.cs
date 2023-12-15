using MySql.Data.MySqlClient;

namespace SalesAndInventory
{
    public partial class productsedit : Form
    {
        private Form currentForm;
        private readonly DatabaseConnector dbConnector;

        private string originalProductName;
        private string originalColorway;
        private string originalBasePrice;
        private string originalRetailPrice;
        public productsedit()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();
            PopulateListBox1();
            savebtn.Enabled = false;

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

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchForm(new products());
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

        private void PopulateListBox1()
        {
            try
            {
                listBox1.Items.Clear(); // Clear existing items

                // Retrieve distinct brands from products_tbl
                string query = "SELECT DISTINCT Brand FROM products_table";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string brand = reader["Brand"].ToString();
                    _ = listBox1.Items.Add(brand);
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

        private void PopulateListBox2(string selectedBrand)
        {
            try
            {
                // Retrieve product names from products_tbl for the selected brand
                string query = $"SELECT ProductName FROM products_table WHERE Brand = '{selectedBrand}'";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    _ = listBox2.Items.Add(productName);
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

        private void PopulateListBox3(string selectedProduct)
        {
            listBox3.Items.Clear();
            try
            {
                // Retrieve colorways from colorway table for the selected product
                string query = $"SELECT ColorwayName FROM colorway WHERE ProductID = (SELECT ProductID FROM products_table WHERE ProductName = '{selectedProduct}')";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string colorwayName = reader["ColorwayName"].ToString();
                    _ = listBox3.Items.Add(colorwayName);
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
            // Handle the event when the selected item in listBox1 changes

            // Clear existing items in listBox2 and listBox3
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            // Get the selected brand from listBox1
            string selectedBrand = listBox1.SelectedItem?.ToString();

            if (selectedBrand != null)
            {
                // Populate listBox2 with product names based on the selected brand
                PopulateListBox2(selectedBrand);
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when the selected item in listBox2 changes

            // Clear existing items in listBox3
            listBox3.Items.Clear();

            // Get the selected product name from listBox2
            string selectedProduct = listBox2.SelectedItem?.ToString();

            if (selectedProduct != null)
            {
                // Populate listBox3 with colorways based on the selected product
                PopulateListBox3(selectedProduct);
            }
        }


        private void PopulateTextBoxes()
        {
            if (listBox3.SelectedItem == null || listBox2.SelectedItem == null)
            {
                return;
            }

            string selectedProductName = listBox2.SelectedItem.ToString();
            string selectedColorwayName = listBox3.SelectedItem.ToString();

            string basePrice = GetBasePrice(selectedProductName); // Implement this function to retrieve decimal as string
            string retailPrice = GetRetailPrice(selectedProductName); // Implement this function to retrieve decimal as string


            // Assign values to the original variables
            originalProductName = selectedProductName;
            originalColorway = selectedColorwayName;
            originalBasePrice = GetBasePrice(selectedProductName);
            originalRetailPrice = GetRetailPrice(selectedProductName);


            // Populate text boxes
            prn.Text = selectedProductName;
            colorwaytxtb.Text = selectedColorwayName;
            basep.Text = basePrice;
            retailp.Text = retailPrice;
        }

        private string GetBasePrice(string productName)
        {
            try
            {
                using MySqlConnection connection = dbConnector.GetConnection();
                dbConnector.OpenConnection();

                string query = "SELECT BasePrice FROM products_table WHERE ProductName = @productName";

                using MySqlCommand command = new(query, connection);
                _ = command.Parameters.AddWithValue("@productName", productName);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred while retrieving BasePrice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0.0"; // Return a default value if an error occurs
            }
            finally
            {
                dbConnector.CloseConnection();
            }

            return "0.0"; // Return a default value if an error occurs
        }

        private string GetRetailPrice(string productName)
        {
            try
            {
                using MySqlConnection connection = dbConnector.GetConnection();
                dbConnector.OpenConnection();

                string query = "SELECT RetailPrice FROM products_table WHERE ProductName = @productName";

                using MySqlCommand command = new(query, connection);
                _ = command.Parameters.AddWithValue("@productName", productName);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred while retrieving RetailPrice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0.0"; // Return a default value if an error occurs
            }
            finally
            {
                dbConnector.CloseConnection();
            }

            return "0.0"; // Return a default value if an error occurs
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }



        private void editbtn_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }
        private void EnableTextBoxes()
        {
            // Implement logic to enable textboxes for editing
            prn.Enabled = true;
            colorwaytxtb.Enabled = true;
            basep.Enabled = true;
            retailp.Enabled = true;

            savebtn.Enabled = true;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            // Check for changes and update the database
            if (HasChanges())
            {
                // Update products_table
                UpdateProductsTable();

                // Update colorway
                UpdateColorway();

                _ = MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _ = MessageBox.Show("No changes to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool HasChanges()
        {
            return prn.Text != originalProductName ||
                   colorwaytxtb.Text != originalColorway ||
                   basep.Text != originalBasePrice ||
                   retailp.Text != originalRetailPrice;
        }

        private void UpdateProductsTable()
        {
            try
            {
                using MySqlConnection connection = dbConnector.GetConnection();
                dbConnector.OpenConnection();

                // Update products_table based on changes
                string updateQuery = "UPDATE products_table " +
                                     "SET ProductName = @productName, BasePrice = @basePrice, RetailPrice = @retailPrice " +
                                     "WHERE ProductName = @originalProductName";


                using MySqlCommand command = new(updateQuery, dbConnector.GetConnection());
                _ = command.Parameters.AddWithValue("@productName", prn.Text);
                _ = command.Parameters.AddWithValue("@basePrice", Convert.ToDecimal(basep.Text));
                _ = command.Parameters.AddWithValue("@retailPrice", Convert.ToDecimal(retailp.Text));
                _ = command.Parameters.AddWithValue("@originalProductName", originalProductName);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Update successful
                }
                else
                {
                    _ = MessageBox.Show("Failed to update products_table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred while updating products_table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void UpdateColorway()
        {
            try
            {
                using MySqlConnection connection = dbConnector.GetConnection();
                dbConnector.OpenConnection();

                // Update colorway based on changes
                string updateQuery = "UPDATE colorway " +
                                     "SET ColorwayName = @colorwayName " +
                                     "WHERE ProductID = (SELECT ProductID FROM products_table WHERE ProductName = @productName) " +
                                     "AND ColorwayName = @originalColorway";

                using MySqlCommand command = new(updateQuery, dbConnector.GetConnection());
                _ = command.Parameters.AddWithValue("@colorwayName", colorwaytxtb.Text);
                _ = command.Parameters.AddWithValue("@productName", prn.Text);
                _ = command.Parameters.AddWithValue("@originalColorway", originalColorway);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Update successful
                }
                else
                {
                    _ = MessageBox.Show("Failed to update colorway.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"An error occurred while updating colorway: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }




    }
}
