namespace gbk2utf8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSourceFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.btnSelectTargetFolder = new System.Windows.Forms.Button();
            this.tbTargetFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbSourceFolderPath
            // 
            resources.ApplyResources(this.tbSourceFolderPath, "tbSourceFolderPath");
            this.tbSourceFolderPath.Name = "tbSourceFolderPath";
            // 
            // btnSelectSourceFolder
            // 
            resources.ApplyResources(this.btnSelectSourceFolder, "btnSelectSourceFolder");
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click_1);
            // 
            // btnSelectTargetFolder
            // 
            resources.ApplyResources(this.btnSelectTargetFolder, "btnSelectTargetFolder");
            this.btnSelectTargetFolder.Name = "btnSelectTargetFolder";
            this.btnSelectTargetFolder.UseVisualStyleBackColor = true;
            this.btnSelectTargetFolder.Click += new System.EventHandler(this.btnSelectTargetFolder_Click_1);
            // 
            // tbTargetFolderPath
            // 
            resources.ApplyResources(this.tbTargetFolderPath, "tbTargetFolderPath");
            this.tbTargetFolderPath.Name = "tbTargetFolderPath";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectTargetFolder);
            this.Controls.Add(this.tbTargetFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Controls.Add(this.tbSourceFolderPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSourceFolderPath;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.Button btnSelectTargetFolder;
        private System.Windows.Forms.TextBox tbTargetFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

