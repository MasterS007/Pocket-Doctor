﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    class Pathologist : User
    {
        internal Pathologist(string userName, string password, string mobileNumber) : base(userName, password, mobileNumber)
        { }

        
     /*  internal override string UserId
        {
            
            set
            {
                base.UserId = value + "-P";
            }
        }*/
    }
}
