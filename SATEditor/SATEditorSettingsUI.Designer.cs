namespace SATEditor
{
    partial class SATEditorSettingsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SATEditorSettingsUI));
            this.CheckKeepBackupFiles = new System.Windows.Forms.CheckBox();
            this.CheckTemporaryFiles = new System.Windows.Forms.CheckBox();
            this.CheckNoLogging = new System.Windows.Forms.CheckBox();
            this.CheckNoAuto = new System.Windows.Forms.CheckBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckKeepBackupFiles
            // 
            this.CheckKeepBackupFiles.AutoSize = true;
            this.CheckKeepBackupFiles.Location = new System.Drawing.Point(23, 28);
            this.CheckKeepBackupFiles.Name = "CheckKeepBackupFiles";
            this.CheckKeepBackupFiles.Size = new System.Drawing.Size(167, 17);
            this.CheckKeepBackupFiles.TabIndex = 0;
            this.CheckKeepBackupFiles.Text = "Create Backup Before Saving";
            this.CheckKeepBackupFiles.UseVisualStyleBackColor = true;
            this.CheckKeepBackupFiles.CheckedChanged += new System.EventHandler(this.CheckKeepBackupFiles_CheckedChanged);
            // 
            // CheckTemporaryFiles
            // 
            this.CheckTemporaryFiles.AutoSize = true;
            this.CheckTemporaryFiles.Location = new System.Drawing.Point(23, 51);
            this.CheckTemporaryFiles.Name = "CheckTemporaryFiles";
            this.CheckTemporaryFiles.Size = new System.Drawing.Size(128, 17);
            this.CheckTemporaryFiles.TabIndex = 0;
            this.CheckTemporaryFiles.Text = "Keep Temporary Files";
            this.CheckTemporaryFiles.UseVisualStyleBackColor = true;
            this.CheckTemporaryFiles.CheckedChanged += new System.EventHandler(this.CheckTemporaryFiles_CheckedChanged);
            // 
            // CheckNoLogging
            // 
            this.CheckNoLogging.AutoSize = true;
            this.CheckNoLogging.Location = new System.Drawing.Point(23, 74);
            this.CheckNoLogging.Name = "CheckNoLogging";
            this.CheckNoLogging.Size = new System.Drawing.Size(102, 17);
            this.CheckNoLogging.TabIndex = 0;
            this.CheckNoLogging.Text = "Disable Logging";
            this.CheckNoLogging.UseVisualStyleBackColor = true;
            this.CheckNoLogging.CheckedChanged += new System.EventHandler(this.CheckNoLogging_CheckedChanged);
            // 
            // CheckNoAuto
            // 
            this.CheckNoAuto.AutoSize = true;
            this.CheckNoAuto.Location = new System.Drawing.Point(23, 97);
            this.CheckNoAuto.Name = "CheckNoAuto";
            this.CheckNoAuto.Size = new System.Drawing.Size(214, 17);
            this.CheckNoAuto.TabIndex = 0;
            this.CheckNoAuto.Text = "Disable Auto Raw HEX Data Comments";
            this.CheckNoAuto.UseVisualStyleBackColor = true;
            this.CheckNoAuto.CheckedChanged += new System.EventHandler(this.CheckNoAuto_CheckedChanged);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonOK.Location = new System.Drawing.Point(251, 145);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonCancel.Location = new System.Drawing.Point(332, 145);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // SATEditorSettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(424, 187);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.CheckNoAuto);
            this.Controls.Add(this.CheckNoLogging);
            this.Controls.Add(this.CheckTemporaryFiles);
            this.Controls.Add(this.CheckKeepBackupFiles);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SATEditorSettingsUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SATEditor Settings";
            this.Load += new System.EventHandler(this.SATEditorSettingsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckKeepBackupFiles;
        private System.Windows.Forms.CheckBox CheckTemporaryFiles;
        private System.Windows.Forms.CheckBox CheckNoLogging;
        private System.Windows.Forms.CheckBox CheckNoAuto;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
    }
}