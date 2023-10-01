using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Core.Config
{
    public class Config
    {
        /// <summary>
        /// TODO:
        ///     - Check which to use dictionay or list
        ///     - Create a view that show all the avaliable conifg data and allow you to edit it
        ///     - Implement a config list attribute functionallty
        /// Store the configuration attributes
        /// </summary>
        //private List<IConfigAttribute> _config = new List<IConfigAttribute>();
        private Dictionary<string, IConfigAttribute> _config;

        private bool isLoaded = false;

        // TODO
        // research parts
        // check the Struct vs the Inteface vs using attributes and the best practices for each of them
        // Refactor the attrites folder (Enums, interfaces, Attributes) look up online for the best struture that can be used in this case
        public Config()
        {
            _config = new Dictionary<string, IConfigAttribute>();

            var attributes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IConfigAttribute).IsAssignableFrom(p) && !p.IsInterface).ToArray();

            // load all the defined config to match them from database
            // var attrs = Assembly.GetEntryAssembly().GetTypes().Select(i => i.GetCustomAttributes().OfType<ConfigAttribute>()).ToList();
            foreach (var attr in attributes)
            {
                var instance = (IConfigAttribute)Activator.CreateInstance(attr);
                Log.Success("[Loaded] new config key: " + instance.Key);
                if (!_config.ContainsKey(instance.Key))
                    _config.Add(instance.Key, instance);
                else
                    Log.Error(string.Format("Couldn't add the key {0} because it is already added!", instance.Key));
                //_config.Add(instance);// for list
            }
        }

        public void loadConfig()
        {
            // should load config from SQL and match it with the
        }

        public IConfigAttribute GetAttribute(string key)
        {
            // return _config.Where(i => i.Key == key).FirstOrDefault(); // for list
            _config.TryGetValue(key, out IConfigAttribute attribute);
            return attribute;
        }

        public IConfigAttribute GetAttribute(ConfigCategory category, string key)
        {
            //return _config.Where(i => i.Category == category && i.Key == key).FirstOrDefault(); // for list
            return _config[key];
            // get config data from the attribute
            // make multipe versions from this function
            // also make another function that cast the value
        }

        // From RSBOT -> Check thier conifg!
        public T Get<T>(string key, T defaultValue = default(T))
        {
            IConfigAttribute attribute = GetAttribute(key);

            if(attribute == null)
                return (T)Convert.ChangeType(false, typeof(T));

            return (T)Convert.ChangeType(attribute.Value, typeof(T));//getType(attribute)
        }

        public Type getType(IConfigAttribute configAttribute)
        {
            Type type = null;
            switch (configAttribute.DataType)
            {
                case ConfigDataType.INT:
                    type = typeof(int);
                    break;
                case ConfigDataType.FLOAT:
                    type = typeof(float);
                    break;
                case ConfigDataType.BOOLEAN:
                    type = typeof(bool);
                    break;
                case ConfigDataType.STRING:
                    type = typeof(string);
                    break;
                case ConfigDataType.INT_LIST: // check in the caller method if list int then serialise it with the delimiter ,
                    type = typeof(List<int>);
                    break;
                case ConfigDataType.STRING_LIST: // check in the caller method if list string then serialise it with the delimiter ,
                    type = typeof(List<string>);
                    break;
            }
            return type;
        }

        /// <summary>
        /// Set value of a specific attribute
        /// </summary>
        /// <param name="category"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set<T>(string key, T value)
        {
            // append it to the database with its T value
            _config[key].Value = value.ToString();
            // this should update the value in the database and in the attribute and
            // it should import a LIVE PATCH row in the instantCommands table to notify the specified module to update its value
            // read about locks so you don't cause a problem later in any appliction
        }

    }
}
