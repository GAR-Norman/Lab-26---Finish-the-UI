using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_26___Finish_the_UI
{
    public partial class SplashForm : Form
    {

        /*
* Name: Gabriel Norman 
* Student#: 300897331
* Date: August 13th, 2017
* Description: This is the SplashForm Class
*  Version: 0.7 Added closing event for form
*/
        public SplashForm()
        {
            InitializeComponent();
        }

        public BMI BMI1
        {
            get
            {
                return Program.bmi;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BMI1.Show();
            this.Hide();
            SplashTimer.Enabled = false;
        }
    }
}
