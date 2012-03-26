using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EcoSim
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
            SimView view = new SimView();
            SimModel model = new SimModel();
            SimController controller = new SimController(model, view);
            Application.Run(view);   
        }
    }
}
