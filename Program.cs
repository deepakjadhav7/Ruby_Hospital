using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruby_Hospital
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


<<<<<<< HEAD
            Application.Run(new IPD_ECG_and_Radiology_fess());
           
=======


            Application.Run(new OPD_Consultaion_mainform());


>>>>>>> 2fc1de717e1ad1e8f1387b116e8689038950ef24

       
           



        }
    }
}
