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
            this.UpdateSelectedButton = new System.Windows.Forms.Button();
            this.DeleteFromRecipeButton = new System.Windows.Forms.Button();
            this.AddAlternativeRecipeButton = new System.Windows.Forms.Button();
            this.AddToRecipeButton = new System.Windows.Forms.Button();
            this.SelectedMaterialProperitiesGroup = new System.Windows.Forms.GroupBox();
            this.AlternativeRecipeIdTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.RecipeIdTextBox = new System.Windows.Forms.TextBox();
            this.CurrentStockLabel = new System.Windows.Forms.Label();
            this.StockIDLabel = new System.Windows.Forms.Label();
            this.StockIdTextBox = new System.Windows.Forms.TextBox();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.MaterialDataGrid = new System.Windows.Forms.DataGridView();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.RecipeDataGrid = new System.Windows.Forms.DataGridView();
            this.UpperPanel.SuspendLayout();
            this.ActionsGroup.SuspendLayout();
            this.OptionsGroup.SuspendLayout();
            this.SelectedMaterialProperitiesGroup.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).BeginInit();
            this.RecipePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGrid)).BeginInit();
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
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "RECIPE_ID";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(75, 19);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(172, 20);
            this.FilterTextBox.TabIndex = 12;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // OptionsGroup
            // 
            this.OptionsGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OptionsGroup.Controls.Add(this.UpdateTableButton);
            this.OptionsGroup.Controls.Add(this.UpdateSelectedButton);
            this.OptionsGroup.Controls.Add(this.DeleteFromRecipeButton);
            this.OptionsGroup.Controls.Add(this.AddAlternativeRecipeButton);
            this.OptionsGroup.Controls.Add(this.AddToRecipeButton);
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
            this.UpdateTableButton.Click += new System.EventHandler(this.UpdateTableButton_Click);
            // 
            // UpdateSelectedButton
            // 
            this.UpdateSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateSelectedButton.Location = new System.Drawing.Point(3, 94);
            this.UpdateSelectedButton.Name = "UpdateSelectedButton";
            this.UpdateSelectedButton.Size = new System.Drawing.Size(194, 26);
            this.UpdateSelectedButton.TabIndex = 34;
            this.UpdateSelectedButton.Text = "Update Selected";
            this.UpdateSelectedButton.UseVisualStyleBackColor = true;
            this.UpdateSelectedButton.Click += new System.EventHandler(this.UpdateSelectedButton_Click);
            // 
            // DeleteFromRecipeButton
            // 
            this.DeleteFromRecipeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteFromRecipeButton.Location = new System.Drawing.Point(3, 68);
            this.DeleteFromRecipeButton.Name = "DeleteFromRecipeButton";
            this.DeleteFromRecipeButton.Size = new System.Drawing.Size(194, 26);
            this.DeleteFromRecipeButton.TabIndex = 33;
            this.DeleteFromRecipeButton.Text = "Delete From Recipe";
            this.DeleteFromRecipeButton.UseVisualStyleBackColor = true;
            this.DeleteFromRecipeButton.Click += new System.EventHandler(this.DeleteFromRecipeButton_Click);
            // 
            // AddAlternativeRecipeButton
            // 
            this.AddAlternativeRecipeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddAlternativeRecipeButton.Location = new System.Drawing.Point(3, 42);
            this.AddAlternativeRecipeButton.Name = "AddAlternativeRecipeButton";
            this.AddAlternativeRecipeButton.Size = new System.Drawing.Size(194, 26);
            this.AddAlternativeRecipeButton.TabIndex = 32;
            this.AddAlternativeRecipeButton.Text = "Add Alternative Recipe";
            this.AddAlternativeRecipeButton.UseVisualStyleBackColor = true;
            this.AddAlternativeRecipeButton.Click += new System.EventHandler(this.AddAlternativeRecipeButton_Click);
            // 
            // AddToRecipeButton
            // 
            this.AddToRecipeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddToRecipeButton.Location = new System.Drawing.Point(3, 16);
            this.AddToRecipeButton.Name = "AddToRecipeButton";
            this.AddToRecipeButton.Size = new System.Drawing.Size(194, 26);
            this.AddToRecipeButton.TabIndex = 31;
            this.AddToRecipeButton.Text = "Add To Recipe";
            this.AddToRecipeButton.UseVisualStyleBackColor = true;
            this.AddToRecipeButton.Click += new System.EventHandler(this.AddToRecipeButton_Click);
            // 
            // SelectedMaterialProperitiesGroup
            // 
            this.SelectedMaterialProperitiesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedMaterialProperitiesGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.AlternativeRecipeIdTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.AmountTextBox);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.AmountLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.UnitPriceLabel);
            this.SelectedMaterialProperitiesGroup.Controls.Add(this.RecipeIdTextBox);
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
            // AlternativeRecipeIdTextBox
            // 
            this.AlternativeRecipeIdTextBox.Enabled = false;
            this.AlternativeRecipeIdTextBox.Location = new System.Drawing.Point(158, 71);
            this.AlternativeRecipeIdTextBox.Name = "AlternativeRecipeIdTextBox";
            this.AlternativeRecipeIdTextBox.Size = new System.Drawing.Size(263, 20);
            this.AlternativeRecipeIdTextBox.TabIndex = 15;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(158, 97);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(263, 20);
            this.AmountTextBox.TabIndex = 12;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(9, 100);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(54, 13);
            this.AmountLabel.TabIndex = 21;
            this.AmountLabel.Text = "AMOUNT";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(9, 75);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(143, 13);
            this.UnitPriceLabel.TabIndex = 14;
            this.UnitPriceLabel.Text = "ALTERNATIVE_RECIPE_ID";
            // 
            // RecipeIdTextBox
            // 
            this.RecipeIdTextBox.Enabled = false;
            this.RecipeIdTextBox.Location = new System.Drawing.Point(158, 45);
            this.RecipeIdTextBox.Name = "RecipeIdTextBox";
            this.RecipeIdTextBox.Size = new System.Drawing.Size(263, 20);
            this.RecipeIdTextBox.TabIndex = 13;
            // 
            // CurrentStockLabel
            // 
            this.CurrentStockLabel.AutoSize = true;
            this.CurrentStockLabel.Location = new System.Drawing.Point(9, 48);
            this.CurrentStockLabel.Name = "CurrentStockLabel";
            this.CurrentStockLabel.Size = new System.Drawing.Size(63, 13);
            this.CurrentStockLabel.TabIndex = 2;
            this.CurrentStockLabel.Text = "RECIPE_ID";
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
            this.StockIdTextBox.Enabled = false;
            this.StockIdTextBox.Location = new System.Drawing.Point(117, 19);
            this.StockIdTextBox.Name = "StockIdTextBox";
            this.StockIdTextBox.Size = new System.Drawing.Size(304, 20);
            this.StockIdTextBox.TabIndex = 11;
            // 
            // LowerPanel
            // 
            this.LowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LowerPanel.Controls.Add(this.MaterialDataGrid);
            this.LowerPanel.Controls.Add(this.RecipePanel);
            this.LowerPanel.Location = new System.Drawing.Point(-1, 156);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(883, 406);
            this.LowerPanel.TabIndex = 3;
            // 
            // MaterialDataGrid
            // 
            this.MaterialDataGrid.AllowUserToAddRows = false;
            this.MaterialDataGrid.AllowUserToDeleteRows = false;
            this.MaterialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialDataGrid.Location = new System.Drawing.Point(0, 200);
            this.MaterialDataGrid.Name = "MaterialDataGrid";
            this.MaterialDataGrid.ReadOnly = true;
            this.MaterialDataGrid.Size = new System.Drawing.Size(883, 206);
            this.MaterialDataGrid.TabIndex = 1;
            this.MaterialDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialDataGrid_CellClick);
            // 
            // RecipePanel
            // 
            this.RecipePanel.Controls.Add(this.RecipeDataGrid);
            this.RecipePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RecipePanel.Location = new System.Drawing.Point(0, 0);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(883, 200);
            this.RecipePanel.TabIndex = 1;
            // 
            // RecipeDataGrid
            // 
            this.RecipeDataGrid.AllowUserToAddRows = false;
            this.RecipeDataGrid.AllowUserToDeleteRows = false;
            this.RecipeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecipeDataGrid.Location = new System.Drawing.Point(0, 0);
            this.RecipeDataGrid.Name = "RecipeDataGrid";
            this.RecipeDataGrid.ReadOnly = true;
            this.RecipeDataGrid.Size = new System.Drawing.Size(883, 200);
            this.RecipeDataGrid.TabIndex = 0;
            this.RecipeDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeDataGrid_CellClick);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecipeControlForm_FormClosing);
            this.Load += new System.EventHandler(this.RecipeControlForm_Load);
            this.UpperPanel.ResumeLayout(false);
            this.ActionsGroup.ResumeLayout(false);
            this.ActionsGroup.PerformLayout();
            this.OptionsGroup.ResumeLayout(false);
            this.SelectedMaterialProperitiesGroup.ResumeLayout(false);
            this.SelectedMaterialProperitiesGroup.PerformLayout();
            this.LowerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).EndInit();
            this.RecipePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGrid)).EndInit();
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
        private System.Windows.Forms.Button UpdateSelectedButton;
        private System.Windows.Forms.Button DeleteFromRecipeButton;
        private System.Windows.Forms.Button AddAlternativeRecipeButton;
        private System.Windows.Forms.Button AddToRecipeButton;
        private System.Windows.Forms.GroupBox SelectedMaterialProperitiesGroup;
        private System.Windows.Forms.TextBox AlternativeRecipeIdTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox RecipeIdTextBox;
        private System.Windows.Forms.Label CurrentStockLabel;
        private System.Windows.Forms.Label StockIDLabel;
        private System.Windows.Forms.TextBox StockIdTextBox;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.DataGridView RecipeDataGrid;
        private System.Windows.Forms.DataGridView MaterialDataGrid;
        private System.Windows.Forms.Panel RecipePanel;
    }
}