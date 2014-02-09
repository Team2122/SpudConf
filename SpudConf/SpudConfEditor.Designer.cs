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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpudConfEditor));
            this.splitContainerGUI = new System.Windows.Forms.SplitContainer();
            this.treeViewGUI = new System.Windows.Forms.TreeView();
            this.groupBoxEditorContainer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGUI)).BeginInit();
            this.splitContainerGUI.Panel1.SuspendLayout();
            this.splitContainerGUI.Panel2.SuspendLayout();
            this.splitContainerGUI.SuspendLayout();
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
            resources.ApplyResources(this.treeViewGUI, "treeViewGUI");
            this.treeViewGUI.LabelEdit = true;
            this.treeViewGUI.Name = "treeViewGUI";
            this.treeViewGUI.PathSeparator = ".";
            this.treeViewGUI.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGUI_AfterSelect);
            // 
            // groupBoxEditorContainer
            // 
            resources.ApplyResources(this.groupBoxEditorContainer, "groupBoxEditorContainer");
            this.groupBoxEditorContainer.Name = "groupBoxEditorContainer";
            this.groupBoxEditorContainer.TabStop = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGUI;
        private System.Windows.Forms.TreeView treeViewGUI;
        private System.Windows.Forms.GroupBox groupBoxEditorContainer;

    }
}
