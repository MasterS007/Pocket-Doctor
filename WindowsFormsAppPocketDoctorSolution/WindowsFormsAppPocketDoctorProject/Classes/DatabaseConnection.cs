﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Classes
{
    public class DatabaseConnection
    {
        private SqlConnection sqlcon;
        private SqlCommand sqlcom;
        private SqlDataAdapter sda;
        private DataSet ds;

        public static string myConnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }


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
        public DatabaseConnection()
        {
            this.Sqlcon = new SqlConnection(myConnection);
            sqlcon.Open();
        }


     /*   public SqlConnection ConnectDB()
        {
           this.conn = new SqlConnection(myConnection);
            conn.Open();
            return conn;
        }*/
       
        //internal DataTable dt;

       
        public SqlCommand Query(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            return this.Sqlcom;

        }
        public void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        public void CloseConnection()
        {
            this.Sqlcon.Close();
        }
    }
}
