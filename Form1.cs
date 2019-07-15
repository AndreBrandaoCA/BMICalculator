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
                ResultLabel.Text = "" + Math.Round((WeightNumericInput.Value * 703) / (HeightNumericInput.Value * HeightNumericInput.Value));
            }
            else
            {
                ResultLabel.Visible = true;
                ResultLabel.Text = "" + Math.Round(WeightNumericInput.Value / (HeightNumericInput.Value * HeightNumericInput.Value));
            }
        }
    }
}
