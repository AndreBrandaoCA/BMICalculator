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
            this.ResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ObeseLabel = new System.Windows.Forms.Label();
            this.OverweightLabel = new System.Windows.Forms.Label();
            this.NormalWeightLabel = new System.Windows.Forms.Label();
            this.UnderwightLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ResultTableLayoutPanel.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
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
            this.WeightNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightNumericTextBox.Location = new System.Drawing.Point(134, 52);
            this.WeightNumericTextBox.MaxLength = 4;
            this.WeightNumericTextBox.Name = "WeightNumericTextBox";
            this.WeightNumericTextBox.Size = new System.Drawing.Size(109, 38);
            this.WeightNumericTextBox.TabIndex = 2;
            this.WeightNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightNumericTextBox.TextChanged += new System.EventHandler(this.WeightNumericTextBox_TextChanged);
            this.WeightNumericTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightNumericTextBox_KeyPress);
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(249, 49);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(50, 46);
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
            this.HeightUnitLabel.Location = new System.Drawing.Point(249, 0);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(50, 49);
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
            this.HeightLabel.Size = new System.Drawing.Size(125, 49);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightNumericTextBox
            // 
            this.HeightNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightNumericTextBox.Location = new System.Drawing.Point(134, 3);
            this.HeightNumericTextBox.MaxLength = 4;
            this.HeightNumericTextBox.Name = "HeightNumericTextBox";
            this.HeightNumericTextBox.Size = new System.Drawing.Size(109, 38);
            this.HeightNumericTextBox.TabIndex = 1;
            this.HeightNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightNumericTextBox.TextChanged += new System.EventHandler(this.HeightNumericTextBox_TextChanged);
            this.HeightNumericTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightNumericTextBox_KeyPress);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 49);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(125, 46);
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
            this.ResultTitleLabel.Location = new System.Drawing.Point(93, 186);
            this.ResultTitleLabel.Name = "ResultTitleLabel";
            this.ResultTitleLabel.Size = new System.Drawing.Size(126, 31);
            this.ResultTitleLabel.TabIndex = 5;
            this.ResultTitleLabel.Text = "Your BMI";
            // 
            // ResultProgressBar
            // 
            this.ResultProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultProgressBar.Location = new System.Drawing.Point(1, 265);
            this.ResultProgressBar.Maximum = 50;
            this.ResultProgressBar.Name = "ResultProgressBar";
            this.ResultProgressBar.Size = new System.Drawing.Size(302, 33);
            this.ResultProgressBar.Step = 40;
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
            // ResultTableLayoutPanel
            // 
            this.ResultTableLayoutPanel.ColumnCount = 1;
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.Controls.Add(this.ObeseLabel, 0, 3);
            this.ResultTableLayoutPanel.Controls.Add(this.OverweightLabel, 0, 2);
            this.ResultTableLayoutPanel.Controls.Add(this.NormalWeightLabel, 0, 1);
            this.ResultTableLayoutPanel.Controls.Add(this.UnderwightLabel, 0, 0);
            this.ResultTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTableLayoutPanel.Location = new System.Drawing.Point(-2, 307);
            this.ResultTableLayoutPanel.Name = "ResultTableLayoutPanel";
            this.ResultTableLayoutPanel.RowCount = 4;
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.ResultTableLayoutPanel.Size = new System.Drawing.Size(313, 134);
            this.ResultTableLayoutPanel.TabIndex = 8;
            // 
            // ObeseLabel
            // 
            this.ObeseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObeseLabel.AutoSize = true;
            this.ObeseLabel.BackColor = System.Drawing.Color.Pink;
            this.ObeseLabel.Location = new System.Drawing.Point(3, 100);
            this.ObeseLabel.Name = "ObeseLabel";
            this.ObeseLabel.Size = new System.Drawing.Size(307, 34);
            this.ObeseLabel.TabIndex = 6;
            this.ObeseLabel.Text = "Obese               < 30";
            this.ObeseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OverweightLabel
            // 
            this.OverweightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverweightLabel.AutoSize = true;
            this.OverweightLabel.BackColor = System.Drawing.Color.Wheat;
            this.OverweightLabel.Location = new System.Drawing.Point(3, 68);
            this.OverweightLabel.Name = "OverweightLabel";
            this.OverweightLabel.Size = new System.Drawing.Size(307, 32);
            this.OverweightLabel.TabIndex = 4;
            this.OverweightLabel.Text = "Overweight       <=25  > 29.9";
            this.OverweightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NormalWeightLabel
            // 
            this.NormalWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalWeightLabel.AutoSize = true;
            this.NormalWeightLabel.BackColor = System.Drawing.Color.LightGreen;
            this.NormalWeightLabel.Location = new System.Drawing.Point(3, 34);
            this.NormalWeightLabel.Name = "NormalWeightLabel";
            this.NormalWeightLabel.Size = new System.Drawing.Size(307, 34);
            this.NormalWeightLabel.TabIndex = 2;
            this.NormalWeightLabel.Text = "Normal             <=18.5 <24.9";
            this.NormalWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UnderwightLabel
            // 
            this.UnderwightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderwightLabel.AutoSize = true;
            this.UnderwightLabel.BackColor = System.Drawing.Color.LightYellow;
            this.UnderwightLabel.Location = new System.Drawing.Point(3, 0);
            this.UnderwightLabel.Name = "UnderwightLabel";
            this.UnderwightLabel.Size = new System.Drawing.Size(307, 34);
            this.UnderwightLabel.TabIndex = 0;
            this.UnderwightLabel.Text = "Underweight     > 18.5";
            this.UnderwightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResultTableLayoutPanel);
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
            this.ResultTableLayoutPanel.ResumeLayout(false);
            this.ResultTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel ResultTableLayoutPanel;
        private System.Windows.Forms.Label ObeseLabel;
        private System.Windows.Forms.Label OverweightLabel;
        private System.Windows.Forms.Label NormalWeightLabel;
        private System.Windows.Forms.Label UnderwightLabel;
    }
}

