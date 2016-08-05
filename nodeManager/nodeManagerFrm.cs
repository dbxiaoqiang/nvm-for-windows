using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;

namespace nodeManager
{
    public partial class nodeManagerFrm : Form
    {
        private const string ENV_VARNAME = "PATH";
        private const string NODE_DIST = "https://nodejs.org/dist/v{0}/node-v{0}-x64.msi";
        private const string UNINSTALL_NODE = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Node.js\Uninstall Node.js.lnk";
        private const string INSTALL_NODE = @"/i {0} INSTALLDIR={1} /quiet /passive /norestart";
        private const string INSTALL_DIR = @"D:\nodejs";

        public nodeManagerFrm()
        {
            InitializeComponent();
            if (!Directory.Exists(INSTALL_DIR))
            {
                Directory.CreateDirectory(INSTALL_DIR);
            }
            GetAllNodejs();
        }

        private void GetAllNodejs()
        {
            var nodejs = (new DirectoryInfo(Path.GetFullPath("../"))).GetDirectories("?.?.?");
            this.lstNodeVersions.Items.Clear();
            foreach (var temp in nodejs)
            {
                this.lstNodeVersions.Items.Add(temp.Name);
            }
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            var url = string.Format(NODE_DIST, this.txtVersion.Text);
            await Task.Run(() =>
            {
                var request = WebRequest.CreateHttp(url);
                request.Method = "GET";
                var downloadPath = string.Format("../{0}/node{0}.msi", this.txtVersion.Text);
                var response = request.GetResponse();
                using (var myResponseStream = response.GetResponseStream())
                {
                    var directory = Path.GetDirectoryName(downloadPath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    using (var fileStream = new FileStream(downloadPath, FileMode.Create))
                    {
                        this.Invoke(new Action(() => { 
                            this.ChangeDownlaodStatusVisable(true);
                            this.prbDownload.Maximum = (int)response.ContentLength;
                        }));
                        var action = new Action<int, float>((value, precent) => {
                            this.prbDownload.Value = value;
                            this.lblPrecentage.Text = string.Format("{0}%", precent);
                        });
                        long totalDownloadSize = 0;
                        long totalBytes = response.ContentLength;
                        var by = new byte[1024];
                        int osize = myResponseStream.Read(by, 0, by.Length);
                        float precentage = 0f;
                        while (osize > 0)
                        {
                            totalDownloadSize += osize;
                            fileStream.Write(by, 0, osize);
                            precentage = (float)totalDownloadSize / (float)totalBytes * 100;
                            this.Invoke(action, (int)totalDownloadSize, precentage);
                            osize = myResponseStream.Read(by, 0, by.Length);
                        }
                        fileStream.Close();
                    }
                    myResponseStream.Close();
                    this.Invoke(new Action(() => {
                        this.ChangeDownlaodStatusVisable(false);
                        GetAllNodejs();
                    }));
                }
            });
        }
        private void UninstallNodejs(Action callback)
        {
            if (!File.Exists(UNINSTALL_NODE))
            {
                if (callback != null)
                {
                    callback();
                }
                return;
            }
            var delProcess = Process.Start(UNINSTALL_NODE);
            delProcess.WaitForExit();
            if (callback != null)
            {
                callback();
            }
        }
        private void InstallNodejs(string path)
        {
            this.UninstallNodejs(() =>
            {
                var args = string.Format(INSTALL_NODE, Path.GetFullPath(path), INSTALL_DIR);
                var process = Process.Start("msiexec", args);
                process.WaitForExit();
            });
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var path = string.Format("../{0}/node{0}.msi", this.lstNodeVersions.SelectedItem);
            InstallNodejs(path);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var version = this.lstNodeVersions.SelectedItem.ToString();
            var directory = new DirectoryInfo(Path.GetFullPath(string.Format("../{0}", version)));
            directory.Delete(true);
            if (version == GetCurrentVersion())
            {
                UninstallNodejs(null);
            }
            GetCurrentVersion();
        }

        private string GetCurrentVersion()
        {
            var path = Environment.GetEnvironmentVariable(ENV_VARNAME, EnvironmentVariableTarget.Machine).Split(';').First((s) => s.IndexOf("nodejs") > 0);
            return FileVersionInfo.GetVersionInfo(path + "node.exe").FileVersion;
        }

        private void ChangeEnableStatus(bool enable)
        {
            foreach (var ctrl in this.Controls)
            {
                ((Control)ctrl).Enabled = enable;
            }
        }

        private void ChangeDownlaodStatusVisable(bool visable)
        {
            this.prbDownload.Value = 0;
            this.pnlDownloadStatus.Visible = visable;
        }
    }
}
