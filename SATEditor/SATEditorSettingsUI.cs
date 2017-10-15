using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATEditor
{
    public partial class SATEditorSettingsUI : Form
    {
        public SATEditorSettingsUI()
        {
            InitializeComponent();
        }

        private void SATEditorSettingsUI_Load(object sender, EventArgs e)
        {
            CheckKeepBackupFiles.Checked = Properties.Settings.Default.CreateBackup;
            CheckTemporaryFiles.Checked = Properties.Settings.Default.KeepTemporaryFiles;
            CheckNoLogging.Checked = Properties.Settings.Default.DisableLogs;
            CheckNoAuto.Checked = Properties.Settings.Default.DisableAutoComments;
        }

        private void CheckKeepBackupFiles_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CreateBackup = CheckKeepBackupFiles.Checked;
        }

        private void CheckTemporaryFiles_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.KeepTemporaryFiles = CheckTemporaryFiles.Checked;
        }

        private void CheckNoLogging_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DisableLogs = CheckNoLogging.Checked;
        }

        private void CheckNoAuto_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DisableAutoComments = CheckNoAuto.Checked;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.Close();
        }
    }
}
