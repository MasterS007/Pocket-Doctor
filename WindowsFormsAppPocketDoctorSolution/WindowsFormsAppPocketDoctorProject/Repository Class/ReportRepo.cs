using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class ReportRepo
    {
        DataTable dataTable;

        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();


        internal bool InsertTest(string pid, List<string> checkedItems)
        {

            bool succeed = false;

            try
            {
                int tid;
                int row = 0;

                foreach (string s in checkedItems)
                {
                    string quyery = "Select t_id from tbl_Test where tname = '" + s + "'";
                    dataTable = dbCon.GetDataTable(quyery);
                    tid = Convert.ToInt32(dataTable.Rows[0]["t_id"].ToString());

                    string sql = "INSERT INTO tbl_Report (t_id, p_id) VALUES(  ' " + tid + " ', '" + pid + "')";
                    row = dbCon.ExecuteUpdateQuery(sql);

                }
                if (row > 0)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

            return succeed;
        }


        internal bool InsertReportDate(string pid, string tname,DateTime issuedate, DateTime duedate)
        {

            bool succeed = false;
            int tid;

            try
            {
                int row = 0;
                string quyery = "Select t_id from tbl_Test where tname = '" + tname + "'";
                dataTable = dbCon.GetDataTable(quyery);
                tid = Convert.ToInt32(dataTable.Rows[0]["t_id"].ToString());
                string sql = "Update tbl_Report SET  issue_date = '" + issuedate +"' , due_date ='" + duedate + "' where t_id ='"+tid+"' and p_id = '"+pid+"' ";
                row = dbCon.ExecuteUpdateQuery(sql);
                if (row > 0)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }

            catch (Exception ex) { MessageBox.Show(ex + ""); }

            return succeed;
        }



        internal DataTable DisplayReport()
        {

            try
            {
                string query = @"SELECT r.rep_id, p.p_id, p.name,t.tname,r.issue_date, r.due_date, r.rep_name from tbl_Patient p ,tbl_Report r,  tbl_Test t
                              where p.p_id = r.p_id and r.t_id = t.t_id ";

                dataTable = dbCon.GetDataTable(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return dataTable;
        }
        internal DataTable GetReport()
        {

            try
            {
                string query = @"SELECT r.rep_id, p.p_id, p.name,t.tname,r.issue_date, r.due_date, r.rep_name from tbl_Patient p ,tbl_Report r,  tbl_Test t
                                        where p.p_id = r.p_id and r.t_id = t.t_id ";

                dataTable = dbCon.GetDataTable(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return dataTable;
        }

        internal DataTable SearchReport(string keyWord)
        {
            try
            {

                string sql = @"SELECT r.rep_id, p.p_id, p.name, t.tname, r.issue_date, r.due_date, r.rep_name from tbl_Patient p,
                                        tbl_Report r,  tbl_Test t where p.p_id LIKE '%" + keyWord + "%' and p.p_id = r.p_id and t.t_id = r.t_id OR p.name LIKE '%" + keyWord + "%' and p.p_id = r.p_id and t.t_id = r.t_id ";
                dataTable = dbCon.GetDataTable(sql);


            }
            catch (Exception ex) { }

            return dataTable;
        }
    }
}




   
