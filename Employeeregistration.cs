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

namespace Ruby_Hospital
{
    public partial class Employeeregistration : Form
    {
        public Employeeregistration()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void radiocontractor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtcontractor.Checked == true)
            {
                Login_Form lm = new Login_Form();
                 lm.Show();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            savedata();
        }
        public void savedata()
        {
            try
            { 
                  SqlConnection con = new SqlConnection(@"Data Source=208.91.198.196;User ID=Ruby_Jamner123;Password=ruby@jamner");
                  con.Open();

                  SqlCommand cmb = new SqlCommand(@"INSERT INTO Employee_registration (Employee_of,MR_M,Name,Gender,Current_Address,Nearest_Landmark,Permanent_Address,Mobile_Number,MaritalStatus,Experience,Alternate_Mobile_number,Date_Of_Birth,Department,Designation,Joining_Date,Probation,Status)
                                    Values (@Employee_of,@MR_M,@Name,@Gender,@Current_Address,@Nearest_Landmark,@Permanent_Address,@Mobile_Number,@MaritalStatus,@Experience,@Alternate_Mobile_number,@Date_Of_Birth,@Department,@Designation,@Joining_Date,@Probation,@Status)", con);
                  if (rbtrubystarhospital.Checked = true)
                  {
                     cmb.Parameters.AddWithValue("@Employee_of", "Ruby Star Hospital");
                  }
                  else
                  {
                       cmb.Parameters.AddWithValue("@Employee_of", "Contractor");
                  }
                  cmb.Parameters.AddWithValue("@MR_M", txtmr.Text);
                  cmb.Parameters.AddWithValue("@Name", txtname.Text);
                  cmb.Parameters.AddWithValue("@Gender", txtgender.Text);
                  cmb.Parameters.AddWithValue("@Current_Address", txtcurrentAddress.Text);
                  cmb.Parameters.AddWithValue("@Nearest_Landmark", txtLandmark.Text);
                  cmb.Parameters.AddWithValue("@Permanent_Address", txtPermanentAddress.Text);
                  cmb.Parameters.AddWithValue("@Mobile_Number", txtMobileNumber.Text);
                  cmb.Parameters.AddWithValue("@MaritalStatus", txtMaritalStatus.Text);
                  cmb.Parameters.AddWithValue("@Experience", txtExperience.Text);
                  cmb.Parameters.AddWithValue("@Alternate_Mobile_number", txtAlternateNumber.Text);
                  cmb.Parameters.AddWithValue("@Date_Of_Birth", txtDateOfBirth.Text);
                  cmb.Parameters.AddWithValue("@Department", txtDepartment.Text);
                  cmb.Parameters.AddWithValue("@Designation", txtDesignation.Text);
                  cmb.Parameters.AddWithValue("@Joining_Date", txtJoinDate.Text);
                  cmb.Parameters.AddWithValue("@Probation", txtprobationDate.Text);
                  if (checkStatus.Enabled = true)
                  {
                     cmb.Parameters.AddWithValue("@Status", "Active");
                  }
                  cmb.ExecuteNonQuery();

                  MessageBox.Show("Employee successfully Added...");
                  clearData();
            }
            catch
            {

            }
       
        }
        public void clearData()
        {
            txtAlternateNumber.Text = "";
            txtcurrentAddress.Text = "";
            txtDateOfBirth.Text = "";
            txtDepartment.Text = "";
            txtDesignation.Text = "";
            txtExperience.Text = "";
            txtgender.Text = "";
            txtJoinDate.Text = "";
            txtLandmark.Text = "";
            txtMaritalStatus.Text = "";
            txtMobileNumber.Text = "";
            txtmr.Text = "";
            txtname.Text = "";
            txtPermanentAddress.Text = "";
            txtprobationDate.Text = "";
        }

        private void txtDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void txtname_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtname.Text== "Fisrtname                    Middle                  Lastname")
            txtname.Clear();
        }

        private void txtname_MouseLeave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
                txtname.Text = "Fisrtname                    Middle                  Lastname";
        }
    }
}
