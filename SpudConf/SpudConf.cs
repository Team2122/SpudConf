using System;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;

namespace Tator.SpudConf
{
    public partial class SpudConf : Form
    {
        string fileName;

        public SpudConf()
        {
            InitializeComponent();
        }

        private void menuStripQuit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripItemOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var s = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    spudConfEditor.LoadConfig(s);
                }
            }
        }


        private void toolStripItemSave_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                toolStripItemSaveAs_Click(sender, e);
                return;
            }
            using (var s = new FileStream(fileName, FileMode.Truncate, FileAccess.ReadWrite))
            {
                spudConfEditor.GenerateConfig(s);
            }
            fileName = openFileDialog.FileName;
        }

        private void toolStripItemName_Click(object sender, EventArgs e)
        {
            var dialog = new NameDialog();
            string name = Properties.Settings.Default.UserName;
            if (name.Length < 1)
            {
                dialog.UserName = Environment.UserName;
                dialog.SelectAll();
            }
            else
            {
                dialog.UserName = name;
            }
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.UserName = dialog.UserName;
                Properties.Settings.Default.Save();
            }
        }

        private void toolStripItemIpAddress_Click(object sender, EventArgs e)
        {
            var dialog = new IPDialog();
            dialog.TeamNumber = Properties.Settings.Default.TeamNumber;
            dialog.IPAddress = Properties.Settings.Default.IPAddress;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.TeamNumber = dialog.TeamNumber;
                Properties.Settings.Default.IPAddress = dialog.IPAddress;
                Properties.Settings.Default.Save();
            }
        }

        private void toolStripItemSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // TODO: change to save
                using (var s = new FileStream(saveFileDialog.FileName, FileMode.Truncate, FileAccess.ReadWrite))
                {
                    spudConfEditor.GenerateConfig(s);
                }
                fileName = saveFileDialog.FileName;
            }
        }
    }
}
