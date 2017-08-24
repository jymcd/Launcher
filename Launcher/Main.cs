using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Ini;
namespace Launcher
{
    public partial class Main : frmTemplate
    {
        string inipath;
        IniFile inifile;
        string runFolder;
        string startPath;
        string toRun;
        string extention = "*.*";

        public Main()
        {
            InitializeComponent();
            inipath = Application.StartupPath.ToString() + "/launcher.ini";
            if (File.Exists(inipath)){
                inifile = new IniFile(inipath);
            }
            else{
                File.Create(inipath);
                inifile = new IniFile(inipath);
                inifile.IniWriteValue("Settings", "StartPath", "c:\\");
                inifile.IniWriteValue("Settings", "RunFolder", "c:\\");
                inifile.IniWriteValue("Settings", "Extention", "*.*");
            }
            extention = inifile.IniReadValue("Settings", "Extention");
            runFolder = inifile.IniReadValue("Settings", "Runfolder");
            startPath = inifile.IniReadValue("Settings", "StartPath");
            cbExtention.Text = extention.ToString();
            tbLauncherPath.Text = startPath;
            tbFolderPath.Text = runFolder;
            reloadDgv();
            reloadComboBox();
            status("Loaded");
        }

        private void reloadDgv()
        {
            if (string.IsNullOrEmpty(runFolder)) { }
            else
            {
                dgvFiles.Rows.Clear();
                string[] files = Directory.GetFiles(runFolder, cbExtention.Text);
                for (int i = 0; i < files.Length; i++)
                {
                    string[] tmp = files[i].Split('\\');
                    dgvFiles.Rows.Add(tmp[tmp.Length - 1]);
                }
            }
        }

        private void reloadComboBox()
        {
            if (string.IsNullOrEmpty(runFolder)) { }
            else
            {
                cbExtention.Items.Clear();
                cbExtention.Items.Add("*.*");
                string[] files = Directory.GetFiles(runFolder, "*.*");
                for (int i = 0; i < files.Length; i++)
                {
                    string[] tmp = files[i].Split('\\');
                    string[] ext = tmp[tmp.Length - 1].Split('.');
                    if (!cbExtention.Items.Contains(string.Format("*.{0}", ext[ext.Length - 1])))
                    {
                        cbExtention.Items.Add(string.Format("*.{0}",ext[ext.Length - 1]));
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLauncher_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                inifile.IniWriteValue("Settings", "StartPath", openFileDialog.FileName.ToString());
                startPath = inifile.IniReadValue("Settings", "StartPath");
                tbLauncherPath.Text = startPath;
                reloadDgv();
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                inifile.IniWriteValue("Settings", "RunFolder", folderBrowserDialog.SelectedPath.ToString());
                runFolder = inifile.IniReadValue("Settings", "Runfolder");
                tbFolderPath.Text = runFolder;
                reloadDgv();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reloadDgv();
            reloadComboBox();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            try
            {
                proc.EnableRaisingEvents = true;
                string args = String.Format(@"{0}/{1}", runFolder, toRun.ToString());
                proc.StartInfo.Arguments = args;
                proc.StartInfo.FileName = startPath;
                proc.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("unable to start no file selected" , "Error", MessageBoxButtons.OK);
            }
            proc.Close();
        }

        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvFiles.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                toRun = dgvFiles.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void cbExtention_SelectedIndexChanged(object sender, EventArgs e)
        {
            inifile.IniWriteValue("Settings", "Extention", cbExtention.Text);
            reloadDgv();
        }
    }
}
