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
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "mt";
            WeightUnitLabel.Text = "kg";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lb";
        }
    }
}
