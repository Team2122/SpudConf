namespace Tator.SpudConf
{
    partial class SpudConfEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpudConfEditor));
            this.splitContainerGUI = new System.Windows.Forms.SplitContainer();
            this.treeViewGUI = new System.Windows.Forms.TreeView();
            this.groupBoxEditorContainer = new System.Windows.Forms.GroupBox();
            this.contextMenuStripTreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripItemRename = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGUI)).BeginInit();
            this.splitContainerGUI.Panel1.SuspendLayout();
            this.splitContainerGUI.Panel2.SuspendLayout();
            this.splitContainerGUI.SuspendLayout();
            this.contextMenuStripTreeNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerGUI
            // 
            resources.ApplyResources(this.splitContainerGUI, "splitContainerGUI");
            this.splitContainerGUI.Name = "splitContainerGUI";
            // 
            // splitContainerGUI.Panel1
            // 
            this.splitContainerGUI.Panel1.Controls.Add(this.treeViewGUI);
            // 
            // splitContainerGUI.Panel2
            // 
            this.splitContainerGUI.Panel2.Controls.Add(this.groupBoxEditorContainer);
            // 
            // treeViewGUI
            // 
            this.treeViewGUI.AllowDrop = true;
            this.treeViewGUI.ContextMenuStrip = this.contextMenuStripTreeNode;
            resources.ApplyResources(this.treeViewGUI, "treeViewGUI");
            this.treeViewGUI.LabelEdit = true;
            this.treeViewGUI.Name = "treeViewGUI";
            this.treeViewGUI.PathSeparator = ".";
            this.treeViewGUI.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewGUI_AfterLabelEdit);
            this.treeViewGUI.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGUI_AfterSelect);
            // 
            // groupBoxEditorContainer
            // 
            resources.ApplyResources(this.groupBoxEditorContainer, "groupBoxEditorContainer");
            this.groupBoxEditorContainer.Name = "groupBoxEditorContainer";
            this.groupBoxEditorContainer.TabStop = false;
            // 
            // contextMenuStripTreeNode
            // 
            this.contextMenuStripTreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemRename});
            this.contextMenuStripTreeNode.Name = "contextMenuStripTreeNode";
            resources.ApplyResources(this.contextMenuStripTreeNode, "contextMenuStripTreeNode");
            // 
            // toolStripItemRename
            // 
            this.toolStripItemRename.Name = "toolStripItemRename";
            resources.ApplyResources(this.toolStripItemRename, "toolStripItemRename");
            this.toolStripItemRename.Click += new System.EventHandler(this.toolStripItemRename_Click);
            // 
            // SpudConfEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerGUI);
            this.Name = "SpudConfEditor";
            this.splitContainerGUI.Panel1.ResumeLayout(false);
            this.splitContainerGUI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGUI)).EndInit();
            this.splitContainerGUI.ResumeLayout(false);
            this.contextMenuStripTreeNode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGUI;
        private System.Windows.Forms.TreeView treeViewGUI;
        private System.Windows.Forms.GroupBox groupBoxEditorContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeNode;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemRename;

    }
}
