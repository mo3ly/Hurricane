using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core
{
    /// <summary>
    /// Controll the events in the appliction
    /// 
    /// Credits: RSBot
    /// </summary>
    public class EventController
    {
        /// <summary>
        /// Store the events and its actions
        /// TODO:
        ///     Investigate the sytnax of that list and check if it can be replaced with dictionary according to the performance
        /// </summary>
        private static readonly List<(EventAttributes name, Delegate action)> _events = new List<(EventAttributes, Delegate)>();

        public static void RegsiterEvent(EventAttributes name, Delegate action)
        {
            if (action != null)
                _events.Add((name, action));
        }

        public static void RegsiterEvent(EventAttributes name, Action action)
        {
            if (action != null)
                _events.Add((name, action));
        }

        public static void InvokeEvent(EventAttributes name, params object[] parameters)
        {
            try
            {
                var targets = (from e in _events
                               where e.name == name & e.action.Method.GetParameters().Length == parameters.Length
                               select e.action).ToArray();

                foreach (var target in targets)
                    if (Thread.CurrentThread.Name == "Proxy.Network.Server.PacketProcessor") // this should be replaced later with the async thread like proxy
                        Task.Run(() => target.DynamicInvoke(parameters));
                    else
                        target.DynamicInvoke(parameters);

            } catch (Exception e)
            {
                Log.Fatal(e);
            }
        }
    }
}
