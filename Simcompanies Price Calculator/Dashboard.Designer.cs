namespace Simcompanies_Price_Calculator {
    partial class Dashboard {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.QuickCalcGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MP3TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MP2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MPTextBox = new System.Windows.Forms.TextBox();
            this.ManualCalcGroupBox = new System.Windows.Forms.GroupBox();
            this.PercentTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QualityTextBox = new System.Windows.Forms.TextBox();
            this.MarketNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MarketIDTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.QuickCalcGroupBox.SuspendLayout();
            this.ManualCalcGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SimCompanies Price Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuickCalcGroupBox
            // 
            this.QuickCalcGroupBox.Controls.Add(this.label5);
            this.QuickCalcGroupBox.Controls.Add(this.MP3TextBox);
            this.QuickCalcGroupBox.Controls.Add(this.label4);
            this.QuickCalcGroupBox.Controls.Add(this.MP2TextBox);
            this.QuickCalcGroupBox.Controls.Add(this.label3);
            this.QuickCalcGroupBox.Controls.Add(this.MPTextBox);
            this.QuickCalcGroupBox.Location = new System.Drawing.Point(9, 105);
            this.QuickCalcGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuickCalcGroupBox.Name = "QuickCalcGroupBox";
            this.QuickCalcGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuickCalcGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuickCalcGroupBox.Size = new System.Drawing.Size(333, 100);
            this.QuickCalcGroupBox.TabIndex = 3;
            this.QuickCalcGroupBox.TabStop = false;
            this.QuickCalcGroupBox.Text = "Quick Values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "-3% MP:";
            // 
            // MP3TextBox
            // 
            this.MP3TextBox.Location = new System.Drawing.Point(89, 68);
            this.MP3TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MP3TextBox.Name = "MP3TextBox";
            this.MP3TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MP3TextBox.Size = new System.Drawing.Size(89, 23);
            this.MP3TextBox.TabIndex = 7;
            this.MP3TextBox.Text = "$470.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 44);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "-2% MP:";
            // 
            // MP2TextBox
            // 
            this.MP2TextBox.Location = new System.Drawing.Point(89, 42);
            this.MP2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MP2TextBox.Name = "MP2TextBox";
            this.MP2TextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MP2TextBox.Size = new System.Drawing.Size(89, 23);
            this.MP2TextBox.TabIndex = 7;
            this.MP2TextBox.Text = "$470.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Market Price:";
            // 
            // MPTextBox
            // 
            this.MPTextBox.Location = new System.Drawing.Point(89, 15);
            this.MPTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MPTextBox.Name = "MPTextBox";
            this.MPTextBox.ReadOnly = true;
            this.MPTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MPTextBox.Size = new System.Drawing.Size(89, 23);
            this.MPTextBox.TabIndex = 5;
            this.MPTextBox.Text = "$470.00";
            // 
            // ManualCalcGroupBox
            // 
            this.ManualCalcGroupBox.Controls.Add(this.PercentTextBox);
            this.ManualCalcGroupBox.Controls.Add(this.label9);
            this.ManualCalcGroupBox.Controls.Add(this.PriceTextBox);
            this.ManualCalcGroupBox.Location = new System.Drawing.Point(9, 209);
            this.ManualCalcGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManualCalcGroupBox.Name = "ManualCalcGroupBox";
            this.ManualCalcGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManualCalcGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManualCalcGroupBox.Size = new System.Drawing.Size(333, 45);
            this.ManualCalcGroupBox.TabIndex = 9;
            this.ManualCalcGroupBox.TabStop = false;
            this.ManualCalcGroupBox.Text = "Manual Values";
            // 
            // PercentTextBox
            // 
            this.PercentTextBox.Location = new System.Drawing.Point(179, 15);
            this.PercentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PercentTextBox.Name = "PercentTextBox";
            this.PercentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PercentTextBox.Size = new System.Drawing.Size(72, 23);
            this.PercentTextBox.TabIndex = 9;
            this.PercentTextBox.Text = "3%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 17);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(159, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Calculate discount (percent):";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(256, 15);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceTextBox.Size = new System.Drawing.Size(72, 23);
            this.PriceTextBox.TabIndex = 5;
            this.PriceTextBox.Text = "$470.00";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(265, 258);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(77, 26);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.label6);
            this.InfoGroupBox.Controls.Add(this.QualityTextBox);
            this.InfoGroupBox.Controls.Add(this.MarketNameTextBox);
            this.InfoGroupBox.Controls.Add(this.label2);
            this.InfoGroupBox.Controls.Add(this.MarketIDTextBox);
            this.InfoGroupBox.Location = new System.Drawing.Point(12, 24);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(330, 76);
            this.InfoGroupBox.TabIndex = 11;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quality:";
            // 
            // QualityTextBox
            // 
            this.QualityTextBox.Location = new System.Drawing.Point(84, 43);
            this.QualityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QualityTextBox.Name = "QualityTextBox";
            this.QualityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QualityTextBox.Size = new System.Drawing.Size(47, 23);
            this.QualityTextBox.TabIndex = 16;
            this.QualityTextBox.Text = "2";
            // 
            // MarketNameTextBox
            // 
            this.MarketNameTextBox.Location = new System.Drawing.Point(135, 16);
            this.MarketNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarketNameTextBox.Name = "MarketNameTextBox";
            this.MarketNameTextBox.Size = new System.Drawing.Size(189, 23);
            this.MarketNameTextBox.TabIndex = 15;
            this.MarketNameTextBox.Text = "On-Board Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Resource:";
            // 
            // MarketIDTextBox
            // 
            this.MarketIDTextBox.Location = new System.Drawing.Point(84, 16);
            this.MarketIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarketIDTextBox.Name = "MarketIDTextBox";
            this.MarketIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MarketIDTextBox.Size = new System.Drawing.Size(47, 23);
            this.MarketIDTextBox.TabIndex = 13;
            this.MarketIDTextBox.Text = "47";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(9, 258);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(77, 26);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "&Refresh...";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 297);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ManualCalcGroupBox);
            this.Controls.Add(this.QuickCalcGroupBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SimCompanies Price Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QuickCalcGroupBox.ResumeLayout(false);
            this.QuickCalcGroupBox.PerformLayout();
            this.ManualCalcGroupBox.ResumeLayout(false);
            this.ManualCalcGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox QuickCalcGroupBox;
        private Label label3;
        private Label label5;
        private Label label4;
        private GroupBox ManualCalcGroupBox;
        private Label label9;
        private Button CloseButton;
        private GroupBox InfoGroupBox;
        private Label label6;
        private Label label2;
        private Button RefreshButton;
        public TextBox MPTextBox;
        public TextBox MP3TextBox;
        public TextBox MP2TextBox;
        public TextBox PriceTextBox;
        public TextBox PercentTextBox;
        public TextBox QualityTextBox;
        public TextBox MarketNameTextBox;
        public TextBox MarketIDTextBox;
    }
}