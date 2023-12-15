using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text;

namespace SalesAndInventory
{
    public partial class sales : Form
    {
        private Form currentForm;
        private readonly DatabaseConnector dbConnector;
        private static int counter = 1;
        public sales()
        {
            InitializeComponent();
            currentForm = this;
            currentForm.Show();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
            PopulateCustomerComboBox();
            PopulateBrandComboBox();
            ClearAndMoveToNextCustomer();
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
                MessageBox.Show($"An error occurredd: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"An error occurredddd: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields before creating an order
                if (!ValidateOrderFields())
                {
                    return;
                }



                // Get other order details from the form
                string orderDetails = GetOrderDetails();

                // Get customer information from the form
                int? customerID = GetCustomerID();

                // If the customer does not exist, add a new customer to Customers_tbl
                if (!customerID.HasValue)
                {
                    customerID = AddNewCustomer();
                }

                // Get Courier and Payment details
                string selectedCourier = courier.Text;
                string selectedPayment = payment.Text;

                // Get the current date
                DateTime orderDate = DateTime.Now;

                // Get the subtotal, discount, and total
                double subtotal = Convert.ToDouble(subtotaltxtb.Text);
                // Get the current subtotal
                double discount = double.TryParse(disc.Text, out discount) ? discount : 0;
                double total = subtotal - discount;

                // Insert the new order into the Orders_tbl
                string strSQLOrder = "INSERT INTO orders_table (CustomerID, OrderList, Courier, Payment, OrderDate, Subtotal, Discount, Total, Status) " +
                                     $"VALUES ({(customerID != null ? customerID.ToString() : "NULL")}, '{orderDetails}', '{selectedCourier}', '{selectedPayment}', " +
                                     $"'{orderDate.ToString("yyyy-MM-dd HH:mm:ss")}', {subtotal}, {discount}, {total}, 'Processed')";

                using (MySqlCommand command = new MySqlCommand(strSQLOrder, dbConnector.GetConnection()))
                {
                    dbConnector.OpenConnection();

                    try
                    {
                        // Execute the SQL statement for the Orders_tbl
                        command.ExecuteNonQuery();

                        // Display a confirmation message or perform other actions
                        MessageBox.Show("Order created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        // Get the max order ID
                        string maxOrderID = dbConnector.ExecuteQueryScalar<int>("SELECT MAX(OrderID) FROM orders_table").ToString();


                        // Update the quantity in Inventory_tblQuery2 and record the event in OrderEvents_tbl
                        UpdateInventoryAndRecordEvent(maxOrderID);




                        // Execute the SQL statement for the Orders_tbl
                        command.ExecuteNonQuery();

                        MessageBox.Show("Order created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        dbConnector.CloseConnection();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private bool ValidateOrderFields()
        {
            // Add your validation logic here
            // Check if required fields are filled, valid values, etc.
            // Return true if validation succeeds, false otherwise
            // Display error messages or alerts as needed

            // Initialize a StringBuilder to concatenate validation messages
            StringBuilder validationMessages = new StringBuilder();

            // Example validation:
            if (dataGridView1.Rows.Count == 0)
            {
                validationMessages.AppendLine("Please add items to the Order List.");
            }

            if (string.IsNullOrEmpty(fname.Text))
            {
                validationMessages.AppendLine("Please enter First Name.");
            }

            if (string.IsNullOrEmpty(lname.Text))
            {
                validationMessages.AppendLine("Please enter Last Name.");
            }

            if (string.IsNullOrEmpty(addr.Text))
            {
                validationMessages.AppendLine("Please enter Street Address.");
            }

            if (string.IsNullOrEmpty(cp.Text))
            {
                validationMessages.AppendLine("Please enter Contact Number.");
            }

            if (string.IsNullOrEmpty(city.Text))
            {
                validationMessages.AppendLine("Please enter City.");
            }

            if (string.IsNullOrEmpty(barangay.Text))
            {
                validationMessages.AppendLine("Please enter Barangay.");
            }

            if (string.IsNullOrEmpty(courier.Text))
            {
                validationMessages.AppendLine("Please enter Courier.");
            }

            if (string.IsNullOrEmpty(payment.Text))
            {
                validationMessages.AppendLine("Please enter Payment Method.");
            }



            // Check if any validation messages were generated
            if (validationMessages.Length > 0)
            {
                // Display a single MessageBox with all validation messages
                MessageBox.Show(validationMessages.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }


        private int GenerateUniqueOrderItemID()
        {
            // For simplicity, using a combination of date and random number
            string uniqueString = $"{DateTime.Now:yyyyMMddhhmmss}-{new Random().Next(1000):D3}";

            // Use a hash function to convert the string to an integer
            int hash = uniqueString.GetHashCode();

            // Ensure the result is positive
            return Math.Abs(hash);
        }

   

        private int? GetCustomerID()
        {
            // Get the customer ID based on matching customer details
            string strSQL = "SELECT CustomerID FROM customers_table " +
                            "WHERE FirstName = @FirstName AND LastName = @LastName AND StreetAddress = @StreetAddress";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@FirstName", fname.Text },
        { "@LastName", lname.Text },
        { "@StreetAddress", addr.Text }
    };

            // Execute the parameterized SQL statement and attempt to convert the result to int
            object result = dbConnector.ExecuteParameterizedQueryScalar<int?>(strSQL, parameters);

            // Return the result
            return (int?)result;
        }


        private int? AddNewCustomer()
        {
            // Add a new customer to Customers_tbl
            string strSQLInsertCustomer = $"INSERT INTO customers_table (FirstName, LastName, StreetAddress, Phone, City, Barangay, Landmark) " +
                                          $"VALUES ('{fname.Text}', '{lname.Text}', '{addr.Text}', '{cp.Text}', '{city.Text}', '{barangay.Text}', '{landmark.Text}')";

            // Execute the SQL statement to insert the new customer
            dbConnector.ExecuteQuery(strSQLInsertCustomer);

            // Return the newly CustomerID as int?
            return dbConnector.ExecuteQueryScalar<int?>("SELECT LAST_INSERT_ID()");
        }
        private string GetOrderDetails()
        {
            // Iterate through the DataGridView rows and concatenate the details
            StringBuilder orderItemIDs = new StringBuilder();
            int newOrderItemID = GenerateUniqueOrderItemID();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row if any
                {
                    string brand = row.Cells["BrandColumn"].Value?.ToString() ?? "";
                    string productName = row.Cells["ProductNameColumn"].Value?.ToString() ?? "";
                    string colorway = row.Cells["ColorwayColumn"].Value?.ToString() ?? "";
                    int quantity = 0;

                    // Safely convert sizes and quantity
                    string sizes = row.Cells["SizesColumn"].Value?.ToString() ?? "";
                    int.TryParse(row.Cells["Quantity"].Value?.ToString(), out quantity);

                    try
                    {

                        // Insert into OrderItems_tbl with parameterized query
                        string strSQLInsertOrderItem = "INSERT INTO orderitems_table (GeneratedOrderID, Brand, ProductName, Colorway, Sizes, Quantity) " +
                                                       "VALUES (@GeneratedOrderID, @Brand, @ProductName, @Colorway, @Sizes, @Quantity)";

                        Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@GeneratedOrderID", newOrderItemID },
                    { "@Brand", brand },
                    { "@ProductName", productName },
                    { "@Colorway", colorway },
                    { "@Sizes", sizes },
                    { "@Quantity", quantity }
                };

                        // Execute the SQL statement to insert the order item
                        dbConnector.ExecuteParameterizedQuery(strSQLInsertOrderItem, parameters);



                        // Retrieve the last inserted OrderItemID
                        object lastOrderItemIDObject = dbConnector.ExecuteParameterizedQueryScalar<object>(
                            $"SELECT LAST_INSERT_ID();", null);  // Assuming there's no need for parameters here

                        // Convert the result to a string
                        string lastOrderItemID = lastOrderItemIDObject.ToString();

                        // Concatenate the OrderItemID to the string
                        if (orderItemIDs.Length > 0)
                        {
                            orderItemIDs.Append($",{lastOrderItemID}");
                        }
                        else
                        {
                            orderItemIDs.Append(lastOrderItemID);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, log it, or display an error message
                        MessageBox.Show($"An error occurred while processing order item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return orderItemIDs.ToString();
        }


        private void UpdateInventoryAndRecordEvent(string maxOrderID)
        {
            // Iterate through the DataGridView rows and update Inventory and record events
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row if any
                {
                    string brand = row.Cells["BrandColumn"].Value.ToString();
                    string productName = row.Cells["ProductNameColumn"].Value.ToString();
                    string colorway = row.Cells["ColorwayColumn"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    int size = Convert.ToInt32(row.Cells["SizesColumn"].Value);

                    string strSQL = $"SELECT " +
                $"    inventory.QuantityInStock " +
                $"FROM " +
                $"    inventory " +
                $"JOIN " +
                $"    products_table ON inventory.ProductID = products_table.ProductID " +
                $"JOIN " +
                $"    colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                $"JOIN " +
                $"    sizes ON inventory.SizeID = sizes.SizeID " +
                $"WHERE " +
                $"    products_table.ProductName = '{productName}' AND " +
                $"    colorway.ColorwayName = '{colorway}' AND " +
                $"    sizes.ShoeSize = {size};";

                    int currentStock = dbConnector.ExecuteQueryScalar<int>(strSQL);

                    // Calculate the new stock without going negative
                    int newStock = currentStock - quantity;

                    // Ensure the new stock doesn't go below 0
                    if (newStock < 0)
                    {
                        newStock = 0;
                    }

                    strSQL = $"UPDATE inventory " +
                                    $"JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                                    $"JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                                    $"JOIN sizes ON inventory.SizeID = sizes.SizeID " +
                                    $"SET inventory.QuantityInStock = {newStock} " +
                                    $"WHERE " +
                                    $"    products_table.ProductName = '{productName}' AND " +
                                    $"    colorway.ColorwayName = '{colorway}' AND " +
                                    $"    sizes.ShoeSize = {size};";

                    // Execute the update query
                    dbConnector.ExecuteQuery(strSQL);


                    // Record the event in OrderEvents_tbl
                    InsertStockUpdate(productName, brand, colorway, size.ToString(), quantity );
                }
            }
        }

        private void InsertStockUpdate(string productName, string brand, string colorway, string sizeID, int quantity)
        {
            // Generate a unique note for "Stock Out"
            string note = "Stock Out";

            // Set the stock status to "Stock Out"
            string stockStatus = "Stock Out";

            // Get the current date and time
            DateTime dateCreated = DateTime.Now;

            // Insert into stocksupdate table
            string strSQLInsertStockUpdate = $"INSERT INTO stocksupdate (ProductName, Brand, ColorwayName, SizeID, Quantity, Notes, StockStatus, DateCreated) " +
                                             $"VALUES ('{productName}', '{brand}', '{colorway}', '{sizeID}', {quantity}, '{note}', '{stockStatus}', '{dateCreated:yyyy-MM-dd HH:mm:ss}')";

            // Execute the query
            dbConnector.ExecuteQuery(strSQLInsertStockUpdate);
        }













    }

}
