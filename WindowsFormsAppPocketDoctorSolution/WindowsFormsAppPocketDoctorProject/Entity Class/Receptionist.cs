using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    internal class Receptionist:User
    {

        internal Receptionist(string userName, string password, string mobileNumber) : base(userName, password, mobileNumber)
        { }

       /* internal override string UserId
        {

            set
            {
                base.UserId = value + "-R";
            }
        }*/
    }
}
