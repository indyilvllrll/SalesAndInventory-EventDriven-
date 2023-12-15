using MySql.Data.MySqlClient;
using System.Data.Common;

namespace SalesAndInventory
{
    public partial class sales : Form
    {
        private Form currentForm;
        private readonly DatabaseConnector dbConnector;

        public sales()
        {
            InitializeComponent();
            currentForm = this;
            currentForm.Show();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
            PopulateCustomerComboBox();
            PopulateBrandComboBox();
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchForm(new salesmanage());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PopulateCustomerComboBox()
        {
            try
            {
                dbConnector.OpenConnection();

                // Assuming you have a ComboBox named customercmb
                customercmb.Items.Clear(); // Clear existing items

                // Retrieve CustomerID values from customers_table
                string query = "SELECT CustomerID FROM customers_table";
                using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerID = reader.GetInt32("CustomerID");
                            customercmb.Items.Add(customerID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating the customer combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }
        private void customercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when the selected item in customercmb changes

            if (customercmb.SelectedItem != null)
            {
                int selectedCustomerID = (int)customercmb.SelectedItem;

                // Retrieve customer details based on the selected CustomerID
                string query = "SELECT FirstName, LastName, StreetAddress, Phone, City, Barangay, Landmark " +
                               "FROM customers_table " +
                               "WHERE CustomerID = @customerID";

                try
                {
                    dbConnector.OpenConnection();

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@customerID", selectedCustomerID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate textboxes with customer details
                                fname.Text = reader.GetString("FirstName");
                                lname.Text = reader.GetString("LastName");
                                addr.Text = reader.GetString("StreetAddress");
                                cp.Text = reader.GetString("Phone");
                                city.Text = reader.GetString("City");
                                barangay.Text = reader.GetString("Barangay");
                                landmark.Text = reader.GetString("Landmark");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnector.CloseConnection();
                }
            }
        }


        private void ClearAndMoveToNextCustomer()
        {
            // Clear all textboxes
            fname.Clear();
            lname.Clear();
            addr.Clear();
            cp.Clear();
            city.Clear();
            barangay.Clear();
            landmark.Clear();

            // Query the database to find the maximum CustomerID
            int maxCustomerID = GetMaxCustomerIDFromDatabase();

            // Increment the maximum CustomerID by 1
            int nextCustomerID = maxCustomerID + 1;

            // Show the next CustomerID in the combo box
            customercmb.Text = nextCustomerID.ToString();
        }

        private int GetMaxCustomerIDFromDatabase()
        {
            try
            {
                using (MySqlConnection connection = dbConnector.GetConnection())
                {
                    dbConnector.OpenConnection();

                    // Query to get the maximum CustomerID from customers_table
                    string query = "SELECT MAX(CustomerID) FROM customers_table";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving max CustomerID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }

            // Default value if an error occurs
            return 0;
        }

        private void cleartxtb_Click(object sender, EventArgs e)
        {
            ClearAndMoveToNextCustomer();
        }

        private void PopulateBrandComboBox()
        {
            try
            {
                using (MySqlConnection connection = dbConnector.GetConnection())
                {
                    dbConnector.OpenConnection();

                    // Query to get distinct brands from products_table
                    string query = "SELECT DISTINCT Brand FROM products_table";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string brand = reader["Brand"].ToString();
                                brandcmb.Items.Add(brand);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating Brand combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void PopulateProductComboBox(string selectedBrand)
        {
            productcmb.Items.Clear(); // Clear existing items

            try
            {
                using (MySqlConnection connection = dbConnector.GetConnection())
                {
                    dbConnector.OpenConnection();

                    // Query to get product names for the selected brand
                    string query = $"SELECT ProductName FROM products_table WHERE Brand = '{selectedBrand}'";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader["ProductName"].ToString();
                                productcmb.Items.Add(productName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating Product combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void PopulateColorwayComboBox(string selectedProduct)
        {
            colorwaycmb.Items.Clear(); // Clear existing items

            try
            {
                using (MySqlConnection connection = dbConnector.GetConnection())
                {
                    dbConnector.OpenConnection();

                    // Query to get colorway names for the selected product
                    string query = $"SELECT ColorwayName FROM colorway WHERE ProductID = (SELECT ProductID FROM products_table WHERE ProductName = '{selectedProduct}')";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string colorwayName = reader["ColorwayName"].ToString();
                                colorwaycmb.Items.Add(colorwayName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating Colorway combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void PopulateSizeComboBox(string selectedProduct, string selectedColorway)
        {
            sizescmb.Items.Clear(); // Clear existing items

            try
            {
                using (MySqlConnection connection = dbConnector.GetConnection())
                {
                    dbConnector.OpenConnection();

                    // Query to get sizes where QuantityInStock is > 0 for the selected product and colorway
                    string query = "SELECT sizes.ShoeSize " +
                                   "FROM inventory " +
                                   "JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                                   "JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                                   "JOIN sizes ON inventory.SizeID = sizes.SizeID " +
                                   "WHERE products_table.ProductName = @productName " +
                                   "AND colorway.ColorwayName = @colorwayName " +
                                   "AND inventory.QuantityInStock > 0";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@productName", selectedProduct);
                        command.Parameters.AddWithValue("@colorwayName", selectedColorway);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string size = reader["ShoeSize"].ToString();
                                sizescmb.Items.Add(size);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating Size combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void PopulateQuantityComboBox(string selectedProduct, string selectedColorway, string selectedSize)
        {
            quantitycmb.Items.Clear(); // Clear existing items

            try
            {
                using (MySqlConnection connection = dbConnector.GetConnection())
                {
                    dbConnector.OpenConnection();

                    // Query to get QuantityInStock for the selected product, colorway, and size
                    string query = "SELECT inventory.QuantityInStock " +
                                   "FROM inventory " +
                                   "JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                                   "JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                                   "JOIN sizes ON inventory.SizeID = sizes.SizeID " +
                                   "WHERE products_table.ProductName = @productName " +
                                   "AND colorway.ColorwayName = @colorwayName " +
                                   "AND sizes.ShoeSize = @size";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@productName", selectedProduct);
                        command.Parameters.AddWithValue("@colorwayName", selectedColorway);
                        command.Parameters.AddWithValue("@size", selectedSize);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int quantityInStock = Convert.ToInt32(reader["QuantityInStock"]);

                                // Populate the Quantity ComboBox with values from 1 to quantityInStock
                                for (int i = 1; i <= quantityInStock; i++)
                                {
                                    quantitycmb.Items.Add(i);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating Quantity combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void brandcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the existing items in subsequent combo boxes
            productcmb.Items.Clear();
            colorwaycmb.Items.Clear();
            sizescmb.Items.Clear();
            quantitycmb.Items.Clear();

            productcmb.Text = "";
            colorwaycmb.Text = "";
            sizescmb.Text = "";
            quantitycmb.Text = "";

            // Get the selected brand from the Brand combo box
            string selectedBrand = brandcmb.SelectedItem?.ToString();

            if (selectedBrand != null)
            {
                // Populate the Product combo box based on the selected brand
                PopulateProductComboBox(selectedBrand);
            }
        }

        private void productcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the existing items in subsequent combo boxes
            colorwaycmb.Items.Clear();
            sizescmb.Items.Clear();
            quantitycmb.Items.Clear();

            colorwaycmb.Text = "";
            sizescmb.Text = "";
            quantitycmb.Text = "";

            // Get the selected product from the Product combo box
            string selectedProduct = productcmb.SelectedItem?.ToString();

            if (selectedProduct != null)
            {
                // Populate the Colorway combo box based on the selected product
                PopulateColorwayComboBox(selectedProduct);
            }
        }

        private void colorwaycmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the existing items in subsequent combo boxes
            sizescmb.Items.Clear();
            sizescmb.Text = "";
            quantitycmb.Text = "";
            quantitycmb.Items.Clear();

            // Get the selected product and colorway from the Product and Colorway combo boxes
            string selectedProduct = productcmb.SelectedItem?.ToString();
            string selectedColorway = colorwaycmb.SelectedItem?.ToString();

            if (selectedProduct != null && selectedColorway != null)
            {
                // Populate the Size combo box based on the selected product and colorway
                PopulateSizeComboBox(selectedProduct, selectedColorway);
            }
        }

        private void sizescmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the existing items in the Quantity combo box
            quantitycmb.Items.Clear();
            quantitycmb.Text = "";


            // Get the selected product, colorway, and size from the Product, Colorway, and Size combo boxes
            string selectedProduct = productcmb.SelectedItem?.ToString();
            string selectedColorway = colorwaycmb.SelectedItem?.ToString();
            string selectedSize = sizescmb.SelectedItem?.ToString();

            if (selectedProduct != null && selectedColorway != null && selectedSize != null)
            {
                // Populate the Quantity combo box based on the selected product, colorway, and size
                PopulateQuantityComboBox(selectedProduct, selectedColorway, selectedSize);
            }
        }

        private void quantitycmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private decimal GetRetailPrice(string productName)
        {
            try
            {
                using (MySqlConnection connection = dbConnector.GetConnection())
                {
                    dbConnector.OpenConnection();

                    string query = "SELECT RetailPrice FROM products_table WHERE ProductName = @productName";

                    using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@productName", productName);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving RetailPrice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }

            return 0.0m; // Return a default value if an error occurs
        }

        private void ClearComboBoxes()
        {
            brandcmb.SelectedIndex = -1;
            productcmb.SelectedIndex = -1;
            colorwaycmb.SelectedIndex = -1;
            sizescmb.SelectedIndex = -1;
            quantitycmb.SelectedIndex = -1;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedBrand = brandcmb.SelectedItem?.ToString();
                string selectedProduct = productcmb.SelectedItem?.ToString();
                string selectedColorway = colorwaycmb.SelectedItem?.ToString();
                string selectedSize = sizescmb.SelectedItem?.ToString();
                int selectedQuantity = Convert.ToInt32(quantitycmb.SelectedItem);

                // Get RetailPrice from products_table
                decimal retailPrice = GetRetailPrice(selectedProduct);

                // Add a new row to dataGridView1
                dataGridView1.Rows.Add(selectedBrand, selectedProduct, selectedColorway, selectedSize, selectedQuantity, retailPrice);

                // Optionally, you can clear the combo boxes and reset them to their default state
                ClearComboBoxes();
                CalculateSubtotal();

                // Optionally, you can clear the combo boxes and reset them to their default state
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateSubtotal()
        {
            decimal subtotal = 0.0m;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Quantity"].Value != null && row.Cells["RetailPrice"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal retailPrice = Convert.ToDecimal(row.Cells["RetailPrice"].Value);
                    decimal rowTotal = quantity * retailPrice;
                    subtotal += rowTotal;
                    decimal total = subtotal;
                    disc.Text = "0.00";

                }
            }

            subtotaltxtb.Text = subtotal.ToString("0.00");
        }

        private void clearlist_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ClearComboBoxes();
            subtotaltxtb.Text = "0.00"; // Reset subtotal to 0.00
            disc.Text = "0.00";
            totaltxtb.Text = "0.00";
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if discount is a valid decimal
                if (decimal.TryParse(disc.Text, out decimal discount))
                {
                    decimal subtotal = decimal.Parse(subtotaltxtb.Text);
                    decimal total = subtotal - discount;

                    // Update the total textbox
                    totaltxtb.Text = total.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Invalid discount value. Please enter a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
