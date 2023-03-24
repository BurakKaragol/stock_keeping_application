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
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StockIDLabel = new System.Windows.Forms.Label();
            this.StockIdTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.OptionsGroup.SuspendLayout();
            this.SelectedMaterialProperitiesGroup.SuspendLayout();
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
            this.MainPanel.Size = new System.Drawing.Size(884, 561);
            this.MainPanel.TabIndex = 0;
            // 
            // LowerPanel
            // 
            this.LowerPanel.Controls.Add(this.StockDataGrid);
            this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerPanel.Location = new System.Drawing.Point(0, 200);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(884, 361);
            this.LowerPanel.TabIndex = 4;
            // 
            // StockDataGrid
            // 
            this.StockDataGrid.AllowUserToAddRows = false;
            this.StockDataGrid.AllowUserToDeleteRows = false;
            this.StockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockDataGrid.Location = new System.Drawing.Point(0, 0);
            this.StockDataGrid.Name = "StockDataGrid";
            this.StockDataGrid.Size = new System.Drawing.Size(884, 361);
            this.StockDataGrid.TabIndex = 1;
            this.StockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDataGrid_CellClick);
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.OptionsGroup);
            this.UpperPanel.Controls.Add(this.SelectedMaterialProperitiesGroup);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(884, 200);
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
            this.OptionsGroup.Location = new System.Drawing.Point(634, 0);
            this.OptionsGroup.Name = "OptionsGroup";
            this.OptionsGroup.Size = new System.Drawing.Size(250, 200);
            this.OptionsGroup.TabIndex = 3;
            this.OptionsGroup.TabStop = false;
            this.OptionsGroup.Text = "Options";
            // 
            // UpdateTableButton
            // 
            this.UpdateTableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateTableButton.Location = new System.Drawing.Point(3, 166);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(244, 30);
            this.UpdateTableButton.TabIndex = 7;
            this.UpdateTableButton.Text = "Update Table";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            this.UpdateTableButton.Click += new System.EventHandler(this.UpdateTableButton_Click_1);
            // 
            // EditRecipeButton
            // 
            this.EditRecipeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditRecipeButton.Location = new System.Drawing.Point(3, 136);
            this.EditRecipeButton.Name = "EditRecipeButton";
            this.EditRecipeButton.Size = new System.Drawing.Size(244, 30);
            this.EditRecipeButton.TabIndex = 6;
            this.EditRecipeButton.Text = "Edit Recipe";
            this.EditRecipeButton.UseVisualStyleBackColor = true;
            this.EditRecipeButton.Click += new System.EventHandler(this.EditRecipeButton_Click);
            // 
            // GetAmountDataButton
            // 
            this.GetAmountDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetAmountDataButton.Location = new System.Drawing.Point(3, 106);
            this.GetAmountDataButton.Name = "GetAmountDataButton";
            this.GetAmountDataButton.Size = new System.Drawing.Size(244, 30);
            this.GetAmountDataButton.TabIndex = 5;
            this.GetAmountDataButton.Text = "Get Amount Data";
            this.GetAmountDataButton.UseVisualStyleBackColor = true;
            this.GetAmountDataButton.Click += new System.EventHandler(this.GetAmountDataButton_Click);
            // 
            // UpdateSelectedButton
            // 
            this.UpdateSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateSelectedButton.Location = new System.Drawing.Point(3, 76);
            this.UpdateSelectedButton.Name = "UpdateSelectedButton";
            this.UpdateSelectedButton.Size = new System.Drawing.Size(244, 30);
            this.UpdateSelectedButton.TabIndex = 4;
            this.UpdateSelectedButton.Text = "Update Selected";
            this.UpdateSelectedButton.UseVisualStyleBackColor = true;
            this.UpdateSelectedButton.Click += new System.EventHandler(this.UpdateSelectedButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(3, 46);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(244, 30);
            this.DeleteSelectedButton.TabIndex = 3;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNewButton.Location = new System.Drawing.Point(3, 16);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(244, 30);
            this.AddNewButton.TabIndex = 2;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // SelectedMaterialProperitiesGroup
            // 
            this.SelectedMaterialProperitiesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedMaterialProperitiesGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.DescriptionTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.DescriptionLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.NameTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.NameLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.StockIDLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.StockIdTextBox);
            this.SelectedMaterialProperitiesGroup.Location = new System.Drawing.Point(3, 3);
            this.SelectedMaterialProperitiesGroup.Name = "SelectedMaterialProperitiesGroup";
            this.SelectedMaterialProperitiesGroup.Size = new System.Drawing.Size(628, 197);
            this.SelectedMaterialProperitiesGroup.TabIndex = 2;
            this.SelectedMaterialProperitiesGroup.TabStop = false;
            this.SelectedMaterialProperitiesGroup.Text = "Selected Material Properities";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(95, 71);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(527, 120);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(9, 74);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "DESCRIPTION";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(95, 45);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(340, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "NAME";
            // 
            // StockIDLabel
            // 
            this.StockIDLabel.AutoSize = true;
            this.StockIDLabel.Location = new System.Drawing.Point(9, 22);
            this.StockIDLabel.Name = "StockIDLabel";
            this.StockIDLabel.Size = new System.Drawing.Size(60, 13);
            this.StockIDLabel.TabIndex = 1;
            this.StockIDLabel.Text = "STOCK_ID";
            // 
            // StockIdTextBox
            // 
            this.StockIdTextBox.Location = new System.Drawing.Point(95, 19);
            this.StockIdTextBox.Name = "StockIdTextBox";
            this.StockIdTextBox.Size = new System.Drawing.Size(220, 20);
            this.StockIdTextBox.TabIndex = 0;
            this.StockIdTextBox.TextChanged += new System.EventHandler(this.StockIdTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MainPanel);
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
    }
}

