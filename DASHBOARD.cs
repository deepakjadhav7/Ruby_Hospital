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
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
         //   constomizedesing();
        }
        private void movepanel(Control btn)
        {
            panel_slide.Height = btn.Height;
            panel_slide.Left = btn.Left;
        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            panel_Regi_down.Visible = false;
            panel_OPD_down.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            movepanel(Login);
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            movepanel(Registration);
        }

        private void OPD_Click(object sender, EventArgs e)
        {
            movepanel(OPD);
        }

        private void IPD_Click(object sender, EventArgs e)
        {
            movepanel(IPD);
        }

        private void Billing_Click(object sender, EventArgs e)
        {
            movepanel(Billing);
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            movepanel(Admin);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            movepanel(Help);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            panel_Regi_down.Visible = false;
        }

        private void Registration_MouseClick(object sender, MouseEventArgs e)
        {
            panel_Regi_down.Visible = true;
            panel_OPD_down.Visible = false;
        }

        private void OPD_MouseClick(object sender, MouseEventArgs e)
        {
            panel_OPD_down.Visible = true;
            panel_Regi_down.Visible = false;

        }
    }
}
