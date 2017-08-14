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
 * Description: This is the driver class
 * Version: 0.1 - This is the form class - created private instance variables, 
 * properties, basic methods and event handlers.
 */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMI());
        }
    }
}
