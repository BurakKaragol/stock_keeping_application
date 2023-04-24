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
            this.RightTotalAmountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LeftTotalAmountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RightStockLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RightComboBox = new System.Windows.Forms.ComboBox();
            this.LeftComboBox = new System.Windows.Forms.ComboBox();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.RecipeMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RecipeStockIdTextBox = new System.Windows.Forms.TextBox();
            this.GetRecipeDataButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RecipeAmmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MoveAmountBack = new System.Windows.Forms.Button();
            this.MoveSelectedBackButton = new System.Windows.Forms.Button();
            this.MoveSelectedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MoveAmountTextBox = new System.Windows.Forms.TextBox();
            this.MoveAmountButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StockIdTextBox = new System.Windows.Forms.TextBox();
            this.RightStockDataGrid = new System.Windows.Forms.DataGridView();
            this.LeftStockDataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RequiredAmountLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CurrentAmountLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RemainingAmountLabel = new System.Windows.Forms.Label();
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
            this.UpperPanel.Controls.Add(this.RightTotalAmountLabel);
            this.UpperPanel.Controls.Add(this.label11);
            this.UpperPanel.Controls.Add(this.LeftTotalAmountLabel);
            this.UpperPanel.Controls.Add(this.label8);
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
            // RightTotalAmountLabel
            // 
            this.RightTotalAmountLabel.AutoSize = true;
            this.RightTotalAmountLabel.Location = new System.Drawing.Point(763, 6);
            this.RightTotalAmountLabel.Name = "RightTotalAmountLabel";
            this.RightTotalAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.RightTotalAmountLabel.TabIndex = 7;
            this.RightTotalAmountLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(687, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Amount";
            // 
            // LeftTotalAmountLabel
            // 
            this.LeftTotalAmountLabel.AutoSize = true;
            this.LeftTotalAmountLabel.Location = new System.Drawing.Point(256, 6);
            this.LeftTotalAmountLabel.Name = "LeftTotalAmountLabel";
            this.LeftTotalAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.LeftTotalAmountLabel.TabIndex = 5;
            this.LeftTotalAmountLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Amount";
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
            this.MiddlePanel.Controls.Add(this.RemainingAmountLabel);
            this.MiddlePanel.Controls.Add(this.label13);
            this.MiddlePanel.Controls.Add(this.CurrentAmountLabel);
            this.MiddlePanel.Controls.Add(this.label12);
            this.MiddlePanel.Controls.Add(this.RequiredAmountLabel);
            this.MiddlePanel.Controls.Add(this.label10);
            this.MiddlePanel.Controls.Add(this.label9);
            this.MiddlePanel.Controls.Add(this.label7);
            this.MiddlePanel.Controls.Add(this.RecipeMaterialComboBox);
            this.MiddlePanel.Controls.Add(this.label6);
            this.MiddlePanel.Controls.Add(this.RecipeStockIdTextBox);
            this.MiddlePanel.Controls.Add(this.GetRecipeDataButton);
            this.MiddlePanel.Controls.Add(this.label5);
            this.MiddlePanel.Controls.Add(this.RecipeAmmountTextBox);
            this.MiddlePanel.Controls.Add(this.label4);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Filter";
            // 
            // RecipeMaterialComboBox
            // 
            this.RecipeMaterialComboBox.FormattingEnabled = true;
            this.RecipeMaterialComboBox.Location = new System.Drawing.Point(3, 370);
            this.RecipeMaterialComboBox.Name = "RecipeMaterialComboBox";
            this.RecipeMaterialComboBox.Size = new System.Drawing.Size(114, 21);
            this.RecipeMaterialComboBox.TabIndex = 19;
            this.RecipeMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.RecipeMaterialComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "STOCK_ID";
            // 
            // RecipeStockIdTextBox
            // 
            this.RecipeStockIdTextBox.Location = new System.Drawing.Point(3, 263);
            this.RecipeStockIdTextBox.Name = "RecipeStockIdTextBox";
            this.RecipeStockIdTextBox.Size = new System.Drawing.Size(114, 20);
            this.RecipeStockIdTextBox.TabIndex = 18;
            this.RecipeStockIdTextBox.TextChanged += new System.EventHandler(this.RecipeStockIdTextBox_TextChanged);
            // 
            // GetRecipeDataButton
            // 
            this.GetRecipeDataButton.Location = new System.Drawing.Point(3, 328);
            this.GetRecipeDataButton.Name = "GetRecipeDataButton";
            this.GetRecipeDataButton.Size = new System.Drawing.Size(114, 23);
            this.GetRecipeDataButton.TabIndex = 14;
            this.GetRecipeDataButton.Text = "Get Recipe Data";
            this.GetRecipeDataButton.UseVisualStyleBackColor = true;
            this.GetRecipeDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Amount";
            // 
            // RecipeAmmountTextBox
            // 
            this.RecipeAmmountTextBox.Location = new System.Drawing.Point(3, 302);
            this.RecipeAmmountTextBox.Name = "RecipeAmmountTextBox";
            this.RecipeAmmountTextBox.Size = new System.Drawing.Size(114, 20);
            this.RecipeAmmountTextBox.TabIndex = 16;
            this.RecipeAmmountTextBox.TextChanged += new System.EventHandler(this.RecipeAmmountTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "MOVE BY RECIPE";
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
            this.StockIdTextBox.AccessibleDescription = "";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Specifications:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Required Amount";
            // 
            // RequiredAmountLabel
            // 
            this.RequiredAmountLabel.AutoSize = true;
            this.RequiredAmountLabel.Location = new System.Drawing.Point(11, 435);
            this.RequiredAmountLabel.Name = "RequiredAmountLabel";
            this.RequiredAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.RequiredAmountLabel.TabIndex = 23;
            this.RequiredAmountLabel.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Current Amount";
            // 
            // CurrentAmountLabel
            // 
            this.CurrentAmountLabel.AutoSize = true;
            this.CurrentAmountLabel.Location = new System.Drawing.Point(11, 468);
            this.CurrentAmountLabel.Name = "CurrentAmountLabel";
            this.CurrentAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.CurrentAmountLabel.TabIndex = 25;
            this.CurrentAmountLabel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Remaining Amount";
            // 
            // RemainingAmountLabel
            // 
            this.RemainingAmountLabel.AutoSize = true;
            this.RemainingAmountLabel.Location = new System.Drawing.Point(11, 503);
            this.RemainingAmountLabel.Name = "RemainingAmountLabel";
            this.RemainingAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.RemainingAmountLabel.TabIndex = 27;
            this.RemainingAmountLabel.Text = "0";
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
        private System.Windows.Forms.Button GetRecipeDataButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RecipeAmmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RecipeStockIdTextBox;
        private System.Windows.Forms.ComboBox RecipeMaterialComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label RightTotalAmountLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LeftTotalAmountLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label RemainingAmountLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CurrentAmountLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label RequiredAmountLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}