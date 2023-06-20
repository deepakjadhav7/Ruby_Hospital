using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruby_Hospital
{
    public partial class OPD_Consultaion_gridview : Form
    {
        int OPDPId;
        public OPD_Consultaion_gridview()
        {
            InitializeComponent();
        }

        private void OPD_Consultaion_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            string columnName = this.dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("PatientName") == true)
            {
                try
                {
                    OPDPId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PatientOPDId"].Value);
                    OPD_Consultaion_mainform o = new OPD_Consultaion_mainform();
                    o.Show();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void show()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmb = new SqlCommand(@"Select Patient_ID,Name,Mobile_Number,Doctors_Name,Referred_By,Address FROM Patient_Registration Where Purpose='OPD'", con);
            SqlDataAdapter adt = new SqlDataAdapter(cmb);
            DataTable o = new DataTable();
            adt.Fill(o);
            if (o.Rows.Count > 0)
            {
                dataGridView1.DataSource = o;
            }


        }
    }
}
