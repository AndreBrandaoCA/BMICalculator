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
        /// <summary>
        /// This method hide result and disable Calculate BMI button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateBMIButton.Enabled = false;
            ResultTitleLabel.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
        }
        /// <summary>
        /// This method will calculate BMI whenever the user presses the CalculateBMIButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double result = 0;
            // check if the radio button selected is Imperial or Metric
            if (ImperialRadioButton.Checked)
            {
                ResultTitleLabel.Visible = true;
                ResultLabel.Visible = true;
                result = Math.Round((Convert.ToDouble(WeightNumericTextBox.Text) * 703) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
                ResultLabel.Text = "" + Convert.ToInt32(result);
                ResultProgressBar.Value = Convert.ToInt32(result);
            }
            else
            {
                ResultTitleLabel.Visible = true;
                ResultLabel.Visible = true;
                result = Math.Round(Convert.ToDouble(WeightNumericTextBox.Text) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
                ResultLabel.Text = "" + Convert.ToInt32(result);
                ResultProgressBar.Value = Convert.ToInt32(result);
            }
            //Make result visible and fill the progress bar
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
        /// <summary>
        /// This method clear all the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// This method clear Height and Weight input textbox and modify labels to match Metric system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightNumericTextBox.Text = string.Empty;
            WeightNumericTextBox.Text = string.Empty;
            ResultTitleLabel.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            ResultProgressBar.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
            ResultProgressBar.Value = 0;
            HeightUnitLabel.Text = "mt";
            WeightUnitLabel.Text = "kg";
        }
        /// <summary>
        /// This method clear Height and Weight input textbox and modify labels to match Imperial system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightNumericTextBox.Text = string.Empty;
            WeightNumericTextBox.Text = string.Empty;
            ResultTitleLabel.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            ResultProgressBar.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Value = 0;
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lb";
        }
        /// <summary>
        /// This method checks if the field WeightNumericTextBox is filled and if true enable CalculateBMI Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// This method checks HeightNumericTextBox entry for digits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightNumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// This method checks if the field HeightNumericTextBox is filled and if true enable CalculateBMI Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// This method checks WeightNumericTextBox entry for digits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightNumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BMICalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
