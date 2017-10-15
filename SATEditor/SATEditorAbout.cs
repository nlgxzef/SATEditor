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
    public partial class SATEditorAbout : Form
    {
        public SATEditorAbout()
        {
            InitializeComponent();
        }

        private void SADEditorAboutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SATEditorAbout_Load(object sender, EventArgs e)
        {
            String[] VersionInfo = ProductVersion.Split('.');
            String VersionText = "SATEditor" + " " + "v" + ProductVersion;
            int VersionDelta = Int32.Parse(VersionInfo[3]);

            VersionText += " " + "(" + "Build" + " " + VersionInfo[0] + (Int32.Parse(VersionInfo[1])!=0 ? VersionInfo[1] + "." : "") + ";" + " " + "Rev." + (Int32.Parse(VersionInfo[2]) < 10 ? "0" : "") + VersionInfo[2];

            if (VersionDelta >= 100 && VersionDelta < 200) VersionText += " " + "Milestone";
            else if (VersionDelta >= 200 && VersionDelta < 400) VersionText += " " + "ALPHA";
            else if (VersionDelta >= 400 && VersionDelta < 800) VersionText += " " + "BETA";
            else if (VersionDelta >= 800 && VersionDelta < 1337) VersionText += " " + "Release Candidate";
            else if (VersionDelta >= 1338 && VersionDelta < 2000) VersionText += " " + "Hotfix";
            else if (VersionDelta >= 2000 && VersionDelta < 9999) VersionText += " " + "Post-Release Test";

            VersionText += ")";
            SATEditorAboutVersion.Text = VersionText;
        }
    }
}
