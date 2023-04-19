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
            connection = new SQLConnectionHandler(SettingsForm.DatabaseConnectionString);
            StockGridData.DataSource = connection.ExecuteQuery("SELECT * FROM stock_table");
            StockIdTextBox.Text = Filter == null ? "" : Filter;
        }

        #region Grid Click
        private int selectedIndex = -1;
        private void StockGridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
            if (selectedIndex == -1)
            {
                return;
            }

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
            DesiredAmount = Convert.ToInt32(Amount);
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

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Calculate();
            int max = MaximumProduction();
            MessageBox.Show($"Maximum amount you can produce with your stock is {max}.", "Calculated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// The algorithm needs to select from stocked materials the required amount and delete thos ones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProduceButton_Click(object sender, EventArgs e)
        {
            Calculate();
            int max = MaximumProduction(false);
            if (DesiredAmount <= max)
            {
                Calculate();
                Produce();
            }
            else
            {
                MessageBox.Show($"You are missing materials. Cannot Produce this much.", "Material is not enogh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Producing
        private void Produce()
        {
            MessageBox.Show("Error");
            return;

            for (int i = 0; i < RequiredGridData.Rows.Count; i++)
            {
                string stockId = RequiredGridData.Rows[i].Cells[2].Value.ToString();
                int required = Convert.ToInt32(RequiredGridData.Rows[i].Cells[6].Value);
                int stock = Convert.ToInt32(RequiredGridData.Rows[i].Cells[5].Value);
                UseStock(stockId, required);
            }
        }

        private void UseStock(string stockId, int amount)
        {
            DataTable stockData = connection.ExecuteQuery($"SELECT * FROM amount_table WHERE STOCK_ID = '{stockId}';");
            // Get the stock and delete required amount
            // Problem is we need to decide which one to use from
            // prioritize the used ones

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
            // required
            DataTable recipeTable;
            recipeTable = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{Filter}'");
            recipeTable.Columns.Add("Stock", typeof(int));
            recipeTable.Columns.Add("Required", typeof(int));

            // active stock
            DataTable stockTableAmount;

            for (int i = 0; i < recipeTable.Rows.Count; i++)
            {
                recipeTable.Rows[i][6] = (Convert.ToInt16(recipeTable.Rows[i][4]) * DesiredAmount).ToString();
            }

            for (int i = 0; i < recipeTable.Rows.Count; i++)
            {
                stockTableAmount = connection.ExecuteQuery($"SELECT ACTIVE_COUNT FROM stock_table WHERE STOCK_ID = '{recipeTable.Rows[i][2]}'");
                recipeTable.Rows[i][5] = stockTableAmount.Rows[0][0];
            }

            // remaining stock
            bool canProduceWithStock = true;
            recipeTable.Columns.Add("Remaining", typeof(int));
            for (int i = 0; i < recipeTable.Rows.Count; i++)
            {
                int remaining = Convert.ToInt32(recipeTable.Rows[i][5]) - Convert.ToInt32(recipeTable.Rows[i][6]);
                recipeTable.Rows[i][7] = remaining.ToString();
                if (remaining < 0)
                {
                    canProduceWithStock = false;
                }
            }

            RequiredGridData.DataSource = recipeTable;

            for (int i = 0; i < recipeTable.Rows.Count; i++)
            {
                RequiredGridData.Rows[i].Cells[7].Style.BackColor = Convert.ToInt32(recipeTable.Rows[i][7]) < 0 ? Color.Red : Color.Green;
            }

            RequiredGridData.Update();
        }

        public int MaximumProduction(bool setValue = true)
        {
            int required = Convert.ToInt32(RequiredGridData.Rows[0].Cells[4].Value);
            int stock = Convert.ToInt32(RequiredGridData.Rows[0].Cells[5].Value);
            int minimum = stock / required;
            int index = 0;
            for (int i = 1; i < RequiredGridData.Rows.Count; i++)
            {
                required = Convert.ToInt32(RequiredGridData.Rows[i].Cells[4].Value);
                stock = Convert.ToInt32(RequiredGridData.Rows[i].Cells[5].Value);
                int current = stock / required;
                if (current < minimum)
                {
                    minimum = current;
                    index = i;
                }
            }
            if (setValue)
            {
                AmountTextBox.Text = minimum.ToString();
                DesiredAmount = minimum;
                Calculate();
            }
            return minimum;
        }
        #endregion
    }
}
