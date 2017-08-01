using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name : Gursharan Singh
 * Student Id: 300931676
 * Date : 1st august ,2017
 * Description : Demo application to showcase windows forms and ui controls
 * Version : 0.1 Program was created
 */
namespace Comp123___Lesson_12__Summmer2017
{
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
            Application.Run(new DemoForm());
        }
    }
}
