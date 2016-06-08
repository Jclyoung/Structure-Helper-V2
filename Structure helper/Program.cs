using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Structure_Helper
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
            //Program.DB = new JobDB();
            var startScrn = new StartScrn();
            StartScrn = startScrn;
            Application.Run(startScrn);
        }

        static public Job CurrentJob { get; set; }
        static public StartScrn StartScrn { get; set; }
        static public Connections Connections { get; set; }
        //static public JobDB DB { get; set; }
    }
}
