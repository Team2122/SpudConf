using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Management;

namespace Tator.SpudConf
{
    /// <summary>
    /// A class that represents a configuration node
    /// </summary>
    public class Config : Dictionary<string, ConfigNode>
    {
        public Config(Config other)
            : base(other)
        {
            Metadata = new Dictionary<string, string>(other.Metadata);
            Comments = new List<string>(other.Comments);
        }

        public Config()
            : base()
        {
            Metadata = new Dictionary<string, string>();
            Comments = new List<string>();
        }

        public void Load(Stream stream)
        {
            Clear();
            ConfigLoader.Load(this, stream);
        }

        public void Generate(Stream stream)
        {
            ConfigLoader.Generate(this, stream);
        }

        public Dictionary<string, string> Metadata { get; set; }
        public List<string> Comments { get; set; }
    }

    public class ConfigNode
    {
        public string Value { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public List<string> Comments { get; set; }

        public ConfigNode(string value = "")
        {
            this.Value = value;
            Metadata = new Dictionary<string, string>();
            Comments = new List<string>();
        }
    }

    public enum ChangeType
    {
        None = 0,
        Added,
        Removed,
        Modified
    }

    public class ConfigChange
    {
        public ChangeType Type { get; set; }
        public string Key { get; set; }
        public ConfigNode Old { get; set; }
        public ConfigNode New { get; set; }
    }

    public class ChangeSet : HashSet<ConfigChange>
    {
        public bool ContainsNodeWithKey(string key)
        {
            foreach (var c in this)
            {
                if (c.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public ConfigChange WithKey(string key)
        {
            foreach (var c in this)
            {
                if (c.Key.Equals(key))
                {
                    return c;
                }
            }
            throw new KeyNotFoundException("Change with key '" + key + "' not found");
        }
    }
}
