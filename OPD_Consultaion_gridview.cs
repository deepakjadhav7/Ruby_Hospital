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
    public partial class OPD_Consultaion_gridview : Form
    {
        public OPD_Consultaion_gridview()
        {
            InitializeComponent();
        }

        private void OPD_Consultaion_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
