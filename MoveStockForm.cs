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

        string Filter;
        public MoveStockForm(Form calledFrom, string StockId)
        {
            mainForm = calledFrom as MainForm;
            Filter = StockId;
            InitializeComponent();
        }

        private void MoveStockForm_Load(object sender, EventArgs e)
        {

        }

        #region Grid Selection
        private int upperSelectedIndex = 0;
        private string upperStockId;
        private void UpperStockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            upperSelectedIndex = e.RowIndex;
            if (upperSelectedIndex == -1)
            {
                return;
            }

            upperStockId = UpperStockDataGrid[1, upperSelectedIndex].Value.ToString();
        }

        private int lowerSelectedIndex = 0;
        private string lowerStockId;
        private void LowerStockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lowerSelectedIndex = e.RowIndex;
            if (lowerSelectedIndex == -1)
            {
                return;
            }

            lowerStockId = LowerStockDataGrid[1, lowerSelectedIndex].Value.ToString();
        }
#endregion
    }
}
