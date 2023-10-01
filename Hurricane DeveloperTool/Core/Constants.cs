using System;
using System.IO;

namespace Hurricane_DeveloperTool.Core
{
    public static class Constants
    {
        public static class General
        {
            public static readonly string Version = "1.0";
        }

        public static class Directories
        {
            public static readonly string currentDirectory = Directory.GetCurrentDirectory();

            public static readonly string Resources = currentDirectory + "/Resources/";

            public static readonly string Icons = currentDirectory + "/Resources/icons/";
        }
    }
}
