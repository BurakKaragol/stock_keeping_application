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
            this.RightStockLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RightComboBox = new System.Windows.Forms.ComboBox();
            this.LeftComboBox = new System.Windows.Forms.ComboBox();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StockIdTextBox = new System.Windows.Forms.TextBox();
            this.RightStockDataGrid = new System.Windows.Forms.DataGridView();
            this.LeftStockDataGrid = new System.Windows.Forms.DataGridView();
            this.MoveAmountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MoveAmountTextBox = new System.Windows.Forms.TextBox();
            this.MoveSelectedButton = new System.Windows.Forms.Button();
            this.MoveSelectedBackButton = new System.Windows.Forms.Button();
            this.MoveAmountBack = new System.Windows.Forms.Button();
            this.UpperPanel.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightStockDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftStockDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpperPanel.Controls.Add(this.RightStockLabel);
            this.UpperPanel.Controls.Add(this.label1);
            this.UpperPanel.Controls.Add(this.RightComboBox);
            this.UpperPanel.Controls.Add(this.LeftComboBox);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(885, 30);
            this.UpperPanel.TabIndex = 0;
            // 
            // RightStockLabel
            // 
            this.RightStockLabel.AutoSize = true;
            this.RightStockLabel.Location = new System.Drawing.Point(519, 6);
            this.RightStockLabel.Name = "RightStockLabel";
            this.RightStockLabel.Size = new System.Drawing.Size(35, 13);
            this.RightStockLabel.TabIndex = 3;
            this.RightStockLabel.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock";
            // 
            // RightComboBox
            // 
            this.RightComboBox.FormattingEnabled = true;
            this.RightComboBox.Location = new System.Drawing.Point(560, 3);
            this.RightComboBox.Name = "RightComboBox";
            this.RightComboBox.Size = new System.Drawing.Size(121, 21);
            this.RightComboBox.TabIndex = 1;
            this.RightComboBox.SelectedIndexChanged += new System.EventHandler(this.RightComboBox_SelectedIndexChanged);
            // 
            // LeftComboBox
            // 
            this.LeftComboBox.FormattingEnabled = true;
            this.LeftComboBox.Location = new System.Drawing.Point(53, 3);
            this.LeftComboBox.Name = "LeftComboBox";
            this.LeftComboBox.Size = new System.Drawing.Size(121, 21);
            this.LeftComboBox.TabIndex = 0;
            this.LeftComboBox.SelectedIndexChanged += new System.EventHandler(this.LeftComboBox_SelectedIndexChanged);
            // 
            // LowerPanel
            // 
            this.LowerPanel.Controls.Add(this.MiddlePanel);
            this.LowerPanel.Controls.Add(this.RightStockDataGrid);
            this.LowerPanel.Controls.Add(this.LeftStockDataGrid);
            this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerPanel.Location = new System.Drawing.Point(0, 30);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(885, 531);
            this.LowerPanel.TabIndex = 1;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MiddlePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MiddlePanel.Controls.Add(this.MoveAmountBack);
            this.MiddlePanel.Controls.Add(this.MoveSelectedBackButton);
            this.MiddlePanel.Controls.Add(this.MoveSelectedButton);
            this.MiddlePanel.Controls.Add(this.label3);
            this.MiddlePanel.Controls.Add(this.MoveAmountTextBox);
            this.MiddlePanel.Controls.Add(this.MoveAmountButton);
            this.MiddlePanel.Controls.Add(this.FilterButton);
            this.MiddlePanel.Controls.Add(this.label2);
            this.MiddlePanel.Controls.Add(this.StockIdTextBox);
            this.MiddlePanel.Location = new System.Drawing.Point(383, 0);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(120, 528);
            this.MiddlePanel.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(3, 45);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(114, 23);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "STOCK_ID";
            // 
            // StockIdTextBox
            // 
            this.StockIdTextBox.Location = new System.Drawing.Point(3, 19);
            this.StockIdTextBox.Name = "StockIdTextBox";
            this.StockIdTextBox.Size = new System.Drawing.Size(114, 20);
            this.StockIdTextBox.TabIndex = 6;
            this.StockIdTextBox.TextChanged += new System.EventHandler(this.StockIdTextBox_TextChanged);
            // 
            // RightStockDataGrid
            // 
            this.RightStockDataGrid.AllowUserToAddRows = false;
            this.RightStockDataGrid.AllowUserToDeleteRows = false;
            this.RightStockDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RightStockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightStockDataGrid.Location = new System.Drawing.Point(509, 0);
            this.RightStockDataGrid.Name = "RightStockDataGrid";
            this.RightStockDataGrid.ReadOnly = true;
            this.RightStockDataGrid.Size = new System.Drawing.Size(373, 528);
            this.RightStockDataGrid.TabIndex = 4;
            this.RightStockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RightStockDataGrid_CellClick);
            // 
            // LeftStockDataGrid
            // 
            this.LeftStockDataGrid.AllowUserToAddRows = false;
            this.LeftStockDataGrid.AllowUserToDeleteRows = false;
            this.LeftStockDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LeftStockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeftStockDataGrid.Location = new System.Drawing.Point(3, 0);
            this.LeftStockDataGrid.Name = "LeftStockDataGrid";
            this.LeftStockDataGrid.ReadOnly = true;
            this.LeftStockDataGrid.Size = new System.Drawing.Size(374, 528);
            this.LeftStockDataGrid.TabIndex = 2;
            this.LeftStockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeftStockDataGrid_CellClick);
            // 
            // MoveAmountButton
            // 
            this.MoveAmountButton.Location = new System.Drawing.Point(3, 116);
            this.MoveAmountButton.Name = "MoveAmountButton";
            this.MoveAmountButton.Size = new System.Drawing.Size(114, 23);
            this.MoveAmountButton.TabIndex = 7;
            this.MoveAmountButton.Text = "Move Amount";
            this.MoveAmountButton.UseVisualStyleBackColor = true;
            this.MoveAmountButton.Click += new System.EventHandler(this.MoveAmountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Move Amount";
            // 
            // MoveAmountTextBox
            // 
            this.MoveAmountTextBox.Location = new System.Drawing.Point(3, 90);
            this.MoveAmountTextBox.Name = "MoveAmountTextBox";
            this.MoveAmountTextBox.Size = new System.Drawing.Size(114, 20);
            this.MoveAmountTextBox.TabIndex = 9;
            this.MoveAmountTextBox.TextChanged += new System.EventHandler(this.MoveAmountTextBox_TextChanged);
            // 
            // MoveSelectedButton
            // 
            this.MoveSelectedButton.Location = new System.Drawing.Point(3, 174);
            this.MoveSelectedButton.Name = "MoveSelectedButton";
            this.MoveSelectedButton.Size = new System.Drawing.Size(114, 23);
            this.MoveSelectedButton.TabIndex = 10;
            this.MoveSelectedButton.Text = "--->";
            this.MoveSelectedButton.UseVisualStyleBackColor = true;
            this.MoveSelectedButton.Click += new System.EventHandler(this.MoveSelectedButton_Click);
            // 
            // MoveSelectedBackButton
            // 
            this.MoveSelectedBackButton.Location = new System.Drawing.Point(3, 203);
            this.MoveSelectedBackButton.Name = "MoveSelectedBackButton";
            this.MoveSelectedBackButton.Size = new System.Drawing.Size(114, 23);
            this.MoveSelectedBackButton.TabIndex = 11;
            this.MoveSelectedBackButton.Text = "<---";
            this.MoveSelectedBackButton.UseVisualStyleBackColor = true;
            this.MoveSelectedBackButton.Click += new System.EventHandler(this.MoveSelectedBackButton_Click);
            // 
            // MoveAmountBack
            // 
            this.MoveAmountBack.Location = new System.Drawing.Point(3, 145);
            this.MoveAmountBack.Name = "MoveAmountBack";
            this.MoveAmountBack.Size = new System.Drawing.Size(114, 23);
            this.MoveAmountBack.TabIndex = 12;
            this.MoveAmountBack.Text = "Move Amount Back";
            this.MoveAmountBack.UseVisualStyleBackColor = true;
            this.MoveAmountBack.Click += new System.EventHandler(this.MoveAmountBack_Click);
            // 
            // MoveStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 561);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.UpperPanel);
            this.Name = "MoveStockForm";
            this.Text = "Move Stock";
            this.Load += new System.EventHandler(this.MoveStockForm_Load);
            this.Resize += new System.EventHandler(this.MoveStockForm_Resize);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.LowerPanel.ResumeLayout(false);
            this.MiddlePanel.ResumeLayout(false);
            this.MiddlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightStockDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftStockDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.DataGridView LeftStockDataGrid;
        private System.Windows.Forms.DataGridView RightStockDataGrid;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.ComboBox RightComboBox;
        private System.Windows.Forms.ComboBox LeftComboBox;
        private System.Windows.Forms.Label RightStockLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockIdTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MoveSelectedButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoveAmountTextBox;
        private System.Windows.Forms.Button MoveAmountButton;
        private System.Windows.Forms.Button MoveSelectedBackButton;
        private System.Windows.Forms.Button MoveAmountBack;
    }
}