using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked)
            {
                ResultLabel.Visible = true;
                ResultLabel.Text = "" + Math.Round((Convert.ToDouble(WeightNumericTextBox.Text) * 703) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
            }
            else
            {
                ResultLabel.Visible = true;
                ResultLabel.Text = "" + Math.Round(Convert.ToDouble(WeightNumericTextBox.Text) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
            }
            ResultTitleLabel.Visible = true;
            ResultTableLayoutPanel.Visible = true;
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightNumericTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            HeightUnitLabel.Text = "mt";
            WeightUnitLabel.Text = "kg";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WeightNumericTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lb";
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateBMIButton.Enabled = false;
            ResultTitleLabel.Visible = false;
            ResultTableLayoutPanel.Visible = false;
        }

        private void WeightNumericTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HeightNumericTextBox.Text != string.Empty && WeightNumericTextBox.Text != string.Empty)
            {
                CalculateBMIButton.Enabled = true;
            }
            else
            {
                CalculateBMIButton.Enabled = false;
            }
        }

        private void HeightNumericTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HeightNumericTextBox.Text != string.Empty && WeightNumericTextBox.Text != string.Empty)
            {
                CalculateBMIButton.Enabled = true;
            }
            else
            {
                CalculateBMIButton.Enabled = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ImperialRadioButton.Checked = true;
            HeightNumericTextBox.Text = string.Empty;
            WeightNumericTextBox.Text = string.Empty;
            ResultTitleLabel.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            ResultTableLayoutPanel.Visible = false;
        }
    }
}
