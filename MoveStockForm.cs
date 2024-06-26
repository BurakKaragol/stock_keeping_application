﻿using System;
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
    /// <summary>
    /// TODO: The remaining current and required values are calculated but the values are not updating correctly.
    /// Control the logic
    /// </summary>
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

        // Created for fixing the bug where when we select one combobox the other one selects it too
        private string[] Copy(string[] arr)
        {
            string[] copy = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }
            return copy;
        }

        private void MoveStockForm_Load(object sender, EventArgs e)
        {
            connection = new SQLConnectionHandler(SettingsForm.DatabaseConnectionString);
            LeftComboBox.DataSource = Copy(SettingsForm.stockPositions);
            RightComboBox.DataSource = Copy(SettingsForm.stockPositions);
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
        private int leftTotal = 0;
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
        private int rightTotal = 0;
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

        /// <summary>
        /// The comboboxes are refreshing the list. This is a bug that needs to be fixed.
        /// </summary>

        private int leftSelectedStock = 0;
        private void LeftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftSelectedStock = LeftComboBox.SelectedIndex;
            Console.WriteLine($"left selected: {leftSelectedStock}");
            FilterDatas(Filter);
        }

        private int rightSelectedStock = 0;
        private void RightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightSelectedStock = RightComboBox.SelectedIndex;
            Console.WriteLine($"right selected: {rightSelectedStock}");
            FilterDatas(Filter);
        }

        /// <summary>
        /// Show the recipe materials and filter the selected stock in the tables.
        /// The user should select the material and move the required amount
        /// when clicked proceed check if all requirements are met and if so move the parts
        /// </summary>
        private int recipeMaterialSelectedIndex = -1;
        private void RecipeMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipeMaterialSelectedIndex = RecipeMaterialComboBox.SelectedIndex;
            Console.WriteLine($"recipe material selected: {recipeMaterialSelectedIndex}");
            Filter = recipeNames[recipeMaterialSelectedIndex];
            FilterDatas(recipeNames[recipeMaterialSelectedIndex]);
            RequiredAmountLabel.Text = (requiredAmounts[recipeMaterialSelectedIndex] * recipeAmount).ToString();
            CurrentAmountLabel.Text = ((requiredAmounts[recipeMaterialSelectedIndex] * recipeAmount) - rightTotal).ToString();
            RemainingAmountLabel.Text = ((requiredAmounts[recipeMaterialSelectedIndex] * recipeAmount) - ((requiredAmounts[recipeMaterialSelectedIndex] * recipeAmount) - rightTotal)).ToString();
        }
        #endregion

        #region Filtering
        private void FilterDataLeft(string leftStock)
        {
            if (!Filter.NullOrEmpty())
            {
                DataTable dataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{Filter}%' AND STOCK_POSITION = '{leftSelectedStock}';");
                LeftStockDataGrid.DataSource = dataTable;
            }
            else
            {
                DataTable dataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_POSITION = '{leftSelectedStock}';");
                LeftStockDataGrid.DataSource = dataTable;
            }
        }

        private void FilterDataRight(string rightStock)
        {
            if (!Filter.NullOrEmpty())
            {
                DataTable dataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{Filter}%' AND STOCK_POSITION = '{leftSelectedStock}';");
                RightStockDataGrid.DataSource = dataTable;
            }
            else
            {
                DataTable dataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_POSITION = '{leftSelectedStock}';");
                RightStockDataGrid.DataSource = dataTable;
            }
        }

        /// <summary>
        /// Filters the datas that are shown in the tables
        /// Needs an upgrade for selecting a recipe materail. 
        /// </summary>
        /// <param name="filter"></param>
        int LeftTotal;
        int RightTotal;
        private void FilterDatas(string filter)
        {
            DataTable leftDataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{filter}%' AND STOCK_POSITION = '{leftSelectedStock}';");
            LeftStockDataGrid.DataSource = leftDataTable;
            DataTable rightDataTable = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID LIKE '%{filter}%' AND STOCK_POSITION = '{rightSelectedStock}';");
            RightStockDataGrid.DataSource = rightDataTable;
            CalculateTotal();
        }
        #endregion

        /// <summary>
        /// Calculate total value of the selected material in left and right.
        /// Calculate required amount and control if the requirement is satisfied
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void CalculateTotal()
        {
            leftTotal = 0;
            for (int i = 0; i < LeftStockDataGrid.Rows.Count; i++)
            {
                LeftTotal += Convert.ToInt32(LeftStockDataGrid.Rows[i].Cells[5].Value) * Convert.ToInt32(LeftStockDataGrid.Rows[i].Cells[6].Value);
            }
            LeftTotalAmountLabel.Text = LeftTotal.ToString();
            RightTotal = 0;
            for (int i = 0; i < RightStockDataGrid.Rows.Count; i++)
            {
                RightTotal += Convert.ToInt32(RightStockDataGrid.Rows[i].Cells[5].Value) * Convert.ToInt32(RightStockDataGrid.Rows[i].Cells[6].Value);
            }
            RightTotalAmountLabel.Text = RightTotal.ToString();
        }

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

        private string RecipeStockId;
        private void RecipeStockIdTextBox_TextChanged(object sender, EventArgs e)
        {
            RecipeStockId = RecipeStockIdTextBox.Text;
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

        private int recipeAmount;
        private void RecipeAmmountTextBox_TextChanged(object sender, EventArgs e)
        {
            recipeAmount = Convert.ToInt32(RecipeAmmountTextBox.Text);
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
            DataTable found = connection.ExecuteQuery(
                $"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{leftStockId}'\r\nAND STOCK_POSITION = '" +
                $"{rightSelectedStock}'\r\nAND CURRENT_AMOUNT = '{leftCurrent}'\r\nAND MAXIMUM_COUNT = '{leftTotal}';");
            // if found add to the amount
            if (found.Rows.Count > 0)
            {
                string foundId = found.Rows[0][0].ToString();
                int newAmount = Convert.ToInt32(found.Rows[0][5]);
                if (moveAmount <= leftAmount)
                {
                    newAmount += moveAmount;
                    connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{newAmount}'\r\nWHERE ID = '{foundId}';");
                    connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{leftAmount - moveAmount}'\r\nWHERE ID = '{leftId}';");
                    leftAmount -= moveAmount;
                }
                else
                {
                    MessageBox.Show("Amount you want to move is bigger than the stock amount", "Amount bigger than stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else // else change the stock position of the selected
            {
                if (moveAmount <= leftAmount)
                {
                    connection.ExecuteQuery($"INSERT INTO amount_table (STOCK_ID, STOCK_POSITION, UNIT_PRICE, TOTAL_PRICE, STOCK_AMOUNT, CURRENT_AMOUNT, MAXIMUM_COUNT)\r\n" +
                        $"VALUES ('{leftStockId}', '{rightSelectedStock}', '{leftUnitPrice}', '{leftTotalPrice}', '{moveAmount}', '{leftCurrent}', '{leftTotal}');");
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
            DataTable found = connection.ExecuteQuery(
                $"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{rightStockId}'\r\nAND STOCK_POSITION = '{leftSelectedStock}'\r\n" +
                $"AND CURRENT_AMOUNT = '{rightCurrent}'\r\nAND MAXIMUM_COUNT = '{rightTotal}';");
            // if found add to the amount
            if (found.Rows.Count > 0)
            {
                string foundId = found.Rows[0][0].ToString();
                int newAmount = Convert.ToInt32(found.Rows[0][5]);
                if (moveAmount <= rightAmount)
                {
                    newAmount += moveAmount;
                    connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{newAmount}'\r\nWHERE ID = '{foundId}';");
                    connection.ExecuteQuery($"UPDATE amount_table\r\nSET STOCK_AMOUNT = '{rightAmount - moveAmount}'\r\nWHERE ID = '{rightId}';");
                    rightAmount -= moveAmount;
                }
                else
                {
                    MessageBox.Show("Amount you want to move is bigger than the stock amount", "Amount bigger than stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else // else change the stock position of the selected
            {
                if (moveAmount <= leftAmount)
                {
                    connection.ExecuteQuery($"INSERT INTO amount_table (STOCK_ID, STOCK_POSITION, UNIT_PRICE, TOTAL_PRICE, STOCK_AMOUNT, CURRENT_AMOUNT, MAXIMUM_COUNT)\r\n" +
                        $"VALUES ('{rightStockId}', '{leftSelectedStock}', '{rightUnitPrice}', '{rightTotalPrice}', '{moveAmount}', '{rightCurrent}', '{rightTotal}');");
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
            DataTable found = connection.ExecuteQuery($"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{leftStockId}'\r\n" +
                $"AND STOCK_POSITION = '{rightSelectedStock}'\r\nAND CURRENT_AMOUNT = '{leftCurrent}'\r\nAND MAXIMUM_COUNT = '{leftTotal}';");
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
            DataTable found = connection.ExecuteQuery($"SELECT * FROM amount_table\r\nWHERE STOCK_ID = '{rightStockId}'\r\n" +
                $"AND STOCK_POSITION = '{leftSelectedStock}'\r\nAND CURRENT_AMOUNT = '{rightCurrent}'\r\nAND MAXIMUM_COUNT = '{rightTotal}';");
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

        /// <summary>
        /// Creates the list based on the recipe
        /// </summary>
        List<string> recipeNames = new List<string>();
        List<string> alternativeNames = new List<string>();
        List<int> requiredAmounts = new List<int>();
        private void GetDataButton_Click(object sender, EventArgs e)
        {
            DataTable recipeData = connection.ExecuteQuery($"SELECT * FROM recipe_table\r\nWHERE STOCK_ID = '{RecipeStockId}';");
            RecipeMaterialComboBox.Items.Clear();
            recipeNames.Clear();
            alternativeNames.Clear();
            requiredAmounts.Clear();
            for (int i = 0; i < recipeData.Rows.Count; i++)
            {
                string id = recipeData.Rows[i][2].ToString();
                int amount = Convert.ToInt32(recipeData.Rows[i][4]);
                if (!(id == null || id == ""))
                {
                    if (!RecipeMaterialComboBox.Items.Contains(id))
                    {
                        RecipeMaterialComboBox.Items.Add(id);
                        recipeNames.Add(id);
                        requiredAmounts.Add(amount * recipeAmount);
                    }
                }
                string alt = recipeData.Rows[i][3].ToString();
                if (!RecipeMaterialComboBox.Items.Contains(alt))
                {
                    alternativeNames.Add(alt);
                }
            }
            RecipeMaterialComboBox.SelectedIndex = 0;
            RecipeMaterialComboBox.Update();
            RequiredAmountLabel.Text = (requiredAmounts[0] * recipeAmount).ToString();
            CurrentAmountLabel.Text = ((requiredAmounts[0] * recipeAmount) - RightTotal).ToString();
            RemainingAmountLabel.Text = ((requiredAmounts[0] * recipeAmount) - ((requiredAmounts[0] * recipeAmount) - RightTotal)).ToString();
        }
        #endregion
    }
}
