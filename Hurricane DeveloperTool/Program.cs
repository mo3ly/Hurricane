using System;
using System.Windows.Forms;
using Hurricane_DeveloperTool.Views;
using Hurricane_DeveloperTool.Presenters;
using System.Diagnostics;

namespace Hurricane_DeveloperTool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsAppRunning())
            {
                MessageBox.Show("This appliction is already running!", "Hurricane DeveloperTool");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDashboardView dashboardView = new DashboardView();
            new DashboardPresenter(dashboardView);

            Application.Run((Form)dashboardView);
        }

        public static bool IsAppRunning()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process process in processes)
                if ((process.Id != currentProcess.Id) && (process.MainModule.FileName == currentProcess.MainModule.FileName))
                    return true;
            return false;
        }
    }
}
