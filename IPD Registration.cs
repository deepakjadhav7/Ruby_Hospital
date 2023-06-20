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
    public partial class IPD_Registration : Form
    {
        public IPD_Registration()
        {
            InitializeComponent();
        }

        private void IPD_Registration_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            FetchDoctor();
            Referred_Doctor();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if( rbtmlc.Checked == true)
           {
                MLC_Details md = new MLC_Details();
                md.Show();
            }
        }

        private void bunSave_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"Insert into IPD_Registration (IPD_ID,Relatives_Name,Relation,Relative_Mobile_No,
                                Date_Of_Admission,Type_Of_Admission,Mediclaim
                   ,Room_Segment,Bed_No,ConsultantID,Reserred_By,MLC_NonMLC,DischargeDate) Values(@IPD_ID,@Relatives_Name,@Relation,@Relative_Mobile_No,@Date_Of_Admission,@Type_Of_Admission,@Mediclaim
                   ,@Room_Segment,@Bed_No,@ConsultantID,@Reserred_By,@MLC_NonMLC,@DischargeDate)", con);

                cmd.Parameters.AddWithValue("@IPD_ID",txtPatientIPDID.Text);
                cmd.Parameters.AddWithValue("@Relatives_Name", txtReativeName.Text);
                cmd.Parameters.AddWithValue("@Relation", cmbRelation.Text);
                cmd.Parameters.AddWithValue("@Relative_Mobile_No", txtRelativeMobileNo.Text); 
                cmd.Parameters.AddWithValue("@Date_Of_Admission", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Type_Of_Admission", cmbTypeOfAddmission.Text);
                cmd.Parameters.AddWithValue("@Mediclaim", cmbMediclaim.Text);
                cmd.Parameters.AddWithValue("@Room_Segment", cmbRoomSegment.Text);
                cmd.Parameters.AddWithValue("@Bed_No", cmb_BedNo.Text);
                cmd.Parameters.AddWithValue("@ConsultantID", cmbConsultant.Text);
                cmd.Parameters.AddWithValue("@Reserred_By", cmbReferredBy.Text); 
               
                if(rbtnonmlc.Checked==true)
                {
                    cmd.Parameters.AddWithValue("@MLC_NonMLC", "NON MLC");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MLC_NonMLC", "MLC");
                }
                cmd.Parameters.AddWithValue("@DischargeDate", dateTimePicker1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtReativeName_MouseClick(object sender, MouseEventArgs e)
        {
            txtReativeName.Clear();
        }

        private void txtRelativeMobileNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtRelativeMobileNo.Clear();
        }

        private void cmbRoomSegment_Click(object sender, EventArgs e)
        {

        }


        private void txtPatientIPDID_Enter(object sender, EventArgs e)
        {
            if(txtPatientIPDID.Text=="123456789")
            {
                txtPatientIPDID.Text = "";
                txtPatientIPDID.ForeColor = Color.Black;
            }
        }

        private void txtReativeName_Enter(object sender, EventArgs e)
        {
            if (txtReativeName.Text == "Firstname                                    Middlename                                 Lastname")
            {
                txtReativeName.Text = "";
                txtReativeName.ForeColor = Color.Black;
            }
        }

        private void txtReativeName_Leave(object sender, EventArgs e)
        {
            if (txtReativeName.Text == "") 
            {
                txtReativeName.Text = "Firstname                                    Middlename                                 Lastname";
                txtReativeName.ForeColor = Color.Gray;
            }
        }

        private void txtRelativeMobileNo_Enter(object sender, EventArgs e)
        {
            if(txtRelativeMobileNo.Text =="123456789")
            {
                txtRelativeMobileNo.Text = "";
                txtRelativeMobileNo.ForeColor = Color.Black;

            }
        }

        private void txtRelativeMobileNo_Leave(object sender, EventArgs e)
        {
            if (txtRelativeMobileNo.Text == "")
            {
                txtRelativeMobileNo.Text = "123456789";
                txtRelativeMobileNo.ForeColor = Color.Gray;

            }
        }

        private void txtPatientIPDID_Leave(object sender, EventArgs e)
        {
            if (txtPatientIPDID.Text == "")
            {
                txtPatientIPDID.Text = "123456789";
                txtPatientIPDID.ForeColor = Color.Gray;
            }
        }

        public void FetchDoctor()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand com = new SqlCommand(@"Select * From Doctors", con);
            SqlDataAdapter adt = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbConsultant.DataSource = dt;
                cmbConsultant.DisplayMember = "Dr_Name";
                cmbConsultant.ValueMember = "DR_ID";
            }
            con.Close();

        }
        public void Referred_Doctor()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand com = new SqlCommand(@"Select * From Referred_Doctor", con);
            SqlDataAdapter adt = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbReferredBy.DataSource = dt;
                cmbReferredBy.DisplayMember = "Referred_Name";
                cmbReferredBy.ValueMember = "ReferredID";
            }
            con.Close();

        }
    }
}

