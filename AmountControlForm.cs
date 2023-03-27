using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stock_keeping_application
{
    public partial class AmountControlForm : Form
    {

        SQLConnectionHandler connection;
        private readonly string _connectionString = "Data Source=BURAKASUSROG\\ZRV2014EXP;Initial Catalog=stock_application_db;Integrated Security=True;\r\n";

        public AmountControlForm()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public AmountControlForm(Form callingFrom)
        {
            mainForm = callingFrom as MainForm;
            InitializeComponent();
        }

        private bool filter = false;
        public AmountControlForm(Form callingFrom, string filter)
        {
            mainForm = callingFrom as MainForm;
            Filter = filter;
            this.filter = true;
            InitializeComponent();
        }

        private void AmountControlForm_Load(object sender, EventArgs e)
        {
            connection = new SQLConnectionHandler(_connectionString);
            if (filter)
            {
                FilterTextBox.Text = Filter;
                AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{Filter}%';");
            }
            else
            {
                AmountDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM amount_table");
            }
        }

        #region Buttons
        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterData(Filter);
        }
        #endregion

        #region Data Grid Functions
        private int selectedIndex = 0;
        private string uniqueId;
        private string StockId;
        private string Amount;
        private string CurrentStock;
        private string TotalStock;
        private string UnitPrice;
        private string TotalPrice;
        private string Description;
        private void AmountDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
            //get the specified values
            //STOCK_ID 1
            //AMOUNT 5
            //CURRENT_STOCK 6
            //TOTAL_STOCK 7
            //UNIT_PRICE 3
            //TOTAL_PRICE 4
            //DESCRIPTION 8
            uniqueId = AmountDataGrid[0, selectedIndex].Value.ToString();
            StockId = AmountDataGrid[1, selectedIndex].Value.ToString();
            Amount = AmountDataGrid[5, selectedIndex].Value.ToString();
            CurrentStock = AmountDataGrid[6, selectedIndex].Value.ToString();
            TotalStock = AmountDataGrid[7, selectedIndex].Value.ToString();
            UnitPrice = AmountDataGrid[3, selectedIndex].Value.ToString();
            TotalPrice = AmountDataGrid[4, selectedIndex].Value.ToString();
            Description = AmountDataGrid[8, selectedIndex].Value.ToString();

            StockIdTextBox.Text = StockId;
            AmountTextBox.Text = Amount;
            CurrentStockTextBox.Text = CurrentStock;
            TotalStockTextBox.Text = TotalStock;
            UnitPriceTextBox.Text = UnitPrice;
            TotalPriceTextBox.Text = TotalPrice;
            DescriptionTextBox.Text = Description;
        }
        #endregion

        #region TextBoxes
        private void StockIdTextBox_TextChanged(object sender, EventArgs e)
        {
            StockId = StockIdTextBox.Text;
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            Amount = AmountTextBox.Text;
        }

        private void CurrentStockTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentStock = CurrentStockTextBox.Text;
        }

        private void TotalStockTextBox_TextChanged(object sender, EventArgs e)
        {
            TotalStock = TotalStockTextBox.Text;
        }

        private void UnitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            UnitPrice = UnitPriceTextBox.Text;
        }

        private void TotalPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            TotalPrice = TotalPriceTextBox.Text;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Description = DescriptionTextBox.Text;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter = FilterTextBox.Text;
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
            if (filter == "" || filter == "*")
            {
                AmountDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM amount_table");
            }
            AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE {compareColumn} LIKE '%{Filter}%';");
            AmountDataGrid.Update();
        }

        private void FilterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterData(Filter);
            }
        }
        #endregion
    }
}
