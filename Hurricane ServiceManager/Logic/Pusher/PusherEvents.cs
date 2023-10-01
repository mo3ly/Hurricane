using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurricaneServiceManager.Logic
{
    public static class PusherEvents
    {
        public const string SERVICE_CREATE = "service.create";
        public const string SERVICE_UPDATE = "service.update";
        public const string SERVICE_DELETE = "service.delete";

        public const string MODULE_START = "module.start";
        public const string MODULE_SHUTDOWN = "server.shutdown"; // should be module.stop
        public const string MODULE_restart = "module.restart";
    }
}
