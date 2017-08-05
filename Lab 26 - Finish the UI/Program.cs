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
 * Description: Changed background of multiline BMI display textbox and heigth and weight textbox
 * Version: 0.4 -  
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
