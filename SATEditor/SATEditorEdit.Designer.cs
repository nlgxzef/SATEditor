namespace SATEditor
{
    partial class SATEditorEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SATEditorEdit));
            this.GreenNew = new System.Windows.Forms.Label();
            this.BlueNew = new System.Windows.Forms.Label();
            this.AlphaNew = new System.Windows.Forms.Label();
            this.NewBoxRed = new System.Windows.Forms.NumericUpDown();
            this.NewBoxGreen = new System.Windows.Forms.NumericUpDown();
            this.NewBoxBlue = new System.Windows.Forms.NumericUpDown();
            this.NewBoxAlpha = new System.Windows.Forms.NumericUpDown();
            this.NewBarRed = new System.Windows.Forms.TrackBar();
            this.NewBarGreen = new System.Windows.Forms.TrackBar();
            this.NewBarBlue = new System.Windows.Forms.TrackBar();
            this.NewBarAlpha = new System.Windows.Forms.TrackBar();
            this.WindowsColorDialog = new System.Windows.Forms.ColorDialog();
            this.EditorButtonWindows = new System.Windows.Forms.Button();
            this.EditorButtonOK = new System.Windows.Forms.Button();
            this.EditorButtonCancel = new System.Windows.Forms.Button();
            this.RedNew = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.Label();
            this.CurrColourGroup = new System.Windows.Forms.GroupBox();
            this.CurrPreview = new System.Windows.Forms.PictureBox();
            this.EditBoxOffset = new System.Windows.Forms.TextBox();
            this.EditBoxGreen = new System.Windows.Forms.TextBox();
            this.EditBoxAlpha = new System.Windows.Forms.TextBox();
            this.EditBoxBlue = new System.Windows.Forms.TextBox();
            this.EditBoxRed = new System.Windows.Forms.TextBox();
            this.EditBoxID = new System.Windows.Forms.TextBox();
            this.BlueCurr = new System.Windows.Forms.Label();
            this.RedCurr = new System.Windows.Forms.Label();
            this.GreenCurr = new System.Windows.Forms.Label();
            this.AlphaCurr = new System.Windows.Forms.Label();
            this.NewColourGroup = new System.Windows.Forms.GroupBox();
            this.NewPreview = new System.Windows.Forms.PictureBox();
            this.CheckMultiEdit = new System.Windows.Forms.CheckBox();
            this.CheckKeepAlpha = new System.Windows.Forms.CheckBox();
            this.NewBoxComments = new System.Windows.Forms.TextBox();
            this.CommentsCurr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarAlpha)).BeginInit();
            this.CurrColourGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrPreview)).BeginInit();
            this.NewColourGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // GreenNew
            // 
            this.GreenNew.AutoSize = true;
            this.GreenNew.Location = new System.Drawing.Point(127, 29);
            this.GreenNew.Name = "GreenNew";
            this.GreenNew.Size = new System.Drawing.Size(36, 13);
            this.GreenNew.TabIndex = 2;
            this.GreenNew.Text = "Green";
            // 
            // BlueNew
            // 
            this.BlueNew.AutoSize = true;
            this.BlueNew.Location = new System.Drawing.Point(227, 29);
            this.BlueNew.Name = "BlueNew";
            this.BlueNew.Size = new System.Drawing.Size(28, 13);
            this.BlueNew.TabIndex = 2;
            this.BlueNew.Text = "Blue";
            // 
            // AlphaNew
            // 
            this.AlphaNew.AutoSize = true;
            this.AlphaNew.Location = new System.Drawing.Point(326, 29);
            this.AlphaNew.Name = "AlphaNew";
            this.AlphaNew.Size = new System.Drawing.Size(34, 13);
            this.AlphaNew.TabIndex = 2;
            this.AlphaNew.Text = "Alpha";
            // 
            // NewBoxRed
            // 
            this.NewBoxRed.Location = new System.Drawing.Point(33, 52);
            this.NewBoxRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NewBoxRed.Name = "NewBoxRed";
            this.NewBoxRed.Size = new System.Drawing.Size(44, 20);
            this.NewBoxRed.TabIndex = 3;
            this.NewBoxRed.ValueChanged += new System.EventHandler(this.NewBoxRed_ValueChanged);
            // 
            // NewBoxGreen
            // 
            this.NewBoxGreen.Location = new System.Drawing.Point(130, 53);
            this.NewBoxGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NewBoxGreen.Name = "NewBoxGreen";
            this.NewBoxGreen.Size = new System.Drawing.Size(44, 20);
            this.NewBoxGreen.TabIndex = 3;
            this.NewBoxGreen.ValueChanged += new System.EventHandler(this.NewBoxGreen_ValueChanged);
            // 
            // NewBoxBlue
            // 
            this.NewBoxBlue.Location = new System.Drawing.Point(230, 52);
            this.NewBoxBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NewBoxBlue.Name = "NewBoxBlue";
            this.NewBoxBlue.Size = new System.Drawing.Size(44, 20);
            this.NewBoxBlue.TabIndex = 3;
            this.NewBoxBlue.ValueChanged += new System.EventHandler(this.NewBoxBlue_ValueChanged);
            // 
            // NewBoxAlpha
            // 
            this.NewBoxAlpha.Location = new System.Drawing.Point(329, 52);
            this.NewBoxAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NewBoxAlpha.Name = "NewBoxAlpha";
            this.NewBoxAlpha.Size = new System.Drawing.Size(44, 20);
            this.NewBoxAlpha.TabIndex = 3;
            this.NewBoxAlpha.ValueChanged += new System.EventHandler(this.NewBoxAlpha_ValueChanged);
            // 
            // NewBarRed
            // 
            this.NewBarRed.Location = new System.Drawing.Point(33, 78);
            this.NewBarRed.Maximum = 255;
            this.NewBarRed.Name = "NewBarRed";
            this.NewBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.NewBarRed.Size = new System.Drawing.Size(45, 179);
            this.NewBarRed.TabIndex = 4;
            this.NewBarRed.Scroll += new System.EventHandler(this.NewBarRed_ValueChanged);
            // 
            // NewBarGreen
            // 
            this.NewBarGreen.Location = new System.Drawing.Point(130, 78);
            this.NewBarGreen.Maximum = 255;
            this.NewBarGreen.Name = "NewBarGreen";
            this.NewBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.NewBarGreen.Size = new System.Drawing.Size(45, 179);
            this.NewBarGreen.TabIndex = 4;
            this.NewBarGreen.Scroll += new System.EventHandler(this.NewBarGreen_ValueChanged);
            // 
            // NewBarBlue
            // 
            this.NewBarBlue.Location = new System.Drawing.Point(230, 78);
            this.NewBarBlue.Maximum = 255;
            this.NewBarBlue.Name = "NewBarBlue";
            this.NewBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.NewBarBlue.Size = new System.Drawing.Size(45, 179);
            this.NewBarBlue.TabIndex = 4;
            this.NewBarBlue.Scroll += new System.EventHandler(this.NewBarBlue_ValueChanged);
            // 
            // NewBarAlpha
            // 
            this.NewBarAlpha.Location = new System.Drawing.Point(328, 78);
            this.NewBarAlpha.Maximum = 255;
            this.NewBarAlpha.Name = "NewBarAlpha";
            this.NewBarAlpha.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.NewBarAlpha.Size = new System.Drawing.Size(45, 179);
            this.NewBarAlpha.TabIndex = 4;
            this.NewBarAlpha.Scroll += new System.EventHandler(this.NewBarAlpha_ValueChanged);
            // 
            // EditorButtonWindows
            // 
            this.EditorButtonWindows.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditorButtonWindows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorButtonWindows.Location = new System.Drawing.Point(33, 334);
            this.EditorButtonWindows.Name = "EditorButtonWindows";
            this.EditorButtonWindows.Size = new System.Drawing.Size(340, 23);
            this.EditorButtonWindows.TabIndex = 5;
            this.EditorButtonWindows.Text = "Use Windows Color Chooser...";
            this.EditorButtonWindows.UseVisualStyleBackColor = false;
            this.EditorButtonWindows.Click += new System.EventHandler(this.EditorButtonWindows_Click);
            // 
            // EditorButtonOK
            // 
            this.EditorButtonOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditorButtonOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorButtonOK.Location = new System.Drawing.Point(429, 438);
            this.EditorButtonOK.Name = "EditorButtonOK";
            this.EditorButtonOK.Size = new System.Drawing.Size(123, 23);
            this.EditorButtonOK.TabIndex = 5;
            this.EditorButtonOK.Text = "OK";
            this.EditorButtonOK.UseVisualStyleBackColor = false;
            this.EditorButtonOK.Click += new System.EventHandler(this.EditorButtonOK_Click);
            // 
            // EditorButtonCancel
            // 
            this.EditorButtonCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditorButtonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorButtonCancel.Location = new System.Drawing.Point(552, 438);
            this.EditorButtonCancel.Name = "EditorButtonCancel";
            this.EditorButtonCancel.Size = new System.Drawing.Size(123, 23);
            this.EditorButtonCancel.TabIndex = 5;
            this.EditorButtonCancel.Text = "Cancel";
            this.EditorButtonCancel.UseVisualStyleBackColor = false;
            this.EditorButtonCancel.Click += new System.EventHandler(this.EditorButtonCancel_Click);
            // 
            // RedNew
            // 
            this.RedNew.AutoSize = true;
            this.RedNew.Location = new System.Drawing.Point(30, 29);
            this.RedNew.Name = "RedNew";
            this.RedNew.Size = new System.Drawing.Size(27, 13);
            this.RedNew.TabIndex = 2;
            this.RedNew.Text = "Red";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(32, 42);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // Offset
            // 
            this.Offset.AutoSize = true;
            this.Offset.Location = new System.Drawing.Point(33, 75);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(35, 13);
            this.Offset.TabIndex = 2;
            this.Offset.Text = "Offset";
            // 
            // CurrColourGroup
            // 
            this.CurrColourGroup.Controls.Add(this.CurrPreview);
            this.CurrColourGroup.Controls.Add(this.EditBoxOffset);
            this.CurrColourGroup.Controls.Add(this.EditBoxGreen);
            this.CurrColourGroup.Controls.Add(this.EditBoxAlpha);
            this.CurrColourGroup.Controls.Add(this.EditBoxBlue);
            this.CurrColourGroup.Controls.Add(this.EditBoxRed);
            this.CurrColourGroup.Controls.Add(this.EditBoxID);
            this.CurrColourGroup.Controls.Add(this.ID);
            this.CurrColourGroup.Controls.Add(this.Offset);
            this.CurrColourGroup.Controls.Add(this.BlueCurr);
            this.CurrColourGroup.Controls.Add(this.RedCurr);
            this.CurrColourGroup.Controls.Add(this.GreenCurr);
            this.CurrColourGroup.Controls.Add(this.AlphaCurr);
            this.CurrColourGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CurrColourGroup.Location = new System.Drawing.Point(15, 12);
            this.CurrColourGroup.Name = "CurrColourGroup";
            this.CurrColourGroup.Size = new System.Drawing.Size(246, 369);
            this.CurrColourGroup.TabIndex = 6;
            this.CurrColourGroup.TabStop = false;
            this.CurrColourGroup.Text = "Current Color";
            // 
            // CurrPreview
            // 
            this.CurrPreview.BackColor = System.Drawing.Color.Red;
            this.CurrPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurrPreview.ErrorImage = null;
            this.CurrPreview.InitialImage = null;
            this.CurrPreview.Location = new System.Drawing.Point(69, 269);
            this.CurrPreview.Name = "CurrPreview";
            this.CurrPreview.Size = new System.Drawing.Size(100, 50);
            this.CurrPreview.TabIndex = 4;
            this.CurrPreview.TabStop = false;
            // 
            // EditBoxOffset
            // 
            this.EditBoxOffset.Enabled = false;
            this.EditBoxOffset.Location = new System.Drawing.Point(86, 72);
            this.EditBoxOffset.Name = "EditBoxOffset";
            this.EditBoxOffset.ReadOnly = true;
            this.EditBoxOffset.Size = new System.Drawing.Size(100, 20);
            this.EditBoxOffset.TabIndex = 3;
            this.EditBoxOffset.Text = "0";
            // 
            // EditBoxGreen
            // 
            this.EditBoxGreen.Enabled = false;
            this.EditBoxGreen.Location = new System.Drawing.Point(86, 155);
            this.EditBoxGreen.Name = "EditBoxGreen";
            this.EditBoxGreen.ReadOnly = true;
            this.EditBoxGreen.Size = new System.Drawing.Size(100, 20);
            this.EditBoxGreen.TabIndex = 3;
            this.EditBoxGreen.Text = "0";
            // 
            // EditBoxAlpha
            // 
            this.EditBoxAlpha.Enabled = false;
            this.EditBoxAlpha.Location = new System.Drawing.Point(86, 221);
            this.EditBoxAlpha.Name = "EditBoxAlpha";
            this.EditBoxAlpha.ReadOnly = true;
            this.EditBoxAlpha.Size = new System.Drawing.Size(100, 20);
            this.EditBoxAlpha.TabIndex = 3;
            this.EditBoxAlpha.Text = "0";
            // 
            // EditBoxBlue
            // 
            this.EditBoxBlue.Enabled = false;
            this.EditBoxBlue.Location = new System.Drawing.Point(86, 188);
            this.EditBoxBlue.Name = "EditBoxBlue";
            this.EditBoxBlue.ReadOnly = true;
            this.EditBoxBlue.Size = new System.Drawing.Size(100, 20);
            this.EditBoxBlue.TabIndex = 3;
            this.EditBoxBlue.Text = "0";
            // 
            // EditBoxRed
            // 
            this.EditBoxRed.Enabled = false;
            this.EditBoxRed.Location = new System.Drawing.Point(86, 122);
            this.EditBoxRed.Name = "EditBoxRed";
            this.EditBoxRed.ReadOnly = true;
            this.EditBoxRed.Size = new System.Drawing.Size(100, 20);
            this.EditBoxRed.TabIndex = 3;
            this.EditBoxRed.Text = "0";
            // 
            // EditBoxID
            // 
            this.EditBoxID.Enabled = false;
            this.EditBoxID.Location = new System.Drawing.Point(86, 39);
            this.EditBoxID.Name = "EditBoxID";
            this.EditBoxID.ReadOnly = true;
            this.EditBoxID.Size = new System.Drawing.Size(100, 20);
            this.EditBoxID.TabIndex = 3;
            this.EditBoxID.Text = "0";
            // 
            // BlueCurr
            // 
            this.BlueCurr.AutoSize = true;
            this.BlueCurr.Location = new System.Drawing.Point(32, 191);
            this.BlueCurr.Name = "BlueCurr";
            this.BlueCurr.Size = new System.Drawing.Size(28, 13);
            this.BlueCurr.TabIndex = 2;
            this.BlueCurr.Text = "Blue";
            // 
            // RedCurr
            // 
            this.RedCurr.AutoSize = true;
            this.RedCurr.Location = new System.Drawing.Point(32, 125);
            this.RedCurr.Name = "RedCurr";
            this.RedCurr.Size = new System.Drawing.Size(27, 13);
            this.RedCurr.TabIndex = 2;
            this.RedCurr.Text = "Red";
            // 
            // GreenCurr
            // 
            this.GreenCurr.AutoSize = true;
            this.GreenCurr.Location = new System.Drawing.Point(32, 158);
            this.GreenCurr.Name = "GreenCurr";
            this.GreenCurr.Size = new System.Drawing.Size(36, 13);
            this.GreenCurr.TabIndex = 2;
            this.GreenCurr.Text = "Green";
            // 
            // AlphaCurr
            // 
            this.AlphaCurr.AutoSize = true;
            this.AlphaCurr.Location = new System.Drawing.Point(32, 224);
            this.AlphaCurr.Name = "AlphaCurr";
            this.AlphaCurr.Size = new System.Drawing.Size(34, 13);
            this.AlphaCurr.TabIndex = 2;
            this.AlphaCurr.Text = "Alpha";
            // 
            // NewColourGroup
            // 
            this.NewColourGroup.Controls.Add(this.NewPreview);
            this.NewColourGroup.Controls.Add(this.NewBarRed);
            this.NewColourGroup.Controls.Add(this.BlueNew);
            this.NewColourGroup.Controls.Add(this.GreenNew);
            this.NewColourGroup.Controls.Add(this.EditorButtonWindows);
            this.NewColourGroup.Controls.Add(this.RedNew);
            this.NewColourGroup.Controls.Add(this.NewBarAlpha);
            this.NewColourGroup.Controls.Add(this.AlphaNew);
            this.NewColourGroup.Controls.Add(this.NewBarBlue);
            this.NewColourGroup.Controls.Add(this.NewBoxRed);
            this.NewColourGroup.Controls.Add(this.NewBarGreen);
            this.NewColourGroup.Controls.Add(this.NewBoxGreen);
            this.NewColourGroup.Controls.Add(this.NewBoxBlue);
            this.NewColourGroup.Controls.Add(this.NewBoxAlpha);
            this.NewColourGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewColourGroup.Location = new System.Drawing.Point(275, 12);
            this.NewColourGroup.Name = "NewColourGroup";
            this.NewColourGroup.Size = new System.Drawing.Size(400, 369);
            this.NewColourGroup.TabIndex = 6;
            this.NewColourGroup.TabStop = false;
            this.NewColourGroup.Text = "New Color";
            // 
            // NewPreview
            // 
            this.NewPreview.BackColor = System.Drawing.Color.Red;
            this.NewPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewPreview.ErrorImage = null;
            this.NewPreview.InitialImage = null;
            this.NewPreview.Location = new System.Drawing.Point(144, 269);
            this.NewPreview.Name = "NewPreview";
            this.NewPreview.Size = new System.Drawing.Size(100, 50);
            this.NewPreview.TabIndex = 4;
            this.NewPreview.TabStop = false;
            // 
            // CheckMultiEdit
            // 
            this.CheckMultiEdit.AutoSize = true;
            this.CheckMultiEdit.Location = new System.Drawing.Point(15, 442);
            this.CheckMultiEdit.Name = "CheckMultiEdit";
            this.CheckMultiEdit.Size = new System.Drawing.Size(155, 17);
            this.CheckMultiEdit.TabIndex = 7;
            this.CheckMultiEdit.Text = "Replace All With This Color";
            this.CheckMultiEdit.UseVisualStyleBackColor = true;
            this.CheckMultiEdit.CheckedChanged += new System.EventHandler(this.CheckMultiEdit_CheckedChanged);
            // 
            // CheckKeepAlpha
            // 
            this.CheckKeepAlpha.AutoSize = true;
            this.CheckKeepAlpha.Enabled = false;
            this.CheckKeepAlpha.Location = new System.Drawing.Point(196, 442);
            this.CheckKeepAlpha.Name = "CheckKeepAlpha";
            this.CheckKeepAlpha.Size = new System.Drawing.Size(119, 17);
            this.CheckKeepAlpha.TabIndex = 8;
            this.CheckKeepAlpha.Text = "Keep Original Alpha";
            this.CheckKeepAlpha.UseVisualStyleBackColor = true;
            this.CheckKeepAlpha.CheckedChanged += new System.EventHandler(this.CheckKeepAlpha_CheckedChanged);
            this.CheckKeepAlpha.EnabledChanged += new System.EventHandler(this.CheckKeepAlpha_EnabledChanged);
            // 
            // NewBoxComments
            // 
            this.NewBoxComments.Location = new System.Drawing.Point(101, 401);
            this.NewBoxComments.MaxLength = 127;
            this.NewBoxComments.Name = "NewBoxComments";
            this.NewBoxComments.Size = new System.Drawing.Size(547, 20);
            this.NewBoxComments.TabIndex = 3;
            // 
            // CommentsCurr
            // 
            this.CommentsCurr.AutoSize = true;
            this.CommentsCurr.Location = new System.Drawing.Point(31, 404);
            this.CommentsCurr.Name = "CommentsCurr";
            this.CommentsCurr.Size = new System.Drawing.Size(56, 13);
            this.CommentsCurr.TabIndex = 2;
            this.CommentsCurr.Text = "Comments";
            // 
            // SATEditorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(687, 472);
            this.Controls.Add(this.CheckKeepAlpha);
            this.Controls.Add(this.CheckMultiEdit);
            this.Controls.Add(this.NewColourGroup);
            this.Controls.Add(this.NewBoxComments);
            this.Controls.Add(this.CurrColourGroup);
            this.Controls.Add(this.EditorButtonCancel);
            this.Controls.Add(this.EditorButtonOK);
            this.Controls.Add(this.CommentsCurr);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SATEditorEdit";
            this.Text = "SATEditor";
            this.Load += new System.EventHandler(this.SATEditorEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBoxAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewBarAlpha)).EndInit();
            this.CurrColourGroup.ResumeLayout(false);
            this.CurrColourGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrPreview)).EndInit();
            this.NewColourGroup.ResumeLayout(false);
            this.NewColourGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GreenNew;
        private System.Windows.Forms.Label BlueNew;
        private System.Windows.Forms.Label AlphaNew;
        private System.Windows.Forms.NumericUpDown NewBoxRed;
        private System.Windows.Forms.NumericUpDown NewBoxGreen;
        private System.Windows.Forms.NumericUpDown NewBoxBlue;
        private System.Windows.Forms.NumericUpDown NewBoxAlpha;
        private System.Windows.Forms.TrackBar NewBarRed;
        private System.Windows.Forms.TrackBar NewBarGreen;
        private System.Windows.Forms.TrackBar NewBarBlue;
        private System.Windows.Forms.TrackBar NewBarAlpha;
        private System.Windows.Forms.ColorDialog WindowsColorDialog;
        private System.Windows.Forms.Button EditorButtonWindows;
        private System.Windows.Forms.Button EditorButtonOK;
        private System.Windows.Forms.Button EditorButtonCancel;
        private System.Windows.Forms.Label RedNew;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Offset;
        private System.Windows.Forms.GroupBox CurrColourGroup;
        private System.Windows.Forms.TextBox EditBoxOffset;
        private System.Windows.Forms.TextBox EditBoxGreen;
        private System.Windows.Forms.TextBox EditBoxAlpha;
        private System.Windows.Forms.TextBox EditBoxBlue;
        private System.Windows.Forms.TextBox EditBoxRed;
        private System.Windows.Forms.TextBox EditBoxID;
        private System.Windows.Forms.Label BlueCurr;
        private System.Windows.Forms.Label RedCurr;
        private System.Windows.Forms.Label GreenCurr;
        private System.Windows.Forms.Label AlphaCurr;
        private System.Windows.Forms.GroupBox NewColourGroup;
        private System.Windows.Forms.PictureBox CurrPreview;
        private System.Windows.Forms.PictureBox NewPreview;
        private System.Windows.Forms.CheckBox CheckMultiEdit;
        private System.Windows.Forms.CheckBox CheckKeepAlpha;
        private System.Windows.Forms.TextBox NewBoxComments;
        private System.Windows.Forms.Label CommentsCurr;
    }
}