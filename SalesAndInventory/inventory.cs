using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;


namespace SalesAndInventory
{
    public partial class inventory : Form
    {

        private Form currentForm;
        private readonly DatabaseConnector dbConnector;
        public inventory()
        {
            dbConnector = new DatabaseConnector("localhost", "shoessalesandinventory1", "shoessalesandinventory", "z7FP[-6kc@ErCAnI");
            InitializeComponent();
            Initialize();
            LoadData();
            PopulateBrandComboBox();

        }

        private void Initialize()
        {

            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();

        }



        private void LoadData()
        {
            try
            {

                string query = @"
        SELECT
            inventory.InventoryID,
            products_table.ProductName,
            colorway.ColorwayName,
            sizes.ShoeSize,
            inventory.QuantityInStock
        FROM
            inventory
        JOIN
            products_table ON inventory.ProductID = products_table.ProductID
        JOIN
            colorway ON inventory.ColorwayID = colorway.ColorwayID
        JOIN
            sizes ON inventory.SizeID = sizes.SizeID;
    ";
                using MySqlCommand command = new(query, dbConnector.GetConnection());
                dbConnector.OpenConnection();

                using MySqlDataAdapter adapter = new(command);
                DataTable dataTable = new();
                _ = adapter.Fill(dataTable);


                // Auto-generate columns based on the DataTable
                dataGridView1.AutoGenerateColumns = true;

                // Set the DataSource directly to the DataTable
                dataGridView1.DataSource = dataTable;

                // Refresh the DataGridView
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void inventory_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateStocks_Click(object sender, EventArgs e)
        {
            Hide();  // hide the login form
            inventorysub inventorysubForm = new()
            {
                Location = Location
            };
            inventorysubForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchForm(new products());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();

        }

        private void UpdateDataGridView()
        {
            string selectedProductName = listBox1.Text;
            string selectedColorway = listBox2.Text;

            string strSQL = $"SELECT * FROM inventory " +
                            $"JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                            $"JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                            $"JOIN sizes ON inventory.SizeID = sizes.SizeID " +
                            $"WHERE products_table.ProductName = '{selectedProductName}' " +
                            $"AND colorway.ColorwayName = '{selectedColorway}'";

            DataTable dataTable = dbConnector.ExecuteQueryDataTable(strSQL);

            dataGridView1.DataSource = dataTable;
        }
        private void PopulateBrandComboBox()
        {
            string strSQL = "SELECT DISTINCT Brand FROM products_table";
            DataTable dataTable = dbConnector.ExecuteQueryDataTable(strSQL);

            brandcmb.DataSource = dataTable;
            brandcmb.DisplayMember = "Brand";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = listBox1.Text;

            // Populate listbox2 with ColorwayName based on the selected product name
            PopulateColorwayListBox(selectedProductName);
        }


        private void PopulateColorwayListBox(string selectedProductName)
        {
            string strSQL = $"SELECT DISTINCT colorway.ColorwayName " +
                            $"FROM inventory " +
                            $"JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                            $"JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                            $"JOIN sizes ON inventory.SizeID = sizes.SizeID " +
                            $"WHERE products_table.ProductName = '{selectedProductName}'";

            DataTable dataTable = dbConnector.ExecuteQueryDataTable(strSQL);

            listBox2.DataSource = dataTable;
            listBox2.DisplayMember = "ColorwayName";
        }

        private void brandcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = brandcmb.Text;

            // Populate listbox1 with ProductName based on the selected brand
            PopulateProductNameListBox(selectedBrand);
        }

        private void PopulateProductNameListBox(string selectedBrand)
        {
            string strSQL = $"SELECT DISTINCT products_table.ProductName " +
                            $"FROM inventory " +
                            $"JOIN products_table ON inventory.ProductID = products_table.ProductID " +
                            $"JOIN colorway ON inventory.ColorwayID = colorway.ColorwayID " +
                            $"JOIN sizes ON inventory.SizeID = sizes.SizeID " +
                            $"WHERE products_table.Brand = '{selectedBrand}'";

            DataTable dataTable = dbConnector.ExecuteQueryDataTable(strSQL);

            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = "ProductName";
        }











    }
}