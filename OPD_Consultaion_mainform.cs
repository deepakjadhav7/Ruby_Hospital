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
    public partial class OPD_Consultaion_mainform : Form
    {
        public OPD_Consultaion_mainform()
        {
            InitializeComponent();
        }

        private void OPD_Consultaion_mainform_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
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
    }
}
