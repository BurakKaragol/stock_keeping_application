using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_keeping_application
{
    internal class SQLConnectionHandler
    {
        private readonly string _connectionString;
        private SqlConnection connection;

        public SQLConnectionHandler(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(_connectionString);
                connection.Open();
                Console.WriteLine("Connection opened successfully!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void FillDataTable(string tableName, DataGridView grid)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM stock_table");
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                grid.DataSource = dataTable;
                connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection cloased successfully!");
            }
            catch(SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
