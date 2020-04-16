using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    class DoctorPatient
    {
        internal int dr_id { get; set;}
        internal int p_id { get; set; }
        internal DateTime visiting_date { get ; set; }
    }
}
