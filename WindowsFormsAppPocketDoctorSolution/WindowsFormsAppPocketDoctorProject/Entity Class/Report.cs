using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    class Report
    {
        internal int rep_id { get; set; }
        internal int t_id { get; set; }
        internal string p_id { get; set; }
        internal DateTime issue_date { get; set; }
        internal DateTime due_date { get; set; }
        internal string rep_name { get; set; }
        internal byte[] report { get; set; }
    }
}
