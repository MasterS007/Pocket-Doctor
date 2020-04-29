using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using System.Windows.Forms;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class

{
     internal class User
    {
        
       
        internal string username { get; set; }
        internal string password { get; set; }
        internal string mobilenumber { get; set; }

        //internal string uId { get; set; }
       // private string userid;
        // private static ushort serialNo = 1;



        internal User() {  }

     /*   internal User (string iD)
        {
            this.UserId = iD;
            
        }*/
        internal string UserId { get; set; }
       /* {
            get{ return this.userid; }
            set
           {
               this.userid = "U-" + value;

                
           }
        }*/


        internal User(string userName, string password, string mobileNumber)
        {
         //   this.UserId = uId;
            this.username = userName;
            this.password = password;
            this.mobilenumber = mobileNumber;
            
            //this.UserId = "U-";

        }
       

       
     
       

         

    }
}
