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
        // merhabalar efendim öncelikle hoşgeldiniz
        // bu uygulamanın geliştirme sürecinin ikimiz adına da keyifli bir deneyim olmasını temenni ediyorum.
        // iyi çalışmalar (. ❛ ᴗ ❛.)

        SQLConnectionHandler connection;
        private readonly string _connectionString = "Data Source=BURAKASUSROG\\ZRV2014EXP;Initial Catalog=stock_application_db;Integrated Security=True;\r\n";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLConnectionHandler(_connectionString);
            StockDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM stock_table");
        }

        #region Buttons
        // Add a new material to the list
        private void AddNewButton_Click(object sender, EventArgs e)
        {

        }

        // Delete the selected material from the list
        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {

        }

        // Update the selected material
        private void UpdateSelectedButton_Click(object sender, EventArgs e)
        {

        }

        // Open AmountControlForm
        private void GetAmountDataButton_Click(object sender, EventArgs e)
        {
            Form amountControlForm = new AmountControlForm(this, StockId);
            amountControlForm.ShowDialog();
        }

        // Edit the recipe of the selected material
        private void EditRecipeButton_Click(object sender, EventArgs e)
        {

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

        }

        /// <summary>
        /// Open another window for producing a part
        /// Window Jobs:
        ///     - Select a material and produce specified amount.
        ///     - If the material has a recipe use the recipe for removing stock
        /// </summary>
        private void ProducePartButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Open another window for general settings
        /// Window jobs:
        ///     - Active crurency value
        ///     - Sql connection string
        /// </summary>
        private void SettingsButton_Click(object sender, EventArgs e)
        {

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
    }
}
