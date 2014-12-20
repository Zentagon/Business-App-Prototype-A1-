using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Business_Application__PC_Prototype_A1_
{
    public class Calc
    {
        public double Add(double x, double y)
        {
            double sum = x + y;
            return sum;
        }
        public double Subtract(double x, double y)
        {
            double sum = x - y;
            return sum;
        }
        public double Multiply(double x, double y)
        {
            double sum = x * y;
            return sum;
        }
        public double Divide(double x, double y)
        {
            double sum = x / y;
            return sum;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
