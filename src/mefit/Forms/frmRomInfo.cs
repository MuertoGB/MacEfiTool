﻿// Mac EFI Toolkit
// https://github.com/MuertoGB/MacEfiToolkit

// Windows Forms
// frmRomInfo.cs
// Released under the GNU GLP v3.0

using Mac_EFI_Toolkit.Firmware.EFI;
using Mac_EFI_Toolkit.Tools;
using Mac_EFI_Toolkit.UI;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mac_EFI_Toolkit.Forms
{
    public partial class frmRominfo : METForm
    {
        #region Constructor
        public frmRominfo()
        {
            InitializeComponent();

            // Attach event handlers.
            WireEventHandlers();

            // Enable drag.
            UITools.EnableFormDrag(
                this,
                tlpTitle,
                lblTitle);

            // Set button propeties.
            SetButtonProperties();
        }

        private void WireEventHandlers()
        {
            Load += frmRominfo_Load;
            KeyDown += frmRominfo_KeyDown;
            pbxLogo.MouseDoubleClick += pbxLogo_MouseDoubleClick;
        }
        #endregion

        #region Window Events
        private void frmRominfo_Load(object sender, EventArgs e)
        {
            lblBiosId.Text = EFIROM.AppleRomInfoSectionData.BiosId
                ?? "N/A";
            lblModel.Text = EFIROM.AppleRomInfoSectionData.Model != null
                ? $"{EFIROM.AppleRomInfoSectionData.Model} " +
                $"({MacTools.ConvertEfiModelCode(EFIROM.AppleRomInfoSectionData.Model)})"
                : "N/A";
            lblEfiVersion.Text =
                EFIROM.AppleRomInfoSectionData.EfiVersion
                ?? "N/A";
            lblBuiltBy.Text =
                EFIROM.AppleRomInfoSectionData.BuiltBy
                ?? "N/A";
            lblDateStamp.Text =
                EFIROM.AppleRomInfoSectionData.DateStamp
                ?? "N/A";
            lblRevision.Text =
                EFIROM.AppleRomInfoSectionData.Revision
                ?? "N/A";
            lblBootRom.Text =
                EFIROM.AppleRomInfoSectionData.RomVersion
                ?? "N/A";
            lblBuildcaveId.Text =
                EFIROM.AppleRomInfoSectionData.BuildcaveId
                ?? "N/A";
            lblBuildType.Text =
                EFIROM.AppleRomInfoSectionData.BuildType
                ?? "N/A";
            lblCompiler.Text =
                EFIROM.AppleRomInfoSectionData.Compiler
                ?? "N/A";
            lblSectionData.Text =
                $"BASE: {EFIROM.AppleRomInfoSectionData.SectionBase:X}h, " +
                $"SIZE: {EFIROM.AppleRomInfoSectionData.SectionBytes.Length:X}h"
                ?? string.Empty;

            foreach (Label label in tlpInfo.Controls)
                if (label.Text == "N/A")
                    label.ForeColor = AppColours.DISABLED_TEXT;
        }
        #endregion

        #region KeyDown Events
        private void frmRominfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        #endregion

        #region Button Events
        private void cmdExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                FileName = $"AppleRomSectionInformation_{EFIROM.FileInfoData.FileName}",
                OverwritePrompt = true,
                InitialDirectory = METPath.WORKING_DIR
            })
            {
                // Action was cancelled
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                StringBuilder builder = new StringBuilder();

                builder.AppendLine($"Bios ID:       {EFIROM.AppleRomInfoSectionData.BiosId ?? "N/A"}");
                builder.AppendLine($"Model:         {EFIROM.AppleRomInfoSectionData.Model ?? "N/A"}");
                builder.AppendLine($"EFI Version:   {EFIROM.AppleRomInfoSectionData.EfiVersion ?? "N/A"}");
                builder.AppendLine($"Built By:      {EFIROM.AppleRomInfoSectionData.BuiltBy ?? "N/A"}");
                builder.AppendLine($"Date Stamp:    {EFIROM.AppleRomInfoSectionData.DateStamp ?? "N/A"}");
                builder.AppendLine($"Revision:      {EFIROM.AppleRomInfoSectionData.Revision ?? "N/A"}");
                builder.AppendLine($"Boot ROM:      {EFIROM.AppleRomInfoSectionData.RomVersion ?? "N/A"}");
                builder.AppendLine($"Buildcave ID:  {EFIROM.AppleRomInfoSectionData.BuildcaveId ?? "N/A"}");
                builder.AppendLine($"Built Type:    {EFIROM.AppleRomInfoSectionData.BuildType ?? "N/A"}");
                builder.AppendLine($"Compiler:      {EFIROM.AppleRomInfoSectionData.Compiler ?? "N/A"}");

                File.WriteAllText(
                    dialog.FileName,
                    builder.ToString());

                if (!File.Exists(dialog.FileName))
                {
                    METPrompt.Show(
                        this,
                        "Data export failed.",
                        METPromptType.Error,
                        METPromptButtons.Okay);

                    return;
                }

                UITools.ShowExplorerFileHighlightPrompt(
                 this,
                 dialog.FileName);
            }
        }

        private void cmdClose_Click(object sender, System.EventArgs e) =>
            Close();
        #endregion

        #region Picturebox Events
        private void pbxLogo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CenterToParent();
        }
        #endregion

        #region UI Events
        private void SetButtonProperties()
        {
            cmdClose.Font = Program.FONT_MDL2_REG_12;
            cmdClose.Text = Program.GLYPH_EXIT_CROSS;
        }
        #endregion
    }
}