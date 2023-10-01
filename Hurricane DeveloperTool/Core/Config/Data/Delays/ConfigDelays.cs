using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core.Config
{
    // [Config(ConfigCategory.DELAYS, "STALL_DELAY")]
    // Maybe now we don't need this attribue because we can select it with the interface have a look about that
    // Also we can include all the delay configs in one file instead of having alot of files
    class ConfigStallDelay : IConfigAttribute
    {
        public ConfigCategory Category { get; set; } = ConfigCategory.DELAYS;

        public string Key { get; set; } = "STALL_DELAY";

        public string Value { get; set; } = "100";

        public ConfigDataType DataType { get; } = ConfigDataType.INT;

        public string Name { get; set; } = "Stall Delay";

        public string Description { get; set; } = "Set the stall delay value you want!";
    }

    class ConfigGlobalDelay : IConfigAttribute
    {
        public ConfigCategory Category { get; set; } = ConfigCategory.DELAYS;

        public string Key { get; set; } = "GLOBAL_DELAY";

        public string Value { get; set; } = "100";

        public ConfigDataType DataType { get; } = ConfigDataType.INT;

        public string Name { get; set; } = "Global Delay";

        public string Description { get; set; } = "Set the global delay value you want!";
    }
}
