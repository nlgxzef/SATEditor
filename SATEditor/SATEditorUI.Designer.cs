namespace SATEditor
{
    partial class SATEditorUI
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SATEditorUI));
            this.SATMenu = new System.Windows.Forms.MenuStrip();
            this.SATMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SATMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SATMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.fNGExtractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımportFNGToGlobalAbunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportFNGToGlobalAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreOriginalGlobalAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SATMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSATEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SATEditorList = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Red = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Green = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Blue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alpha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FNGExtractorOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GameFolderSelectDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SATMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SATMenu
            // 
            this.SATMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SATMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SATMenuFile,
            this.SATMenuEdit,
            this.SATMenuTools,
            this.SATMenuHelp});
            resources.ApplyResources(this.SATMenu, "SATMenu");
            this.SATMenu.Name = "SATMenu";
            this.SATMenu.TabStop = true;
            // 
            // SATMenuFile
            // 
            this.SATMenuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SATMenuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SATMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.ImportToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.SATMenuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SATMenuFile.Name = "SATMenuFile";
            resources.ApplyResources(this.SATMenuFile, "SATMenuFile");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exportToolStripMenuItem
            // 
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // ImportToolStripMenuItem
            // 
            resources.ApplyResources(this.ImportToolStripMenuItem, "ImportToolStripMenuItem");
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SATMenuEdit
            // 
            this.SATMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.toolStripSeparator4,
            this.optionsToolStripMenuItem});
            this.SATMenuEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SATMenuEdit.Name = "SATMenuEdit";
            resources.ApplyResources(this.SATMenuEdit, "SATMenuEdit");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // SATMenuTools
            // 
            this.SATMenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fNGExtractorToolStripMenuItem,
            this.ımportFNGToGlobalAbunToolStripMenuItem});
            this.SATMenuTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SATMenuTools.Name = "SATMenuTools";
            resources.ApplyResources(this.SATMenuTools, "SATMenuTools");
            // 
            // fNGExtractorToolStripMenuItem
            // 
            this.fNGExtractorToolStripMenuItem.Name = "fNGExtractorToolStripMenuItem";
            resources.ApplyResources(this.fNGExtractorToolStripMenuItem, "fNGExtractorToolStripMenuItem");
            this.fNGExtractorToolStripMenuItem.Click += new System.EventHandler(this.fNGExtractorToolStripMenuItem_Click);
            // 
            // ımportFNGToGlobalAbunToolStripMenuItem
            // 
            this.ımportFNGToGlobalAbunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportFNGToGlobalAToolStripMenuItem,
            this.RestoreOriginalGlobalAToolStripMenuItem});
            this.ımportFNGToGlobalAbunToolStripMenuItem.Name = "ımportFNGToGlobalAbunToolStripMenuItem";
            resources.ApplyResources(this.ımportFNGToGlobalAbunToolStripMenuItem, "ımportFNGToGlobalAbunToolStripMenuItem");
            // 
            // ImportFNGToGlobalAToolStripMenuItem
            // 
            this.ImportFNGToGlobalAToolStripMenuItem.Name = "ImportFNGToGlobalAToolStripMenuItem";
            resources.ApplyResources(this.ImportFNGToGlobalAToolStripMenuItem, "ImportFNGToGlobalAToolStripMenuItem");
            this.ImportFNGToGlobalAToolStripMenuItem.Click += new System.EventHandler(this.ImportFNGToGlobalAToolStripMenuItem_Click);
            // 
            // RestoreOriginalGlobalAToolStripMenuItem
            // 
            this.RestoreOriginalGlobalAToolStripMenuItem.Name = "RestoreOriginalGlobalAToolStripMenuItem";
            resources.ApplyResources(this.RestoreOriginalGlobalAToolStripMenuItem, "RestoreOriginalGlobalAToolStripMenuItem");
            this.RestoreOriginalGlobalAToolStripMenuItem.Click += new System.EventHandler(this.RestoreOriginalGlobalAToolStripMenuItem_Click);
            // 
            // SATMenuHelp
            // 
            this.SATMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSATEditorToolStripMenuItem});
            this.SATMenuHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SATMenuHelp.Name = "SATMenuHelp";
            resources.ApplyResources(this.SATMenuHelp, "SATMenuHelp");
            // 
            // aboutSATEditorToolStripMenuItem
            // 
            this.aboutSATEditorToolStripMenuItem.Name = "aboutSATEditorToolStripMenuItem";
            resources.ApplyResources(this.aboutSATEditorToolStripMenuItem, "aboutSATEditorToolStripMenuItem");
            this.aboutSATEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutSATEditorToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            resources.ApplyResources(this.OpenFileDialog, "OpenFileDialog");
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SATEditorList
            // 
            this.SATEditorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Offset,
            this.Red,
            this.Green,
            this.Blue,
            this.Alpha,
            this.Comments});
            this.SATEditorList.FullRowSelect = true;
            resources.ApplyResources(this.SATEditorList, "SATEditorList");
            this.SATEditorList.MultiSelect = false;
            this.SATEditorList.Name = "SATEditorList";
            this.SATEditorList.UseCompatibleStateImageBehavior = false;
            this.SATEditorList.View = System.Windows.Forms.View.Details;
            this.SATEditorList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SATEditorList_MouseDoubleClick);
            // 
            // Index
            // 
            this.Index.Tag = "";
            resources.ApplyResources(this.Index, "Index");
            // 
            // Offset
            // 
            resources.ApplyResources(this.Offset, "Offset");
            // 
            // Red
            // 
            this.Red.Tag = "";
            resources.ApplyResources(this.Red, "Red");
            // 
            // Green
            // 
            this.Green.Tag = "";
            resources.ApplyResources(this.Green, "Green");
            // 
            // Blue
            // 
            this.Blue.Tag = "";
            resources.ApplyResources(this.Blue, "Blue");
            // 
            // Alpha
            // 
            this.Alpha.Tag = "";
            resources.ApplyResources(this.Alpha, "Alpha");
            // 
            // Comments
            // 
            resources.ApplyResources(this.Comments, "Comments");
            // 
            // ExportFileDialog
            // 
            this.ExportFileDialog.DefaultExt = "txt";
            resources.ApplyResources(this.ExportFileDialog, "ExportFileDialog");
            // 
            // ImportFileDialog
            // 
            resources.ApplyResources(this.ImportFileDialog, "ImportFileDialog");
            // 
            // SaveAsFileDialog
            // 
            this.SaveAsFileDialog.DefaultExt = "fng";
            resources.ApplyResources(this.SaveAsFileDialog, "SaveAsFileDialog");
            // 
            // FNGExtractorOpenFileDialog
            // 
            resources.ApplyResources(this.FNGExtractorOpenFileDialog, "FNGExtractorOpenFileDialog");
            this.FNGExtractorOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // GameFolderSelectDialog
            // 
            resources.ApplyResources(this.GameFolderSelectDialog, "GameFolderSelectDialog");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // SATEditorUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.SATEditorList);
            this.Controls.Add(this.SATMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.SATMenu;
            this.MaximizeBox = false;
            this.Name = "SATEditorUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SATEditorUI_FormClosing);
            this.Load += new System.EventHandler(this.SATEditorUI_Load);
            this.SATMenu.ResumeLayout(false);
            this.SATMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SATMenu;
        private System.Windows.Forms.ToolStripMenuItem SATMenuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SATMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutSATEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ListView SATEditorList;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Red;
        private System.Windows.Forms.ColumnHeader Green;
        private System.Windows.Forms.ColumnHeader Blue;
        private System.Windows.Forms.ColumnHeader Alpha;
        private System.Windows.Forms.ColumnHeader Comments;
        private System.Windows.Forms.SaveFileDialog ExportFileDialog;
        private System.Windows.Forms.ColumnHeader Offset;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveAsFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SATMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SATMenuTools;
        private System.Windows.Forms.ToolStripMenuItem fNGExtractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımportFNGToGlobalAbunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog FNGExtractorOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog GameFolderSelectDialog;
        private System.Windows.Forms.ToolStripMenuItem ImportFNGToGlobalAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestoreOriginalGlobalAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

