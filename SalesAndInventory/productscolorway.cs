using MySql.Data.MySqlClient;

namespace SalesAndInventory
{
    public partial class productscolorway : Form
    {
        private Form currentForm;
        private readonly DatabaseConnector dbConnector;
        public productscolorway()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");


            // Set ComboBox properties
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            button1.Click += button1_Click;

            // Populate listBox1 with distinct brands
            PopulateListBox1();
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

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchForm(new products());
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle the event when button1 is clicked

            // Get the selected values from listBox2 and textBox1
            string selectedProduct = listBox2.SelectedItem?.ToString();
            string colorwayName = textBox1.Text;

            if (!string.IsNullOrEmpty(selectedProduct) && !string.IsNullOrEmpty(colorwayName))
            {
                // Insert a new colorway into the colorway table
                InsertColorway(selectedProduct, colorwayName);
            }
        }

        private void InsertColorway(string selectedProduct, string colorwayName)
        {
            try
            {
                // Retrieve ProductID for the selected product
                string productIdQuery = $"SELECT ProductID FROM products_table WHERE ProductName = '{selectedProduct}'";
                using MySqlCommand productIdCommand = new(productIdQuery, dbConnector.GetConnection());
                dbConnector.OpenConnection();
                int productId = Convert.ToInt32(productIdCommand.ExecuteScalar());

                // Insert the new colorway into the colorway table
                string insertColorwayQuery = $"INSERT INTO colorway (ColorwayName, ProductID) VALUES ('{colorwayName}', {productId})";
                using MySqlCommand insertColorwayCommand = new(insertColorwayQuery, dbConnector.GetConnection());
                _ = insertColorwayCommand.ExecuteNonQuery();

                // Get the ColorwayID of the newly added colorway
                string colorwayIdQuery = $"SELECT LAST_INSERT_ID()";
                using MySqlCommand colorwayIdCommand = new(colorwayIdQuery, dbConnector.GetConnection());
                int colorwayId = Convert.ToInt32(colorwayIdCommand.ExecuteScalar());

                // Insert the new colorway into the inventory table with SizeID (1-10) and QuantityInStock (all 0)
                for (int sizeId = 1; sizeId <= 10; sizeId++)
                {
                    string insertInventoryQuery = $"INSERT INTO inventory (ProductID, ColorwayID, SizeID, QuantityInStock) " +
                                                  $"VALUES ({productId}, {colorwayId}, {sizeId}, 0)";
                    using MySqlCommand insertInventoryCommand = new(insertInventoryQuery, dbConnector.GetConnection());
                    _ = insertInventoryCommand.ExecuteNonQuery();
                }
                listBox3.Items.Clear();
                PopulateListBox3(selectedProduct);

                _ = MessageBox.Show("Colorway added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}






