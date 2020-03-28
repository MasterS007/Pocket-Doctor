using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPocketDoctorProject
{
    public partial class UCPaitent : UserControl
    {
        public UCPaitent()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable ss = new DataTable();
            DataRow row = ss.NewRow();

            row["ID"] = "";
            row["Patient's Name"] = "";
            row["Patient's History"] = "";
            row["Phone Number"] = "";
            ss.Rows.Add(row);

            foreach(DataRow dataRow in ss.Rows)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = dataRow["ID"].ToString();
                dataGridView1.Rows[num].Cells[1].Value = dataRow["Patient's Name"].ToString();
                dataGridView1.Rows[num].Cells[2].Value = dataRow["Patient's History"].ToString();
                dataGridView1.Rows[num].Cells[3].Value = dataRow["Phone Number"].ToString();
            }
            
        }
    }
}
