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
    public partial class OPD_Consultaion_mainform : Form
    {
        public int OPDFillID;
        private DataTable dtPublic;
        public int Public_Opd_procedureID=0;
        public string Public_Opd_ProcedureCharges="";
        public OPD_Consultaion_mainform()
        {
            InitializeComponent();
        }
        public OPD_Consultaion_mainform(int OPDId)
        {
            InitializeComponent();
             
            txtID.Text = OPDId.ToString();

            show_PatientDetails();


        }
        public void show_ADD()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Select * From Patient_OPDProcedures where Patient_OPDID=@OPDId", con);
            cmd.Parameters.AddWithValue(@"OPDId", txtID.Text);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dtPublic = new DataTable();

            adt.Fill(dtPublic);
            dataGridView3.DataSource = dtPublic;
            dataGridView3.Columns["ID"].Visible = false;
            dataGridView3.Columns["Patient_OPDID"].Visible = false;
            dataGridView3.Columns["OPDProcedure_ID"].Visible = false;
            dataGridView3.Columns["Charges"].Visible = false;
           

        }
        public void Save()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Insert into Patient_OPDProcedures (Patient_OPDID,OPDProcedure_ID,Name,Charges) Values(@Patient_OPDID,@OPDProcedure_ID,@Name,@Charges)", con);
            cmd.Parameters.AddWithValue("@Patient_OPDID", txtID.Text);
            cmd.Parameters.AddWithValue("@OPDProcedure_ID", Public_Opd_procedureID);
            cmd.Parameters.AddWithValue("@Name", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Charges", Public_Opd_ProcedureCharges);
            cmd.ExecuteNonQuery();
            show_ADD();
            MessageBox.Show("Record Added");
            
        }
        public void show_PatientDetails()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT OPD_Patient_Registration.PatientOPDIdWithSr,Patient_Registration.Name, Patient_Registration.Mobile_Number, Patient_Registration.Doctors_Name, Patient_Registration.Referred_By
                      FROM Patient_Registration INNER JOIN OPD_Patient_Registration ON Patient_Registration.PID = OPD_Patient_Registration.PatientId where IsCheck = 0 and PatientOPDId=@OPDId", con);
            cmd.Parameters.AddWithValue(@"OPDId", txtID.Text);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable o = new DataTable();
            adt.Fill(o);
            if (o.Rows.Count > 0)
            {
                dataGridView1.DataSource = o;

            }


        }

        public void OPD_Procedure_show()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Select * From Master_OPD_Procedures", con);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "OPD_ProcedureID";
                if(comboBox1.Text != "")

                {
                    Public_Opd_procedureID = Convert.ToInt32(dt.Rows[0]["OPD_ProcedureID"]);
                    Public_Opd_ProcedureCharges = Convert.ToString(dt.Rows[0]["Charges"]);
                }
            }


        }

        private void OPD_Consultaion_mainform_Load(object sender, EventArgs e)
        {
            
            OPD_Procedure_show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Assgin_lab_test alt = new Assgin_lab_test();
            alt.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Assign_OPD_Drugs aod = new Assign_OPD_Drugs();
            aod.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OPD_Print_Certificate opc = new OPD_Print_Certificate();
            opc.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text == "")
                {

                    MessageBox.Show("and Select OPD Procedure Name");
                }

                else
                {
                    Save();
                    //show_ADD();

                    //DataRow dr = dtPublic.NewRow();
                    //dr["Name"] = comboBox1.Text;
                    //dtPublic.Rows.Add(dr);
                    //dataGridView3.DataSource = dtPublic;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Updatedata();
           
        }
        public void Updatedata()
        {

            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmd  = new SqlCommand(@"UPDATE OPD_Patient_Registration SET Summary=@Summary,Treatement=@Treatement,ChargesId=@ChargesId,XRay=@XRay,OPDSurgicalProcedureID=@OPDSurgicalProcedureID,VisitDate=@VisitDate,IsCheck=@IsCheck,FollowUpDate=@FollowUpDate where (PatientOPDId=@OPDId)", con);
          
            cmd.Parameters.AddWithValue("@OPDId", txtID.Text);
            cmd.Parameters.AddWithValue("@Summary", txtIllness.Text);
            cmd.Parameters.AddWithValue("@Treatement", txtTreatment.Text);
            cmd.Parameters.AddWithValue("@ChargesId", "0");
            cmd.Parameters.AddWithValue("@XRay", "0");
            cmd.Parameters.AddWithValue("@OPDSurgicalProcedureID", "1");
            cmd.Parameters.AddWithValue("@VisitDate", System.DateTime.Now);
            cmd.Parameters.AddWithValue("@IsCheck", "1");
            cmd.Parameters.AddWithValue("@FollowUpDate", System.DateTime.Now);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
        }
    }

}
