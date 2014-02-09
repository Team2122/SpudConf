namespace Tator.SpudConf
{
    partial class SpudConf
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpudConf));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelRobotConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemIpAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemNetworkProfiler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.spudConfEditor = new Tator.SpudConf.SpudConfEditor();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.spudConfEditor);
            resources.ApplyResources(this.toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
            resources.ApplyResources(this.toolStripContainer, "toolStripContainer");
            this.toolStripContainer.Name = "toolStripContainer";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRobotConnected});
            this.statusStrip.Name = "statusStrip";
            // 
            // labelRobotConnected
            // 
            this.labelRobotConnected.Name = "labelRobotConnected";
            resources.ApplyResources(this.labelRobotConnected, "labelRobotConnected");
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemFile,
            this.toolStripItemOptions,
            this.toolStripItemHelp});
            this.menuStrip.Name = "menuStrip";
            // 
            // toolStripItemFile
            // 
            this.toolStripItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemOpen,
            this.toolStripItemSave,
            this.toolStripItemSaveAs,
            this.toolStripItemUpload,
            this.toolStripSeparator1,
            this.toolStripItemQuit});
            this.toolStripItemFile.Name = "toolStripItemFile";
            resources.ApplyResources(this.toolStripItemFile, "toolStripItemFile");
            // 
            // toolStripItemOpen
            // 
            this.toolStripItemOpen.Name = "toolStripItemOpen";
            resources.ApplyResources(this.toolStripItemOpen, "toolStripItemOpen");
            this.toolStripItemOpen.Click += new System.EventHandler(this.toolStripItemOpen_Click);
            // 
            // toolStripItemSave
            // 
            this.toolStripItemSave.Name = "toolStripItemSave";
            resources.ApplyResources(this.toolStripItemSave, "toolStripItemSave");
            this.toolStripItemSave.Click += new System.EventHandler(this.toolStripItemSave_Click);
            // 
            // toolStripItemSaveAs
            // 
            this.toolStripItemSaveAs.Name = "toolStripItemSaveAs";
            resources.ApplyResources(this.toolStripItemSaveAs, "toolStripItemSaveAs");
            this.toolStripItemSaveAs.Click += new System.EventHandler(this.toolStripItemSaveAs_Click);
            // 
            // toolStripItemUpload
            // 
            this.toolStripItemUpload.Name = "toolStripItemUpload";
            resources.ApplyResources(this.toolStripItemUpload, "toolStripItemUpload");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripItemQuit
            // 
            this.toolStripItemQuit.Name = "toolStripItemQuit";
            resources.ApplyResources(this.toolStripItemQuit, "toolStripItemQuit");
            this.toolStripItemQuit.Click += new System.EventHandler(this.menuStripQuit);
            // 
            // toolStripItemOptions
            // 
            this.toolStripItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemName,
            this.toolStripItemIpAddress});
            this.toolStripItemOptions.Name = "toolStripItemOptions";
            resources.ApplyResources(this.toolStripItemOptions, "toolStripItemOptions");
            // 
            // toolStripItemName
            // 
            this.toolStripItemName.Name = "toolStripItemName";
            resources.ApplyResources(this.toolStripItemName, "toolStripItemName");
            this.toolStripItemName.Click += new System.EventHandler(this.toolStripItemName_Click);
            // 
            // toolStripItemIpAddress
            // 
            this.toolStripItemIpAddress.Name = "toolStripItemIpAddress";
            resources.ApplyResources(this.toolStripItemIpAddress, "toolStripItemIpAddress");
            this.toolStripItemIpAddress.Click += new System.EventHandler(this.toolStripItemIpAddress_Click);
            // 
            // toolStripItemHelp
            // 
            this.toolStripItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemRepo,
            this.toolStripItemGithub,
            this.toolStripItemNetworkProfiler});
            this.toolStripItemHelp.Name = "toolStripItemHelp";
            resources.ApplyResources(this.toolStripItemHelp, "toolStripItemHelp");
            // 
            // toolStripItemRepo
            // 
            this.toolStripItemRepo.Name = "toolStripItemRepo";
            resources.ApplyResources(this.toolStripItemRepo, "toolStripItemRepo");
            // 
            // toolStripItemGithub
            // 
            this.toolStripItemGithub.Name = "toolStripItemGithub";
            resources.ApplyResources(this.toolStripItemGithub, "toolStripItemGithub");
            // 
            // toolStripItemNetworkProfiler
            // 
            this.toolStripItemNetworkProfiler.Name = "toolStripItemNetworkProfiler";
            resources.ApplyResources(this.toolStripItemNetworkProfiler, "toolStripItemNetworkProfiler");
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonRemove});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::Tator.SpudConf.Properties.Resources.Action_Add;
            resources.ApplyResources(this.toolStripButtonAdd, "toolStripButtonAdd");
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemove.Image = global::Tator.SpudConf.Properties.Resources.Action_Cancel;
            resources.ApplyResources(this.toolStripButtonRemove, "toolStripButtonRemove");
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            // 
            // spudConfEditor
            // 
            this.spudConfEditor.CurrentType = null;
            resources.ApplyResources(this.spudConfEditor, "spudConfEditor");
            this.spudConfEditor.Name = "spudConfEditor";
            // 
            // SpudConf
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer);
            this.Name = "SpudConf";
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemQuit;
        private SpudConfEditor spudConfEditor;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemName;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemUpload;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemIpAddress;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemRepo;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemGithub;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemNetworkProfiler;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelRobotConnected;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
    }
}

