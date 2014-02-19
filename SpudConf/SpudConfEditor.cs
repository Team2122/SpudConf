using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tator.SpudConf
{
    public partial class SpudConfEditor : UserControl
    {
        private Config currentConfig;
        private DataEditor currentEditor;

        public SpudConfEditor()
        {
            InitializeComponent();
            currentConfig = new Config();
            SetEditor(new StringDataEditor());
            groupBoxEditorContainer.Controls.Add(currentEditor);
        }

        public string CurrentType { get; set; }

        public bool Dirty { get; set; }
        public void Add()
        {
            uint extendedNum = 0;
            var prefix = treeViewGUI.SelectedNode == null ? "" : treeViewGUI.SelectedNode.FullPath;
            prefix = prefix.Length > 0 ? prefix + "." : prefix;
            string key = prefix + "New Key";
            while (currentConfig.ContainsKey(key))
            {
                key = prefix + String.Format("New Key ({0})", ++extendedNum);
            }
            currentConfig.Add(key, new ConfigNode());
            PopulateTreeView();
        }

        public void GenerateConfig(Stream stream)
        {
            currentConfig.Generate(stream);
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
        public void Remove()
        {
            if (treeViewGUI.SelectedNode == null)
                return;
            var key = treeViewGUI.SelectedNode.FullPath;
            currentConfig.RemoveParent(key);
            PopulateTreeView();
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

        private void SelectNode(string key)
        {
            if (currentConfig.ContainsKey(key))
            {
                currentEditor.Key = key;
                currentEditor.Value = currentConfig[key].Value;
            }
        }

        private void SetEditor(DataEditor editor)
        {
            currentEditor = editor;
            currentEditor.ValueChanged += updateConfigFromEditor;
            currentEditor.Dock = DockStyle.Fill;
            groupBoxEditorContainer.Text = currentEditor.GetEditorName();
        }
        private void toolStripItemAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void toolStripItemRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void toolStripItemRename_Click(object sender, EventArgs e)
        {
            Rename();
        }

        public void Rename()
        {
            if (treeViewGUI.SelectedNode != null)
                treeViewGUI.SelectedNode.BeginEdit();
        }

        private void treeViewGUI_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // Fixes weird NullPointerException
            if (e.Node == null || e.Label == null)
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
            currentConfig.RenameParent(oldKey, newKey);
            SelectNode(newKey);
            Dirty = true;
        }

        private void treeViewGUI_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectNode(e.Node.FullPath);
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
    }

    public class DataEditor : UserControl
    {
        public virtual event EventHandler ValueChanged;

        public virtual string Description { get; set; }

        public virtual string Key { get; set; }

        public virtual string Value { get; set; }
        public virtual string GetEditorName()
        {
            return "Default Editor";
        }
    }
}