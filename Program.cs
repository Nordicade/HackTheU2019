using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;

using System.Threading.Tasks;

namespace test2
{
    public class SettingsGUI
    {
        private int test;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public void run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Application.Run(form);

        }
    }

    }
    



