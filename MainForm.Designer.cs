namespace stock_keeping_application
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.StockDataGrid = new System.Windows.Forms.DataGridView();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.OptionsGroup = new System.Windows.Forms.GroupBox();
            this.UpdateTableButton = new System.Windows.Forms.Button();
            this.EditRecipeButton = new System.Windows.Forms.Button();
            this.GetAmountDataButton = new System.Windows.Forms.Button();
            this.UpdateSelectedButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.SelectedMaterialProperitiesGroup = new System.Windows.Forms.GroupBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StockIDLabel = new System.Windows.Forms.Label();
            this.StockIdTextBox = new System.Windows.Forms.TextBox();
            this.WindowsGroup = new System.Windows.Forms.GroupBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CalculateStockButton = new System.Windows.Forms.Button();
            this.ProducePartButton = new System.Windows.Forms.Button();
            this.MoveStockButton = new System.Windows.Forms.Button();
            this.PrepareProductListButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.OptionsGroup.SuspendLayout();
            this.SelectedMaterialProperitiesGroup.SuspendLayout();
            this.WindowsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LowerPanel);
            this.MainPanel.Controls.Add(this.UpperPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1179, 690);
            this.MainPanel.TabIndex = 0;
            // 
            // LowerPanel
            // 
            this.LowerPanel.Controls.Add(this.StockDataGrid);
            this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerPanel.Location = new System.Drawing.Point(0, 246);
            this.LowerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(1179, 444);
            this.LowerPanel.TabIndex = 4;
            // 
            // StockDataGrid
            // 
            this.StockDataGrid.AllowUserToAddRows = false;
            this.StockDataGrid.AllowUserToDeleteRows = false;
            this.StockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockDataGrid.Location = new System.Drawing.Point(0, 0);
            this.StockDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StockDataGrid.MultiSelect = false;
            this.StockDataGrid.Name = "StockDataGrid";
            this.StockDataGrid.ReadOnly = true;
            this.StockDataGrid.Size = new System.Drawing.Size(1179, 444);
            this.StockDataGrid.TabIndex = 40;
            this.StockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDataGrid_CellClick);
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.OptionsGroup);
            this.UpperPanel.Controls.Add(this.SelectedMaterialProperitiesGroup);
            this.UpperPanel.Controls.Add(this.WindowsGroup);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1179, 246);
            this.UpperPanel.TabIndex = 3;
            // 
            // OptionsGroup
            // 
            this.OptionsGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OptionsGroup.Controls.Add(this.UpdateTableButton);
            this.OptionsGroup.Controls.Add(this.EditRecipeButton);
            this.OptionsGroup.Controls.Add(this.GetAmountDataButton);
            this.OptionsGroup.Controls.Add(this.UpdateSelectedButton);
            this.OptionsGroup.Controls.Add(this.DeleteSelectedButton);
            this.OptionsGroup.Controls.Add(this.AddNewButton);
            this.OptionsGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptionsGroup.Location = new System.Drawing.Point(593, 0);
            this.OptionsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptionsGroup.Name = "OptionsGroup";
            this.OptionsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptionsGroup.Size = new System.Drawing.Size(293, 246);
            this.OptionsGroup.TabIndex = 20;
            this.OptionsGroup.TabStop = false;
            this.OptionsGroup.Text = "Options";
            // 
            // UpdateTableButton
            // 
            this.UpdateTableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateTableButton.Location = new System.Drawing.Point(4, 204);
            this.UpdateTableButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(285, 37);
            this.UpdateTableButton.TabIndex = 26;
            this.UpdateTableButton.Text = "Update Table";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            this.UpdateTableButton.Click += new System.EventHandler(this.UpdateTableButton_Click);
            // 
            // EditRecipeButton
            // 
            this.EditRecipeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditRecipeButton.Location = new System.Drawing.Point(4, 167);
            this.EditRecipeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditRecipeButton.Name = "EditRecipeButton";
            this.EditRecipeButton.Size = new System.Drawing.Size(285, 37);
            this.EditRecipeButton.TabIndex = 25;
            this.EditRecipeButton.Text = "Edit Recipe";
            this.EditRecipeButton.UseVisualStyleBackColor = true;
            this.EditRecipeButton.Click += new System.EventHandler(this.EditRecipeButton_Click);
            // 
            // GetAmountDataButton
            // 
            this.GetAmountDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetAmountDataButton.Location = new System.Drawing.Point(4, 130);
            this.GetAmountDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetAmountDataButton.Name = "GetAmountDataButton";
            this.GetAmountDataButton.Size = new System.Drawing.Size(285, 37);
            this.GetAmountDataButton.TabIndex = 24;
            this.GetAmountDataButton.Text = "Get / Set Amount Data";
            this.GetAmountDataButton.UseVisualStyleBackColor = true;
            this.GetAmountDataButton.Click += new System.EventHandler(this.GetAmountDataButton_Click);
            // 
            // UpdateSelectedButton
            // 
            this.UpdateSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateSelectedButton.Location = new System.Drawing.Point(4, 93);
            this.UpdateSelectedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateSelectedButton.Name = "UpdateSelectedButton";
            this.UpdateSelectedButton.Size = new System.Drawing.Size(285, 37);
            this.UpdateSelectedButton.TabIndex = 23;
            this.UpdateSelectedButton.Text = "Update Selected";
            this.UpdateSelectedButton.UseVisualStyleBackColor = true;
            this.UpdateSelectedButton.Click += new System.EventHandler(this.UpdateSelectedButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(4, 56);
            this.DeleteSelectedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(285, 37);
            this.DeleteSelectedButton.TabIndex = 22;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNewButton.Location = new System.Drawing.Point(4, 19);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(285, 37);
            this.AddNewButton.TabIndex = 21;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // SelectedMaterialProperitiesGroup
            // 
            this.SelectedMaterialProperitiesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedMaterialProperitiesGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.FilterButton);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.DescriptionTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.DescriptionLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.NameTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.NameLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.StockIDLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.StockIdTextBox);
            this.SelectedMaterialProperitiesGroup.Location = new System.Drawing.Point(4, 4);
            this.SelectedMaterialProperitiesGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedMaterialProperitiesGroup.Name = "SelectedMaterialProperitiesGroup";
            this.SelectedMaterialProperitiesGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedMaterialProperitiesGroup.Size = new System.Drawing.Size(584, 242);
            this.SelectedMaterialProperitiesGroup.TabIndex = 10;
            this.SelectedMaterialProperitiesGroup.TabStop = false;
            this.SelectedMaterialProperitiesGroup.Text = "Selected Material Properities";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(428, 21);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(148, 28);
            this.FilterButton.TabIndex = 14;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(127, 87);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(448, 147);
            this.DescriptionTextBox.TabIndex = 13;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 91);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(98, 16);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "DESCRIPTION";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(127, 55);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(448, 22);
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 59);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 16);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "NAME";
            // 
            // StockIDLabel
            // 
            this.StockIDLabel.AutoSize = true;
            this.StockIDLabel.Location = new System.Drawing.Point(12, 27);
            this.StockIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockIDLabel.Name = "StockIDLabel";
            this.StockIDLabel.Size = new System.Drawing.Size(72, 16);
            this.StockIDLabel.TabIndex = 1;
            this.StockIDLabel.Text = "STOCK_ID";
            // 
            // StockIdTextBox
            // 
            this.StockIdTextBox.Location = new System.Drawing.Point(127, 23);
            this.StockIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StockIdTextBox.Name = "StockIdTextBox";
            this.StockIdTextBox.Size = new System.Drawing.Size(292, 22);
            this.StockIdTextBox.TabIndex = 11;
            this.StockIdTextBox.TextChanged += new System.EventHandler(this.StockIdTextBox_TextChanged);
            // 
            // WindowsGroup
            // 
            this.WindowsGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WindowsGroup.Controls.Add(this.SettingsButton);
            this.WindowsGroup.Controls.Add(this.button2);
            this.WindowsGroup.Controls.Add(this.CalculateStockButton);
            this.WindowsGroup.Controls.Add(this.ProducePartButton);
            this.WindowsGroup.Controls.Add(this.MoveStockButton);
            this.WindowsGroup.Controls.Add(this.PrepareProductListButton);
            this.WindowsGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.WindowsGroup.Location = new System.Drawing.Point(886, 0);
            this.WindowsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WindowsGroup.Name = "WindowsGroup";
            this.WindowsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WindowsGroup.Size = new System.Drawing.Size(293, 246);
            this.WindowsGroup.TabIndex = 30;
            this.WindowsGroup.TabStop = false;
            this.WindowsGroup.Text = "Windows";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.Location = new System.Drawing.Point(4, 204);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(285, 37);
            this.SettingsButton.TabIndex = 36;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(4, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 37);
            this.button2.TabIndex = 35;
            this.button2.Text = "Edit Recipe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CalculateStockButton
            // 
            this.CalculateStockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalculateStockButton.Location = new System.Drawing.Point(4, 130);
            this.CalculateStockButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalculateStockButton.Name = "CalculateStockButton";
            this.CalculateStockButton.Size = new System.Drawing.Size(285, 37);
            this.CalculateStockButton.TabIndex = 34;
            this.CalculateStockButton.Text = "Active Stock Status";
            this.CalculateStockButton.UseVisualStyleBackColor = true;
            this.CalculateStockButton.Click += new System.EventHandler(this.CalculateStockButton_Click);
            // 
            // ProducePartButton
            // 
            this.ProducePartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProducePartButton.Location = new System.Drawing.Point(4, 93);
            this.ProducePartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProducePartButton.Name = "ProducePartButton";
            this.ProducePartButton.Size = new System.Drawing.Size(285, 37);
            this.ProducePartButton.TabIndex = 33;
            this.ProducePartButton.Text = "ProducePart";
            this.ProducePartButton.UseVisualStyleBackColor = true;
            this.ProducePartButton.Click += new System.EventHandler(this.ProducePartButton_Click);
            // 
            // MoveStockButton
            // 
            this.MoveStockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveStockButton.Location = new System.Drawing.Point(4, 56);
            this.MoveStockButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoveStockButton.Name = "MoveStockButton";
            this.MoveStockButton.Size = new System.Drawing.Size(285, 37);
            this.MoveStockButton.TabIndex = 32;
            this.MoveStockButton.Text = "Move Stock";
            this.MoveStockButton.UseVisualStyleBackColor = true;
            this.MoveStockButton.Click += new System.EventHandler(this.MoveStockButton_Click);
            // 
            // PrepareProductListButton
            // 
            this.PrepareProductListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrepareProductListButton.Location = new System.Drawing.Point(4, 19);
            this.PrepareProductListButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrepareProductListButton.Name = "PrepareProductListButton";
            this.PrepareProductListButton.Size = new System.Drawing.Size(285, 37);
            this.PrepareProductListButton.TabIndex = 31;
            this.PrepareProductListButton.Text = "Prepare Product List";
            this.PrepareProductListButton.UseVisualStyleBackColor = true;
            this.PrepareProductListButton.Click += new System.EventHandler(this.PrepareProductListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Stock Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.LowerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.OptionsGroup.ResumeLayout(false);
            this.SelectedMaterialProperitiesGroup.ResumeLayout(false);
            this.SelectedMaterialProperitiesGroup.PerformLayout();
            this.WindowsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView StockDataGrid;
        private System.Windows.Forms.GroupBox SelectedMaterialProperitiesGroup;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.GroupBox OptionsGroup;
        private System.Windows.Forms.Button UpdateSelectedButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StockIDLabel;
        private System.Windows.Forms.TextBox StockIdTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button GetAmountDataButton;
        private System.Windows.Forms.Button UpdateTableButton;
        private System.Windows.Forms.Button EditRecipeButton;
        private System.Windows.Forms.GroupBox WindowsGroup;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CalculateStockButton;
        private System.Windows.Forms.Button ProducePartButton;
        private System.Windows.Forms.Button MoveStockButton;
        private System.Windows.Forms.Button PrepareProductListButton;
        private System.Windows.Forms.Button FilterButton;
    }
}

