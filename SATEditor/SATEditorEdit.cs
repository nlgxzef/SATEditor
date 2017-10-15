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
    public partial class SATEditorEdit : Form
    {
        public String IDInfo { get; set; }
        public String OffsetInfo { get; set; }
        public String Comments { get; set; }

        public int NewRed { get; set; }
        public int NewGreen { get; set; }
        public int NewBlue { get; set; }
        public int NewAlpha { get; set; }

        public bool isMultiEdit { get; set; }
        public bool isKeepAlpha { get; set; }

        public SATEditorEdit()
        {
            InitializeComponent();
        }

        private void NewBoxRed_ValueChanged(object sender, EventArgs e)
        {
            NewBarRed.Value = (int)NewBoxRed.Value;
            NewPreview.BackColor = Color.FromArgb(NewPreview.BackColor.A, (int)NewBoxRed.Value, NewPreview.BackColor.G, NewPreview.BackColor.B);
        }

        private void NewBarRed_ValueChanged(object sender, EventArgs e)
        {
            NewBoxRed.Value = NewBarRed.Value;
            NewPreview.BackColor = Color.FromArgb(NewPreview.BackColor.A, (int)NewBoxRed.Value, NewPreview.BackColor.G, NewPreview.BackColor.B);
        }

        private void NewBoxGreen_ValueChanged(object sender, EventArgs e)
        {
            NewBarGreen.Value = (int)NewBoxGreen.Value;
            NewPreview.BackColor = Color.FromArgb(NewPreview.BackColor.A, NewPreview.BackColor.R, (int)NewBoxGreen.Value, NewPreview.BackColor.B);
        }

        private void NewBarGreen_ValueChanged(object sender, EventArgs e)
        {
            NewBoxGreen.Value = NewBarGreen.Value;
            NewPreview.BackColor = Color.FromArgb(NewPreview.BackColor.A, NewPreview.BackColor.R, (int)NewBoxGreen.Value, NewPreview.BackColor.B);
        }

        private void NewBoxBlue_ValueChanged(object sender, EventArgs e)
        {
            NewBarBlue.Value = (int)NewBoxBlue.Value;
            NewPreview.BackColor = Color.FromArgb(NewPreview.BackColor.A, NewPreview.BackColor.R, NewPreview.BackColor.G, (int)NewBoxBlue.Value);
        }

        private void NewBarBlue_ValueChanged(object sender, EventArgs e)
        {
            NewBoxBlue.Value = NewBarBlue.Value;
            NewPreview.BackColor = Color.FromArgb(NewPreview.BackColor.A, NewPreview.BackColor.R, NewPreview.BackColor.G, (int)NewBoxBlue.Value);
        }

        private void NewBoxAlpha_ValueChanged(object sender, EventArgs e)
        {
            NewBarAlpha.Value = (int)NewBoxAlpha.Value;
            NewPreview.BackColor = Color.FromArgb((int)NewBoxAlpha.Value, NewPreview.BackColor.R, NewPreview.BackColor.G, NewPreview.BackColor.B);
        }

        private void NewBarAlpha_ValueChanged(object sender, EventArgs e)
        {
            NewBoxAlpha.Value = NewBarAlpha.Value;
            NewPreview.BackColor = Color.FromArgb((int)NewBoxAlpha.Value, NewPreview.BackColor.R, NewPreview.BackColor.G, NewPreview.BackColor.B);
        }

        private void EditorButtonWindows_Click(object sender, EventArgs e)
        {
            if (WindowsColorDialog.ShowDialog() == DialogResult.OK)
            {
                NewBarRed.Value = WindowsColorDialog.Color.R;
                NewBoxRed.Value = WindowsColorDialog.Color.R;

                NewBarGreen.Value = WindowsColorDialog.Color.G;
                NewBoxGreen.Value = WindowsColorDialog.Color.G;

                NewBarBlue.Value = WindowsColorDialog.Color.B;
                NewBoxBlue.Value = WindowsColorDialog.Color.B;

                NewPreview.BackColor = Color.FromArgb(WindowsColorDialog.Color.R, WindowsColorDialog.Color.G, WindowsColorDialog.Color.B);
            }
        }

        private void SATEditorEdit_Load(object sender, EventArgs e)
        {
            EditBoxID.Text = IDInfo;
            EditBoxOffset.Text = OffsetInfo;

            EditBoxRed.Text = NewRed.ToString();
            EditBoxGreen.Text = NewGreen.ToString();
            EditBoxBlue.Text = NewBlue.ToString();
            EditBoxAlpha.Text = NewAlpha.ToString();

            CurrPreview.BackColor = Color.FromArgb(NewAlpha, NewRed, NewGreen, NewBlue);

            NewBarAlpha.Value = CurrPreview.BackColor.A;
            NewBoxAlpha.Value = CurrPreview.BackColor.A;

            NewBarRed.Value = CurrPreview.BackColor.R;
            NewBoxRed.Value = CurrPreview.BackColor.R;

            NewBarGreen.Value = CurrPreview.BackColor.G;
            NewBoxGreen.Value = CurrPreview.BackColor.G;

            NewBarBlue.Value = CurrPreview.BackColor.B;
            NewBoxBlue.Value = CurrPreview.BackColor.B;

            NewPreview.BackColor = CurrPreview.BackColor;

            NewBoxComments.Text = "";

            isMultiEdit = false;
            isKeepAlpha = false;

            this.Text = "SATEditor" + " " + "|" + " " + "Editing Item" + " " + "#" + IDInfo + " " + "in Offset" + " " + OffsetInfo;
            
        }

        private void EditorButtonOK_Click(object sender, EventArgs e)
        {
            this.NewRed = (int)NewBoxRed.Value;
            this.NewGreen = (int)NewBoxGreen.Value;
            this.NewBlue = (int)NewBoxBlue.Value;
            this.NewAlpha = (int)NewBoxAlpha.Value;
            this.Comments = NewBoxComments.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditorButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckMultiEdit_CheckedChanged(object sender, EventArgs e)
        {
            isMultiEdit = CheckMultiEdit.Checked;
            CheckKeepAlpha.Enabled = CheckMultiEdit.Checked;
        }

        private void CheckKeepAlpha_CheckedChanged(object sender, EventArgs e)
        {
            isKeepAlpha = CheckKeepAlpha.Checked;
        }

        private void CheckKeepAlpha_EnabledChanged(object sender, EventArgs e)
        {
            if (CheckKeepAlpha.Checked) CheckKeepAlpha.Checked = false;
            isKeepAlpha = false;
        }
    }
}
