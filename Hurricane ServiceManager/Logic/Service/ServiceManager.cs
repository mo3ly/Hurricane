using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurricaneServiceManager.Logic.Service
{
    class ServiceManager
    {
        public void CreateNewService()
        {
            // vadliate in the database that the id found (should be inserted from the web dashboard)
            // then copy the modules to the folder
        }

        public void DeleteService()
        {
            // vadliate in the database that the id found (should be inserted from the web dashboard)
            // shutdown the service modules 
            // then delete the files
        }

        public void UpdateService()
        {
            // vadliate in the database that the id found (should be inserted from the web dashboard)
            // shutdown the service modules 
            // copy the new files and replace it with this module
        }
    }
}
