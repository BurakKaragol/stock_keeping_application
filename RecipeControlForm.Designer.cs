namespace stock_keeping_application
{
    partial class RecipeControlForm
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
            this.ActionsGroup = new System.Windows.Forms.GroupBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.OptionsGroup = new System.Windows.Forms.GroupBox();
            this.UpdateTableButton = new System.Windows.Forms.Button();
            this.EditStockButton = new System.Windows.Forms.Button();
            this.UpdateSelectedButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.SelectedMaterialProperitiesGroup = new System.Windows.Forms.GroupBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.TotalStockTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalStockLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CurrentStockTextBox = new System.Windows.Forms.TextBox();
            this.CurrentStockLabel = new System.Windows.Forms.Label();
            this.StockIDLabel = new System.Windows.Forms.Label();
            this.StockIdTextBox = new System.Windows.Forms.TextBox();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.AmountDataGrid = new System.Windows.Forms.DataGridView();
            this.UpperPanel.SuspendLayout();
            this.ActionsGroup.SuspendLayout();
            this.OptionsGroup.SuspendLayout();
            this.SelectedMaterialProperitiesGroup.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpperPanel.Controls.Add(this.ActionsGroup);
            this.UpperPanel.Controls.Add(this.OptionsGroup);
            this.UpperPanel.Controls.Add(this.SelectedMaterialProperitiesGroup);
            this.UpperPanel.Location = new System.Drawing.Point(-1, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(883, 150);
            this.UpperPanel.TabIndex = 2;
            // 
            // ActionsGroup
            // 
            this.ActionsGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ActionsGroup.Controls.Add(this.FilterButton);
            this.ActionsGroup.Controls.Add(this.label1);
            this.ActionsGroup.Controls.Add(this.FilterTextBox);
            this.ActionsGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActionsGroup.Location = new System.Drawing.Point(433, 0);
            this.ActionsGroup.Name = "ActionsGroup";
            this.ActionsGroup.Size = new System.Drawing.Size(250, 150);
            this.ActionsGroup.TabIndex = 20;
            this.ActionsGroup.TabStop = false;
            this.ActionsGroup.Text = "Actions";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(9, 46);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(238, 22);
            this.FilterButton.TabIndex = 32;
            this.FilterButton.Text = "Filter List";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "STOCK_ID";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(72, 19);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(175, 20);
            this.FilterTextBox.TabIndex = 12;
            // 
            // OptionsGroup
            // 
            this.OptionsGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OptionsGroup.Controls.Add(this.UpdateTableButton);
            this.OptionsGroup.Controls.Add(this.EditStockButton);
            this.OptionsGroup.Controls.Add(this.UpdateSelectedButton);
            this.OptionsGroup.Controls.Add(this.DeleteSelectedButton);
            this.OptionsGroup.Controls.Add(this.AddNewButton);
            this.OptionsGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptionsGroup.Location = new System.Drawing.Point(683, 0);
            this.OptionsGroup.Name = "OptionsGroup";
            this.OptionsGroup.Size = new System.Drawing.Size(200, 150);
            this.OptionsGroup.TabIndex = 30;
            this.OptionsGroup.TabStop = false;
            this.OptionsGroup.Text = "Options";
            // 
            // UpdateTableButton
            // 
            this.UpdateTableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateTableButton.Location = new System.Drawing.Point(3, 120);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(194, 26);
            this.UpdateTableButton.TabIndex = 35;
            this.UpdateTableButton.Text = "Update Table";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            // 
            // EditStockButton
            // 
            this.EditStockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditStockButton.Location = new System.Drawing.Point(3, 94);
            this.EditStockButton.Name = "EditStockButton";
            this.EditStockButton.Size = new System.Drawing.Size(194, 26);
            this.EditStockButton.TabIndex = 34;
            this.EditStockButton.Text = "Edit Stock Position";
            this.EditStockButton.UseVisualStyleBackColor = true;
            // 
            // UpdateSelectedButton
            // 
            this.UpdateSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateSelectedButton.Location = new System.Drawing.Point(3, 68);
            this.UpdateSelectedButton.Name = "UpdateSelectedButton";
            this.UpdateSelectedButton.Size = new System.Drawing.Size(194, 26);
            this.UpdateSelectedButton.TabIndex = 33;
            this.UpdateSelectedButton.Text = "Update Selected";
            this.UpdateSelectedButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(3, 42);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(194, 26);
            this.DeleteSelectedButton.TabIndex = 32;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNewButton.Location = new System.Drawing.Point(3, 16);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(194, 26);
            this.AddNewButton.TabIndex = 31;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            // 
            // SelectedMaterialProperitiesGroup
            // 
            this.SelectedMaterialProperitiesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedMaterialProperitiesGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.TotalPriceTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.TotalStockTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.UnitPriceTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.AmountTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.AmountLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.TotalPriceLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.TotalStockLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.UnitPriceLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.DescriptionTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.DescriptionLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.CurrentStockTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.CurrentStockLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.StockIDLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.StockIdTextBox);
            this.SelectedMaterialProperitiesGroup.Location = new System.Drawing.Point(0, 0);
            this.SelectedMaterialProperitiesGroup.Name = "SelectedMaterialProperitiesGroup";
            this.SelectedMaterialProperitiesGroup.Size = new System.Drawing.Size(427, 150);
            this.SelectedMaterialProperitiesGroup.TabIndex = 10;
            this.SelectedMaterialProperitiesGroup.TabStop = false;
            this.SelectedMaterialProperitiesGroup.Text = "Selected Material Properities";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceTextBox.Location = new System.Drawing.Point(322, 71);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(99, 20);
            this.TotalPriceTextBox.TabIndex = 16;
            // 
            // TotalStockTextBox
            // 
            this.TotalStockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalStockTextBox.Location = new System.Drawing.Point(322, 45);
            this.TotalStockTextBox.Name = "TotalStockTextBox";
            this.TotalStockTextBox.Size = new System.Drawing.Size(99, 20);
            this.TotalStockTextBox.TabIndex = 14;
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(117, 71);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.UnitPriceTextBox.TabIndex = 15;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextBox.Location = new System.Drawing.Point(347, 19);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(74, 20);
            this.AmountTextBox.TabIndex = 12;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(287, 22);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(54, 13);
            this.AmountLabel.TabIndex = 21;
            this.AmountLabel.Text = "AMOUNT";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(223, 74);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(80, 13);
            this.TotalPriceLabel.TabIndex = 20;
            this.TotalPriceLabel.Text = "TOTAL_PRICE";
            // 
            // TotalStockLabel
            // 
            this.TotalStockLabel.AutoSize = true;
            this.TotalStockLabel.Location = new System.Drawing.Point(223, 48);
            this.TotalStockLabel.Name = "TotalStockLabel";
            this.TotalStockLabel.Size = new System.Drawing.Size(84, 13);
            this.TotalStockLabel.TabIndex = 16;
            this.TotalStockLabel.Text = "TOTAL_STOCK";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(9, 74);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(71, 13);
            this.UnitPriceLabel.TabIndex = 14;
            this.UnitPriceLabel.Text = "UNIT_PRICE";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(95, 97);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(326, 47);
            this.DescriptionTextBox.TabIndex = 17;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(9, 100);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "DESCRIPTION";
            // 
            // CurrentStockTextBox
            // 
            this.CurrentStockTextBox.Location = new System.Drawing.Point(117, 45);
            this.CurrentStockTextBox.Name = "CurrentStockTextBox";
            this.CurrentStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentStockTextBox.TabIndex = 13;
            // 
            // CurrentStockLabel
            // 
            this.CurrentStockLabel.AutoSize = true;
            this.CurrentStockLabel.Location = new System.Drawing.Point(9, 48);
            this.CurrentStockLabel.Name = "CurrentStockLabel";
            this.CurrentStockLabel.Size = new System.Drawing.Size(102, 13);
            this.CurrentStockLabel.TabIndex = 2;
            this.CurrentStockLabel.Text = "CURRENT_STOCK";
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
            this.StockIdTextBox.Location = new System.Drawing.Point(117, 19);
            this.StockIdTextBox.Name = "StockIdTextBox";
            this.StockIdTextBox.Size = new System.Drawing.Size(164, 20);
            this.StockIdTextBox.TabIndex = 11;
            // 
            // LowerPanel
            // 
            this.LowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LowerPanel.Controls.Add(this.AmountDataGrid);
            this.LowerPanel.Location = new System.Drawing.Point(-1, 156);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(883, 406);
            this.LowerPanel.TabIndex = 3;
            // 
            // AmountDataGrid
            // 
            this.AmountDataGrid.AllowUserToAddRows = false;
            this.AmountDataGrid.AllowUserToDeleteRows = false;
            this.AmountDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AmountDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmountDataGrid.Location = new System.Drawing.Point(0, 0);
            this.AmountDataGrid.Name = "AmountDataGrid";
            this.AmountDataGrid.ReadOnly = true;
            this.AmountDataGrid.Size = new System.Drawing.Size(883, 406);
            this.AmountDataGrid.TabIndex = 0;
            // 
            // RecipeControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.UpperPanel);
            this.Name = "RecipeControlForm";
            this.Text = "RecipeControlForm";
            this.Load += new System.EventHandler(this.RecipeControlForm_Load);
            this.UpperPanel.ResumeLayout(false);
            this.ActionsGroup.ResumeLayout(false);
            this.ActionsGroup.PerformLayout();
            this.OptionsGroup.ResumeLayout(false);
            this.SelectedMaterialProperitiesGroup.ResumeLayout(false);
            this.SelectedMaterialProperitiesGroup.PerformLayout();
            this.LowerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.GroupBox ActionsGroup;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.GroupBox OptionsGroup;
        private System.Windows.Forms.Button UpdateTableButton;
        private System.Windows.Forms.Button EditStockButton;
        private System.Windows.Forms.Button UpdateSelectedButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.GroupBox SelectedMaterialProperitiesGroup;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.TextBox TotalStockTextBox;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label TotalStockLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox CurrentStockTextBox;
        private System.Windows.Forms.Label CurrentStockLabel;
        private System.Windows.Forms.Label StockIDLabel;
        private System.Windows.Forms.TextBox StockIdTextBox;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.DataGridView AmountDataGrid;
    }
}