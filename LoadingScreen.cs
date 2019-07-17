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
    public partial class LoadingScreenForm : Form
    {
        public LoadingScreenForm()
        {
            InitializeComponent();
        }

        private void LoadingScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = true;
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            BMICalculatorForm bmi = new BMICalculatorForm();
            bmi.Show();
            this.Hide();
        }
    }
}
