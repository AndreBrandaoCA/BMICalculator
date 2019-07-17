namespace BMICalculator
{
    partial class BMICalculatorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeightNumericTextBox = new System.Windows.Forms.TextBox();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightNumericTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResultTitleLabel = new System.Windows.Forms.Label();
            this.ResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.24074F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.75926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.WeightNumericTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightUnitLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightUnitLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightNumericTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WeightNumericTextBox
            // 
            this.WeightNumericTextBox.Location = new System.Drawing.Point(131, 52);
            this.WeightNumericTextBox.Name = "WeightNumericTextBox";
            this.WeightNumericTextBox.Size = new System.Drawing.Size(97, 38);
            this.WeightNumericTextBox.TabIndex = 2;
            this.WeightNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightNumericTextBox.TextChanged += new System.EventHandler(this.WeightNumericTextBox_TextChanged);
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(244, 49);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(55, 46);
            this.WeightUnitLabel.TabIndex = 5;
            this.WeightUnitLabel.Text = "lb";
            this.WeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Location = new System.Drawing.Point(244, 0);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(55, 49);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "in";
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(122, 49);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightNumericTextBox
            // 
            this.HeightNumericTextBox.Location = new System.Drawing.Point(131, 3);
            this.HeightNumericTextBox.Name = "HeightNumericTextBox";
            this.HeightNumericTextBox.Size = new System.Drawing.Size(97, 38);
            this.HeightNumericTextBox.TabIndex = 1;
            this.HeightNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightNumericTextBox.TextChanged += new System.EventHandler(this.HeightNumericTextBox_TextChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 49);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(122, 46);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(20, 0);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 5;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(172, 0);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 6;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateBMIButton.Location = new System.Drawing.Point(8, 139);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(140, 40);
            this.CalculateBMIButton.TabIndex = 3;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResultTitleLabel
            // 
            this.ResultTitleLabel.AutoSize = true;
            this.ResultTitleLabel.Location = new System.Drawing.Point(87, 186);
            this.ResultTitleLabel.Name = "ResultTitleLabel";
            this.ResultTitleLabel.Size = new System.Drawing.Size(92, 31);
            this.ResultTitleLabel.TabIndex = 5;
            this.ResultTitleLabel.Text = "Result";
            // 
            // ResultProgressBar
            // 
            this.ResultProgressBar.Location = new System.Drawing.Point(1, 363);
            this.ResultProgressBar.Name = "ResultProgressBar";
            this.ResultProgressBar.Size = new System.Drawing.Size(302, 23);
            this.ResultProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ResultProgressBar.TabIndex = 6;
            this.ResultProgressBar.Visible = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(2, 217);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(298, 45);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultLabel.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Location = new System.Drawing.Point(160, 139);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(140, 40);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultProgressBar);
            this.Controls.Add(this.ResultTitleLabel);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label ResultTitleLabel;
        private System.Windows.Forms.ProgressBar ResultProgressBar;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox HeightNumericTextBox;
        private System.Windows.Forms.TextBox WeightNumericTextBox;
        private System.Windows.Forms.Button ResetButton;
    }
}

