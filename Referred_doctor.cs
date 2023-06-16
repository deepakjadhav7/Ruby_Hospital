using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruby_Hospital
{
    public partial class Referred_doctor : Form
    {
        public Referred_doctor()
        {
            InitializeComponent();
        }

        private void Referred_doctor_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void txtdrrename_Enter(object sender, EventArgs e)
        {
            if(txtdrrename.Text == "Enter the Doctor Name")
            {
                txtdrrename.Text = "";
                txtdrrename.ForeColor = Color.Black;
            }
        }

        private void txtdrrename_Leave(object sender, EventArgs e)
        {
            if (txtdrrename.Text == "")
            {
                txtdrrename.Text = "Enter the Doctor Name";
                txtdrrename.ForeColor = Color.Gray;
            }
        }

        private void txtdigree_Enter(object sender, EventArgs e)
        {
           if(txtdigree.Text == "Degree")
            {
                txtdigree.Text = "";
                txtdigree.ForeColor = Color.Black;
            }
        }

        private void txtdigree_Leave(object sender, EventArgs e)
        {
            if (txtdigree.Text == "")
            {
                txtdigree.Text = "Degree";
                txtdigree.ForeColor = Color.Gray;
            }
        }

        private void txtdrremobileno_Enter(object sender, EventArgs e)
        {
            if(txtdrremobileno.Text== "Mobile No")
            {
                txtdrremobileno.Text = "";
                txtdrremobileno.ForeColor = Color.Black;
            }
        }

        private void txtdrremobileno_Leave(object sender, EventArgs e)
        {
            if (txtdrremobileno.Text == "")
            {
                txtdrremobileno.Text = "Mobile No";
                txtdrremobileno.ForeColor = Color.Gray;
            }
        }

        private void txtdrrgeaddress_Enter(object sender, EventArgs e)
        {
            if(txtdrrgeaddress.Text=="Address")
            {
                txtdrrgeaddress.Text = "";
                txtdrrgeaddress.ForeColor = Color.Black;

            }
        }

        private void txtdrrgeaddress_Leave(object sender, EventArgs e)
        {
            if (txtdrrgeaddress.Text == "")
            {
                txtdrrgeaddress.Text = "Address";
                txtdrrgeaddress.ForeColor = Color.Gray;

            }
        }

        private void txtdrrename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtdigree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtdrremobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled =  true;

            }
        }
    }
}
