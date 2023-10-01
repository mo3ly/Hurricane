using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core.Config
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ConfigAttribute : Attribute//, IConfigAttribute
    {
        public ConfigCategory Category { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ConfigAttribute(ConfigCategory category, string key)
        {
            Category = category;
            Key = key;
        }
    }
}
