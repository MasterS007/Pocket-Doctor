using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject
{
    internal class Doctor : User
    {
        internal Doctor():base()
        { }
        internal Doctor( string userName, string password, string mobileNumber) : base( userName, password, mobileNumber)
        {
           
            
        }

        internal override string UserId
        {
            set
            {
                base.UserId = value + "D";
            }

        }
      
    }
}
