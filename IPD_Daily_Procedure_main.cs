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
    public partial class IPD_Daily_Procedure_main : Form
    {
        public IPD_Daily_Procedure_main()
        {
            InitializeComponent();
          //  AdjustFormSize();
        }


        private void AdjustFormSize()
        {
            Rectangle screen = Screen.PrimaryScreen.Bounds;
            int screenWidth = screen.Width;
            int screenHeight = screen.Height;

            // Set the form size to match the screen resolution
            this.Width = screenWidth;
            this.Height = screenHeight;

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }





        private void IPD_Daily_Procedure_main_Load_1(object sender, EventArgs e)
        {
            AdjustFormSize();
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
