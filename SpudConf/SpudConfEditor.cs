using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tator.SpudConf
{
    public partial class SpudConfEditor : UserControl
    {
        private DataEditor currentEditor;
        public string CurrentType { get; set; }

        private Config currentConfig;

        public SpudConfEditor()
        {
            InitializeComponent();
            currentConfig = new Config();
            SetEditor(new StringDataEditor());
            groupBoxEditorContainer.Controls.Add(currentEditor);

        }

        public void LoadConfig(Stream stream)
        {
            currentConfig.Load(stream);
            PopulateTreeView();
        }

        public void GenerateConfig(Stream stream)
        {
            currentConfig.Generate(stream);
        }

        private void SetEditor(DataEditor editor)
        {
            currentEditor = editor;
            currentEditor.ValueChanged += updateConfigFromEditor;
            currentEditor.Dock = DockStyle.Fill;
            groupBoxEditorContainer.Text = currentEditor.GetEditorName();
        }

        private void PopulateTreeView()
        {
            treeViewGUI.BeginUpdate();
            treeViewGUI.Nodes.Clear();
            foreach (var c in currentConfig)
            {
                var path = new List<string>(c.Key.Split('.'));
                if (!treeViewGUI.Nodes.ContainsKey(path[0]))
                {
                    treeViewGUI.Nodes.Add(path[0], path[0]);
                }
                var currentNode = treeViewGUI.Nodes[path[0]];
                path.RemoveAt(0);
                foreach (var p in path)
                {
                    if (!currentNode.Nodes.ContainsKey(p))
                    {
                        currentNode.Nodes.Add(p, p);
                    }
                    currentNode = currentNode.Nodes[p];
                }
            }
            treeViewGUI.EndUpdate();
        }

        private void updateConfigFromEditor(object sender, EventArgs e)
        {
            var de = sender as DataEditor;
            if (currentConfig != null && currentConfig.ContainsKey(de.Key))
            {
                currentConfig[de.Key].Value = de.Value;
            }
        }

        private void treeViewGUI_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string key = e.Node.FullPath;
            if (currentConfig.ContainsKey(key))
            {
                currentEditor.Key = e.Node.FullPath;
                currentEditor.Value = currentConfig[e.Node.FullPath].Value;
            }
        }
    }

    public class DataEditor : UserControl
    {
        public virtual string Key { get; set; }
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }

        public virtual string GetEditorName() { return "Default Editor"; }
        public virtual event EventHandler ValueChanged;
    }
}
