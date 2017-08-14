using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_26___Finish_the_UI
{
    static class Program
    {
        /*
 * Name: Gabriel Norman 
 * Student#: 300897331
 * Date: August 13th, 2017
 * Description: This is the Form Class
 * Version: 0.5 built splash form and completed project
 */
        public static BMI bmi; 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bmi = new BMI();
            Application.Run(new SplashForm());
            Application.Run(new BMI());
        }
    }
}
