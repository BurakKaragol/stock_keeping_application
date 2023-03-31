namespace stock_keeping_application
{
    partial class MoveStockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.UpperStockDataGrid = new System.Windows.Forms.DataGridView();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.LowerStockDataGrid = new System.Windows.Forms.DataGridView();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperStockDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerStockDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(884, 50);
            this.UpperPanel.TabIndex = 0;
            // 
            // LowerPanel
            // 
            this.LowerPanel.Controls.Add(this.LowerStockDataGrid);
            this.LowerPanel.Controls.Add(this.MiddlePanel);
            this.LowerPanel.Controls.Add(this.UpperStockDataGrid);
            this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerPanel.Location = new System.Drawing.Point(0, 50);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(884, 511);
            this.LowerPanel.TabIndex = 1;
            // 
            // UpperStockDataGrid
            // 
            this.UpperStockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpperStockDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperStockDataGrid.Location = new System.Drawing.Point(0, 0);
            this.UpperStockDataGrid.Name = "UpperStockDataGrid";
            this.UpperStockDataGrid.Size = new System.Drawing.Size(884, 230);
            this.UpperStockDataGrid.TabIndex = 2;
            this.UpperStockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpperStockDataGrid_CellClick);
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddlePanel.Location = new System.Drawing.Point(0, 230);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(884, 50);
            this.MiddlePanel.TabIndex = 3;
            // 
            // LowerStockDataGrid
            // 
            this.LowerStockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LowerStockDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.LowerStockDataGrid.Location = new System.Drawing.Point(0, 280);
            this.LowerStockDataGrid.Name = "LowerStockDataGrid";
            this.LowerStockDataGrid.Size = new System.Drawing.Size(884, 230);
            this.LowerStockDataGrid.TabIndex = 4;
            this.LowerStockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LowerStockDataGrid_CellClick);
            // 
            // MoveStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.UpperPanel);
            this.Name = "MoveStockForm";
            this.Text = "Move Stock";
            this.Load += new System.EventHandler(this.MoveStockForm_Load);
            this.LowerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpperStockDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerStockDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.DataGridView UpperStockDataGrid;
        private System.Windows.Forms.DataGridView LowerStockDataGrid;
        private System.Windows.Forms.Panel MiddlePanel;
    }
}