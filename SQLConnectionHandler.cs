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

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return rowsAffected;
        }

        public void UpdateStock(string stockId, string newValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE stock_table SET myColumn = @NewValue WHERE STOCK_ID = @StockId", connection))
                    {
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@StockId", stockId);
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Rows affected: {rowsAffected}");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
