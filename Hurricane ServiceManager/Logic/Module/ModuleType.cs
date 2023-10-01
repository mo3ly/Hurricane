using System;

namespace HurricaneServiceManager.Logic.Module
{
    [Flags]
    public enum ModuleType
    {
        GatewayServer,
        AgentServer,
        DownloadServer
    }
}
