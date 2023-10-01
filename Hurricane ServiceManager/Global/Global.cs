using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurricaneServiceManager.Logic;

namespace HurricaneServiceManager
{
    class Global
    {
        public static Dashboard Dashboard;

        public static DBConnection DBConnection = null;

        public static PusherConnection pusherClient = null;
    }
}
