using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Controll_App
{
    static class Program
    {
        static Interface MyInterface;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyInterface = new Interface();
            Application.Run(MyInterface);


        }
    }
}
