using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Ruby_Hospital
{
    public partial class Patient_Registration : Form
    {
        public Patient_Registration()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_Leave(object sender, EventArgs e)
        {
            

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtmail.Text, pattern))
            {
                errorProvider1.Clear();
                txtmail.BackColor = Color.White;
            }
            else
            {

                errorProvider1.SetError(this.txtmail, "PLEASE PROVIDE VALID EMAIL ADDRESS...");
                txtmail.BackColor = Color.LightPink;
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( char .IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtmobilenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char .IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                e.Handled = true;
            }
        }

        private void txtaadhaar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char .IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtweight_KeyPress(object sender, KeyPressEventArgs e)
        {
                 if(!char .IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtalternateno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char .IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtremark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
         }

        private void txtpatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
         }

        private void txtreferred_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char .IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void Patient_Registration_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            FetchDoctor();
            Referred_Doctor();
            State();
            District();
        }
        public void State()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmb = new SqlCommand(@"Select * From States", con);
            SqlDataAdapter adt = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if(dt.Rows.Count>0)
            {
                txtstate.DataSource = dt;
                txtstate.DisplayMember = "State";
                txtstate.ValueMember = "SID";
            }

        }
        public void District()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmb = new SqlCommand(@"Select * From District where (SID=@SID) ", con);
            cmb.Parameters.AddWithValue("@SID", txtstate.SelectedIndex);
            cmb.ExecuteNonQuery();
            SqlDataAdapter adt = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtdistrict.DataSource = dt;
                txtdistrict.DisplayMember = "District";
                txtdistrict.ValueMember = "DID";
            }
        }
        public void Taluka()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmb = new SqlCommand(@"Select * From Taluka where (DID=@DID) ", con);
            cmb.Parameters.AddWithValue("@DID", txtdistrict.SelectedIndex);
            cmb.ExecuteNonQuery();
            SqlDataAdapter adt = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txttaluka.DataSource = dt;
                txttaluka.DisplayMember = "Taluka";
                txttaluka.ValueMember = "TID";
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"Insert Into Patient_Registration (Patient_ID,Prefixes,Name,Gender,DOB,Age,Marital_Status,Mobile_Number,
                                               Email,Adhaar_ID,Weight,Purpose,Alternate_Mobile,Nationality,Remark,AROGYA_Card,Registration_Charges,Consultation_Charges,
                                               Address,State,District,Taluka,City,Doctors_Name,Referred_By) Values (@Patient_ID,@Prefixes,@Name,@Gender,@DOB,@Age,@Marital_Status,@Mobile_Number,
                                               @Email,@Adhaar_ID,@Weight,@Purpose,@Alternate_Mobile,@Nationality,@Remark,@AROGYA_Card,@Registration_Charges,@Consultation_Charges,
                                               @Address,@State,@District,@Taluka,@City,@Doctors_Name,@Referred_By)", con);


                cmd.Parameters.AddWithValue("@Patient_ID", "RSHJ001");
                cmd.Parameters.AddWithValue("@Prefixes", txtprofix.Text);
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                if (btnmale.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Gender", "Male");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gender", "Female");
                }

                cmd.Parameters.AddWithValue("@DOB", txtdate.Text);
                cmd.Parameters.AddWithValue("@Age", txtage.Text);
                cmd.Parameters.AddWithValue("@Marital_Status", cbmmaritalstatus.Text);
                cmd.Parameters.AddWithValue("@Mobile_Number", txtmobilenumber.Text);
                cmd.Parameters.AddWithValue("@Email", txtmail.Text);
                cmd.Parameters.AddWithValue("@Adhaar_ID", txtaadhaar.Text);
                cmd.Parameters.AddWithValue("@Weight", txtweight.Text);
                cmd.Parameters.AddWithValue("@Purpose", txtpurpose.Text);
                cmd.Parameters.AddWithValue("@Alternate_Mobile", txtalternateno.Text);
                cmd.Parameters.AddWithValue("@Nationality", txtnationality.Text);
                cmd.Parameters.AddWithValue("@Remark", txtremark.Text);

                cmd.Parameters.AddWithValue("@AROGYA_Card", txtarogyacard.Text);
                cmd.Parameters.AddWithValue("@Registration_Charges", txtregicharges.Text);
                cmd.Parameters.AddWithValue("@Consultation_Charges", txtconsultacharges.Text);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@State", txtstate.Text);
                cmd.Parameters.AddWithValue("@District", txtdistrict.Text);
                cmd.Parameters.AddWithValue("@Taluka", txttaluka.Text);
                cmd.Parameters.AddWithValue("@City", txtcity.Text);
                cmd.Parameters.AddWithValue("@Doctors_Name", cmbDoctor.Text);
                cmd.Parameters.AddWithValue("@Referred_By", cmbReferred.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                
                if (txtpurpose.Text == "IPD")
                {
                   
                    MessageBox.Show("Record Added Successfully to IPD...");
                    btnGOTOIPD.Visible = true;
                    btnsave.Visible = false;
                    btnPrint.Visible = false;
                }

                if (txtpurpose.Text == "Only Test")
                {

                    MessageBox.Show("Record Added Successfully ...");
                    btnGOTOIPD.Visible = false;
                    btnsave.Visible = false;
                    btnPrint.Visible = false;
                }
                else
                {
                    
                    MessageBox.Show("Patient  Added successfully...");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void UpdateRegistration()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Update Patient_Registration set (Prefixes=@Prefixes,Name=@Name,Gender=@Gende,DOB=@DOB,Age=@Age,Marital_Status=@Marital_Status,Mobile_Number=@Mobile_Number,
                                               Email=@Email,Adhaar_ID=@Adhaar_ID,Weight=@Weight,Purpose=@Purpose,Alternate_Mobile=@Alternate_Mobile,Nationality=@Nationality,Remark=@Remark,AROGYA_Card=@AROGYA_Card,Registration_Charges=@Registration_Charges,Consultation_Charges=@Consultation_Charges,
                                               Address=@Address,State=@State,District=@District,Taluka=@Taluka,City=@City,Doctors_Name=@Doctors_Name,Referred_By=@Referred_By)  where Patient_ID=@Patient_ID)", con);


            cmd.Parameters.AddWithValue("@Patient_ID", "RSHJ001");
            cmd.Parameters.AddWithValue("@Prefixes", txtprofix.Text);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            if (btnmale.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Gender", "Male");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Gender", "Female");
            }

            cmd.Parameters.AddWithValue("@DOB", txtdate.Text);
            cmd.Parameters.AddWithValue("@Age", txtage.Text);
            cmd.Parameters.AddWithValue("@Marital_Status", cbmmaritalstatus.Text);
            cmd.Parameters.AddWithValue("@Mobile_Number", txtmobilenumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtmail.Text);
            cmd.Parameters.AddWithValue("@Adhaar_ID", txtaadhaar.Text);
            cmd.Parameters.AddWithValue("@Weight", txtweight.Text);
            cmd.Parameters.AddWithValue("@Purpose", txtpurpose.Text);
            cmd.Parameters.AddWithValue("@Alternate_Mobile", txtalternateno.Text);
            cmd.Parameters.AddWithValue("@Nationality", txtnationality.Text);
            cmd.Parameters.AddWithValue("@Remark", txtremark.Text);
            cmd.Parameters.AddWithValue("@AROGYA_Card", txtarogyacard.Text);
            cmd.Parameters.AddWithValue("@Registration_Charges", txtregicharges.Text);
            cmd.Parameters.AddWithValue("@Consultation_Charges", txtconsultacharges.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@State", txtstate.Text);
            cmd.Parameters.AddWithValue("@District", txtdistrict.Text);
            cmd.Parameters.AddWithValue("@Taluka", txttaluka.Text);
            cmd.Parameters.AddWithValue("@City", txtcity.Text);
            cmd.Parameters.AddWithValue("@Doctors_Name", cmbDoctor.Text);
            cmd.Parameters.AddWithValue("@Referred_By", cmbReferred.Text);

            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtmobilenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnsave.Visible = false;

        }

        private void txtpatient_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpatientsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if(txtname.Text== "Fisrtname           Middle             Lastname")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Fisrtname           Middle             Lastname";
                txtname.ForeColor = Color.Gray;
            }
        }

        private void txtmobilenumber_Enter(object sender, EventArgs e)
        {
            if(txtmobilenumber.Text == "123456789")
            {
                txtmobilenumber.Text = "";
                txtmobilenumber.ForeColor = Color.Black;
            }
        }

        private void txtmobilenumber_Leave(object sender, EventArgs e)
        {
            if (txtmobilenumber.Text == "")
            {
                txtmobilenumber.Text = "123456789";
                txtmobilenumber.ForeColor = Color.Gray;
            }
        }

        private void txtpatient_Enter(object sender, EventArgs e)
        {
            if(txtpatient.Text == "Enter the Patient Info")
            {
                txtpatient.Text = "";
                txtpatient.ForeColor = Color.Black;
            }
        }

        private void txtpatient_Leave(object sender, EventArgs e)
        {
            if(txtpatient.Text == "")
            {
                txtpatient.Text = "Enter the Patient Info";
                txtpatient.ForeColor = Color.Gray;
            }
        }

        private void txtmail_Enter(object sender, EventArgs e)
        {
            if(txtmail.Text == "Enter Your Email")
            {
                txtmail.Text = "";
                txtmail.ForeColor = Color.Black;
            }
        }

        private void txtaadhaar_Enter(object sender, EventArgs e)
        {
            if(txtaadhaar.Text == "1233456789012")
            {
                txtaadhaar.Text = "";
                txtaadhaar.ForeColor = Color.Black;

            }
        }

        private void txtaadhaar_Leave(object sender, EventArgs e)
        {
            if (txtaadhaar.Text == "")
            {
                txtaadhaar.Text = "1233456789012";
                txtaadhaar.ForeColor = Color.Gray;

            }
        }

        private void txtregicharges_Enter(object sender, EventArgs e)
        {
            if(txtregicharges.Text== "Enter Registration Charges")
            {
                txtregicharges.Text = "";
                txtregicharges.ForeColor = Color.Black;
            }
        }

        private void txtregicharges_Leave(object sender, EventArgs e)
        {

            if (txtregicharges.Text == "")
            {
                txtregicharges.Text = "Enter Registration Charges";
                txtregicharges.ForeColor = Color.Gray;
            }
        }

        private void txtconsultacharges_Enter(object sender, EventArgs e)
        {
            if (txtconsultacharges.Text == "50" )
            {
                txtconsultacharges.Text = "";
                txtconsultacharges.ForeColor = Color.Black;
            }
        }

        private void txtconsultacharges_Leave(object sender, EventArgs e)
        {
            if (txtconsultacharges.Text == "") 
            {
                txtconsultacharges.Text = "50";
                txtconsultacharges.ForeColor = Color.Gray;
            }
        }

        private void txtarogyacard_Enter(object sender, EventArgs e)
        {
            if(txtarogyacard.Text== "1233456789012")
            {
                txtarogyacard.Text = "";
                txtarogyacard.ForeColor = Color.Black;
            }
        }

        private void txtarogyacard_Leave(object sender, EventArgs e)
        {
            if (txtarogyacard.Text == "")
            {
                txtarogyacard.Text = "1233456789012";
                txtarogyacard.ForeColor = Color.Gray;
            }
        }

        private void txtage_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {
            int AgeYear = DateTime.Today.Year - txtdate.Value.Year;
            txtage.Text = AgeYear.ToString();
        }

        private void txtname_Click(object sender, EventArgs e)
        {

        }

        private void txtname_MouseClick(object sender, MouseEventArgs e)
        {
            txtname.Clear();
        }

        private void txtmobilenumber_MouseClick(object sender, MouseEventArgs e)
        {
            txtmobilenumber.Clear();
        }

        private void txtarogyacard_MouseClick(object sender, MouseEventArgs e)
        {
            txtarogyacard.Clear();
        }

        private void txtage_MouseClick(object sender, MouseEventArgs e)
        {
            txtage.Clear();
        }

        private void txtweight_MouseClick(object sender, MouseEventArgs e)
        {
            txtweight.Clear();
        }

        private void txtalternateno_MouseClick(object sender, MouseEventArgs e)
        {
            txtalternateno.Clear();
        }

        private void txtremark_MouseClick(object sender, MouseEventArgs e)
        {
            txtremark.Clear();
        }

        private void txtaddress_MouseClick(object sender, MouseEventArgs e)
        {
            txtaddress.Clear();
        }

        private void btnGOTOIPD_Click(object sender, EventArgs e)
        {
            IPD_Registration o = new IPD_Registration();
            o.Show();
        }
        public void FetchDoctor()
        {
            SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
            con.Open();
            SqlCommand com = new SqlCommand(@"Select * From Doctors", con);
            SqlDataAdapter adt = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if(dt.Rows.Count>0)
            {
                cmbDoctor.DataSource = dt;
                cmbDoctor.DisplayMember = "Dr_Name";
                cmbDoctor.ValueMember = "DR_ID";
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
                cmbReferred.DataSource = dt;
                cmbReferred.DisplayMember = "Referred_Name";
                cmbReferred.ValueMember = "ReferredID";
            }
            con.Close();
        }

        private void txtdistrict_TextChanged(object sender, EventArgs e)
        {
            //if(txtstate.Text.Trim)
            //{

            //}
            Taluka();
        }

        private void txtstate_TextChanged(object sender, EventArgs e)
        {
            District();
        }
    }
}
