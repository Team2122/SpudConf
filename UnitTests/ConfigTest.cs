using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Tator.SpudConf.UnitTests
{
    [TestClass]
    public class ConfigTest
    {
        [TestMethod]
        public void Config_Parse()
        {
            var config = new Config();
            var configString = @"
# Hello world
#!type = ""string""
Hello.World = ""True""
";
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(configString));
            ConfigLoader.Load(config, stream);

            Assert.IsTrue(config.ContainsKey("Hello.World"), "Config doesn't contain key");
            var node = config["Hello.World"];
            Assert.AreEqual("True", node.Value, "Unexpected value in key");
            Assert.AreEqual("string", node.Metadata["type"], "Type invalid");
            Assert.AreEqual(" Hello world", node.Comments[0], "Comment incorrect");
        }

        [TestMethod]
        public void Config_Generate()
        {
            Config config = new Config() { {"Hello.World", new ConfigNode("World") } };
        }

        [TestMethod]
        public void Config_ChangeSet()
        {
            Config oldConfig = new Config();
            oldConfig.Add("Test.Modified", new ConfigNode("NotModified"));
            oldConfig.Add("Test.Removed", new ConfigNode("NotRemoved"));

            Config newConfig = new Config(oldConfig);
            newConfig.Remove("Test.Removed");
            newConfig["Test.Modified"] = new ConfigNode("Modified");
            newConfig.Add("Test.Added", new ConfigNode("Added"));

            var changeSet = ConfigLoader.GenerateChangeSet(oldConfig, newConfig);

            Assert.IsTrue(changeSet.ContainsNodeWithKey("Test.Modified"), "Modified change not recorded");
            Assert.IsTrue(changeSet.ContainsNodeWithKey("Test.Removed"), "Removed change not recorded");
            Assert.IsTrue(changeSet.ContainsNodeWithKey("Test.Added"), "Added change not recorded");

            Assert.AreEqual(ChangeType.Modified, changeSet.WithKey("Test.Modified").Type);
            Assert.AreEqual(ChangeType.Removed, changeSet.WithKey("Test.Removed").Type);
            Assert.AreEqual(ChangeType.Added, changeSet.WithKey("Test.Added").Type);

            Assert.AreEqual("NotModified", changeSet.WithKey("Test.Modified").Old.Value);
            Assert.AreEqual("Modified", changeSet.WithKey("Test.Modified").New.Value);
            Assert.AreEqual("NotRemoved", changeSet.WithKey("Test.Removed").Old.Value);
            Assert.AreEqual(null, changeSet.WithKey("Test.Removed").New);
            Assert.AreEqual(null, changeSet.WithKey("Test.Added").Old);
            Assert.AreEqual("Added", changeSet.WithKey("Test.Added").New.Value);
        }
    }


}
