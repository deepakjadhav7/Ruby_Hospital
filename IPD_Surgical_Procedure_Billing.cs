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
    public partial class IPD_Surgical_Procedure_Billing : Form
    {
        public IPD_Surgical_Procedure_Billing()
        {
            InitializeComponent();

        }

        private void IPD_Surgical_Procedure_Billing_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
