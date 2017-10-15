namespace SATEditor
{
    partial class SATEditorAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SATEditorAbout));
            this.SATEditorAboutText = new System.Windows.Forms.Label();
            this.SADEditorAboutButton = new System.Windows.Forms.Button();
            this.SATEditorAboutVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SATEditorAboutText
            // 
            this.SATEditorAboutText.Location = new System.Drawing.Point(12, 65);
            this.SATEditorAboutText.Name = "SATEditorAboutText";
            this.SATEditorAboutText.Size = new System.Drawing.Size(462, 169);
            this.SATEditorAboutText.TabIndex = 0;
            this.SATEditorAboutText.Text = resources.GetString("SATEditorAboutText.Text");
            this.SATEditorAboutText.UseMnemonic = false;
            // 
            // SADEditorAboutButton
            // 
            this.SADEditorAboutButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SADEditorAboutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SADEditorAboutButton.Location = new System.Drawing.Point(399, 237);
            this.SADEditorAboutButton.Name = "SADEditorAboutButton";
            this.SADEditorAboutButton.Size = new System.Drawing.Size(75, 23);
            this.SADEditorAboutButton.TabIndex = 1;
            this.SADEditorAboutButton.Text = "OK";
            this.SADEditorAboutButton.UseVisualStyleBackColor = false;
            this.SADEditorAboutButton.Click += new System.EventHandler(this.SADEditorAboutButton_Click);
            // 
            // SATEditorAboutVersion
            // 
            this.SATEditorAboutVersion.Location = new System.Drawing.Point(12, 21);
            this.SATEditorAboutVersion.Name = "SATEditorAboutVersion";
            this.SATEditorAboutVersion.Size = new System.Drawing.Size(462, 19);
            this.SATEditorAboutVersion.TabIndex = 0;
            this.SATEditorAboutVersion.Text = "SATEditor";
            this.SATEditorAboutVersion.UseMnemonic = false;
            // 
            // SATEditorAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(488, 272);
            this.Controls.Add(this.SADEditorAboutButton);
            this.Controls.Add(this.SATEditorAboutVersion);
            this.Controls.Add(this.SATEditorAboutText);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SATEditorAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "About SATEditor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SATEditorAbout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SATEditorAboutText;
        private System.Windows.Forms.Button SADEditorAboutButton;
        private System.Windows.Forms.Label SATEditorAboutVersion;
    }
}