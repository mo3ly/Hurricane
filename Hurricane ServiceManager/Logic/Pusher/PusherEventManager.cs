using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PusherClient;

namespace HurricaneServiceManager.Logic
{
    class PusherEventManager
    {
        public static void OnEventReceive(string eventName, PusherEvent response)
        {
            switch (eventName)
            {
                case PusherEvents.SERVICE_CREATE:
                    OnCreateNewServerEvent(response);
                    break;
                case PusherEvents.MODULE_SHUTDOWN:
                    OnServerShutdownEvent(response);
                    break;
            }
        }

        public static void OnServerShutdownEvent(PusherEvent response)
        {
            Global.Dashboard.WriteLog("OnServerShutdownEvent:" + response.Data, 1);
        }

        public static void OnCreateNewServerEvent(PusherEvent response)
        {
            Global.Dashboard.WriteLog("OnCreateNewServerEvent:" + response.Data, 1);
        }
    }
}
