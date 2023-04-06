using stock_keeping_application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_keeping_application
{
    public partial class MainForm : Form
    {
        SQLConnectionHandler connection;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ReloadGrid()
        {
            DataTable dataTable = connection.ExecuteQuery("SELECT * FROM stock_table");
            StockDataGrid.DataSource = dataTable;
            StockDataGrid.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLConnectionHandler(SettingsForm.DatabaseConnectionString);
            ReloadGrid();
        }

        #region Buttons
        // Add a new material to the list
        private void AddNewButton_Click(object sender, EventArgs e)
        {
            if (StockId.NullOrEmpty())
            {
                MessageBox.Show($"STOCK_ID cannot be null!", "STOCKID Null or Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int found = connection.ExecuteNonQuery($"SELECT * FROM stock_table WHERE STOCK_ID = '{StockId}';");
            if (found != 0)
            {
                MessageBox.Show($"STOCK_ID {StockId} Already exists!", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"INSERT INTO stock_table(STOCK_ID, COMPONENT_TYPE, NAME, DESCRIPTION)\r\nVALUES ('{StockId}', '0', '{Name}', '{Description}');");
                ReloadGrid();
            }
        }

        // Delete the selected material from the list
        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            int found = connection.ExecuteNonQuery($"SELECT * FROM stock_table WHERE STOCK_ID = '{StockId}';");
            if (found == 0)
            {
                MessageBox.Show($"STOCK_ID {StockId} cannot be found!", "Can't found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"DELETE FROM stock_table WHERE STOCK_ID = '{StockId}';");
                ReloadGrid();
            }
        }

        // Update the selected material
        private void UpdateSelectedButton_Click(object sender, EventArgs e)
        {
            int found = connection.ExecuteNonQuery($"SELECT * FROM stock_table WHERE STOCK_ID = '{StockId}';");
            if (found == 0)
            {
                MessageBox.Show($"STOCK_ID {StockId} cannot be found!", "Can't found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"UPDATE stock_table\r\nSET STOCK_ID = '{StockId}', NAME = '{Name}', DESCRIPTION = '{Description}'\r\nWHERE STOCK_ID = '{StockId}';");
                ReloadGrid();
            }
        }

        // Open AmountControlForm
        private void GetAmountDataButton_Click(object sender, EventArgs e)
        {
            Form amountControlForm;
            if (selectedIndex != -1 && StockId != null)
            {
                amountControlForm = new AmountControlForm(this, StockId);
            }
            else
            {
                amountControlForm = new AmountControlForm(this);
            }
            amountControlForm.ShowDialog();
        }

        // Edit the recipe of the selected material
        private void EditRecipeButton_Click(object sender, EventArgs e)
        {
            Form recipeControlForm;
            if (selectedIndex != -1 && StockId != null)
            {
                recipeControlForm = new RecipeControlForm(this, StockId);
                recipeControlForm.ShowDialog();
            }
            else
            {
                MessageBox.Show($"You need to select a material for editing the recipe", "No material selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Update the Table
        private void UpdateTableButton_Click(object sender, EventArgs e)
        {
            UpdateAllTableValues();
            ReloadGrid();
        }

        // Recalculate the amount value based on the stock data
        public void UpdateAllTableValues()
        {
            DataTable stockDataTable = connection.ExecuteQuery("SELECT * FROM stock_table");

            for (int i = 0; i < stockDataTable.Rows.Count; i++)
            {
                string StockId = stockDataTable.Rows[i][1].ToString();
                DataTable amountDataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID = '{StockId}';");
                if (amountDataTable.Rows.Count == 0)
                {
                    connection.ExecuteNonQuery($"UPDATE stock_table\r\nSET ACTIVE_COUNT = '0', TOTAL_COUNT = '0'\r\nWHERE STOCK_ID = '{StockId}';");
                }
                else
                {
                    int active = 0;
                    int total = 0;
                    float price = 0f;
                    for (int j = 0; j < amountDataTable.Rows.Count; j++)
                    {
                        string stockPos = amountDataTable.Rows[j][2].ToString();
                        Console.WriteLine("--------------------------");
                        int stockCount = Convert.ToInt32(amountDataTable.Rows[j][5]);
                        Console.WriteLine($"Stock count: {stockCount}");
                        int stockAmount = Convert.ToInt32(amountDataTable.Rows[j][6]);
                        Console.WriteLine($"Stock amount: {stockAmount}");
                        if (stockPos == "0")
                        {
                            active += stockCount * stockAmount;
                            Console.WriteLine($"Active stock added: {active}");
                        }
                        else
                        {
                            total += stockCount * stockAmount;
                            Console.WriteLine($"Total stock added: {total}");
                        }
                    }
                    Console.WriteLine($"Active stock calculated: {active}");
                    Console.WriteLine($"Total stock calculated: {total}");
                    connection.ExecuteNonQuery($"UPDATE stock_table\r\nSET ACTIVE_COUNT = '{active}', TOTAL_COUNT = '{total}'\r\nWHERE STOCK_ID = '{StockId}';");
                }
            }
        }

        /// <summary>
        /// Open another window for selecting a material and making stock querries
        /// Window Jobs:
        ///     - Select a material and define a required value
        ///     - Calculate the maksimum amount we can produce with current stock
        ///     - Calculate the missing parts for producing the selected part
        ///     - Price calculation for all of the jobs above
        /// </summary>
        private void PrepareProductListButton_Click(object sender, EventArgs e)
        {
            Form prepareProductForm;
            if (selectedIndex != -1 && StockId != null)
            {
                prepareProductForm = new PrepareProductForm(this, StockId);
            }
            else
            {
                prepareProductForm = new PrepareProductForm(this);
            }
            prepareProductForm.ShowDialog();
        }

        /// <summary>
        /// Open another window for moving the current stock from one store to another
        /// Window Jobs:
        ///     - Show the material's total stock
        ///     - Show the material's stock positions
        ///     - Select amount to move to another stock
        /// </summary>
        private void MoveStockButton_Click(object sender, EventArgs e)
        {
            Form moveStockForm;
            if (selectedIndex != -1 && StockId != null)
            {
                moveStockForm = new MoveStockForm(this, StockId);
            }
            else
            {
                moveStockForm = new MoveStockForm(this);
            }
            moveStockForm.ShowDialog();
        }

        /// <summary>
        /// Open another window for producing a part
        /// Window Jobs:
        ///     - Select a material and produce specified amount.
        ///     - If the material has a recipe use the recipe for removing stock
        /// </summary>
        private void ProducePartButton_Click(object sender, EventArgs e)
        {
            Form producePartForm;
            producePartForm = new ProducePartForm();
            producePartForm.ShowDialog();
        }

        /// <summary>
        /// All movement, oreders and production history are saved under here
        /// Window Jobs:
        ///     - The history is going to be stacked as a enum type
        /// </summary>
        private void MovementHistoryButton_Click(object sender, EventArgs e)
        {
            Form movementHistoryForm;
            movementHistoryForm = new MovementHistoryForm();
            movementHistoryForm.ShowDialog();
        }

        /// <summary>
        /// Open another window for general settings
        /// Window jobs:
        ///     - Active crurency value
        ///     - Sql connection string
        /// </summary>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form settingsForm;
            settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
        #endregion

        #region Data Grid Functions
        private int selectedIndex = 0;
        private string StockId;
        private string Name;
        private string Description;
        private void StockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
            if (selectedIndex == -1)
            {
                return;
            }
            //get the specified values
            //STOCK_ID 1
            //NAME 3
            //DESCRIPTION 8
            StockId = StockDataGrid[1, selectedIndex].Value.ToString();
            Name = StockDataGrid[3, selectedIndex].Value.ToString();
            Description = StockDataGrid[8, selectedIndex].Value.ToString();

            StockIdTextBox.Text = StockId;
            NameTextBox.Text = Name;
            DescriptionTextBox.Text = Description;
        }
        #endregion

        #region TextBoxes
        private void StockIdTextBox_TextChanged(object sender, EventArgs e)
        {
            StockId = StockIdTextBox.Text;
            Filter = StockId;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Name = NameTextBox.Text;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Description = DescriptionTextBox.Text;
        }
        #endregion

        #region Filtering
        private string Filter;
        /// <summary>
        /// This function is used for generating a filtered data grid
        /// We can both do this using sql querries or using datatables
        /// </summary>
        /// <param name="filter">seraching filter</param>
        public void FilterData(string filter)
        {
            FilterData("STOCK_ID", filter);
        }

        /// <summary>
        /// This function is used for generating a filtered data grid
        /// We can both do this using sql querries or using datatables
        /// </summary>
        /// <param name="filter">seraching filter</param>
        public void FilterData(string compareColumn, string filter)
        {
            Console.WriteLine("Trirggered");
            if (filter.NullOrEmpty())
            {
                StockDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM stock_table");
            }
            ReloadGrid();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterData(Filter);
        }
        #endregion
    }
}
