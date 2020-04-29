using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    internal class Doctor : User
    {
        internal string dr_id { get; set; }
        internal string dr_catagory { get; set; }
        internal int info_id { get; set; }
        internal float earnings { get; set; }
        internal string educational_background {get;set;}

        internal float commission { get; set; }

        internal Doctor() { }

        internal Doctor(string userName, string password, string mobileNumber) : base(userName, password, mobileNumber)
        {
        }


    }
}
