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
 * Date: August 4th, 2017
 * Student#300897331
 * Description: Added form fields (Radio buttons for metric and imperial, label and texboxes for 
 * weight and height).
 * Version: 0.2 -  
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
