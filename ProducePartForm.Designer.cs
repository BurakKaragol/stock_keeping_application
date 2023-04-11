namespace stock_keeping_application
{
    partial class ProducePartForm
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
            this.UpperPanel.SuspendLayout();
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
            this.UpperPanel.Location = new System.Drawing.Point(1, 2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(882, 40);
            this.UpperPanel.TabIndex = 1;
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(628, 8);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(251, 23);
            this.ReportButton.TabIndex = 6;
            this.ReportButton.Text = "How Much Can I Produce With My Stock";
            this.ReportButton.UseVisualStyleBackColor = true;
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
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(502, 8);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(120, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(282, 10);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 20);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
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
            // 
            // ProducePartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.UpperPanel);
            this.Name = "ProducePartForm";
            this.Text = "Produce Part";
            this.Load += new System.EventHandler(this.ProducePartForm_Load);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockIdTextBox;
    }
}