using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace HurricaneServiceManager.Logic.Module
{
    public class ModuleAction
    {
        Module module;

        public ModuleAction(Module module)
        {
            this.module = module;
        }

        public void Start()
        {
            
        }

        public void Stop()
        {
            // source: https://docs.microsoft.com/en-US/dotnet/api/system.diagnostics.process.close?view=net-5.0
            try
            {
                using (Process myProcess = Process.Start("Notepad.exe"))
                {
                    // Display physical memory usage 5 times at intervals of 2 seconds.
                    for (int i = 0; i < 5; i++)
                    {
                        if (!myProcess.HasExited)
                        {
                            // Discard cached information about the process.
                            myProcess.Refresh();
                            // Print working set to console.
                            Console.WriteLine($"Physical Memory Usage: {myProcess.WorkingSet}");
                            // Wait 2 seconds.
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            break;
                        }
                    }

                    // Close process by sending a close message to its main window.
                    myProcess.CloseMainWindow();
                    // Free resources associated with process.
                    myProcess.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The following exception was raised: ");
                Console.WriteLine(e.Message);
            }
        }


        public void Delete()
        {
            // delete the folder of the module
        }

        public void Update()
        {
            // update the folder on the module
        }

    }
}
