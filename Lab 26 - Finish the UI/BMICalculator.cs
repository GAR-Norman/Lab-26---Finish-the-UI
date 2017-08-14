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
    public partial class BMI : Form
    {

        /*
 * Name: Gabriel Norman 
 * Student#: 300897331
 * Date: August 13th, 2017
 * Description: This is the Form Class
 * Version: 0.2 - Added a clear button and created method to show result text box value
 */


        //Private Instance Variables
        private bool _metricTrue;
        private bool _imperialTrue;
        private double _height;
        private double _weight;
        private double _bMI;

        //Public properties 
        public bool MetricTrue {
            get
            {
                return this._metricTrue;
            }
        set
            {
                this._metricTrue = value;
            }
        }


        public bool ImperialTrue
        {
            get
            {
                return this._imperialTrue;
            }
            set
            {
                this._imperialTrue = value;
            }
        }

        public double Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }

        public double HeightVal
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }


        public double BMIVal
        {
            get
            {
                return this._bMI;
            }
            set
            {
                this._bMI = value;
            }
        }


        /// <summary>
        /// This is the main class constructor for the BMI calculator
        /// </summary> 
        /// 


        //Constructor
        public BMI()
        {
            InitializeComponent();
            this.HeightVal = Convert.ToDouble(MyHeightTextbox.Text);
            this.Weight = Convert.ToDouble(WeightTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImperialRadioButtonClickChanged(object sender, EventArgs e)
        {
            this.MetricTrue = false;
            this.ImperialTrue = true;
            
        }


        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {

            this.ImperialTrue = false;
            this.MetricTrue = true; 


        }


        private void CalculateBMI(object sender, EventArgs e)
        {

            if(this.ImperialTrue == true)
            {
                double multipliedWeight = Weight * 703;
                double multipliedHeight = Height * Height;
                BMIVal = multipliedWeight / multipliedHeight;
                
            }

            if(this.MetricTrue == true)
            {
                double multipliedWeight = Weight * 703;
                double multipliedHeight = Height * Height;
                BMIVal = multipliedWeight / multipliedHeight;
               
            }

            ShowBMI();

        }

        private void ShowBMI()
        {
            if (BMIVal < 18.5 )
            {
                ResultTextBox.Text = "UnderWeight";
            } 

           else if((BMIVal >= 18.5) && (BMIVal < 25))
            {
                ResultTextBox.Text = "Normal";
            }

            else if ((BMIVal >= 25) && (BMIVal < 30))
            {
                ResultTextBox.Text = "OverWeight";
            }

            else if (BMIVal <= 30)
            {
                ResultTextBox.Text = "Obese";
            }
        }
    }
}
