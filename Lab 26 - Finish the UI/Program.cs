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
 * Description: began adding table and basic elements.
 * Version: 0. -  
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
