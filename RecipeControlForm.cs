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
    public partial class RecipeControlForm : Form
    {
        SQLConnectionHandler connection;

        public RecipeControlForm()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public RecipeControlForm(Form callingFrom)
        {
            mainForm = callingFrom as MainForm;
            InitializeComponent();
        }

        private string SelectedStock;
        public RecipeControlForm(Form callingFrom, string selectedStock)
        {
            mainForm = callingFrom as MainForm;
            SelectedStock = selectedStock;
            InitializeComponent();
        }

        private void RecipeControlForm_Load(object sender, EventArgs e)
        {
            StockIdTextBox.Text = SelectedStock;
            connection = new SQLConnectionHandler(SettingsForm.DatabaseConnectionString);
            MaterialDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM stock_table");
            RecipeDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{SelectedStock}'");
        }

        #region Buttons
        private void AddToRecipeButton_Click(object sender, EventArgs e)
        {
            if (SelectedMaterialIndex == -1)
            {
                MessageBox.Show("Please select a material!", "Material null", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int count = connection.ExecuteNonQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{RecipeId}'");
            if (count != 0)
            {
                MessageBox.Show("Recipe already exists!", "Material already added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"INSERT INTO recipe_table(STOCK_ID, RECIPE_ID, ALT_RECIPE_ID, AMOUNT)\r\nVALUES ('{SelectedStock}', '{StockId}', '', '{Amount}');");
                RecipeDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{SelectedStock}'");
                RecipeDataGrid.Update();
            }
        }

        private void AddAlternativeRecipeButton_Click(object sender, EventArgs e)
        {
            if (SelectedMaterialIndex == -1)
            {
                MessageBox.Show("Please select a material!", "Material null", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SelectedRecipeIndex == -1)
            {
                MessageBox.Show("Please select a recipe!", "Recipe is not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (RecipeId == StockId)
            {
                MessageBox.Show("Recipe already aded as normal!", "Already added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int count = connection.ExecuteNonQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{RecipeId}'");
            if (count != 0)
            {
                MessageBox.Show("Recipe already exists!", "Material already added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"UPDATE recipe_table\r\nSET ALT_RECIPE_ID = '{StockId}'\r\nWHERE ID = '{Id}';");
                RecipeDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{SelectedStock}'");
                RecipeDataGrid.Update();
            }
        }

        private void DeleteFromRecipeButton_Click(object sender, EventArgs e)
        {
            int found = connection.ExecuteNonQuery($"SELECT * FROM recipe_table WHERE ID = '{Id}';");
            if (found == 0)
            {
                MessageBox.Show($"ID {Id} cannot be found!", "Can't found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"DELETE FROM recipe_table WHERE ID = '{Id}';");
                RecipeDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{SelectedStock}'");
                RecipeDataGrid.Update();
            }
        }

        private void UpdateSelectedButton_Click(object sender, EventArgs e)
        {
            int found = connection.ExecuteNonQuery($"SELECT * FROM recipe_table WHERE ID = '{Id}';");
            if (found == 0)
            {
                MessageBox.Show($"ID {Id} cannot be found!", "Can't found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.ExecuteQuery($"UPDATE recipe_table\r\nSET AMOUNT = '{Amount}'\r\nWHERE ID = '{Id}';");
                RecipeDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{SelectedStock}'");
                RecipeDataGrid.Update();
            }
        }

        private void UpdateTableButton_Click(object sender, EventArgs e)
        {

        }

        private string Filter;
        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (Filter == "" || Filter == "*")
            {
                RecipeDataGrid.DataSource = connection.ExecuteQuery("SELECT * FROM recipe_table");
            }
            RecipeDataGrid.DataSource = connection.ExecuteQuery($"SELECT * FROM recipe_table WHERE RECIPE_ID LIKE '%{Filter}%';");
            RecipeDataGrid.Update();
        }
        #endregion

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            Amount = AmountTextBox.Text;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter = FilterTextBox.Text;
        }

        private int SelectedRecipeIndex = -1;
        private string Id;
        private string RecipeId;
        private string AlternativeRecipeId;
        private string Amount;
        private void RecipeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRecipeIndex = e.RowIndex;
            //get the specified values
            //ID 0
            //RECIPE_ID 2
            //ALTERNATIVE_RECIPE_ID 3
            //AMOUNT 4
            Id = RecipeDataGrid[0, SelectedRecipeIndex].Value.ToString();
            RecipeId = RecipeDataGrid[2, SelectedRecipeIndex].Value.ToString();
            AlternativeRecipeId = RecipeDataGrid[3, SelectedRecipeIndex].Value.ToString();
            Amount = RecipeDataGrid[4, SelectedRecipeIndex].Value.ToString();

            RecipeIdTextBox.Text = RecipeId;
            AlternativeRecipeIdTextBox.Text = AlternativeRecipeId;
            AmountTextBox.Text = Amount;
        }

        private int SelectedMaterialIndex = -1;
        private string StockId;
        private void MaterialDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedMaterialIndex = e.RowIndex;
            if (SelectedMaterialIndex == -1)
            {
                return;
            }

            StockId = MaterialDataGrid[1, SelectedMaterialIndex].Value.ToString();
        }

        // update the material type if there are any recipe tables
        private void RecipeControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int found = connection.ExecuteNonQuery($"SELECT * FROM recipe_table WHERE STOCK_ID = '{SelectedStock}';");
            if (found != 0)
            {
                connection.ExecuteQuery($"UPDATE stock_table\r\nSET COMPONENT_TYPE = '1'\r\nWHERE STOCK_ID = '{SelectedStock}';");
                mainForm.ReloadGrid();
            }
            else
            {
                connection.ExecuteQuery($"UPDATE stock_table\r\nSET COMPONENT_TYPE = '0'\r\nWHERE STOCK_ID = '{SelectedStock}';");
                mainForm.ReloadGrid();
            }
        }
    }
}
