using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            CheckForTables();
        }

        //// TODO:
        ////     Create a function for checking if the specified SQL connection has the required tables
        ////     If the tables are not provided create the required tables

        /// <summary>
        /// Checks if the database has the required tables, if there are any missing tables create them
        /// </summary>
        private void CheckForTables()
        {
            bool stock = false;
            bool amount = false;
            bool recipe = false;
            bool movement = false;
            DataTable dataTable = ExecuteQuery("SELECT TABLE_NAME\r\nFROM INFORMATION_SCHEMA.TABLES\r\nWHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='stock_application_db'");

            // check if the database is created

            Console.WriteLine("Checking if the required tables are provided");

            if (dataTable.Rows[0][0].ToString() == "recipe_table")
            {
                recipe = true;
                Console.WriteLine("Has recipe table");
            }
            else
            {
                OpenConnection();
                ExecuteQuery("USE [stock_application_db]\r\nGO\r\n\r\n/****** Object:  Table [dbo].[recipe_table]    Script Date: 3/27/2023 10:48:10 AM ******/\r\nSET ANSI_NULLS ON\r\nGO\r\n\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\n\r\nCREATE TABLE [dbo].[recipe_table](\r\n\t[ID] [int] IDENTITY(1,1) NOT NULL,\r\n\t[STOCK_ID] [nvarchar](50) NOT NULL,\r\n\t[RECIPE_ID] [nvarchar](50) NOT NULL,\r\n\t[ALT_RECIPE_ID] [nvarchar](50) NOT NULL,\r\n\t[AMOUNT] [int] NOT NULL,\r\n CONSTRAINT [PK_recipe_table] PRIMARY KEY CLUSTERED \r\n(\r\n\t[ID] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nGO\r\n\r\n");
                Console.WriteLine("Created recipe table");
            }

            if (dataTable.Rows[1][0].ToString() == "stock_table")
            {
                stock = true;
                Console.WriteLine("Has stock table");
            }
            else
            {
                OpenConnection();
                ExecuteQuery("USE [stock_application_db]\r\nGO\r\n\r\n/****** Object:  Table [dbo].[stock_table]    Script Date: 3/27/2023 10:48:53 AM ******/\r\nSET ANSI_NULLS ON\r\nGO\r\n\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\n\r\nCREATE TABLE [dbo].[stock_table](\r\n\t[ID] [int] IDENTITY(1,1) NOT NULL,\r\n\t[STOCK_ID] [nvarchar](50) NOT NULL,\r\n\t[COMPONENT_TYPE] [int] NULL,\r\n\t[NAME] [nvarchar](max) NOT NULL,\r\n\t[ACTIVE_COUNT] [int] NULL,\r\n\t[TOTAL_COUNT] [int] NULL,\r\n\t[AMOUNT] [int] NULL,\r\n\t[TOTAL_PRICE] [money] NULL,\r\n\t[DESCRIPTION] [nvarchar](max) NULL,\r\n CONSTRAINT [PK_stock_table] PRIMARY KEY CLUSTERED \r\n(\r\n\t[ID] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nGO\r\n\r\nALTER TABLE [dbo].[stock_table] ADD  CONSTRAINT [DF_stock_table_COMPONENT_TYPE_1]  DEFAULT ((0)) FOR [COMPONENT_TYPE]\r\nGO\r\n\r\nALTER TABLE [dbo].[stock_table] ADD  CONSTRAINT [DF_stock_table_ACTIVE_COUNT]  DEFAULT ((0)) FOR [ACTIVE_COUNT]\r\nGO\r\n\r\nALTER TABLE [dbo].[stock_table] ADD  CONSTRAINT [DF_stock_table_TOTAL_COUNT]  DEFAULT ((0)) FOR [TOTAL_COUNT]\r\nGO\r\n\r\nALTER TABLE [dbo].[stock_table] ADD  CONSTRAINT [DF_stock_table_AMOUNT]  DEFAULT ((0)) FOR [AMOUNT]\r\nGO\r\n\r\n");
                Console.WriteLine("Created stock table");
            }

            if (dataTable.Rows[2][0].ToString() == "amount_table")
            {
                amount = true;
                Console.WriteLine("Has amount table");
            }
            else
            {
                OpenConnection();
                ExecuteQuery("USE [stock_application_db]\r\nGO\r\n\r\n/****** Object:  Table [dbo].[amount_table]    Script Date: 3/27/2023 10:49:10 AM ******/\r\nSET ANSI_NULLS ON\r\nGO\r\n\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\n\r\nCREATE TABLE [dbo].[amount_table](\r\n\t[ID] [int] IDENTITY(1,1) NOT NULL,\r\n\t[STOCK_ID] [nvarchar](50) NOT NULL,\r\n\t[STOCK_POSITION] [int] NOT NULL,\r\n\t[UNIT_PRICE] [money] NULL,\r\n\t[TOTAL_PRICE] [money] NULL,\r\n\t[STOCK_AMOUNT] [int] NULL,\r\n\t[CURRENT_AMOUNT] [int] NOT NULL,\r\n\t[MAXIMUM_COUNT] [int] NULL,\r\n\t[DESCRIPTION] [nvarchar](max) NULL,\r\n CONSTRAINT [PK_amount_table] PRIMARY KEY CLUSTERED \r\n(\r\n\t[ID] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nGO\r\n\r\n");
                Console.WriteLine("Created amount table");
            }

            if (dataTable.Rows[3][0].ToString() == "movement_table")
            {
                movement = true;
                Console.WriteLine("Has movement table");
            }
            else
            {
                OpenConnection();
                ExecuteQuery("USE [stock_application_db]\r\nGO\r\n\r\n/****** Object:  Table [dbo].[movement_table]    Script Date: 3/27/2023 10:49:24 AM ******/\r\nSET ANSI_NULLS ON\r\nGO\r\n\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\n\r\nCREATE TABLE [dbo].[movement_table](\r\n\t[ID] [int] IDENTITY(1,1) NOT NULL,\r\n\t[STOCK_ID] [nvarchar](50) NOT NULL,\r\n\t[MOVE_FROM] [int] NOT NULL,\r\n\t[MOVE_TO] [int] NOT NULL,\r\n\t[AMOUNT] [int] NOT NULL,\r\n\t[DATE] [date] NULL,\r\n\t[DESCRIPTION] [nvarchar](max) NULL\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nGO\r\n\r\n");
                Console.WriteLine("Created movement table");
            }
        }

        /// <summary>
        /// Opens the connection with sql for querries
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(_connectionString);
                connection.Open();
                Console.Write("Connection opened ");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Execute the specified query and return the result as a DataTable
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    OpenConnection();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    CloseConnection();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        /// <summary>
        /// Execute the query and return the number of rows affected
        /// </summary>
        /// <param name="query">SQL Query</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query)
        {
            DataTable datatTable = ExecuteQuery(query);
            return datatTable.Rows.Count;
        }

        public string ExecuteSingleQuery(string query)
        {
            DataTable dataTable = ExecuteQuery(query);
            return dataTable.Rows[0][0].ToString();
        }

        /// <summary>
        /// Updates the stock of the specified stockId with the specified value
        /// </summary>
        /// <param name="stockId">Stock id of the material</param>
        /// <param name="newValue">new value</param>
        public void UpdateStock(string stockId, string newValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    OpenConnection();
                    using (SqlCommand command = new SqlCommand("UPDATE stock_table SET myColumn = @NewValue WHERE STOCK_ID = @StockId", connection))
                    {
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@StockId", stockId);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Close the connection
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("and closed successfully!");
            }
            catch(SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
