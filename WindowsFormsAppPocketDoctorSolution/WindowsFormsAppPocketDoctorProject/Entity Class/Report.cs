using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    class Report
    {
        private int rep_id { get; set; }
        private int t_id { get; set; }
        private string p_id { get; set; }
        private DateTime issue_date { get; set; }
        private DateTime due_date { get; set; }
        private string rep_name { get; set; }
        private byte[] report { get; set; }
    }
}
