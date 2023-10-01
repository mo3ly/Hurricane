using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core.Config
{
    class ConfigBattleArenaMinLevel : IConfigAttribute
    {
        public ConfigCategory Category { get; set; } = ConfigCategory.GAMESERVER;

        public string Key { get; set; } = "BATTLE_ARENA_MIN_LEVEL";

        public string Value { get; set; } = "20";

        public ConfigDataType DataType { get; } = ConfigDataType.INT;

        public string Name { get; set; } = "Battle arena min level";

        public string Description { get; set; } = "Set the battle arena min level - Hot reload cannot work for this attribute it requires game server reload";
    }

}
