using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    internal class Doctor : User
    {
       
        internal Doctor( string userName, string password, string mobileNumber,string role) : base( userName, password, mobileNumber,role)
        { }

    

      /*  internal override string UserId
        {
            set
            {
                base.UserId = value + "-D";

            }
            
        }*/


    }
}
