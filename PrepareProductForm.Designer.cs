namespace stock_keeping_application
{
    partial class PrepareProductForm
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
            this.ReportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StockIdTextBox = new System.Windows.Forms.TextBox();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.RequiredGridData = new System.Windows.Forms.DataGridView();
            this.LowerSearchPanel = new System.Windows.Forms.Panel();
            this.StockGridData = new System.Windows.Forms.DataGridView();
            this.UpperPanel.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequiredGridData)).BeginInit();
            this.LowerSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpperPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpperPanel.Controls.Add(this.ReportButton);
            this.UpperPanel.Controls.Add(this.label2);
            this.UpperPanel.Controls.Add(this.AmountTextBox);
            this.UpperPanel.Controls.Add(this.CalculateButton);
            this.UpperPanel.Controls.Add(this.FilterButton);
            this.UpperPanel.Controls.Add(this.label1);
            this.UpperPanel.Controls.Add(this.StockIdTextBox);
            this.UpperPanel.Location = new System.Drawing.Point(2, 2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(882, 40);
            this.UpperPanel.TabIndex = 0;
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(628, 8);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(251, 23);
            this.ReportButton.TabIndex = 6;
            this.ReportButton.Text = "How Much Can I Produce With My Stock";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AMOUNT";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(423, 10);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(73, 20);
            this.AmountTextBox.TabIndex = 3;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(502, 8);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(120, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(282, 10);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 20);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STOCK_ID";
            // 
            // StockIdTextBox
            // 
            this.StockIdTextBox.Location = new System.Drawing.Point(76, 10);
            this.StockIdTextBox.Name = "StockIdTextBox";
            this.StockIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.StockIdTextBox.TabIndex = 1;
            this.StockIdTextBox.TextChanged += new System.EventHandler(this.StockIdTextBox_TextChanged);
            // 
            // LowerPanel
            // 
            this.LowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowerPanel.Controls.Add(this.RequiredGridData);
            this.LowerPanel.Controls.Add(this.LowerSearchPanel);
            this.LowerPanel.Location = new System.Drawing.Point(2, 48);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(882, 511);
            this.LowerPanel.TabIndex = 1;
            // 
            // RequiredGridData
            // 
            this.RequiredGridData.AllowUserToAddRows = false;
            this.RequiredGridData.AllowUserToDeleteRows = false;
            this.RequiredGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequiredGridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequiredGridData.Location = new System.Drawing.Point(0, 150);
            this.RequiredGridData.Name = "RequiredGridData";
            this.RequiredGridData.ReadOnly = true;
            this.RequiredGridData.Size = new System.Drawing.Size(882, 361);
            this.RequiredGridData.TabIndex = 21;
            // 
            // LowerSearchPanel
            // 
            this.LowerSearchPanel.Controls.Add(this.StockGridData);
            this.LowerSearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LowerSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.LowerSearchPanel.Name = "LowerSearchPanel";
            this.LowerSearchPanel.Size = new System.Drawing.Size(882, 150);
            this.LowerSearchPanel.TabIndex = 0;
            // 
            // StockGridData
            // 
            this.StockGridData.AllowUserToAddRows = false;
            this.StockGridData.AllowUserToDeleteRows = false;
            this.StockGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockGridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockGridData.Location = new System.Drawing.Point(0, 0);
            this.StockGridData.Name = "StockGridData";
            this.StockGridData.ReadOnly = true;
            this.StockGridData.Size = new System.Drawing.Size(882, 150);
            this.StockGridData.TabIndex = 11;
            this.StockGridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockGridData_CellClick);
            // 
            // PrepareProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.UpperPanel);
            this.Name = "PrepareProductForm";
            this.Text = "Prepare Product";
            this.Load += new System.EventHandler(this.PrepareProductForm_Load);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.LowerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RequiredGridData)).EndInit();
            this.LowerSearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockGridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockIdTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.DataGridView RequiredGridData;
        private System.Windows.Forms.Panel LowerSearchPanel;
        private System.Windows.Forms.DataGridView StockGridData;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}