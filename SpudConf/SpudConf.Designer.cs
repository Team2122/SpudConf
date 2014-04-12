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
            this.labelLocalDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemOpenDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemOpenTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemRobot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemDeploy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemPushAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemPullAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemPullLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemIpAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemNetworkProfiler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditor = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRename = new System.Windows.Forms.ToolStripButton();
            this.toolStripFiles = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboFiles = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogPullLogs = new System.Windows.Forms.FolderBrowserDialog();
            this.spudConfEditor = new Tator.SpudConf.SpudConfEditor();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStripEditor.SuspendLayout();
            this.toolStripFiles.SuspendLayout();
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
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripEditor);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripFiles);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelLocalDirectory});
            this.statusStrip.Name = "statusStrip";
            // 
            // labelLocalDirectory
            // 
            this.labelLocalDirectory.Name = "labelLocalDirectory";
            resources.ApplyResources(this.labelLocalDirectory, "labelLocalDirectory");
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemFile,
            this.toolStripItemRobot,
            this.toolStripItemOptions,
            this.toolStripItemHelp});
            this.menuStrip.Name = "menuStrip";
            // 
            // toolStripItemFile
            // 
            this.toolStripItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemOpenDirectory,
            this.toolStripItemOpenTemp,
            this.toolStripItemOpen,
            this.toolStripItemSave,
            this.toolStripItemSaveAs,
            this.toolStripSeparator1,
            this.toolStripItemQuit});
            this.toolStripItemFile.Name = "toolStripItemFile";
            resources.ApplyResources(this.toolStripItemFile, "toolStripItemFile");
            // 
            // toolStripItemOpenDirectory
            // 
            this.toolStripItemOpenDirectory.Name = "toolStripItemOpenDirectory";
            resources.ApplyResources(this.toolStripItemOpenDirectory, "toolStripItemOpenDirectory");
            this.toolStripItemOpenDirectory.Click += new System.EventHandler(this.toolStripItemOpenDirectory_Click);
            // 
            // toolStripItemOpenTemp
            // 
            this.toolStripItemOpenTemp.Name = "toolStripItemOpenTemp";
            resources.ApplyResources(this.toolStripItemOpenTemp, "toolStripItemOpenTemp");
            this.toolStripItemOpenTemp.Click += new System.EventHandler(this.toolStripItemOpenTemp_Click);
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
            // toolStripItemRobot
            // 
            this.toolStripItemRobot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemDeploy,
            this.toolStripItemPushAll,
            this.toolStripItemPullAll,
            this.toolStripItemPullLogs});
            this.toolStripItemRobot.Name = "toolStripItemRobot";
            resources.ApplyResources(this.toolStripItemRobot, "toolStripItemRobot");
            // 
            // toolStripItemDeploy
            // 
            this.toolStripItemDeploy.Name = "toolStripItemDeploy";
            resources.ApplyResources(this.toolStripItemDeploy, "toolStripItemDeploy");
            this.toolStripItemDeploy.Click += new System.EventHandler(this.toolStripItemPush_Click);
            // 
            // toolStripItemPushAll
            // 
            resources.ApplyResources(this.toolStripItemPushAll, "toolStripItemPushAll");
            this.toolStripItemPushAll.Name = "toolStripItemPushAll";
            this.toolStripItemPushAll.Click += new System.EventHandler(this.toolStripItemPushAll_Click);
            // 
            // toolStripItemPullAll
            // 
            resources.ApplyResources(this.toolStripItemPullAll, "toolStripItemPullAll");
            this.toolStripItemPullAll.Name = "toolStripItemPullAll";
            this.toolStripItemPullAll.Click += new System.EventHandler(this.toolStripItemPullAll_Click);
            // 
            // toolStripItemPullLogs
            // 
            this.toolStripItemPullLogs.Name = "toolStripItemPullLogs";
            resources.ApplyResources(this.toolStripItemPullLogs, "toolStripItemPullLogs");
            this.toolStripItemPullLogs.Click += new System.EventHandler(this.toolStripItemPullLogs_Click);
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
            this.toolStripItemRepo.Click += new System.EventHandler(this.toolStripItemRepo_Click);
            // 
            // toolStripItemGithub
            // 
            this.toolStripItemGithub.Name = "toolStripItemGithub";
            resources.ApplyResources(this.toolStripItemGithub, "toolStripItemGithub");
            this.toolStripItemGithub.Click += new System.EventHandler(this.toolStripItemGithub_Click);
            // 
            // toolStripItemNetworkProfiler
            // 
            this.toolStripItemNetworkProfiler.Name = "toolStripItemNetworkProfiler";
            resources.ApplyResources(this.toolStripItemNetworkProfiler, "toolStripItemNetworkProfiler");
            this.toolStripItemNetworkProfiler.Click += new System.EventHandler(this.toolStripItemNetworkProfiler_Click);
            // 
            // toolStripEditor
            // 
            resources.ApplyResources(this.toolStripEditor, "toolStripEditor");
            this.toolStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonRemove,
            this.toolStripButtonRename});
            this.toolStripEditor.Name = "toolStripEditor";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::Tator.SpudConf.Properties.Resources.Action_Add;
            resources.ApplyResources(this.toolStripButtonAdd, "toolStripButtonAdd");
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemove.Image = global::Tator.SpudConf.Properties.Resources.Action_Cancel;
            resources.ApplyResources(this.toolStripButtonRemove, "toolStripButtonRemove");
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // toolStripButtonRename
            // 
            this.toolStripButtonRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRename.Image = global::Tator.SpudConf.Properties.Resources.Action_Rename;
            resources.ApplyResources(this.toolStripButtonRename, "toolStripButtonRename");
            this.toolStripButtonRename.Name = "toolStripButtonRename";
            this.toolStripButtonRename.Click += new System.EventHandler(this.toolStripButtonRename_Click);
            // 
            // toolStripFiles
            // 
            resources.ApplyResources(this.toolStripFiles, "toolStripFiles");
            this.toolStripFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboFiles});
            this.toolStripFiles.Name = "toolStripFiles";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // toolStripComboFiles
            // 
            this.toolStripComboFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboFiles.Name = "toolStripComboFiles";
            resources.ApplyResources(this.toolStripComboFiles, "toolStripComboFiles");
            this.toolStripComboFiles.SelectedIndexChanged += new System.EventHandler(this.toolStripComboFiles_SelectedIndexChanged);
            // 
            // spudConfEditor
            // 
            this.spudConfEditor.CurrentType = null;
            this.spudConfEditor.Dirty = false;
            resources.ApplyResources(this.spudConfEditor, "spudConfEditor");
            this.spudConfEditor.Name = "spudConfEditor";
            // 
            // SpudConf
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer);
            this.Name = "SpudConf";
            this.Load += new System.EventHandler(this.SpudConf_Load);
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
            this.toolStripEditor.ResumeLayout(false);
            this.toolStripEditor.PerformLayout();
            this.toolStripFiles.ResumeLayout(false);
            this.toolStripFiles.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripItemIpAddress;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemRepo;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemGithub;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemNetworkProfiler;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelLocalDirectory;
        private System.Windows.Forms.ToolStrip toolStripEditor;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemOpenDirectory;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemRobot;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemDeploy;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemPushAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemPullAll;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemOpenTemp;
        private System.Windows.Forms.ToolStripButton toolStripButtonRename;
        private System.Windows.Forms.ToolStrip toolStripFiles;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemPullLogs;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPullLogs;
    }
}

