using Obs_AdoNet.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obs_AdoNet
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Personel.Personel_Student_Process());
            //Application.Run(new Form1());
            //Application.Run(new Teacher_Screen());
            // Application.Run(new Teacher_Exam_Input());


        }
    }
}
