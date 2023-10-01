using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core
{
    /// <summary>
    /// Log class 
    /// TODO:
    ///     Write those logs into files
    /// </summary>
    public class Log
    {
        public static void Success(object obj) => EventController.InvokeEvent(EventAttributes.OnAddLog, obj.ToString(), LogType.SUCCESS);

        public static void Notify(object obj) => EventController.InvokeEvent(EventAttributes.OnAddLog, obj.ToString(), LogType.NOTIFY);

        public static void Error(object obj) => EventController.InvokeEvent(EventAttributes.OnAddLog, obj.ToString(), LogType.ERROR);

        public static void Fatal(object obj)
        {
            Notify(obj);
            // write to fatal file
        }
    }
}
