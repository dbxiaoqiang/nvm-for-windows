namespace nodeManager
{
    partial class nodeManagerFrm
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
            this.btnGet = new System.Windows.Forms.Button();
            this.lstNodeVersions = new System.Windows.Forms.ListBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prbDownload = new System.Windows.Forms.ProgressBar();
            this.pnlDownloadStatus = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecentage = new System.Windows.Forms.Label();
            this.pnlDownloadStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "get";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // lstNodeVersions
            // 
            this.lstNodeVersions.FormattingEnabled = true;
            this.lstNodeVersions.ItemHeight = 12;
            this.lstNodeVersions.Location = new System.Drawing.Point(108, 12);
            this.lstNodeVersions.Name = "lstNodeVersions";
            this.lstNodeVersions.Size = new System.Drawing.Size(236, 100);
            this.lstNodeVersions.TabIndex = 1;
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(12, 123);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(109, 125);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(80, 19);
            this.txtVersion.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 41);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 70);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please input version of nodejs";
            // 
            // prbDownload
            // 
            this.prbDownload.Location = new System.Drawing.Point(3, 25);
            this.prbDownload.Name = "prbDownload";
            this.prbDownload.Size = new System.Drawing.Size(339, 23);
            this.prbDownload.TabIndex = 7;
            // 
            // pnlDownloadStatus
            // 
            this.pnlDownloadStatus.Controls.Add(this.lblPrecentage);
            this.pnlDownloadStatus.Controls.Add(this.label2);
            this.pnlDownloadStatus.Controls.Add(this.prbDownload);
            this.pnlDownloadStatus.Location = new System.Drawing.Point(12, 236);
            this.pnlDownloadStatus.Name = "pnlDownloadStatus";
            this.pnlDownloadStatus.Size = new System.Drawing.Size(345, 55);
            this.pnlDownloadStatus.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "current download precentage is ";
            // 
            // lblPrecentage
            // 
            this.lblPrecentage.AutoSize = true;
            this.lblPrecentage.Location = new System.Drawing.Point(175, 8);
            this.lblPrecentage.Name = "lblPrecentage";
            this.lblPrecentage.Size = new System.Drawing.Size(0, 12);
            this.lblPrecentage.TabIndex = 9;
            // 
            // nodeManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 296);
            this.Controls.Add(this.pnlDownloadStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lstNodeVersions);
            this.Controls.Add(this.btnGet);
            this.Name = "nodeManagerFrm";
            this.Text = "Form1";
            this.pnlDownloadStatus.ResumeLayout(false);
            this.pnlDownloadStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ListBox lstNodeVersions;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prbDownload;
        private System.Windows.Forms.Panel pnlDownloadStatus;
        private System.Windows.Forms.Label lblPrecentage;
        private System.Windows.Forms.Label label2;
    }
}

