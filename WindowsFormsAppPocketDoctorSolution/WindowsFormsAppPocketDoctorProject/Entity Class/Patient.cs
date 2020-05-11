using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Data_Layer;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    class Patient
    {
        internal Patient() { }
        internal Patient(string name, int age, string mobilenumber, string bloodgroup)
        {   
            this.name = name;
            this.age = age;
            this.mobilenumber = mobilenumber;
            this.bloodgroup = bloodgroup;
        }

        internal string gender
        { get; set; }

        internal string name
        { get; set; }
        internal int age
        { get; set; }
        internal string mobilenumber
        { get; set; }

        internal string p_id
        { set; get; }

        internal string bloodgroup { get; set; }
       

    }
}
