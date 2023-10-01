using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core.Config
{
    class ConfigMaxUserLimit : IConfigAttribute
    {
        public ConfigCategory Category { get; set; } = ConfigCategory.LIMITS;

        public string Key { get; set; } = "MAX_USER";

        public string Value { get; set; } = "100";

        public ConfigDataType DataType { get; } = ConfigDataType.INT;

        public string Name { get; set; } = "Maximum Users";

        public string Description { get; set; } = "Set the maximum users you want to have Users";
    }

    class ConfigMaxGuildLevelLimit : IConfigAttribute
    {
        public ConfigCategory Category { get; set; } = ConfigCategory.LIMITS;

        public string Key { get; set; } = "MAX_GUILD";

        public string Value { get; set; } = "4";

        public ConfigDataType DataType { get; } = ConfigDataType.INT;

        public string Name { get; set; } = "Maximum Guild Level";

        public string Description { get; set; } = "Set the maximum guild level you want to have Users";
    }
}
