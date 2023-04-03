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
    public partial class MoveStockForm : Form
    {
        SQLConnectionHandler connection;

        public MoveStockForm()
        {
            InitializeComponent();
        }

        MainForm mainForm;
        public MoveStockForm(Form calledFrom)
        {
            mainForm = calledFrom as MainForm;
            InitializeComponent();
        }

        string Filter = "";
        public MoveStockForm(Form calledFrom, string StockId)
        {
            mainForm = calledFrom as MainForm;
            Filter = StockId;
            InitializeComponent();
        }

        private void MoveStockForm_Load(object sender, EventArgs e)
        {
            connection = new SQLConnectionHandler(SettingsForm.DatabaseConnectionString);
            LeftComboBox.DataSource = Enum.GetNames(typeof(StockPosition));
            RightComboBox.DataSource = Enum.GetNames(typeof(StockPosition));
            if (Filter == "" || Filter == "*")
            {
                FilterDataLeft(LeftSelectedStock.ToString());
                FilterDataRight(RightSelectedStock.ToString());
            }
            else
            {
                FilterDatas(Filter);
            }
        }

        #region Grid Selection
        private int leftSelectedIndex = 0;
        private string leftStockId;
        private string leftId;
        private void LeftStockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            leftSelectedIndex = e.RowIndex;
            if (leftSelectedIndex == -1)
            {
                return;
            }

            leftStockId = LeftStockDataGrid[1, leftSelectedIndex].Value.ToString();
            leftId = LeftStockDataGrid[0, leftSelectedIndex].Value.ToString();
            StockIdTextBox.Text = leftStockId;
            FilterStockId = leftStockId;
        }

        private int rightSelectedIndex = 0;
        private string rightStockId;
        private string rightId;
        private void RightStockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rightSelectedIndex = e.RowIndex;
            if (rightSelectedIndex == -1)
            {
                return;
            }

            rightStockId = RightStockDataGrid[1, rightSelectedIndex].Value.ToString();
            rightId = LeftStockDataGrid[0, rightSelectedIndex].Value.ToString();
            StockIdTextBox.Text = rightStockId;
            FilterStockId = rightStockId;
        }
        #endregion

        #region ComboBox
        private int LeftSelectedStock = 0;
        private void LeftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeftSelectedStock = LeftComboBox.SelectedIndex;
            FilterDatas(FilterStockId);
        }

        private int RightSelectedStock = 0;
        private void RightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RightSelectedStock = RightComboBox.SelectedIndex;
            FilterDatas(FilterStockId);
        }
        #endregion

        #region Filtering
        private void FilterDataLeft(string leftStock)
        {
            LeftStockDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_POSITION = '{leftStock}';");
        }

        private void FilterDataRight(string rightStock)
        {
            RightStockDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_POSITION = '{rightStock}';");
        }

        private void FilterDatas(string filter)
        {
            LeftStockDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{filter}%' AND STOCK_POSITION = '{LeftSelectedStock}';");
            RightStockDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{filter}%' AND STOCK_POSITION = '{RightSelectedStock}';");
        }
        #endregion

        private void MoveStockForm_Resize(object sender, EventArgs e)
        {
            MiddlePanel.Width = 120;
            MiddlePanel.Location = new Point((ActiveForm.Width / 2) - 60, 0);
            LeftStockDataGrid.Location = new Point(0, 0);
            LeftStockDataGrid.Width = (ActiveForm.Width / 2) - 60;
            RightStockDataGrid.Location = new Point((ActiveForm.Width / 2) + 60, 0);
            RightStockLabel.Location = new Point((ActiveForm.Width / 2) + 60, 6);
            RightComboBox.Location = new Point((ActiveForm.Width / 2) + 100, 3);
            RightStockDataGrid.Width = (ActiveForm.Width / 2) - 60;
        }

        private string FilterStockId;
        private void StockIdTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterStockId = StockIdTextBox.Text;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterDatas(FilterStockId);
        }

        #region Move Logic Algorithm
        private int MoveAmount;
        private void MoveAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            MoveAmount = Convert.ToInt32(MoveAmountTextBox.Text);
        }

        private void MoveAmountButton_Click(object sender, EventArgs e)
        {

        }

        private void MoveAmountBack_Click(object sender, EventArgs e)
        {

        }

        private void MoveSelectedButton_Click(object sender, EventArgs e)
        {

        }

        private void MoveSelectedBackButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
