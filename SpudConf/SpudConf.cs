using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tator.SpudConf
{
    public partial class SpudConf : Form
    {
        private string currentDirectory;
        private FtpClient ftpClient;
        private string localFileName;
        private string remoteFileName;

        public SpudConf()
        {
            InitializeComponent();
        }

        private string[] listAllFiles(string path)
        {
            var files = new List<string>();
            var directoryInfo = new DirectoryInfo(path);

            foreach (var item in directoryInfo.EnumerateFiles())
            {
                files.Add(path + Path.DirectorySeparatorChar + item.Name);
            }

            foreach (var item in directoryInfo.EnumerateDirectories())
            {
                files.AddRange(listAllFiles(path + Path.DirectorySeparatorChar + item.Name));
            }
            return files.ToArray();
        }

        private string[] listRemoteFiles(string dir)
        {
            var toDownload = new List<string>();
            var fileList = ftpClient.GetListing(dir);
            foreach (var file in fileList)
            {
                switch (file.Type)
                {
                    case FtpFileSystemObjectType.File:
                        toDownload.Add(dir + "/" + file.Name);
                        break;

                    case FtpFileSystemObjectType.Directory:
                        toDownload.AddRange(listRemoteFiles(dir + "/" + file.Name));
                        break;

                    default:
                        break;
                }
            }
            return toDownload.ToArray();
        }

        private void menuStripQuit(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool PromptSave()
        {
            if (!spudConfEditor.Dirty)
                return false;
            var ret = MessageBox.Show(this, "Do you want to save before performing this action?",
                "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ret == DialogResult.Yes)
            {
                toolStripItemSave_Click(this, new EventArgs());
                return true;
            }
            else
            {
                return false;
            }
        }

        private void scanDirectory()
        {
            toolStripComboFiles.Items.Clear();
            var baseDir = new Uri(currentDirectory);
            foreach (var file in listAllFiles(currentDirectory))
            {
                var path = baseDir.MakeRelativeUri(new Uri(file)).ToString();
                path = String.Join("/", path.Split('/').SkipWhile((s, i) => i < 1).ToArray());
                toolStripComboFiles.Items.Add(path);
            }
        }

        private void SpudConf_Load(object sender, EventArgs e)
        {
            ftpClient = new FtpClient()
            {
                Credentials = new NetworkCredential("anonymous", ""),
                Host = Properties.Settings.Default.IPAddress
            };
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            spudConfEditor.Add();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            spudConfEditor.Remove();
        }

        private void toolStripComboFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileName = (string)toolStripComboFiles.SelectedItem;
            if (fileName != "")
            {
                spudConfEditor.LoadConfig(new FileStream(currentDirectory
                    + Path.DirectorySeparatorChar + fileName,
                    FileMode.Open, FileAccess.Read));
                if (currentDirectory.Contains("Config"))
                {
                    var remoteDirectory = currentDirectory.Substring(currentDirectory.IndexOf("Config")).Replace("\\", "/");
                    remoteFileName = "/" + remoteDirectory + "/" + fileName;
                }
                else
                {
                    remoteFileName = fileName;
                }
                localFileName = currentDirectory + Path.DirectorySeparatorChar + fileName;
            }
            spudConfEditor.Dirty = false;
        }

        private void toolStripItemGithub_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com/Team2122");
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
                ftpClient.Host = dialog.IPAddress;
            }
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

        private void toolStripItemNetworkProfiler_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ain't got no network profiler yet! Yell at Alex to finish it.",
                "Nope", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            localFileName = openFileDialog.FileName;
        }

        private void toolStripItemOpenDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Properties.Settings.Default.LocalDirectory;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                currentDirectory = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.LocalDirectory = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                labelLocalDirectory.Text = "Local Directory: " + currentDirectory;
                scanDirectory();
            }
        }

        private void toolStripItemOpenTemp_Click(object sender, EventArgs e)
        {
            currentDirectory = Path.GetTempPath() + Path.DirectorySeparatorChar + Path.GetRandomFileName();
            Directory.CreateDirectory(currentDirectory);
            scanDirectory();
        }

        private void toolStripItemPullAll_Click(object sender, EventArgs e)
        {
            var directory = "Config";
            if (currentDirectory == null)
                toolStripItemOpenTemp_Click(this, new EventArgs());
            toolStripComboFiles.Items.Clear();
            var fileList = listRemoteFiles(directory);
            foreach (var file in fileList)
            {
                var fileName = currentDirectory + Path.DirectorySeparatorChar + file;
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                using (var bufferedStream = new BufferedStream(fileStream))
                {
                    ftpClient.OpenRead(file, FtpDataType.ASCII).CopyTo(bufferedStream);
                }
                var path = String.Join("/", file.Split('/').SkipWhile((s, i) => i < 1).ToArray());
                toolStripComboFiles.Items.Add(path);
            }
            scanDirectory();
        }

        private void toolStripItemPush_Click(object sender, EventArgs e)
        {
            if (!PromptSave())
                return;
            if (localFileName == null || localFileName == "")
            {
                MessageBox.Show(this, "Unable to upload: No file open", "Unable to upload",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            using (var fileStream = new FileStream(localFileName, FileMode.Open, FileAccess.Read))
            using (var bufferedStream = new BufferedStream(fileStream))
            {
                try
                {
                    using (var ftpStream = ftpClient.OpenWrite(this.remoteFileName, FtpDataType.ASCII))
                    {
                        bufferedStream.CopyTo(ftpStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "FTP Error: " + ex.Message, "FTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripItemPushAll_Click(object sender, EventArgs e)
        {
        }

        private void toolStripItemRepo_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com/Team2122/SpudConf");
        }

        private void toolStripItemSave_Click(object sender, EventArgs e)
        {
            if (localFileName == null)
            {
                toolStripItemSaveAs_Click(sender, e);
                return;
            }
            using (var s = new FileStream(localFileName, FileMode.Truncate, FileAccess.ReadWrite))
            {
                spudConfEditor.GenerateConfig(s);
            }
            spudConfEditor.Dirty = false;
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
                localFileName = saveFileDialog.FileName;
            }
            spudConfEditor.Dirty = true;
        }

        private void toolStripButtonRename_Click(object sender, EventArgs e)
        {
            spudConfEditor.Rename();
        }

        private void toolStripItemPullLogs_Click(object sender, EventArgs e)
        {
            //var result = folderBrowserDialogPullLogs.ShowDialog(this);
            var directory = "/";
            var fileList = ftpClient.GetListing(directory);
            Regex r = new Regex(@"^/Log_\d+\.csv$");
            foreach (var f in fileList)
            {
                var file = f.FullName;
                if (!r.Match(file).Success)
                {
                    continue;
                }
                var fileName = String.Format(@"C:\Users\{0}\Documents\Spudnik Logs\{1} {2}", Environment.UserName, DateTime.Now.ToString(@"yyyy_MM_dd hh.mm.ss"), file.Replace("/", "").Replace(@"\", "") /* Remove slashes */);
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                using (var bufferedStream = new BufferedStream(fileStream))
                {
                    var ftpStream = ftpClient.OpenRead(file, FtpDataType.ASCII);
                    ftpStream.CopyTo(bufferedStream);
                    ftpStream.Close();
                    ftpClient.DeleteFile(file);
                }
            }
        }
    }
}