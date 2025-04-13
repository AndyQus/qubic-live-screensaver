using System;
using System.Windows.Forms;

namespace qubic_live_screensaver
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new WebForm());
        }
    }
}
