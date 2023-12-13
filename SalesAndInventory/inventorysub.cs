using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndInventory
{
    public partial class inventorysub : Form
    {
        private Form currentForm;
        private DatabaseConnector dbConnector;

        public inventorysub()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
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
            newForm.Location = this.Location;

            // Hide the current form
            currentForm.Hide();

            // Show the new form
            newForm.Show();

            // Update the currentForm reference
            currentForm = newForm;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();  // hide the login form
            inventory inventoryForm = new inventory();
            inventoryForm.Location = this.Location;
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
                using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                {
                    dbConnector.OpenConnection();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string selectedBrand = reader["Brand"].ToString();
                            comboBox1.Items.Add(selectedBrand);
                        }
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













        private void btnUpdateStocks_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items in the ListBox
            listBox1.Items.Clear();

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
            try
            {
                // Modify the query based on your database structure
                string query = $"SELECT ProductName FROM products_table WHERE Brand = '{selectedBrand}'";
                using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                {
                    dbConnector.OpenConnection();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            listBox1.Items.Add(productName);
                        }
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ListBox
            string selectedProduct = listBox1.SelectedItem?.ToString();

            // Update the shoesLabel with the selected product
            shoeslabel.Text = selectedProduct;

            // Populate the colorwayComboBox based on the selected product
            PopulateColorwayComboBox(selectedProduct);
        }



        private void PopulateColorwayComboBox(string selectedProduct)
        {
            try
            {
                // Modify the query based on your database structure
                string query = $"SELECT DISTINCT colorway.ColorwayName FROM inventory " +
                               $"JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                               $"JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                               $"WHERE products_table.ProductName = '{selectedProduct}';";

                using (MySqlCommand command = new MySqlCommand(query, dbConnector.GetConnection()))
                {
                    dbConnector.OpenConnection();
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }





}

