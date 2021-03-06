﻿using System;
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
* Date: August 14th, 2017
* Description: This is the Form Class
* Version: 0.7 Added closing event for form
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
            
        }


        // Private Methods


        /// <summary>
        /// Checks to see which radio button selected alters bool fields accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButtonClickChanged(object sender, EventArgs e)
        {
            this.MetricTrue = false;
            this.ImperialTrue = true;
            
        }

        /// <summary>
        /// Checks to see which radio button selected alters bool fields accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {

            this.ImperialTrue = false;
            this.MetricTrue = true; 


        }


        /// <summary>
        /// Calculates BMI value, converts text to double datatype and resets the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMI(object sender, EventArgs e)
        {

            BmiProgressBar.Value = 0;
            try
            {
                this.HeightVal = Convert.ToDouble(MyHeightTextbox.Text);
                this.Weight = Convert.ToDouble(WeightTextBox.Text);
            }
            catch 
            {

                this.HeightVal = 0;
                this.Weight = 0;
                ResultTextBox.Text = "Only use numbers!";
            }
                

            

            if (this.ImperialTrue == true)
            {
                double multipliedWeight = Weight * 703;
                double multipliedHeight = HeightVal * HeightVal;
                this.BMIVal = multipliedWeight / multipliedHeight;


            }

            else if(this.MetricTrue == true)
            {
                double multipliedWeight = Weight;
                double multipliedHeight = HeightVal * HeightVal;
                this.BMIVal = multipliedWeight / multipliedHeight;

            } 

            ShowBMI();

        }


        /// <summary>
        /// Initiates progress bar timer and displays approprite values in textboxes
        /// </summary>
        private void ShowBMI()
        {
            if (BMIVal < 18.5 )
            {
                this.ProgressBarTimer.Start(); 

                ResultTextBox.Text = "";
                ResultTextBox.Text = "UnderWeight";
                BMIResultTextbox.Text = Convert.ToString(BMIVal);
            } 

          else if((BMIVal >= 18.5) && (BMIVal < 25))
            {
                this.ProgressBarTimer.Start(); 

                ResultTextBox.Text = "";
                ResultTextBox.Text = "Normal";
                BMIResultTextbox.Text = Convert.ToString(BMIVal);
            }

           else if ((BMIVal >= 25) && (BMIVal < 30))
            {
                this.ProgressBarTimer.Start();

                ResultTextBox.Text = "";
                ResultTextBox.Text = "OverWeight";
                BMIResultTextbox.Text = Convert.ToString(BMIVal);
            }

           else if (BMIVal >= 30)
            {
                this.ProgressBarTimer.Start();
                

                ResultTextBox.Text = "";
                ResultTextBox.Text = "Obese";
                BMIResultTextbox.Text = Convert.ToString(BMIVal);


            }
        }

        /// <summary>
        /// Starts Progress Bar timer ticker and loads or clears progress bar accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {

            if (BMIResultTextbox.Text == "")
            {
                this.BmiProgressBar.Increment(0);
            }

            else if (BMIVal < 18.5)
            { 

                this.BmiProgressBar.Increment(25);
                this.BmiProgressBar.Value = 15;

            }

            else if ((BMIVal >= 18.5) && (BMIVal < 25))
            {
                this.BmiProgressBar.Increment(10);
                this.BmiProgressBar.Value = 45;
            }

            else if ((BMIVal >= 25) && (BMIVal < 30))
            {
                this.BmiProgressBar.Increment(5);
                this.BmiProgressBar.Value = 70;
            }

            else if (BMIVal >= 30)
            {
                this.BmiProgressBar.Increment(5);
                this.BmiProgressBar.Value = 100;
            }  

            
        }

        /// <summary>
        /// Resets all form Values To Default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {


            BMIResultTextbox.Text = "";
            ResultTextBox.Text = "";
            BmiProgressBar.Value = 0;
            MyHeightTextbox.Text = "0";
            WeightTextBox.Text = "0";
            MetricButton.Checked = false;
            ImperialRadioButton.Checked = true;


        } 

        //Kills the application upon form closing event
        private void BMI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
