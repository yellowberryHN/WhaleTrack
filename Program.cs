using System;
using System.Windows.Forms;

namespace WhaleTrack
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #if NET5_0_OR_GREATER
                ApplicationConfiguration.Initialize();
            #endif

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}