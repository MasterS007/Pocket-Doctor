using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Classes
{
    internal class Receptionist:User
    {

        internal Receptionist(string userName, string password, string mobileNumber, string role) : base(userName, password, mobileNumber, role)
        { }

    }
}
