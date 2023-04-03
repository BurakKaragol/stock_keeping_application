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
            connection = new SQLConnectionHandler(SettingsForm.DatabaseConnectionString);
            if (filter)
            {
                FilterTextBox.Text = Filter;
                AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{Filter}%';");
            }
            else
            {
                AmountDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM amount_table");
            }
            StockPositionComboBox.DataSource = Enum.GetNames(typeof(StockPosition));
        }

        #region Buttons

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            connection.ExecuteQuery($"INSERT INTO amount_table(STOCK_ID, STOCK_POSITION, UNIT_PRICE, TOTAL_PRICE, STOCK_AMOUNT, CURRENT_AMOUNT, MAXIMUM_COUNT, DESCRIPTION)\r\nVALUES ('{StockId}', '{SelectedStock}', '{UnitPrice}', '{TotalPrice}', '{Amount}', '{CurrentStock}', '{TotalStock}', '{Description}');");
            AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{Filter}%';");
            AmountDataGrid.Update();
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            int found = connection.ExecuteNonQuery($"SELECT * FROM amount_table WHERE ID = '{uniqueId}';");
            if (found == 0)
            {
                MessageBox.Show($"STOCK_ID {StockId} cannot be found!", "Can't found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"DELETE FROM amount_table WHERE ID = '{uniqueId}';");
                AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{Filter}%';");
                AmountDataGrid.Update();
            }
        }

        private void UpdateSelectedButton_Click(object sender, EventArgs e)
        {
            int found = connection.ExecuteNonQuery($"SELECT * FROM amount_table WHERE ID = '{uniqueId}';");
            if (found == 0)
            {
                MessageBox.Show($"STOCK_ID {StockId} cannot be found!", "Can't found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_ID = '{StockId}', STOCK_POSITION = '{SelectedStock}', UNIT_PRICE = '{UnitPrice}', TOTAL_PRICE = '{TotalPrice}', STOCK_AMOUNT = '{Amount}', CURRENT_AMOUNT = '{CurrentStock}', MAXIMUM_COUNT = '{TotalStock}', DESCRIPTION = '{Description}'\r\nWHERE ID = '{uniqueId}';");
                AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{Filter}%';");
                AmountDataGrid.Update();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterData(Filter);
        }

        private void FilterStockButton_Click(object sender, EventArgs e)
        {
            FilterData("STOCK_POSITION", SelectedStock.ToString());
        }

        private void FilterBothButton_Click(object sender, EventArgs e)
        {
            FilterDataBoth(Filter, SelectedStock.ToString());
        }

        #region Price Calculation
        private void CalculateValueButton_Click(object sender, EventArgs e)
        {
            bool UnitNull = UnitPriceTextBox.Text == "";
            bool UnitZero = UnitPriceTextBox.Text == "0" || UnitPriceTextBox.Text == "0.0000";
            bool TotalNull = TotalPriceTextBox.Text == "";
            bool TotalZero = TotalPriceTextBox.Text == "0" || TotalPriceTextBox.Text == "0.0000";
            bool CurrentStockNull = CurrentStockTextBox.Text == "";
            bool CurrentStockZero = CurrentStockTextBox.Text == "0";
            bool TotalStockNull = TotalStockTextBox.Text == "";
            bool TotalStockZero = TotalStockTextBox.Text == "0";
            bool AmountNull = AmountTextBox.Text == "";
            bool AmountZero = AmountTextBox.Text == "0";

            if (CurrentStockNull || CurrentStockZero)
            {
                MessageBox.Show($"Please define CURRENT_STOCK", "Value null or zero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TotalStockNull || TotalStockZero)
            {
                MessageBox.Show($"Please define TOTAL_STOCK", "Value null or zero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (AmountNull || AmountZero)
            {
                MessageBox.Show($"Please define AMOUNT", "Value null or zero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int CurrentStock = int.Parse(CurrentStockTextBox.Text);
            int TotalStock = int.Parse(TotalStockTextBox.Text);
            int Amount = int.Parse(AmountTextBox.Text);

            if (UnitNull && TotalNull)
            {
                MessageBox.Show($"UNIT_PRICE or TOTAL_PRICE should not be empty", "Values null", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (UnitPriceTextBox.Text == "0" && TotalPriceTextBox.Text == "0")
            {
                MessageBox.Show($"Please define at least one UNIT_PRICE or TOTAL_PRICE", "Value zero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!(UnitNull || UnitZero) && (TotalNull || TotalZero))
            {
                float unitPrice = float.Parse(UnitPriceTextBox.Text);
                CalculateUsingUnit(CurrentStock, TotalStock, Amount, unitPrice);
            }
            else if (!(TotalNull || TotalZero) && (UnitNull || UnitZero))
            {
                float totalPrice = float.Parse(TotalPriceTextBox.Text);
                CalculateUsingTotal(CurrentStock, TotalStock, Amount, totalPrice);
            }
            else if (!(UnitNull || UnitZero) && !(TotalNull || TotalZero))
            {
                MessageBox.Show($"Please define only one UNIT_PRICE or TOTAL_PRICE", "Values collide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        // Calculate by using unit value
        public void CalculateUsingUnit(int current, int total, int amount, float price)
        {
            float unitPrice = current * price;
            TotalPriceTextBox.Text = unitPrice.ToString();
            float totalPrice = unitPrice * amount;
            connection.ExecuteNonQuery($"UPDATE stock_table\r\nSET TOTAL_PRICE = '{totalPrice}'\r\nWHERE STOCK_ID = '{StockId}';");
            CalculateTotalAmount();
        }

        // Calculate by using total value
        public void CalculateUsingTotal(int current, int total, int amount, float totalP)
        {
            float price = totalP / total;
            float unitPrice = current * price;
            UnitPriceTextBox.Text = unitPrice.ToString();
            float totalPrice = unitPrice * amount;
            connection.ExecuteNonQuery($"UPDATE stock_table\r\nSET TOTAL_PRICE = '{totalPrice}'\r\nWHERE STOCK_ID = '{StockId}';");
            CalculateTotalAmount();
        }

        // Calculate the total amount and set the stock values accordingly
        public void CalculateTotalAmount()
        {
            int row = AmountDataGrid.RowCount;
            int activeCount = 0;
            int totalCount = 0;
            DataTable table = AmountDataGrid.DataSource as DataTable;
            for (int i = 0; i < row; i++)
            {
                int total = Convert.ToInt16(table.Rows[i][5]) * Convert.ToInt16(table.Rows[i][6]);
                Console.WriteLine(table.Rows[i][2]);
                if (table.Rows[i][2].ToString() == "0")
                {
                    activeCount += total;
                }
                totalCount += total;
            }
            //connection.ExecuteNonQuery($"UPDATE stock_table\r\nSET ACTIVE_COUNT = '{activeCount}', TOTAL_COUNT = '{totalCount}'\r\nWHERE STOCK_ID = '{StockId}';");
            mainForm.UpdateAllTableValues();
        }
        #endregion

        private void UpdateTableButton_Click(object sender, EventArgs e)
        {
            AmountDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM amount_table");
            AmountDataGrid.Update();
        }
        #endregion

        private int SelectedStock;
        private void StockPositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStock = StockPositionComboBox.SelectedIndex;
        }

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
            if (selectedIndex == -1)
            {
                return;
            }
            //get the specified values
            //STOCK_ID 1
            //STOCK_POSITION 2
            //AMOUNT 5
            //CURRENT_STOCK 6
            //TOTAL_STOCK 7
            //UNIT_PRICE 3
            //TOTAL_PRICE 4
            //DESCRIPTION 8
            uniqueId = AmountDataGrid[0, selectedIndex].Value.ToString();
            StockId = AmountDataGrid[1, selectedIndex].Value.ToString();
            StockPositionComboBox.SelectedIndex = Convert.ToInt16(AmountDataGrid[2, selectedIndex].Value);
            StockPositionComboBox.Update();
            Amount = AmountDataGrid[5, selectedIndex].Value.ToString();
            CurrentStock = AmountDataGrid[6, selectedIndex].Value.ToString();
            TotalStock = AmountDataGrid[7, selectedIndex].Value.ToString();
            UnitPrice = AmountDataGrid[3, selectedIndex].Value.ToString();
            TotalPrice = AmountDataGrid[4, selectedIndex].Value.ToString();
            Description = AmountDataGrid[8, selectedIndex].Value.ToString();

            StockIdTextBox.Text = StockId;
            FilterTextBox.Text = StockId;
            Filter = StockId;
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
            if (filter == "" || filter == "*")
            {
                AmountDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM amount_table");
            }
            AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE {compareColumn} LIKE '%{filter}%';");
            AmountDataGrid.Update();
        }

        public void FilterDataBoth(string idFilter, string stockFilter)
        {
            if ((idFilter == "" || stockFilter == "*") || (stockFilter == "" || stockFilter == "*"))
            {
                AmountDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM amount_table");
            }
            AmountDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{idFilter}%' AND STOCK_POSITION = '{stockFilter}';");
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
