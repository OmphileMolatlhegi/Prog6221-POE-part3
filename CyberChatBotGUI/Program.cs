using System;
using System.Windows.Forms;

namespace CyberChatBotGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Enable modern UI styling
            SetHighDpiMode();

            // Initialize and run the main application form
            Application.Run(new MainForm());
        }

        private static void SetHighDpiMode()
        {
            // Enable high DPI support for modern displays
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}