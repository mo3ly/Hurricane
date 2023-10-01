namespace Hurricane_DeveloperTool.Core.Config
{
    public interface IConfigAttribute
    {
        ConfigCategory Category { get; set; }
        string Key { get; set; }
        string Value { get; set; }
        ConfigDataType DataType { get; }
        string Name { get; set; } // this shouldn't be in the data base it should be defined here for guiding the user
        string Description { get; set; } // this shouldn't be in the data base it should be defined here for guiding the user
    }
}