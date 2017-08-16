using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Linlin Han
 * Number: 300883493
 * Date: August 15, 2017
 * Description: A BMI calculator app with Windows Forms
 * Version: 0.1
 */

namespace COMP123_S2017_Assignment5
{
    static class Program
    {
        //Create Reference to Forms
        public static BMICalculator BMIcalculator;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BMIcalculator = new BMICalculator();
            Application.Run(new SplashForm());
        }
    }
}
