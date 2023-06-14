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
    public partial class Dashboard_page : Form
    {
        public Dashboard_page()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_page_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            Panel_admin_master_.Visible = false;
            panel_admin_misReport.Visible = false;
            panel_admin_down.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iPDLABTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billingToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void oldIPDBilsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void panel_admin_down_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel_admin_down.Visible = true;
        }

        private void Btnmaster_Click(object sender, EventArgs e)
        {
            Panel_admin_master_.Visible = true;
        }

        private void Btnmaster_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_admin_master_.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnreport_MouseClick(object sender, MouseEventArgs e)
        {
            panel_admin_misReport.Visible = true;
        }

        private void Btnmaster_MouseLeave(object sender, EventArgs e)
        {
            panel_admin_misReport.Visible = false;
            panel_admin_down.Visible = false;
        }
    }
}
