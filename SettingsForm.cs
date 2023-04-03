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
    public partial class SettingsForm : Form
    {
        public static string DatabasePosition = "BURAKASUSROG\\ZRV2014EXP";
        public static string DatabaseConnectionString = $"Data Source={SettingsForm.DatabasePosition};Initial Catalog=stock_application_db;Integrated Security=True;\r\n";

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            DatabasePositionTextBox.Text = DatabasePosition;
        }

        private void DatabasePositionTextBox_TextChanged(object sender, EventArgs e)
        {
            DatabasePosition = DatabasePositionTextBox.Text;
        }
    }
}
