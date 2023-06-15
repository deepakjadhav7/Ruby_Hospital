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
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

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
            if (txtconsultacharges.Text == "50") ;
            {
                txtconsultacharges.Text = "";
                txtconsultacharges.ForeColor = Color.Black;
            }
        }

        private void txtconsultacharges_Leave(object sender, EventArgs e)
        {
            if (txtconsultacharges.Text == "") ;
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
    }
}
