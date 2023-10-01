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
    public class Module
    {

        public string moduleId { get; set; }

        public string ownerServer { get; set; }

        public ModuleType moduleType { get; set; }

        public string moduleName { get; set; }

        public string modulePath { get; set; }

        public bool isRunning { get; set; }

        public bool autoReconnect { get; set; }

        public Process moduleProcess { get; set; } = null;

        public ModuleAction moduleAction;

        public Module()
        {
            moduleAction = new ModuleAction(this);
        }
    }
}
