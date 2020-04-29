using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPocketDoctorProject.Data_Layer
{
    class DatabaseConnection
    {

        //
        private static DatabaseConnection dbCon;
        private static SqlConnection sqlCon;

        public static string myConnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private DatabaseConnection()
        {
            sqlCon = new SqlConnection(myConnection);
           // sqlCon.Open();
        }

        public static DatabaseConnection GetDbInstance()
        {
            if (dbCon == null)
            {
                dbCon = new DatabaseConnection();
            }
            return dbCon;
        }
        private static SqlConnection SqlCon
        {
            get
            {
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }
                return sqlCon;
            }
            set
            {
                sqlCon = value;
            }
        }
        public SqlCommand Query(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
            return sqcom;
            

        }

        private DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public int ExecuteUpdateQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
            return sqcom.ExecuteNonQuery();
        }

        public void CloseConnection()
        {
            SqlCon.Close();
        }
        

        /*  private SqlCommand sqlcom;
          private SqlDataAdapter sda;
          private DataSet ds;
          private DataTable dt;






          public SqlCommand Sqlcom
          {
              get { return sqlcom; }
              set { sqlcom = value; }
          }


          public SqlDataAdapter Sda
          {
              get { return sda; }
              set { sda = value; }
          }

          public DataSet Ds
          {
              get { return ds; }
              set { ds = value; }
          }

          public DataTable Dt
          {
              get { return dt; }
              set { dt = value; }
          }



          /*   public SqlConnection ConnectDB()
             {
                this.conn = new SqlConnection(myConnection);
                 conn.Open();
                 return conn;
             }*/

        //internal DataTable dt;

        /*

                private void QueryText(string query)
                {
                    this.Sqlcom = new SqlCommand(query, this.Sqlcon);
                }*/

        /*  public DataSet ExecuteQuery(string sql)
          {
              this.QueryText(sql);
              this.Sda = new SqlDataAdapter(this.Sqlcom);
              this.Ds = new DataSet();
              this.Sda.Fill(this.Ds);
              return Ds;
          }*/

        //  public DataTable ExecuteQuery(string sql)
        /* {
             this.QueryText(sql);
             this.Sda = new SqlDataAdapter(this.Sqlcom);
             this.Dt = new DataTable();
             this.Sda.Fill(this.Dt);
             return Dt;
         }*/



        
    }
}
