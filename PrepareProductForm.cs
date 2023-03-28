using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_keeping_application
{
    public partial class PrepareProductForm : Form
    {
        SQLConnectionHandler connection;
        private readonly string _connectionString = $"Data Source={SettingsForm.DatabasePosition};Initial Catalog=stock_application_db;Integrated Security=True;\r\n";

        public PrepareProductForm()
        {
            InitializeComponent();
        }

        MainForm mainForm;
        public PrepareProductForm(Form callingFrom)
        {
            mainForm = callingFrom as MainForm;
            InitializeComponent();
        }

        public PrepareProductForm(Form callingFrom, string StockId)
        {
            mainForm = callingFrom as MainForm;
            Filter = StockId;
            InitializeComponent();
        }

        private void PrepareProductForm_Load(object sender, EventArgs e)
        {
            connection = new SQLConnectionHandler(_connectionString);
            StockGridData.DataSource = connection.ExecuteQuery("SELECT * FROM stock_table");
            StockIdTextBox.Text = Filter == null ? "" : Filter;
        }

        #region Grid Click
        private int selectedIndex = -1;
        private void StockGridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;

            Filter = StockGridData[1, selectedIndex].Value.ToString();

            StockIdTextBox.Text = Filter;
        }
        #endregion

        #region Textbox
        private string Filter;
        private void StockIdTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter = StockIdTextBox.Text;
        }

        private string Amount;
        private int DesiredAmount;
        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            Amount = AmountTextBox.Text;
            DesiredAmount = Convert.ToInt16(Amount);
        }
        #endregion

        #region Button
        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterData(Filter);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ProduceButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Filtering
        public void FilterData(string filter)
        {
            Console.WriteLine("Trirggered");
            if (filter == "" || filter == "*")
            {
                StockGridData.DataSource = connection.ExecuteQuery("SELECT * FROM stock_table");
            }
            StockGridData.DataSource = connection.ExecuteQuery($"SELECT * FROM stock_table WHERE STOCK_ID LIKE '%{Filter}%';");
            StockGridData.Update();
        }
        #endregion

        #region Calculating
        /// <summary>
        /// This function gets the amount data from the recipe table and then calculates the
        /// required amount and paints the table accordingly
        /// First we need to calculate the stock on tha main panel
        /// </summary>
        private void Calculate()
        {
            DataTable dataTable;
            dataTable = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{Filter}'");
            RequiredGridData.DataSource = dataTable;
            RequiredGridData.Update();
        }
        #endregion
    }
}
