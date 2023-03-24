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

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLConnectionHandler("Data Source=BURAKASUSROG\\ZRV2014EXP;Initial Catalog=stock_application_db;Integrated Security=True;\r\n");
            connection.FillDataTable("stock_table", StockDataGrid);
        }

        #region Buttons
        private void AddNewButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateSelectedButton_Click(object sender, EventArgs e)
        {

        }

        private void GetAmountDataButton_Click(object sender, EventArgs e)
        {

        }

        private void EditRecipeButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTableButton_Click_1(object sender, EventArgs e)
        {

        }
        #endregion

        #region TextBoxes
        private void StockIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void StockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
