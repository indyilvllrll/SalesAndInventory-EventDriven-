using MySql.Data.MySqlClient;
using System.Data;

namespace SalesAndInventory
{


    public class DatabaseConnector
    {
        private MySqlConnection connection;
        private readonly string server, database, uid, password;

        public DatabaseConnector(string server, string database, string uid, string password)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;

            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public T ExecuteQueryScalar<T>(string query)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                OpenConnection();

                object result = command.ExecuteScalar();

                CloseConnection();

                // Convert the result to the specified type
                return (result != null && result != DBNull.Value) ? (T)result : default(T);
            }
        }

        public void ExecuteQuery(string query)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
        // New methods for parameterized queries

        public T ExecuteParameterizedQueryScalar<T>(string query, Dictionary<string, object> parameters)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                OpenConnection();

                // Add parameters to the command
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                    }
                }

                object result = command.ExecuteScalar();

                CloseConnection();

                // Convert the result to the specified type
                return Convert.IsDBNull(result) ? default(T) : (T)result;
            }
        }


        public void ExecuteParameterizedQuery(string query, Dictionary<string, object> parameters)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                OpenConnection();

                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                command.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void ExecuteParameterizedQueryY(string query, Dictionary<string, object> parameters)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                OpenConnection();

                // Add parameters to the command
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                command.ExecuteNonQuery();

                CloseConnection();
            }
        }


        public DataTable ExecuteQueryDataTable(string query)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                OpenConnection();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    CloseConnection();

                    return dataTable;
                }
            }
        }

    }
}
