using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    class Appointment
    {
        internal int appt_id { get; set; }
        internal string dr_id { get; set;}
        internal string p_id { get; set; }
        internal DateTime visiting_date { get ; set; }
    }
}
