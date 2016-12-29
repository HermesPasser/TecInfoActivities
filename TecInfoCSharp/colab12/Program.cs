using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Agenda12_forum_loopListBox_plus_trap
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
            Application.Run(new loopListBox());
        }
    }
}
