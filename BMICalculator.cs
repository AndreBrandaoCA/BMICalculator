using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Author: Andre Brandao Teodor
/// ID: 300944427
/// Last Modified: 2019-07-17
/// Description:
///         Program calculates user's BMI acording to the inputs given
/// History:
///     2019-07-14
///         Interface design and BMI calculations created
///         Form rename
///     2019-07-17
///         Height and Weight textbox included, Label change when different unit selected
///         Reset Button created
///         Progress Bar created and colors ajusted
///         Refactoring and documentation
///         SplashScreen added
/// </summary>
namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        #region Show results method
        /// <summary>
        /// Show result controls
        /// </summary>
        private void _ShowResults()
        {
            ResultTitleLabel.Visible = true;
            ResultTextBox.Visible = true;
            ResultProgressBar.Visible = true;
            ResultTableLayoutPanel.Visible = true;
        }
        #endregion
        #region Hide results method
        /// <summary>
        /// Hide result controls
        /// </summary>
        private void _HideResults()
        {
            ResultTextBox.Visible = false;
            ResultTitleLabel.Visible = false;
            ResultTableLayoutPanel.Visible = false;
            ResultProgressBar.Visible = false;
        }
        #endregion
        #region Reset results method
        /// <summary>
        /// Reset result controls
        /// </summary>
        private void _ResetResults()
        {
            HeightNumericTextBox.Text = string.Empty;
            WeightNumericTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
            ResultProgressBar.Value = 0;
        }
        #endregion
        #region Form Load
        /// <summary>
        /// This method hide result and disable Calculate BMI button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateBMIButton.Enabled = false;
            _HideResults();
        }
        #endregion
        #region Calculate BMI Button
        /// <summary>
        /// This method will calculate BMI whenever the user presses the CalculateBMIButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double result = 0;
            if (WeightNumericTextBox.Text != "0" && HeightNumericTextBox.Text != "0")
            {
                // check if the radio button selected is Imperial or Metric and calculate BMI acordingly
                if (ImperialRadioButton.Checked)
                {
                    result = Math.Round((Convert.ToDouble(WeightNumericTextBox.Text) * 703) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
                    ResultTextBox.Text = "" + Convert.ToInt32(result);
                    if (result < 50)
                    {
                        ResultProgressBar.Value = Convert.ToInt32(result);
                    } else { ResultProgressBar.Value = 50; }
                }
                else
                {
                    result = Math.Round(Convert.ToDouble(WeightNumericTextBox.Text) / (Convert.ToDouble(HeightNumericTextBox.Text) * Convert.ToDouble(HeightNumericTextBox.Text)));
                    ResultTextBox.Text = "" + Convert.ToInt32(result);
                    if (result < 50)
                    {
                        ResultProgressBar.Value = Convert.ToInt32(result);
                    }
                    else { ResultProgressBar.Value = 50; }

                }
                _ShowResults();
            }
            else
            {
                ResultTextBox.Text = "Invalid entry";
            }
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
        #endregion
        #region Reset Button
        /// <summary>
        /// This method clear all the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ImperialRadioButton.Checked = true;
            _ResetResults();
            _HideResults();
        }
        #endregion
        #region Change units to Metric
        /// <summary>
        /// This method clear Height and Weight input textbox and modify labels to match Metric system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _ResetResults();
            _HideResults();
            HeightUnitLabel.Text = "mt";
            WeightUnitLabel.Text = "kg";
        }
        #endregion
        #region Change units to Imperial
        /// <summary>
        /// This method clear Height and Weight input textbox and modify labels to match Imperial system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _ResetResults();
            _HideResults();
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lb";
        }
        #endregion
        #region Enable Calculate BMI Button if both fields are filled
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
        #endregion
        #region Check for numbers in Height field
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
        #endregion
        #region Enable Calculate BMI Button
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
        #endregion
        #region Check for numbers in Weight field
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
        #endregion
        #region Exit
        private void BMICalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
