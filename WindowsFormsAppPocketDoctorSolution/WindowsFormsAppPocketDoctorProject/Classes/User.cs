using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject
{
     internal class User
    {
        private static int serialNo = 1;
        private string userId;
        private string userName;
        private string password;
        private string mobileNumber;

        internal User() { }
        internal User(string userName, string password, string mobileNumber)
        {
            this.userId = (serialNo++).ToString("0000");
            this.UserName = userName;
            this.Password = password;
            this.MobileNumber = mobileNumber;
        }

        internal virtual string UserId
        {
            get { return this.userId; }
            set
            {
                this.userId = "U-"+value;

            }

        }
        internal  string UserName
        {
            get { return this.userName; }
            set
            {
                this.userName = value;
            }

        }
        internal  string Password
        {
            get { return this.password; }
            set
            {   //if(value.Length<6)
                //{
                  //  Console.WriteLine("Password must be more than or equals to 6 characters");
                //}
                //else
                //{
                  this.password = value;
                //}
                
            }

        }
        internal string MobileNumber
        {
            get { return this.mobileNumber; }
            set
            {
               // if(value.Length< mobileNumber.Length || value[0]!=0 )
               // {
                //    Console.WriteLine("Invalid Phone Number");
               // }
               // else
               // {
                    this.mobileNumber = value;
               // }
            }


        }


    }
}
