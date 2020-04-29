using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.View;

namespace WindowsFormsAppPocketDoctorProject
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
            // Application.Run(new FormLogin());
           //  Application.Run(new FormSignUp());
             Application.Run(new FormDoctor());
            // Application.Run(new FormReceptonist());
            // Application.Run(new FormPatient());
            // Application.Run(new FormPathologist());
          // Application.Run(new FormAppointment());


        }
    }
}
