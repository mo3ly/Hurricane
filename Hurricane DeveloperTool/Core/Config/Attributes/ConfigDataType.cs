using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core.Config
{
    public enum ConfigDataType
    {
        INT,
        FLOAT,
        STRING,
        BOOLEAN, // check later shall we do it 1 and 0 or true and false
        INT_LIST, // can be seralised with delimiter , and casted into int
        STRING_LIST, // can be seralised with delimiter , and casted into string
    }
}
