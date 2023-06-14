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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
            constomizedesing();
           
        }

        private void movepanel(Control btn)
        {
            panel_slide.Width = btn.Width;
            panel_slide.Left = btn.Left;
        }
        private void Dashbord_Load(object sender, EventArgs e)
        {
            
            
            Panel_admin_master_.Visible = false;
            panel_admin_misReport.Visible = false;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            panel_Regi_down.Visible = false;
            panel_OPD_down.Visible = false;
            panel_IPD_down.Visible = false;
            panel_bill_down.Visible = false;
            panel_admin_down.Visible = false;
           
            

        }
        private void constomizedesing()
            {
            
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            movepanel(Dashboard);
            panel_Regi_down.Visible =false;
            panel_OPD_down.Visible = false;
            panel_IPD_down.Visible = false;
            panel_bill_down.Visible = false;
            
            panel_admin_down.Visible = false;
         //   panel_admin_misreprt.Visible = false;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            movepanel(Registration);
            panel_OPD_down.Visible = false;
            panel_IPD_down.Visible = false;
            panel_bill_down.Visible = false;
            panel_admin_down.Visible = false;
            
         //   panel_admin_misreprt.Visible = false;
        }

        private void OPD_Click(object sender, EventArgs e)
        {
            movepanel(OPD);
            panel_Regi_down.Visible = false;
            panel_OPD_down.Visible = true;
            panel_IPD_down.Visible = false;
            panel_admin_down.Visible = false;
            panel_bill_down.Visible = false;
            
          //  panel_admin_misreprt.Visible = false;
        }

        private void IPD_Click(object sender, EventArgs e)
        {
            movepanel(IPD);
            panel_Regi_down.Visible = false;
            panel_OPD_down.Visible = false;
            panel_IPD_down.Visible = true;
            panel_bill_down.Visible = false;
            panel_admin_down.Visible = false;
         
         //   panel_admin_misreprt.Visible = false;
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            movepanel(Bill);
            panel_Regi_down.Visible = false;
            panel_OPD_down.Visible = false;
            panel_IPD_down.Visible = false;
            panel_bill_down.Visible = true;
            panel_admin_down.Visible = false;
            Panel_admin_master_.Visible = false;
          

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            movepanel(Admin);

            panel_Regi_down.Visible = false;
            panel_OPD_down.Visible = false;
            panel_IPD_down.Visible = false;
            panel_bill_down.Visible = false;
            panel_admin_down.Visible = true;
            
        }

        private void Help_Click(object sender, EventArgs e)
        {
            movepanel(Help);
            panel_OPD_down.Visible = false;
            panel_Regi_down.Visible = false;
            panel_IPD_down.Visible = false;
            panel_bill_down.Visible = false;
            panel_admin_down.Visible = false;

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Registration_MouseClick(object sender, MouseEventArgs e)
        {
            panel_Regi_down.Visible = true;
           
        }

        private void OPD_MouseClick(object sender, MouseEventArgs e)
        {
            panel_OPD_down.Visible = true;
            
        }

        private void IPD_MouseClick(object sender, MouseEventArgs e)
        {
            panel_IPD_down.Visible = true;
           
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void Bill_MouseClick(object sender, MouseEventArgs e)
        {
            panel_bill_down.Visible = true;
            
        }

        private void Admin_MouseClick(object sender, MouseEventArgs e)
        {
            panel_admin_down.Visible = true;
            

        }

        

        private void btnreport_Click(object sender, EventArgs e)
        {
            panel_admin_misReport.Visible = true;
            MSI_REPORT ms = new MSI_REPORT();
            ms.Show();
          
        }

        private void btnempmanagement_Click(object sender, EventArgs e)
        {
            // panel_admin_misreprt.Visible = false;
            Panel_admin_master_.Visible = false;
        }

        private void btnapproval_Click(object sender, EventArgs e)
        {
            /// panel_admin_misreprt.Visible = false;
            
            Panel_admin_master_.Visible = false;
        }

        private void btnreport_MouseClick(object sender, MouseEventArgs e)
        {
           
            panel_admin_misReport.Visible = true;
            panel_bill_down.Visible = false;
           
        }

      

        private void Btnmaster_Click(object sender, EventArgs e)
        {
            Panel_admin_master_.Visible = true;
            panel_admin_misReport.Visible = false;
        }

        private void Btnmaster_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_admin_master_.Visible = true;
            panel_admin_misReport.Visible = false;
        }

        private void btnipdadmin_Click(object sender, EventArgs e)
        {

        }

        

        private void btnopdd_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
