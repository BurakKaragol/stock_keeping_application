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

        private int selectedIndex = 0;
        private string stockText;
        private string nameText;
        private string descriptionText;
        private void StockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
            //get the specified values
            //STOCK_ID 1
            //NAME 3
            //DESCRIPTION 8
            stockText = StockDataGrid[1, selectedIndex].Value.ToString();
            nameText = StockDataGrid[3, selectedIndex].Value.ToString();
            descriptionText = StockDataGrid[8, selectedIndex].Value.ToString();

            StockIdTextBox.Text = stockText;
            NameTextBox.Text = nameText;
            DescriptionTextBox.Text = descriptionText;
        }

        #region TextBoxes
        private void StockIdTextBox_TextChanged(object sender, EventArgs e)
        {
            stockText = StockIdTextBox.Text;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameText = NameTextBox.Text;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionText = DescriptionTextBox.Text;
        }
        #endregion
    }
}
