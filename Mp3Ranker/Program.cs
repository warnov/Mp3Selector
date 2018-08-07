using System;
using System.Windows.Forms;

namespace Mp3Ranker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (SingleInstanceClass.CheckForOtherApp("F53A8025-2FF6-418A-B688-53610C47A2DF"))
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}