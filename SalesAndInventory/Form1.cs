using MySql.Data.MySqlClient;

namespace SalesAndInventory
{
    public partial class Form1 : Form
    {
        private MySqlConnection? connection;
        private string? server, database, uid, password;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "shoessalesandinventory1";
            uid = "shoessalesandinventory";
            password = "z7FP[-6kc@ErCAnI";

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
            pw_tb.UseSystemPasswordChar = true;
            pw_tb.PasswordChar = '*';
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = un_tb.Text;
            string password = pw_tb.Text;

            Form1 db = new();

            if (db.OpenConnection())
            {
                string query = $"SELECT * FROM login_credentials WHERE username='{username}' AND password='{password}'";
                MySqlCommand cmd = new(query, db.GetConnection());

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    // Credentials are correct, close the current form and open the dashboard form
                    dataReader.Close();
                    _ = db.CloseConnection();

                    Hide();  // hide the login form
                    dashboard inventory = new();
                    inventory.Show();
                }
                else
                {
                    _ = MessageBox.Show("Invalid Credentials. Please try again.");
                }

                _ = db.CloseConnection();
            }
        }

        private void pw_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }





}
