using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurricaneServiceManager.Logic.Module
{
    class ModuleManager
    {
        Dictionary<string, Module> _modules = new Dictionary<string, Module>();

        public void LoadModules()
        {
            // load modules from database and call -> RegisterModule for each of them
        }


        public void CheckModulesActivity()
        {
            // loops through all the modules to check if any one shutdown to update status (if auto reconnect is activated then re-open the module)
        }

        public void StartModule(string name)
        {
            _modules[name].moduleAction.Start();
        }

        public void StopModule(string name)
        {
            _modules[name].moduleAction.Stop();
        }

        public void StartAllModules()
        {
            foreach (var module in _modules.Values)
                if (!module.isRunning)
                    module.moduleAction.Start();
        }

        public void StopAllModules()
        {
            foreach (var module in _modules.Values)
                if(module.isRunning)
                    module.moduleAction.Stop();
        }

        public void RegisterModule(string name, Module module)
        {
            _modules.Add(name, module);
        }

        public void UnregisterModule(string name)
        {
            _modules.Remove(name);
        }
    }
}
