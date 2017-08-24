namespace Launcher
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbExtention = new System.Windows.Forms.ComboBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnLauncher = new System.Windows.Forms.Button();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLauncherPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(460, 246);
            this.tabControl.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.btnReload);
            this.tabMain.Controls.Add(this.btnRun);
            this.tabMain.Controls.Add(this.dgvFiles);
            this.tabMain.Controls.Add(this.btnExit);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(452, 220);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Home";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(8, 97);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(8, 68);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFile});
            this.dgvFiles.Location = new System.Drawing.Point(204, 6);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.Size = new System.Drawing.Size(240, 211);
            this.dgvFiles.TabIndex = 2;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            // 
            // colFile
            // 
            this.colFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFile.HeaderText = "File";
            this.colFile.Name = "colFile";
            this.colFile.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(8, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.cbExtention);
            this.tabSettings.Controls.Add(this.btnFolder);
            this.tabSettings.Controls.Add(this.btnLauncher);
            this.tabSettings.Controls.Add(this.tbFolderPath);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.tbLauncherPath);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(452, 220);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Extention:";
            // 
            // cbExtention
            // 
            this.cbExtention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtention.FormattingEnabled = true;
            this.cbExtention.Items.AddRange(new object[] {
            "*.*"});
            this.cbExtention.Location = new System.Drawing.Point(106, 121);
            this.cbExtention.Name = "cbExtention";
            this.cbExtention.Size = new System.Drawing.Size(79, 24);
            this.cbExtention.TabIndex = 6;
            this.cbExtention.Text = "*.*";
            this.cbExtention.SelectedIndexChanged += new System.EventHandler(this.cbExtention_SelectedIndexChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(7, 81);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(90, 23);
            this.btnFolder.TabIndex = 5;
            this.btnFolder.Text = "Change Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnLauncher
            // 
            this.btnLauncher.Location = new System.Drawing.Point(7, 32);
            this.btnLauncher.Name = "btnLauncher";
            this.btnLauncher.Size = new System.Drawing.Size(102, 23);
            this.btnLauncher.TabIndex = 4;
            this.btnLauncher.Text = "change launcher";
            this.btnLauncher.UseVisualStyleBackColor = true;
            this.btnLauncher.Click += new System.EventHandler(this.btnLauncher_Click);
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(86, 60);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.ReadOnly = true;
            this.tbFolderPath.Size = new System.Drawing.Size(358, 20);
            this.tbFolderPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To start:";
            // 
            // tbLauncherPath
            // 
            this.tbLauncherPath.Location = new System.Drawing.Point(86, 6);
            this.tbLauncherPath.Name = "tbLauncherPath";
            this.tbLauncherPath.ReadOnly = true;
            this.tbLauncherPath.Size = new System.Drawing.Size(358, 20);
            this.tbLauncherPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start With:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "exe";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 268);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Main";
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnLauncher;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLauncherPath;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbExtention;
    }
}