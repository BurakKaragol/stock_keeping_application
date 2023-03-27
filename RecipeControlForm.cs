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

        }
    }
}
