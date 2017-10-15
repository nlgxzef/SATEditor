using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATEditor
{
    public partial class SATEditorUI : Form
    {
        public SATEditorUI()
        {
            InitializeComponent();
        }

        String FNGFileName;
        bool FNGChanged, isProgramNewlyStarted;
        bool CreateBackup, KeepTemporaryFiles, DisableLogs, DisableAutoComments;

        public void LoadSettings()
        {
            try
            {
                Properties.Settings.Default.Reload();

                CreateBackup = Properties.Settings.Default.CreateBackup;
                KeepTemporaryFiles = Properties.Settings.Default.KeepTemporaryFiles;
                DisableLogs = Properties.Settings.Default.DisableLogs;
                DisableAutoComments = Properties.Settings.Default.DisableAutoComments;
            }
            catch (Exception)
            {
                CreateBackup = true;
                KeepTemporaryFiles = false;
                DisableLogs = false;
                DisableAutoComments = false;
            }
        }

        public void Log(String LogEntry)
        {
            if (!DisableLogs) try
            {
                FileStream LogStream;
                StreamWriter LogFile;

                if (isProgramNewlyStarted) // Create a new log file
                {
                    LogStream = File.Open("SATEditor.log", FileMode.Create);
                    LogFile = new StreamWriter(LogStream);
                    LogFile.WriteLine("# SATEditor Log File");
                    LogFile.WriteLine("# File created on: " + DateTime.Now.ToString());
                    LogFile.WriteLine("# ------------------------------------------------------------------------------");
                    LogFile.WriteLine("[" + DateTime.Now.ToString() + "]" + " : " + LogEntry);

                    isProgramNewlyStarted = false;
                    LogFile.Close();
                }
                else // Use existing log file
                {
                    LogStream = File.Open("SATEditor.log", FileMode.Append);
                    LogFile = new StreamWriter(LogStream);

                    LogFile.WriteLine("[" + DateTime.Now.ToString() + "]" + " : " + LogEntry);

                    LogFile.Close();
                }
            }
            catch (Exception)
            {
                DisableLogs = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream FNGFileStream;

                try
                {
                    FNGFileStream = File.Open(OpenFileDialog.FileName, FileMode.Open);
                    Log("SATEditor : " + "Selected" + " " + OpenFileDialog.FileName + " " + "to open.");

                    FNGFileName = OpenFileDialog.FileName;

                    SATEditorUI.ActiveForm.Text = "SATEditor" + " " + "|" + " " + FNGFileName;

                    using (BinaryReader FNGFile = new BinaryReader(FNGFileStream))
                    {
                        Log("SATEditor : " + "Reading entries from" + " " + OpenFileDialog.FileName);
                        SATEditorList.Items.Clear();
                        int FNGItemID = 0;
                        while (FNGFile.BaseStream.Position != FNGFile.BaseStream.Length)
                        {
                            byte[] FNGtempSAT = FNGFile.ReadBytes(4);
                            if ((FNGtempSAT[0]=='S' && FNGtempSAT[1]=='A')
                                || (FNGtempSAT[0] == 0xFF && FNGtempSAT[1] == 0xFF && FNGtempSAT[2] == 0xFF && FNGtempSAT[3]==0xFF)) // Check if SA(0x90), SAD, SAT or ıııı
                            {
                                // Read color values
                                int FNGtempPosition = Convert.ToInt32(FNGFile.BaseStream.Position); // Assuming that file size will be less than 2 GB.
                                int FNGtempBlue = FNGFile.ReadInt32();
                                int FNGtempGreen = FNGFile.ReadInt32();
                                int FNGtempRed = FNGFile.ReadInt32();
                                int FNGtempAlpha = FNGFile.ReadInt32();
                                if ((FNGtempBlue >= 0 && FNGtempBlue <= 255)
                                    && (FNGtempGreen >= 0 && FNGtempGreen <= 255)
                                    && (FNGtempRed >= 0 && FNGtempRed <= 255)
                                    && (FNGtempAlpha >= 0 && FNGtempAlpha <= 255))
                                {
                                    // Increase Counter
                                    FNGItemID++;

                                    // Create new list item with color value
                                    var FNGItem = new ListViewItem();
                                    FNGItem.Text = FNGItemID.ToString();
                                    FNGItem.SubItems.Add(FNGtempPosition.ToString("X8"));
                                    FNGItem.SubItems.Add(FNGtempRed.ToString());
                                    FNGItem.SubItems.Add(FNGtempGreen.ToString());
                                    FNGItem.SubItems.Add(FNGtempBlue.ToString());
                                    FNGItem.SubItems.Add(FNGtempAlpha.ToString());
                                    if (!DisableAutoComments) FNGItem.SubItems.Add(FNGtempBlue.ToString("X") + "000000" + " " + FNGtempGreen.ToString("X") + "000000" + " " + FNGtempRed.ToString("X") + "000000" + " " + FNGtempAlpha.ToString("X") + "000000");
                                    else FNGItem.SubItems.Add("");

                                    // Set item color
                                    FNGItem.BackColor = Color.FromArgb(FNGtempAlpha, FNGtempRed, FNGtempGreen, FNGtempBlue);
                                    float Brightness = FNGItem.BackColor.GetBrightness();
                                    // Make text always readable
                                    if (Brightness > 0.5) FNGItem.ForeColor = Color.Black;
                                    else FNGItem.ForeColor = Color.White;

                                    // Add item to list
                                    SATEditorList.Items.Add(FNGItem);

                                }
                            }
                        }

                        Log("SATEditor : " + "Read " + FNGItemID + " entries from " + OpenFileDialog.FileName);

                        // Enable functions after file opened successfully
                        exportToolStripMenuItem.Enabled = true;
                        ImportToolStripMenuItem.Enabled = true;
                        saveAsToolStripMenuItem.Enabled = true;
                        saveToolStripMenuItem.Enabled = true;

                        FNGChanged = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("File could not be opened.", "SATEditor", MessageBoxButtons.OK);
                    Log("SATEditor : File could not be opened." + " " + "Exception: " + ex.ToString());

                    // Disable functions
                    exportToolStripMenuItem.Enabled = false;
                    ImportToolStripMenuItem.Enabled = false;
                    saveAsToolStripMenuItem.Enabled = false;
                    saveToolStripMenuItem.Enabled = false;
                    return;
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutSATEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var About = new SATEditorAbout();
            About.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExportFileDialog.ShowDialog() == DialogResult.OK)
            {
                Log("SATEditor : Starting TXT Exporter...");

                String TXTFileName = ExportFileDialog.FileName.ToString();
                if (TXTFileName != "") try
                {
                    Log("TXT Exporter : Exporting all entries on the screen into " + TXTFileName);
                    using (StreamWriter TXTFile = new StreamWriter(TXTFileName))
                    {
                        TXTFile.WriteLine("#" + " " + "\t" + SATEditorUI.ActiveForm.Text);
                        TXTFile.WriteLine("#");
                        TXTFile.WriteLine("#" + " " + "\t" + "Offset (HEX)" + "\t\t" + "Red" + "\t" + "Blue" + "\t" + "Green" + "\t" + "Alpha" + "\t\t" + "Comments (BGRA HEX as Default)");
                        TXTFile.WriteLine("#" + " " + "---------------------------------------------------------------------------------------------------------");
                        foreach (ListViewItem item in SATEditorList.Items)
                        {
                            TXTFile.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t\t{6}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text);
                        }

                        MessageBox.Show("All values on the screen are exported into" + "\n" + TXTFileName, "SATEditor", MessageBoxButtons.OK);
                        Log("TXT Exporter : All values on the screen are exported into " +  TXTFileName);
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Values could not be exported.", "SATEditor", MessageBoxButtons.OK);
                    Log("TXT Exporter : Values could not be exported." + " " + "Exception: " + ex.ToString());
                }
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImportFileDialog.ShowDialog() == DialogResult.OK) try
            {
                FileStream TXTFileStream = File.Open(ImportFileDialog.FileName, FileMode.Open);
                String TXTLineBuffer;
                int ImportedEntries = 0;
                int IgnoredEntries = 0;
                Log("SATEditor : Starting TXT Importer...");

                using (StreamReader TXTFile = new StreamReader(TXTFileStream))
                {
                    Log("TXT Importer : Importing all entries to the screen from " + ImportFileDialog.FileName);

                    while ((TXTLineBuffer = TXTFile.ReadLine()) != null)
                    {
                        
                        if (!TXTLineBuffer.StartsWith("#")) // If it's not a comment
                        {
                            char[] charsToTrim = {'\t', ' '};
                            String[] Parts = TXTLineBuffer.Split(charsToTrim, StringSplitOptions.RemoveEmptyEntries);

                            if (Parts.Length >= 6) try // string -> int -> string to check errors beforehand
                            {
                                int FNGtempID = int.Parse(Parts[0]);
                                int FNGtempOffset = Convert.ToInt32(Parts[1], 16);
                                int FNGtempRed = int.Parse(Parts[2]);
                                int FNGtempGreen = int.Parse(Parts[3]);
                                int FNGtempBlue = int.Parse(Parts[4]);
                                int FNGtempAlpha = int.Parse(Parts[5]);
                                // Hex values in txt are ignored, we will recreate them below with imported values

                                if ((FNGtempBlue >= 0 && FNGtempBlue <= 255)
                                    && (FNGtempGreen >= 0 && FNGtempGreen <= 255)
                                    && (FNGtempRed >= 0 && FNGtempRed <= 255)
                                    && (FNGtempAlpha >= 0 && FNGtempAlpha <= 255))
                                {
                                    var FNGItem = new ListViewItem(); 
                                    FNGItem.Text = FNGtempID.ToString();
                                    FNGItem.SubItems.Add(FNGtempOffset.ToString("X8")); // offset in hex
                                    FNGItem.SubItems.Add(FNGtempRed.ToString()); // red
                                    FNGItem.SubItems.Add(FNGtempGreen.ToString()); // green
                                    FNGItem.SubItems.Add(FNGtempBlue.ToString()); // blue
                                    FNGItem.SubItems.Add(FNGtempAlpha.ToString()); // alpha
                                    
                                    // Comments
                                    String Comments = "";
                                    for (int i = 6; i < Parts.Length; i++) Comments += Parts[i] + " ";
                                    FNGItem.SubItems.Add(Comments);

                                    // Set item color
                                    FNGItem.BackColor = Color.FromArgb(FNGtempAlpha, FNGtempRed, FNGtempGreen, FNGtempBlue);
                                    float Brightness = FNGItem.BackColor.GetBrightness();
                                    // Make text always readable
                                    if (Brightness > 0.5) FNGItem.ForeColor = Color.Black;
                                    else FNGItem.ForeColor = Color.White;

                                    // Replace imported item with the old one (if offset strings match)
                                    if (SATEditorList.Items[FNGtempID - 1].SubItems[1].Text == Parts[1])
                                    {
                                        SATEditorList.Items.RemoveAt(FNGtempID - 1);
                                        SATEditorList.Items.Insert(FNGtempID - 1, FNGItem);
                                        ImportedEntries++;
                                    }
                                    else IgnoredEntries++;
                                }
                                else IgnoredEntries++;
                            }
                            catch (Exception) // If there is any error, just ingore the line
                            {
                                IgnoredEntries++;
                                continue;
                            }
                        }
                    }
                    String Status = "Imported" + " " + ImportedEntries + " " + "entries.";
                    if (IgnoredEntries>0) Status += "\n" + "Ignored" + " " + IgnoredEntries + " " + "entries due to some formatting errors in selected text file.";

                    if (ImportedEntries > 0) FNGChanged = true;

                    MessageBox.Show(Status, "SATEditor", MessageBoxButtons.OK);
                    Log("TXT Importer: Imported" + " " + ImportedEntries + " " + "entries from" + " " + ImportFileDialog.FileName);
                    Log("TXT Importer: Ignored" + " " + IgnoredEntries + " " + "entries.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Values could not be imported.", "SATEditor", MessageBoxButtons.OK);
                Log("TXT Importer : Values could not be imported." + " " + "Exception:" + ex.ToString());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FNGFileName != "")
            {
                FileStream FNGFileStream;
                BinaryWriter newFNGFile;
                Log("SATEditor : Saving to " + FNGFileName);

                try
                {
                    if (!File.Exists(FNGFileName + ".bak") && CreateBackup) // Create a backup of FNG if there isn't any
                    {
                        File.Copy(FNGFileName, FNGFileName + ".bak", true);
                        Log("SATEditor : Created backup file: " + FNGFileName + ".bak");
                    }

                    FNGFileStream = File.Open(FNGFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    newFNGFile = new BinaryWriter(FNGFileStream);

                    // Write new values from list view
                    foreach (ListViewItem item in SATEditorList.Items)
                    {
                        newFNGFile.BaseStream.Position = int.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.AllowHexSpecifier);
                        newFNGFile.Write(int.Parse(item.SubItems[4].Text)); // blue
                        newFNGFile.Write(int.Parse(item.SubItems[3].Text)); // green
                        newFNGFile.Write(int.Parse(item.SubItems[2].Text)); // red
                        newFNGFile.Write(int.Parse(item.SubItems[5].Text)); // alpha
                    }

                    Log("SATEditor : Saved " + FNGFileName);
                    FNGChanged = false;
                    newFNGFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File could not be saved.", "SATEditor", MessageBoxButtons.OK);
                    Log("SATEditor : File could not be saved." + " " + "Exception: " + ex.ToString());
                    return;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                String FNGSaveFileName = SaveAsFileDialog.FileName.ToString();
                if (FNGSaveFileName != "")
                {
                    FileStream FNGFileStream, NewFNGFileStream;
                    BinaryReader FNGFile;
                    BinaryWriter newFNGFile;

                    Log("SATEditor : Saving to " + FNGSaveFileName);

                    try
                    { 
                        FNGFileStream = File.Open(FNGFileName, FileMode.Open);
                        NewFNGFileStream = File.Open(FNGSaveFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                        FNGFile = new BinaryReader(FNGFileStream);
                        newFNGFile = new BinaryWriter(NewFNGFileStream);

                        // Create a copy
                        File.Copy(FNGFileName, FNGSaveFileName, true);

                        // Write new values from list view
                        foreach (ListViewItem item in SATEditorList.Items)
                        {
                            newFNGFile.BaseStream.Position = int.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.AllowHexSpecifier);
                            newFNGFile.Write(int.Parse(item.SubItems[4].Text)); // blue
                            newFNGFile.Write(int.Parse(item.SubItems[3].Text)); // green
                            newFNGFile.Write(int.Parse(item.SubItems[2].Text)); // red
                            newFNGFile.Write(int.Parse(item.SubItems[5].Text)); // alpha
                        }

                        Log("SATEditor : Saved " + FNGSaveFileName);
                        FNGChanged = false;
                        FNGFile.Close();
                        newFNGFile.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File could not be saved.", "SATEditor", MessageBoxButtons.OK);
                        Log("SATEditor : File could not be saved." + " " + "Exception: " + ex.ToString());
                        return;
                    }
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SettingsUI = new SATEditorSettingsUI();
            var Result = SettingsUI.ShowDialog();
            if (Result == DialogResult.OK) LoadSettings();
        }

        private void SATEditorList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = SATEditorList.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                Log("SATEditor : Starting Color Editor...");
                var ColorEditor = new SATEditorEdit();
                ColorEditor.IDInfo = item.SubItems[0].Text;
                ColorEditor.OffsetInfo = item.SubItems[1].Text;
                ColorEditor.NewRed = int.Parse(item.SubItems[2].Text);
                ColorEditor.NewGreen = int.Parse(item.SubItems[3].Text);
                ColorEditor.NewBlue = int.Parse(item.SubItems[4].Text);
                ColorEditor.NewAlpha = int.Parse(item.SubItems[5].Text);
                ColorEditor.Comments = item.SubItems[6].Text;

                var Result = ColorEditor.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    int FNGtempID = int.Parse(ColorEditor.IDInfo);
                    int FNGtempOffset = Convert.ToInt32(ColorEditor.OffsetInfo, 16);
                    int FNGtempRed = ColorEditor.NewRed;
                    int FNGtempGreen = ColorEditor.NewGreen;
                    int FNGtempBlue = ColorEditor.NewBlue;
                    int FNGtempAlpha = ColorEditor.NewAlpha;

                    if ((FNGtempBlue >= 0 && FNGtempBlue <= 255)
                        && (FNGtempGreen >= 0 && FNGtempGreen <= 255)
                        && (FNGtempRed >= 0 && FNGtempRed <= 255)
                        && (FNGtempAlpha >= 0 && FNGtempAlpha <= 255))
                    {
                        var FNGItem = new ListViewItem();
                        FNGItem.Text = FNGtempID.ToString();
                        FNGItem.SubItems.Add(FNGtempOffset.ToString("X8")); // offset in hex
                        FNGItem.SubItems.Add(FNGtempRed.ToString()); // red
                        FNGItem.SubItems.Add(FNGtempGreen.ToString()); // green
                        FNGItem.SubItems.Add(FNGtempBlue.ToString()); // blue
                        FNGItem.SubItems.Add(FNGtempAlpha.ToString()); // alpha
                        FNGItem.SubItems.Add(ColorEditor.Comments); // comments

                        // Set item color
                        FNGItem.BackColor = Color.FromArgb(FNGtempAlpha, FNGtempRed, FNGtempGreen, FNGtempBlue);
                        float Brightness = FNGItem.BackColor.GetBrightness();
                        // Make text always readable
                        if (Brightness > 0.5) FNGItem.ForeColor = Color.Black;
                        else FNGItem.ForeColor = Color.White;

                        // Replace Multi Items if Multi-Edit mode is used
                        if (ColorEditor.isMultiEdit)
                        {
                            var OriginalFNGItem = SATEditorList.Items[FNGtempID - 1];

                            int OriginalRed = int.Parse(OriginalFNGItem.SubItems[2].Text);
                            int OriginalGreen = int.Parse(OriginalFNGItem.SubItems[3].Text);
                            int OriginalBlue = int.Parse(OriginalFNGItem.SubItems[4].Text);
                            int OriginalAlpha = int.Parse(OriginalFNGItem.SubItems[5].Text);

                            foreach (ListViewItem MultiEditItem in SATEditorList.Items)
                            {
                                int MultiEditRed = int.Parse(MultiEditItem.SubItems[2].Text);
                                int MultiEditGreen = int.Parse(MultiEditItem.SubItems[3].Text);
                                int MultiEditBlue = int.Parse(MultiEditItem.SubItems[4].Text);

                                // If caught an entry with the same color
                                if (MultiEditRed == OriginalRed
                                    && MultiEditGreen == OriginalGreen
                                    && MultiEditBlue == OriginalBlue)
                                {
                                    MultiEditItem.SubItems[2].Text = FNGtempRed.ToString();
                                    MultiEditItem.SubItems[3].Text = FNGtempGreen.ToString();
                                    MultiEditItem.SubItems[4].Text = FNGtempBlue.ToString();

                                    if (!ColorEditor.isKeepAlpha) MultiEditItem.SubItems[5].Text = FNGtempAlpha.ToString();

                                    MultiEditItem.SubItems[6].Text = ColorEditor.Comments;

                                    MultiEditItem.BackColor = FNGItem.BackColor;
                                    MultiEditItem.ForeColor = FNGItem.ForeColor;
                                    
                                    FNGChanged = true;
                                }
                            }
                            Log("Color Editor : Replaced all entries with (" + OriginalRed + ", " + OriginalGreen + ", " + OriginalBlue + 
                                                                ") into (" + FNGtempRed + ", " + FNGtempGreen + ", " + FNGtempBlue + ").");
                            if (ColorEditor.isKeepAlpha) Log("Color Editor : Kept original alpha values from these entries.");
                        }

                        else // Replace Single Item
                        {
                            Log("Color Editor : Replaced entry " + FNGtempID + " with (" + SATEditorList.Items[FNGtempID-1].SubItems[2].Text + ", " + SATEditorList.Items[FNGtempID - 1].SubItems[3].Text + ", " + SATEditorList.Items[FNGtempID - 1].SubItems[4].Text +
                                                                ") into (" + FNGtempRed + ", " + FNGtempGreen + ", " + FNGtempBlue + ").");
                            SATEditorList.Items.RemoveAt(FNGtempID - 1);
                            SATEditorList.Items.Insert(FNGtempID - 1, FNGItem);
                            FNGChanged = true;
                        }
                    }
                }
            }
            else
            {
                this.SATEditorList.SelectedItems.Clear();
            }
        }

        private void SATEditorUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FNGChanged == true)
            {
                DialogResult result = MessageBox.Show("Would you like to save your changes before quitting?", "SATEditor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
                else if (result == DialogResult.Cancel)
                {
                    // Return to the form
                    e.Cancel = true;
                }
                
            }

            Log("SATEditor : Quitting SATEditor...");
        }

        // Thanks to MWisBest for their OpenNFSTools library.
        // https://github.com/MWisBest/OpenNFSTools/blob/29984b26f33db244d198ae450aee880922d39f16/LibNFS/Compression/JDLZ.cs
        public static byte[] JDLZDecompress(byte[] input)
        {
            int flags1 = 1, flags2 = 1;
            int t, length;
            int inPos = 16, outPos = 0;

            if (input[0] != 'J' || input[1] != 'D' || input[2] != 'L' || input[3] != 'Z' || input[4] != 0x02)
            {
                return null;
            }

            // TODO: Can we always trust the header's stated length?
            byte[] output = new byte[(input[11] << 24) + (input[10] << 16) + (input[9] << 8) + input[8]];

            while ((inPos < input.Length) && (outPos < output.Length))
            {
                if (flags1 == 1)
                {
                    flags1 = input[inPos++] | 0x100;
                }
                if (flags2 == 1)
                {
                    flags2 = input[inPos++] | 0x100;
                }

                if ((flags1 & 1) == 1)
                {
                    if ((flags2 & 1) == 1) // 3 to 4098(?) iterations, backtracks 1 to 16(?) bytes
                    {
                        // length max is 4098(?) (0x1002), assuming input[inPos] and input[inPos + 1] are both 0xFF
                        length = (input[inPos + 1] | ((input[inPos] & 0xF0) << 4)) + 3;
                        // t max is 16(?) (0x10), assuming input[inPos] is 0xFF
                        t = (input[inPos] & 0x0F) + 1;
                    }
                    else // 3(?) to 34(?) iterations, backtracks 17(?) to 2064(?) bytes
                    {
                        // t max is 2064(?) (0x810), assuming input[inPos] and input[inPos + 1] are both 0xFF
                        t = (input[inPos + 1] | ((input[inPos] & 0xE0) << 3)) + 17;
                        // length max is 34(?) (0x22), assuming input[inPos] is 0xFF
                        length = (input[inPos] & 0x1F) + 3;
                    }

                    inPos += 2;

                    for (int i = 0; i < length; ++i)
                    {
                        output[outPos + i] = output[outPos + i - t];
                    }

                    outPos += length;
                    flags2 >>= 1;
                }
                else
                {
                    if (outPos < output.Length)
                    {
                        output[outPos++] = input[inPos++];
                    }
                }
                flags1 >>= 1;
            }
            return output;
        }

        private void SATEditorUI_Load(object sender, EventArgs e)
        {
            LoadSettings();
            isProgramNewlyStarted = true;
            Log("SATEditor : Ready.");
        }

        private void fNGExtractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FNGExtractorOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Log("SATEditor : Starting FNG Extractor...");

                FileStream FNGExtFileStream;
                String NewFolder="";

                try
                {
                    FNGExtFileStream = File.Open(FNGExtractorOpenFileDialog.FileName, FileMode.Open);
                    Log("FNG Extractor : Opened " + FNGExtractorOpenFileDialog.FileName + " to export.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File could not be opened.", "SATEditor", MessageBoxButtons.OK);
                    Log("FNG Extractor : File could not be opened." + " " + "Exception: " + ex.ToString());
                    return;
                }

                // Read all the file into a buffer
                BinaryReader FNGExtFile = new BinaryReader(FNGExtFileStream);
                
                String DirectoryPath = Path.GetDirectoryName(FNGExtractorOpenFileDialog.FileName);
                String FileNameWOExt = Path.GetFileNameWithoutExtension(FNGExtractorOpenFileDialog.FileName);
                String FileExtension = Path.GetExtension(FNGExtractorOpenFileDialog.FileName);
                
                int ExtractedFNGCount = 0;

                try
                {
                    byte[] FNGtempJDLZ = FNGExtFile.ReadBytes(4);

                    if (FNGtempJDLZ[0] == 'J' && FNGtempJDLZ[1] == 'D' && FNGtempJDLZ[2] == 'L' && FNGtempJDLZ[3] == 'Z') // If file starts with JDLZ
                    {
                        Log("FNG Extractor : Decompressing JDLZ file...");

                        FNGExtFile.BaseStream.Position = FNGExtFile.BaseStream.Position - 4;

                        // Decompress JDLZ
                        byte[] buf = new byte[FNGExtFileStream.Length];
                        FNGExtFile.Read(buf, 0, (int)FNGExtFileStream.Length);
                        byte[] bufDecompressed = JDLZDecompress(buf);

                        // Create an uncompressed file
                        FileStream FNGExtDecFileStream = File.Open(DirectoryPath + "\\" + FileNameWOExt + ".lzc.tmp", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        BinaryWriter NewFNGExtFile = new BinaryWriter(FNGExtDecFileStream);
                        NewFNGExtFile.Write(bufDecompressed);

                        // Switch to uncompressed file to continue
                        FNGExtFile = new BinaryReader(FNGExtDecFileStream);
                    }

                    FNGExtFile.BaseStream.Position = 0;

                    Log("FNG Extractor : Extracting uncompressed FNG files...");

                    while (FNGExtFile.BaseStream.Position != FNGExtFile.BaseStream.Length) // Initial extraction, for uncompressed FNG files
                    {
                        byte[] FNGtempFEn = FNGExtFile.ReadBytes(4);

                        if (FNGtempFEn[0] == 'F' && FNGtempFEn[1] == 'E' && FNGtempFEn[2] == 'n') // If found a FNG file
                        {
                            FNGExtFile.BaseStream.Position = FNGExtFile.BaseStream.Position - 8; // To read size information
                            int FNGFileSize = FNGExtFile.ReadInt32() + 8;

                            FNGExtFile.BaseStream.Position = FNGExtFile.BaseStream.Position + 40; // Goes to file name
                            String FNGFileName = "";
                            char c;
                            for (int i = 0; i < FNGFileSize; i++)
                            {
                                if ((c = (char)FNGExtFile.ReadByte()) == 0)
                                {
                                    break;
                                }
                                FNGFileName += c.ToString();
                            }

                            FNGExtFile.BaseStream.Position = FNGExtFile.BaseStream.Position - FNGFileName.Length - 48 - 1; // Return to header

                            // Create a folder in File's name
                            NewFolder = Path.Combine(DirectoryPath, FileNameWOExt);
                            Directory.CreateDirectory(NewFolder);

                            // Extract the FNG file
                            if (!FNGFileName.EndsWith(".fng")) FNGFileName = "Unknown_" + ExtractedFNGCount + ".fng";
                            FileStream ExtractedFNGFileStream = File.Open(NewFolder + "\\" + FNGFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            BinaryWriter ExtractedFNGFile = new BinaryWriter(ExtractedFNGFileStream);
                            ExtractedFNGFile.Write(FNGExtFile.ReadBytes(FNGFileSize));
                            ExtractedFNGFile.Close();
                            ExtractedFNGCount++;
                        }
                    }

                    FNGExtFile.BaseStream.Position = 0;

                    List<int> JDLZEntries = new List<int>();

                    Log("FNG Extractor : Extracting JDLZ compressed FNG files...");

                    // Locate and extract any other JDLZ content if exists
                    while (FNGExtFile.BaseStream.Position != FNGExtFile.BaseStream.Length)
                    {
                        FNGtempJDLZ = FNGExtFile.ReadBytes(4);

                        if (FNGtempJDLZ[0] == 'J' && FNGtempJDLZ[1] == 'D' && FNGtempJDLZ[2] == 'L' && FNGtempJDLZ[3] == 'Z') // If found a JDLZ file
                        {
                            JDLZEntries.Add((int)FNGExtFile.BaseStream.Position - 4);
                        }
                    }

                    // Add a final entry to fix issues
                    JDLZEntries.Add((int)FNGExtFile.BaseStream.Length);

                    if (JDLZEntries.Count > 0)
                    {
                        FileStream FNGExtDecFileStream = File.Open(DirectoryPath + "\\" + FileNameWOExt + ".tmp", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        BinaryWriter NewFNGExtFile = new BinaryWriter(FNGExtDecFileStream);

                        for (int i = 0; i< JDLZEntries.Count-2; i++)
                        {
                            byte[] buf = new byte[JDLZEntries[i + 1] - JDLZEntries[i]];
                            FNGExtFile.BaseStream.Position = JDLZEntries[i];
                            FNGExtFile.Read(buf, 0, JDLZEntries[i + 1] - JDLZEntries[i]);
                            byte[] bufDecompressed = JDLZDecompress(buf);

                            if (bufDecompressed != null)
                            {
                                // Write 4-bytes index
                                NewFNGExtFile.Write(0x00030203);
                                // Write file length
                                NewFNGExtFile.Write(bufDecompressed.Length);
                                // Write the rest of FNG
                                NewFNGExtFile.Write(bufDecompressed);
                            }
                            
                        }

                        FNGExtFile = new BinaryReader(FNGExtDecFileStream);
                    }

                    FNGExtFile.BaseStream.Position = 0;

                    while (FNGExtFile.BaseStream.Position != FNGExtFile.BaseStream.Length) // 2nd pass, for compressed FNG files
                    {
                        byte[] FNGtempFEn = FNGExtFile.ReadBytes(4);

                        if (FNGtempFEn[0] == 'F' && FNGtempFEn[1] == 'E' && FNGtempFEn[2] == 'n') // If found a FNG file
                        {
                            FNGExtFile.BaseStream.Position = FNGExtFile.BaseStream.Position - 8; // To read size information
                            int FNGFileSize = FNGExtFile.ReadInt32() + 8;

                            FNGExtFile.BaseStream.Position = FNGExtFile.BaseStream.Position + 40; // Goes to file name
                            String FNGFileName = "";
                            char c;
                            for (int i = 0; i < FNGFileSize; i++)
                            {
                                if ((c = (char)FNGExtFile.ReadByte()) == 0)
                                {
                                    break;
                                }
                                FNGFileName += c.ToString();
                            }
                                
                            FNGExtFile.BaseStream.Position = FNGExtFile.BaseStream.Position - FNGFileName.Length - 48 - 1; // Return to header

                            // Create a folder in File's name
                            NewFolder = Path.Combine(DirectoryPath, FileNameWOExt);
                            Directory.CreateDirectory(NewFolder);

                            // Extract the FNG file
                            if (!FNGFileName.EndsWith(".fng")) FNGFileName = "Unknown_" + ExtractedFNGCount + ".fng";
                            FileStream ExtractedFNGFileStream = File.Open(NewFolder + "\\" + FNGFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            BinaryWriter ExtractedFNGFile = new BinaryWriter(ExtractedFNGFileStream);
                            ExtractedFNGFile.Write(FNGExtFile.ReadBytes(FNGFileSize));
                            ExtractedFNGFile.Close();
                            ExtractedFNGCount++;
                        }
                    }

                    if (ExtractedFNGCount == 0) MessageBox.Show("This file doesn't contain any FNG files.", "SATEditor", MessageBoxButtons.OK); // Report status
                    else MessageBox.Show("Successfully extracted" + " " + ExtractedFNGCount + " " + "FNG files from" + " " + FileNameWOExt + FileExtension + " " + "into" + "\n" + NewFolder, "SATEditor", MessageBoxButtons.OK);
                    FNGExtFile.Close();  // Close the file
                    Log("FNG Extractor : Extracted " + ExtractedFNGCount + " FNG files.");
                    if (File.Exists(DirectoryPath + "\\" + FileNameWOExt + ".lzc.tmp") && !KeepTemporaryFiles) File.Delete(DirectoryPath + "\\" + FileNameWOExt + ".lzc.tmp"); // Delete temp files
                    if (File.Exists(DirectoryPath + "\\" + FileNameWOExt + ".tmp") && !KeepTemporaryFiles) File.Delete(DirectoryPath + "\\" + FileNameWOExt + ".tmp");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("File could not be processed.", "SATEditor", MessageBoxButtons.OK); // Report status
                    Log("FNG Extractor : File could not be processed." + " " + "Exception: " + ex.ToString());
                    FNGExtFile.Close(); // Close the file
                    return; // exit
                }
            }
        }

        private void ImportFNGToGlobalAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                String FNGAFileName = OpenFileDialog.FileName.ToString();
                if (FNGAFileName != "")
                {
                    if (GameFolderSelectDialog.ShowDialog() == DialogResult.OK)
                    {
                        Log("SATEditor : Starting FNG Injector...");

                        String GameFolder = GameFolderSelectDialog.SelectedPath.ToString();
                        if (GameFolder != "")
                        {
                            FileStream FNGAFileStream, GlobalAFileStream;
                            BinaryReader FNGAFile, GlobalAFile;
                            BinaryWriter NewGlobalAFile;

                            String GlobalAPath = Path.Combine(GameFolder, "GLOBAL", "GlobalA.bun");

                            try
                            {
                                if (!File.Exists(GlobalAPath + ".bak")) // Create a backup of GlobalA if there isn't any
                                {
                                    File.Copy(GlobalAPath, GlobalAPath + ".bak", true);
                                }

                                FNGAFileStream = File.Open(FNGAFileName, FileMode.Open);
                                GlobalAFileStream = File.Open(GlobalAPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                FNGAFile = new BinaryReader(FNGAFileStream);
                                GlobalAFile = new BinaryReader(GlobalAFileStream);

                                NewGlobalAFile = new BinaryWriter(GlobalAFileStream);
                                // Add FNG at the end of GlobalA
                                NewGlobalAFile.BaseStream.Position = NewGlobalAFile.BaseStream.Length;
                                NewGlobalAFile.Write(FNGAFile.ReadBytes((int)FNGAFileStream.Length));
                                
                                MessageBox.Show("File injected successfully.", "SATEditor", MessageBoxButtons.OK);
                                Log("FNG Injector : " + FNGAFile + " " + "is injected at the end of" + " " + GlobalAPath);

                                FNGAFile.Close();
                                GlobalAFile.Close();
                                NewGlobalAFile.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("File could not be injected.", "SATEditor", MessageBoxButtons.OK);
                                Log("FNG Injector : File could not be injected." + " " + "Exception: " + ex.ToString());
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void RestoreOriginalGlobalAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GameFolderSelectDialog.ShowDialog() == DialogResult.OK)
            {
                String GameFolder = GameFolderSelectDialog.SelectedPath.ToString();
                if (GameFolder != "")
                {
                    Log("SATEditor : Starting FNG Injector...");

                    String GlobalAPath = Path.Combine(GameFolder, "GLOBAL", "GlobalA.bun");

                    try
                    {
                        if (File.Exists(GlobalAPath)) File.Delete(GlobalAPath);
                        File.Copy(GlobalAPath + ".bak", GlobalAPath, true);

                        MessageBox.Show("File restored successfully.", "SATEditor", MessageBoxButtons.OK);
                        Log("FNG Injector : " + GlobalAPath + " " + "is restored successfully from a backup file.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File could not be restored.", "SATEditor", MessageBoxButtons.OK);
                        Log("FNG Injector : File could not be restored." + " " + "Exception: " + ex.ToString());
                        return;
                    }
                }
            }
        }
    }
}
