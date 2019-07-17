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
            double result = 0;
            if (ImperialRadioButton.Checked)
            {
                ResultLabel.Visible = true;
                result = Math.Round((Convert.ToDouble(WeightNumericTextBox.Text) * 703) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
                ResultLabel.Text = "" + Convert.ToInt32(result);
                ResultProgressBar.Value = Convert.ToInt32(result);
            }
            else
            {
                ResultLabel.Visible = true;
                result = Math.Round(Convert.ToDouble(WeightNumericTextBox.Text) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
                ResultLabel.Text = "" + Convert.ToInt32(result);
                ResultProgressBar.Value = Convert.ToInt32(result);
            }
            ResultTitleLabel.Visible = true;
            ResultProgressBar.Visible = true;
            ResultTableLayoutPanel.Visible = true;
            if (result < 18.5){
                ResultProgressBar.ForeColor = Color.LightYellow;
            }
            else if (result >= 18.5 && result< 24.9)
            {
                ResultProgressBar.ForeColor = Color.LightGreen;
            }
            else if (result >= 25  && result < 30)
            {
                ResultProgressBar.ForeColor = Color.Wheat;
            }
            else
            {
                ResultProgressBar.ForeColor = Color.Pink;
            }
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
            HeightNumericTextBox.Text = string.Empty;
            WeightNumericTextBox.Text = string.Empty;
            ResultTitleLabel.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            ResultProgressBar.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
            ResultProgressBar.Value = 0;
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lb";
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateBMIButton.Enabled = false;
            ResultTitleLabel.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
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
            ResultProgressBar.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
            ResultProgressBar.Value = 0;
        }
    }
}
