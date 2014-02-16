using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tator.SpudConf
{
    public enum ChangeType
    {
        None = 0,
        Added,
        Removed,
        Modified
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

        public List<string> Comments { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public bool ContainsParentKey(string key)
        {
            var splitKey = key.Split('.');
            foreach (var n in this)
            {
                var splitNode = n.Key.Split('.');
                if (splitNode.Length < splitKey.Length)
                    continue;
                var isChild = from k in splitKey
                              from j in splitNode
                              where k.Equals(j)
                              select k;
                if (isChild.Count() >= splitKey.Length)
                    return true;
            }
            return false;
        }

        public void Generate(Stream stream)
        {
            ConfigLoader.Generate(this, stream);
        }

        public void Load(Stream stream)
        {
            Clear();
            Metadata.Clear();
            Comments.Clear();
            ConfigLoader.Load(this, stream);
        }

        public void RemoveParent(string key)
        {
            var splitKey = key.Split('.');
            foreach (var n in this.ToList())
            {
                var splitNode = n.Key.Split('.');
                if (splitNode.Length < splitKey.Length)
                    continue;
                var isChild = from k in splitKey
                              from j in splitNode
                              where k.Equals(j)
                              select k;
                if (isChild.Count() >= splitKey.Length)
                    this.Remove(n.Key);
            }
        }

        public void RenameParent(string oldKey, string newKey)
        {
            var toChange = from c in this.ToList()
                           where c.Key.Length >= oldKey.Length
                           where c.Key.Substring(0, oldKey.Length).Equals(oldKey)
                           select c;
            foreach (var change in toChange)
            {
                var transformedKey = newKey + String.Join("", change.Key.Skip(oldKey.Length));
                this.Add(transformedKey, this[change.Key]);
                this.Remove(change.Key);
            }
        }
    }

    public class ConfigChange
    {
        public string Key { get; set; }

        public ConfigNode New { get; set; }

        public ConfigNode Old { get; set; }

        public ChangeType Type { get; set; }
    }

    public class ConfigNode
    {
        public ConfigNode(string value = "")
        {
            this.Value = value;
            Metadata = new Dictionary<string, string>();
            Comments = new List<string>();
        }

        public List<string> Comments { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Value { get; set; }
    }
}