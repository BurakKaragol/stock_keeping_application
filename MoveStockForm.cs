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
            if (Filter.NullOrEmpty())
            {
                FilterDataLeft(leftSelectedStock.ToString());
                FilterDataRight(rightSelectedStock.ToString());
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
        private string leftUnitPrice;
        private string leftTotalPrice;
        private int leftAmount;
        private int leftCurrent;
        private int leftTotal;
        private void LeftStockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            leftSelectedIndex = e.RowIndex;
            if (leftSelectedIndex == -1)
            {
                return;
            }
            leftStockId = LeftStockDataGrid[1, leftSelectedIndex].Value.ToString();
            leftId = LeftStockDataGrid[0, leftSelectedIndex].Value.ToString();
            leftUnitPrice = LeftStockDataGrid[3, leftSelectedIndex].Value.ToString();
            leftTotalPrice = LeftStockDataGrid[4, leftSelectedIndex].Value.ToString();
            leftAmount = Convert.ToInt32(LeftStockDataGrid[5, leftSelectedIndex].Value);
            leftCurrent = Convert.ToInt32(LeftStockDataGrid[6, leftSelectedIndex].Value);
            leftTotal = Convert.ToInt32(LeftStockDataGrid[7, leftSelectedIndex].Value);
            Console.WriteLine($"\nLeft Selected\n----\namount: {leftAmount}\ncurrent: {leftCurrent}\ntotasl: {leftTotal}");
            StockIdTextBox.Text = leftStockId;
            FilterStockId = leftStockId;
        }

        private int rightSelectedIndex = 0;
        private string rightStockId;
        private string rightId;
        private string rightUnitPrice;
        private string rightTotalPrice;
        private int rightAmount;
        private int rightCurrent;
        private int rightTotal;
        private void RightStockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rightSelectedIndex = e.RowIndex;
            if (rightSelectedIndex == -1)
            {
                return;
            }

            rightStockId = RightStockDataGrid[1, rightSelectedIndex].Value.ToString();
            rightId = RightStockDataGrid[0, rightSelectedIndex].Value.ToString();
            rightUnitPrice = RightStockDataGrid[3, rightSelectedIndex].Value.ToString();
            rightTotalPrice = RightStockDataGrid[4, rightSelectedIndex].Value.ToString();
            rightAmount = Convert.ToInt32(RightStockDataGrid[5, rightSelectedIndex].Value);
            rightCurrent = Convert.ToInt32(RightStockDataGrid[6, rightSelectedIndex].Value);
            rightTotal = Convert.ToInt32(RightStockDataGrid[7, rightSelectedIndex].Value);
            Console.WriteLine($"\nRight Selected\n----\namount: {rightAmount}\ncurrent: {rightCurrent}\ntotasl: {rightTotal}");
            StockIdTextBox.Text = rightStockId;
            FilterStockId = rightStockId;
        }
        #endregion

        #region ComboBox
        private int leftSelectedStock = 0;
        private void LeftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftSelectedStock = LeftComboBox.SelectedIndex;
            FilterDatas(FilterStockId);
        }

        private int rightSelectedStock = 0;
        private void RightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightSelectedStock = RightComboBox.SelectedIndex;
            FilterDatas(FilterStockId);
        }
        #endregion

        #region Filtering
        private void FilterDataLeft(string leftStock)
        {
            DataTable dataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_POSITION = '{leftStock}';");
            LeftStockDataGrid.DataSource = dataTable;
        }

        private void FilterDataRight(string rightStock)
        {
            DataTable dataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_POSITION = '{rightStock}';");
            RightStockDataGrid.DataSource = dataTable;
        }

        private void FilterDatas(string filter)
        {
            DataTable leftDataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{filter}%' AND STOCK_POSITION = '{leftSelectedStock}';");
            LeftStockDataGrid.DataSource = leftDataTable;
            DataTable rightDataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{filter}%' AND STOCK_POSITION = '{rightSelectedStock}';");
            RightStockDataGrid.DataSource = rightDataTable;
        }
        #endregion

        // For resızıng the form and keepıng the wındow form
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
        private int moveAmount;
        private void MoveAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            moveAmount = Convert.ToInt32(MoveAmountTextBox.Text);
        }

        /// <summary>
        /// Move The selected amount of stock from the left to the right
        /// Before moving should check if the value already exist on the other position
        /// if so should add to it
        /// and if not create a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveAmountButton_Click(object sender, EventArgs e)
        {
            DataTable found = connection.ExecuteQuery($"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{leftStockId}'\r\nAND STOCK_POSITION = '{rightSelectedStock}'\r\nAND CURRENT_AMOUNT = '{leftCurrent}'\r\nAND MAXIMUM_COUNT = '{leftTotal}';");
            // if found add to the amount
            if (found.Rows.Count > 0)
            {
                string foundId = found.Rows[0][0].ToString();
                int newAmount = Convert.ToInt32(found.Rows[0][5]);
                if (moveAmount <= leftAmount)
                {
                    newAmount += moveAmount;
                }
                else
                {
                    MessageBox.Show("Amount you want to move is bigger than the stock amount", "Amount bigger than stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{newAmount}'\r\nWHERE ID = '{foundId}';");
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{leftAmount - moveAmount}'\r\nWHERE ID = '{leftId}';");
                leftAmount -= moveAmount;
            }
            else // else change the stock position of the selected
            {
                if (moveAmount <= leftAmount)
                {
                    connection.ExecuteQuery($"INSERT INTO amount_table (STOCK_ID, STOCK_POSITION, UNIT_PRICE, TOTAL_PRICE, STOCK_AMOUNT, CURRENT_AMOUNT, MAXIMUM_COUNT)\r\nVALUES ('{leftStockId}', '{rightSelectedStock}', '{leftUnitPrice}', '{leftTotalPrice}', '{moveAmount}', '{leftCurrent}', '{leftTotal}');");
                    connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{leftAmount - moveAmount}'\r\nWHERE ID = '{leftId}';");
                }
                else
                {
                    MessageBox.Show("Amount you want to move is bigger than the stock amount", "Amount bigger than stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            FilterDatas(FilterStockId);
        }

        /// <summary>
        /// Move The selected amount of stock from the right to the left
        /// Before moving should check if the value already exist on the other position
        /// if so should add to it
        /// and if not create a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveAmountBack_Click(object sender, EventArgs e)
        {
            DataTable found = connection.ExecuteQuery($"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{rightStockId}'\r\nAND STOCK_POSITION = '{leftSelectedStock}'\r\nAND CURRENT_AMOUNT = '{rightCurrent}'\r\nAND MAXIMUM_COUNT = '{rightTotal}';");
            // if found add to the amount
            if (found.Rows.Count > 0)
            {
                string foundId = found.Rows[0][0].ToString();
                int newAmount = Convert.ToInt32(found.Rows[0][5]);
                if (moveAmount <= rightAmount)
                {
                    newAmount += moveAmount;
                }
                else
                {
                    MessageBox.Show("Amount you want to move is bigger than the stock amount", "Amount bigger than stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{newAmount}'\r\nWHERE ID = '{foundId}';");
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{rightAmount - moveAmount}'\r\nWHERE ID = '{rightId}';");
                rightAmount -= moveAmount;
            }
            else // else change the stock position of the selected
            {
                if (moveAmount <= leftAmount)
                {
                    connection.ExecuteQuery($"INSERT INTO amount_table (STOCK_ID, STOCK_POSITION, UNIT_PRICE, TOTAL_PRICE, STOCK_AMOUNT, CURRENT_AMOUNT, MAXIMUM_COUNT)\r\nVALUES ('{rightStockId}', '{leftSelectedStock}', '{rightUnitPrice}', '{rightTotalPrice}', '{moveAmount}', '{rightCurrent}', '{rightTotal}');");
                    connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{rightAmount - moveAmount}'\r\nWHERE ID = '{rightId}';");
                }
                else
                {
                    MessageBox.Show("Amount you want to move is bigger than the stock amount", "Amount bigger than stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            FilterDatas(FilterStockId);
        }

        /// <summary>
        /// Move all the selected stock from the left to the right
        /// Before moving should check if the value already exist on the other position
        /// if so should add to it
        /// and if not create a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveSelectedButton_Click(object sender, EventArgs e)
        {
            DataTable found = connection.ExecuteQuery($"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{leftStockId}'\r\nAND STOCK_POSITION = '{rightSelectedStock}'\r\nAND CURRENT_AMOUNT = '{leftCurrent}'\r\nAND MAXIMUM_COUNT = '{leftTotal}';");
            // if found add to the amount
            if (found.Rows.Count > 0)
            {
                string foundId = found.Rows[0][0].ToString();
                int newAmount = Convert.ToInt32(found.Rows[0][5]);
                newAmount += leftAmount;
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{newAmount}'\r\nWHERE ID = '{foundId}';");
                connection.ExecuteQuery($"DELETE FROM amount_table WHERE ID = '{leftId}';");
            }
            else // else change the stock position of the selected
            {
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_POSITION = '{rightSelectedStock}'\r\nWHERE ID = '{leftId}';");
            }
            FilterDatas(FilterStockId);
        }

        /// <summary>
        /// Move all the selected stock from the right to the left
        /// Before moving should check if the value already exist on the other position
        /// if so should add to it
        /// and if not create a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveSelectedBackButton_Click(object sender, EventArgs e)
        {
            DataTable found = connection.ExecuteQuery($"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{rightStockId}'\r\nAND STOCK_POSITION = '{leftSelectedStock}'\r\nAND CURRENT_AMOUNT = '{rightCurrent}'\r\nAND MAXIMUM_COUNT = '{rightTotal}';");
            // if found add to the amount
            if (found.Rows.Count > 0)
            {
                string foundId = found.Rows[0][0].ToString();
                int newAmount = Convert.ToInt32(found.Rows[0][5]);
                newAmount += rightAmount;
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{newAmount}'\r\nWHERE ID = '{foundId}';");
                connection.ExecuteQuery($"DELETE FROM amount_table WHERE ID = '{rightId}';");
            }
            else // else change the stock position of the selected
            {
                connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_POSITION = '{leftSelectedStock}'\r\nWHERE ID = '{rightId}';");
            }
            FilterDatas(FilterStockId);
        }
        #endregion
    }
}
