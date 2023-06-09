﻿// Mac EFI Toolkit
// https://github.com/MuertoGB/MacEfiToolkit

// WinForms
// editorWindow.cs
// Released under the GNU GLP v3.0
// Yes, the code is messy, it's far from complete and unoptimised, stop crying.

using Mac_EFI_Toolkit.Common;
using Mac_EFI_Toolkit.UI;
using Mac_EFI_Toolkit.Utils;
using Mac_EFI_Toolkit.WIN32;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mac_EFI_Toolkit.WinForms
{
    public partial class editorWindow : Form
    {

        #region Private Members
        private byte[] _bytesNewFsysRegion = null;
        private byte[] _bytesNewBinary = null;
        private readonly string _strChevronRight = "\xE76C";

        private long _primaryVssOffset = -1;
        private int _primaryVssSize = -1;
        private long _backupVssOffset = -1;
        private int _backupVssSize = -1;

        private long _primarySvsOffset = -1;
        private int _primarySvsSize = -1;
        private long _backupSvsOffset = -1;
        private int _backupSvsSize = -1;

        private long _primaryNssOffset = -1;
        private int _primaryNssSize = -1;
        private long _backupNssOffset = -1;
        private int _backupNssSize = -1;

        private bool _maskCrc = false;
        private bool _buildFailed = false;

        private string _fullBuildPath = string.Empty;
        #endregion

        #region Overriden Properties
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams Params = base.CreateParams;
                Params.ClassStyle = Params.ClassStyle | Program.CS_DBLCLKS | Program.CS_DROP;
                return Params;
            }
        }
        #endregion

        #region Constructor
        public editorWindow()
        {
            InitializeComponent();

            Load += mainWindow_Load;
            lblTitle.MouseMove += editorWindow_MouseMove;

            var font = Program.FONT_MDL2_REG_9;
            var chevronRight = _strChevronRight;
            SetLabelProperties(lblSvsChevRight, font, chevronRight);
            SetLabelProperties(lblVssChevRight, font, chevronRight);
            SetLabelProperties(lblNssChevRight, font, chevronRight);

            SetButtonProperties();
        }
        #endregion

        #region Window Events
        private void mainWindow_Load(object sender, EventArgs e)
        {
            tbxSerialNumber.MaxLength = FWParser.strSerialNumber.Length;

            Logger.WriteLogTextToRtb($"{DateTime.Now}", RtbLogPrefix.Info, rtbLog);
            Logger.WriteLogTextToRtb($"The editor is unfinished, use caution!", RtbLogPrefix.Warn, rtbLog);

            LogLoadedBinarySize();

            LogFsysData();

            ValidateNvramStoreData();
            LogNvramData();

            Logger.WriteLogTextToRtb($"Initial checks complete", RtbLogPrefix.Good, rtbLog);
        }
        #endregion

        #region Mouse Events
        private void editorWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture(new HandleRef(this, Handle));
                NativeMethods.SendMessage(new HandleRef(this, Handle), Program.WM_NCLBUTTONDOWN, (IntPtr)Program.HT_CAPTION, (IntPtr)0);
            }
        }
        #endregion

        #region Button Events

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdFsysPath_Click(object sender, EventArgs e)
        {

            using (var dialog = new OpenFileDialog
            {
                InitialDirectory = Program.appDirectory,
                Filter = "Binary Files (*.rom, *.bin)|*.rom;*.bin|All Files (*.*)|*.*"
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    cbxReplaceFsysRgn.Checked = false;
                    return;
                }

                Logger.WriteLogTextToRtb($"Opening '{dialog.FileName}'", RtbLogPrefix.Info, rtbLog);
                _bytesNewFsysRegion = File.ReadAllBytes(dialog.FileName);
                bool isValid = ValidateNewFsysRegion(_bytesNewFsysRegion);
                if (!isValid) cbxReplaceFsysRgn.Checked = false;
            }
        }

        private void cmdBuild_Click(object sender, EventArgs e)
        {
            ToggleControlEnable(false);

            _bytesNewBinary = FWParser.bytesLoadedFile;

            if (cbxReplaceFsysRgn.Checked)
            {
                PatchFsys();
            }

            //if (cbxReplaceSerial.Checked)
            //{
            //    Logger.WriteLogTextToRtb($"Replacing serial number...", RtbLogPrefix.MET, rtbLog);
            //}

            //if (cbxClearVssStore.Checked)
            //{
            //    Logger.WriteLogTextToRtb($"Clearing VSS store...", RtbLogPrefix.MET, rtbLog);
            //}

            //if (cbxClearSvsStore.Checked)
            //{
            //    Logger.WriteLogTextToRtb($"Clearing VSS store...", RtbLogPrefix.MET, rtbLog);
            //}

            //if (cbxClearNssStore.Checked)
            //{
            //    Logger.WriteLogTextToRtb($"Clearing VSS store...", RtbLogPrefix.MET, rtbLog);
            //}

            // If the build fails, disallow exporting.
            if (!_buildFailed)
            {
                Logger.WriteLogTextToRtb($"BUILD SUCCEEDED.", RtbLogPrefix.Good, rtbLog);

                var dir = Path.Combine(Program.appDirectory, "builds");
                var filename = $"outimage_{DateTime.Now:yyMMdd_HHmmss}.bin";

                _fullBuildPath = Path.Combine(dir, filename);

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.WriteAllBytes(_fullBuildPath, _bytesNewBinary);
                Logger.WriteLogTextToRtb($"Save path: {_fullBuildPath}", RtbLogPrefix.Info, rtbLog);

                var shaNewBinary = FileUtils.GetSha256Digest(_bytesNewBinary);
                var outFileBytes = File.ReadAllBytes(_fullBuildPath);
                var shaOutFile = FileUtils.GetSha256Digest(outFileBytes);

                if (string.Equals(shaNewBinary, shaOutFile))
                {
                    Logger.WriteLogTextToRtb($"Written file checksum is good, export successful!", RtbLogPrefix.Good, rtbLog);
                }
                else
                {
                    Logger.WriteLogTextToRtb($"Written file checksum is bad, export was not successful!", RtbLogPrefix.Error, rtbLog);
                }
            }

            ToggleControlEnable(true);
        }
        #endregion

        #region Checkbox Events

        private void cbxClearVssRegion_CheckedChanged(object sender, EventArgs e)
        {
            METCheckbox cb = (METCheckbox)sender;

            if (_backupVssOffset != -1)
            {
                lblVssChevRight.Visible = cb.Checked;
                cbxClearVssBackup.Enabled = cb.Checked;
            }

            if (!cb.Checked)
            {
                cbxClearVssBackup.Checked = false;
            }
        }

        private void cbxClearSvsRegion_CheckedChanged(object sender, EventArgs e)
        {
            METCheckbox cb = (METCheckbox)sender;

            if (_backupSvsOffset != -1)
            {
                lblSvsChevRight.Visible = cb.Checked;
                cbxClearSvsBackup.Enabled = cb.Checked;
            }

            if (!cb.Checked)
            {
                cbxClearSvsBackup.Checked = false;
            }
        }

        private void cbxClearNssRegion_CheckedChanged(object sender, EventArgs e)
        {
            METCheckbox cb = (METCheckbox)sender;

            if (_backupNssOffset != -1)
            {
                lblNssChevRight.Visible = cb.Checked;
                cbxClearNssBackup.Enabled = cb.Checked;
            }

            if (!cb.Checked)
            {
                cbxClearNssBackup.Checked = false;
            }
        }

        private void cbxReplaceFsysRgn_CheckedChanged(object sender, EventArgs e)
        {
            METCheckbox cb = (METCheckbox)sender;
            bool isChecked = cb.Checked;

            cmdFsysPath.Enabled = isChecked;
            tlpSerialA.Enabled = !isChecked;

            if (isChecked)
            {
                cmdFsysPath.PerformClick();
            }
        }

        private void cmdReplaceSerial_CheckedChanged(object sender, EventArgs e)
        {
            METCheckbox cb = (METCheckbox)sender;
            bool isChecked = cb.Checked;

            tlpSerialB.Enabled = isChecked;
            tlpFsysA.Enabled = !isChecked;

            if (!isChecked)
            {
                tbxSerialNumber.Text = string.Empty;
                tbxHwc.Text = string.Empty;
            }
        }

        private void cmdSaveLog_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Log File...",
                FileName = $"metlog_{DateTime.Now:yyMMdd_HHmmss}.txt",
                OverwritePrompt = true,
                InitialDirectory = Program.appDirectory
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                File.WriteAllText(dialog.FileName, rtbLog.Text);
            }
        }
        #endregion

        #region TextBox Events
        private void tbxSerialNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int textLength = tb.Text.Length;

            if (textLength == FWParser.strSerialNumber.Length)
            {
                if (EFIUtils.GetIsValidSerialChars(tb.Text))
                {
                    UpdateTextBoxColor(tb, Colours.clrGood);
                    Logger.WriteLogTextToRtb("Valid serial characters entered.", RtbLogPrefix.Info, rtbLog);
                    if (FWParser.strSerialNumber.Length == 11)
                    {
                        UpdateHwcTextBoxText(tb.Text.Substring(textLength - 3));
                    }
                    if (FWParser.strSerialNumber.Length == 12)
                    {
                        UpdateHwcTextBoxText(tb.Text.Substring(textLength - 4));
                    }
                    cmdBuild.Enabled = true;
                }
                else
                {
                    UpdateTextBoxColor(tb, Colours.clrError);
                    Logger.WriteLogTextToRtb("Invalid serial characters entered.", RtbLogPrefix.Error, rtbLog);
                    UpdateHwcTextBoxText(string.Empty);
                    cmdBuild.Enabled = false;
                }
            }
            else
            {
                UpdateTextBoxColor(tb, Color.White);
                UpdateHwcTextBoxText(string.Empty);
                cmdBuild.Enabled = true;
            }
        }
        #endregion

        #region Validation
        private bool ValidateNewFsysRegion(byte[] sourceBytes)
        {
            Logger.WriteLogTextToRtb("Validating donor Fsys region:", RtbLogPrefix.Info, rtbLog);

            if (sourceBytes.Length != FWParser.FSYS_RGN_SIZE)
            {
                Logger.WriteLogTextToRtb($"Filesize: {sourceBytes.Length:X2}h, expected 800h", RtbLogPrefix.Error, rtbLog);
                return false;
            }

            long lSigPos = BinaryUtils.GetOffset(sourceBytes, FSSignatures.FSYS_SIG);
            if (lSigPos == -1 || lSigPos != 0)
            {
                Logger.WriteLogTextToRtb(lSigPos == -1 ? "Fsys signature not found." : $"Fsys signature misaligned at {lSigPos:X2}h", RtbLogPrefix.Error, rtbLog);
                return false;
            }

            var serialData = FWParser.GetSystemSerialNumber(sourceBytes, false);
            string strSerial = serialData.Serial;
            int lenSerial = strSerial.Length;
            string strHwc = lenSerial == 11 ? strSerial.Substring(strSerial.Length - 3).ToUpper() : lenSerial == 12 ? strSerial.Substring(strSerial.Length - 4).ToUpper() : string.Empty;

            Logger.WriteLogTextToRtb($"Filesize: {sourceBytes.Length:X2}h", RtbLogPrefix.Info, rtbLog);
            Logger.WriteLogTextToRtb($"Fsys signature found at {lSigPos:X2}h", RtbLogPrefix.Info, rtbLog);
            Logger.WriteLogTextToRtb($"Serial: {strSerial} ({lenSerial}char)", RtbLogPrefix.Info, rtbLog);
            Logger.WriteLogTextToRtb($"HWC: {strHwc}", RtbLogPrefix.Info, rtbLog);

            string strCrcInFile = FWParser.GetFsysCrc32(sourceBytes);
            string strCrcCalculated = EFIUtils.GetUintFsysCrc32(sourceBytes).ToString("X8");

            Logger.WriteLogTextToRtb($"{strCrcInFile}h > {strCrcCalculated}h", RtbLogPrefix.Info, rtbLog);

            if (strCrcInFile != strCrcCalculated)
            {
                Logger.WriteLogTextToRtb("Donor Fsys CRC32 is invalid, 'Mask CRC32' flag set!", RtbLogPrefix.Warn, rtbLog);
                _maskCrc = true;
            }
            else
            {
                _maskCrc = false;
            }

            Logger.WriteLogTextToRtb("Validation completed", RtbLogPrefix.Good, rtbLog);

            return true;
        }

        private void ValidateNvramStoreData()
        {
            NvramStoreData vssStore = FWParser.GetNvramStoreData(FWParser.bytesLoadedFile, NvramStoreType.VSS);
            if (vssStore.PrimaryStoreOffset != -1)
            {
                _primaryVssOffset = vssStore.PrimaryStoreOffset;
                _primaryVssSize = vssStore.PrimaryStoreSize;

            }
            else
            {
                cbxClearVssStore.Enabled = false;
            }

            if (vssStore.BackupStoreOffset != -1)
            {
                _backupVssOffset = vssStore.BackupStoreOffset;
                _backupVssSize = vssStore.BackupStoreSize;

            }
            else
            {
                cbxClearVssBackup.Enabled = false;
                lblVssChevRight.Visible = false;
            }

            NvramStoreData svsStore = FWParser.GetNvramStoreData(FWParser.bytesLoadedFile, NvramStoreType.SVS);
            if (svsStore.PrimaryStoreOffset != -1)
            {
                _primarySvsOffset = svsStore.PrimaryStoreOffset;
                _primarySvsSize = svsStore.PrimaryStoreSize;
            }
            else
            {
                cbxClearSvsStore.Enabled = false;
            }
            if (svsStore.BackupStoreOffset != -1)
            {
                _backupSvsOffset = svsStore.BackupStoreOffset;
                _backupSvsSize = svsStore.BackupStoreSize;
            }
            else
            {
                cbxClearSvsBackup.Enabled = false;
                lblSvsChevRight.Visible = false;
            }

            NvramStoreData nssStore = FWParser.GetNvramStoreData(FWParser.bytesLoadedFile, NvramStoreType.NSS);
            if (nssStore.PrimaryStoreOffset != -1)
            {
                _primaryNssOffset = nssStore.PrimaryStoreOffset;
                _primaryNssSize = nssStore.PrimaryStoreSize;
            }
            else
            {
                cbxClearNssStore.Enabled = false;
            }
            if (nssStore.BackupStoreOffset != -1)
            {
                _backupNssOffset = nssStore.BackupStoreOffset;
                _backupNssSize = nssStore.BackupStoreSize;
            }
            else
            {
                cbxClearNssBackup.Enabled = false;
                lblNssChevRight.Visible = false;
            }
        }
        #endregion

        #region Misc Events
        private void UpdateTextBoxColor(TextBox textBox, Color color)
        {
            textBox.ForeColor = color;
        }

        private void UpdateHwcTextBoxText(string text)
        {
            tbxHwc.Text = text;
        }

        private void SetLabelProperties(Label label, Font font, string text)
        {
            label.Font = font;
            label.Text = text;
            label.Visible = false;
        }

        private void SetButtonProperties()
        {
            cmdClose.Font = Program.FONT_MDL2_REG_12;
            cmdClose.Text = Program.closeChar;
        }

        private void ToggleControlEnable(bool enable)
        {
            tlpOptions.Enabled = enable;
            cmdBuild.Enabled = enable;
        }
        #endregion

        #region Logging
        private void LogFsysData()
        {
            if (FWParser.lFsysOffset != 0)
            {
                Logger.WriteLogTextToRtb($"Fsys: Offset {FWParser.lFsysOffset:X2}h, Size {FWParser.FSYS_RGN_SIZE:X2}h", RtbLogPrefix.Info, rtbLog);
            }
        }

        private void LogLoadedBinarySize()
        {
            if (!FileUtils.GetIsValidBinSize((int)FWParser.lLoadedFileSize))
            {
                Logger.WriteLogTextToRtb($"Loaded binary size {FWParser.lLoadedFileSize:X2}h is invalid and should not be used as a donor.", RtbLogPrefix.Error, rtbLog);
            }
            else
            {
                Logger.WriteLogTextToRtb($"Loaded binary size {FWParser.lLoadedFileSize:X2}h is valid", RtbLogPrefix.Info, rtbLog);
            }
        }

        private void LogNvramData()
        {
            if (_primaryVssOffset != -1)
            {
                Logger.WriteLogTextToRtb($"VSS Store: Offset {_primaryVssOffset:X2}h, Size {_primaryVssSize:X2}h", RtbLogPrefix.Info, rtbLog);

                if (_backupVssOffset != -1)
                {
                    Logger.WriteLogTextToRtb($"VSS Backup: Offset {_backupVssOffset:X2}h, Size {_backupVssSize:X2}h", RtbLogPrefix.Info, rtbLog);
                }
            }

            if (_primarySvsOffset != -1)
            {
                Logger.WriteLogTextToRtb($"SVS Store: Offset {_primarySvsOffset:X2}h, Size {_primarySvsSize:X2}h", RtbLogPrefix.Info, rtbLog);

                if (_backupSvsOffset != -1)
                {
                    Logger.WriteLogTextToRtb($"SVS Backup: Offset {_backupSvsOffset:X2}h, Size {_backupSvsSize:X2}h", RtbLogPrefix.Info, rtbLog);
                }
            }

            if (_primaryNssOffset != -1)
            {
                Logger.WriteLogTextToRtb($"NSS Store: Offset {_primaryNssOffset:X2}h, Size {_primaryNssSize:X2}h", RtbLogPrefix.Info, rtbLog);

                if (_backupNssOffset != -1)
                {
                    Logger.WriteLogTextToRtb($"NSS Backup: Offset {_backupNssOffset:X2}h, Size {_backupNssSize:X2}h", RtbLogPrefix.Info, rtbLog);
                }
            }
        }
        #endregion

        #region Editing
        private void PatchFsys()
        {
            Logger.WriteLogTextToRtb("Writing new Fsys Region:", RtbLogPrefix.Info, rtbLog);

            // Mask Fsys CRC
            if (_maskCrc)
            {
                // Mask CRC32 was checked
                Logger.WriteLogTextToRtb("Masking Fsys CRC32", RtbLogPrefix.Info, rtbLog);

                // Calculate actual CRC32 from _bytesNewFsysRegion
                uint newCrc = EFIUtils.GetUintFsysCrc32(_bytesNewFsysRegion);

                // Get bytes from newCrc uint
                byte[] newCrcBytes = BitConverter.GetBytes(newCrc);

                // Write newCrcBytes to the donor Fsys region
                BinaryUtils.OverwriteBytesAtOffset(_bytesNewFsysRegion, 0x7FC, newCrcBytes);

                // Read CRC32 string from _bytesNewFsysRegion
                string patchedCrcBytes = FWParser.GetFsysCrc32(_bytesNewFsysRegion);

                Logger.WriteLogTextToRtb($"{newCrc:X8}h > {patchedCrcBytes}h", RtbLogPrefix.Info, rtbLog);

                // Convert newCrc to hex string to string and compare it to was was read.
                if (string.Equals(newCrc.ToString("X8"), patchedCrcBytes))
                {
                    Logger.WriteLogTextToRtb("CRC32 masking successful", RtbLogPrefix.Info, rtbLog);
                }
                else
                {
                    HandleBuildFailure("CRC32 masking failed.");
                    return;
                }
            }

            // Write new Fsys bytes to _bytesNewBinary
            BinaryUtils.OverwriteBytesAtOffset(_bytesNewBinary, FWParser.lFsysOffset, _bytesNewFsysRegion);

            // Validate new Fsys was written
            FsysRegion fsys = FWParser.GetFsysRegionBytes(_bytesNewBinary, false);
            if (fsys.RegionBytes.SequenceEqual(_bytesNewFsysRegion))
            {
                Logger.WriteLogTextToRtb("Fsys comparison check passed", RtbLogPrefix.Info, rtbLog);
            }
            else
            {
                HandleBuildFailure("Fsys comparison check failed");
                return;
            }

            Logger.WriteLogTextToRtb("New Fsys region written successfully", RtbLogPrefix.Good, rtbLog);
        }

        private void HandleBuildFailure(string errorMessage)
        {
            Logger.WriteLogTextToRtb("BUILD FAILED:", RtbLogPrefix.Error, rtbLog);
            Logger.WriteLogTextToRtb(errorMessage, RtbLogPrefix.Error, rtbLog);
            _buildFailed = true;
        }

        #endregion

    }
}