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
    }
}
