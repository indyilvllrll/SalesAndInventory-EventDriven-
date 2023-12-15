using MySql.Data.MySqlClient;
using System.Data;


namespace SalesAndInventory
{
    public partial class inventory : Form
    {
        private MySqlConnection? connection;
        private string? server, database, uid, password;
        private string? connectionString;
        private Form currentForm;
        public inventory()
        {
            InitializeComponent();
            Initialize();
            InitializeDatabaseConnection();
            LoadData();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "shoessalesandinventory1";
            uid = "shoessalesandinventory";
            password = "z7FP[-6kc@ErCAnI";

            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            // Initialize the currentForm with the initial form 
            currentForm = this;
            currentForm.Show();

        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void LoadData()
        {
            if (connection is null || connection.State != ConnectionState.Open)
            {
                _ = MessageBox.Show("Database connection is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            try
            {
                using MySqlCommand command = new(query, connection);
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














    }
}