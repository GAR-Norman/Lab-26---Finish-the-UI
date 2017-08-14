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
 * Version: 0.3 - Got a working version of the app. 
 * Simply need to work on results bar and reset button.
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
