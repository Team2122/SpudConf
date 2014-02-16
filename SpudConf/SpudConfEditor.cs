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
        public bool Dirty { get; set; }

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
            try
            {
                currentConfig.Load(stream);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error opening config file: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PopulateTreeView();
            Dirty = false;
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
            Dirty = true;
        }

        private void treeViewGUI_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectNode(e.Node.FullPath);
        }

        private void SelectNode(string key)
        {
            if (currentConfig.ContainsKey(key))
            {
                currentEditor.Key = key;
                currentEditor.Value = currentConfig[key].Value;
            }
        }

        private void treeViewGUI_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // Fixes weird NullPointerException
            if (e.Node == null)
                return;
            if (e.Label.Contains('.'))
            {
                e.CancelEdit = true;
                return;
            }
            string oldKey = e.Node.FullPath;
            string[] nKey = oldKey.Split('.');
            nKey[e.Node.Level] = e.Label;
            string newKey = String.Join(".", nKey);
            if (currentConfig.ContainsParentKey(newKey))
            {
                e.CancelEdit = true;
                return;
            }
            e.CancelEdit = false;
            currentConfig.RenameKey(oldKey, newKey);
            SelectNode(newKey);
            Dirty = true;
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
