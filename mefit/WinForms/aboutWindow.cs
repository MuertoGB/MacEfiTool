﻿// Mac EFI Toolkit
// https://github.com/MuertoGB/MacEfiToolkit

// WinForms
// aboutWindow.cs
// Updated 05.05.23 - Enabled KeyPreview, enabled links.
// Released under the GNU GLP v3.0

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Mac_EFI_Toolkit.Interop;

namespace Mac_EFI_Toolkit.WinForms
{
    public partial class aboutWindow : Form
    {

        #region Overriden Properties
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams Params = base.CreateParams;
                Params.Style |= Program.WS_MINIMIZEBOX;
                Params.ClassStyle = Params.ClassStyle | Program.CS_DBLCLKS | Program.CS_DROP;
                return Params;
            }
        }
        #endregion

        #region Constructor
        public aboutWindow()
        {
            InitializeComponent();

            Load += new EventHandler(aboutWindow_Load);
            tlpMain.MouseMove += new MouseEventHandler(Move_Form);
            pbxLogo.MouseMove += new MouseEventHandler(Move_Form);
            lblBuild.MouseMove += new MouseEventHandler(Move_Form);
            lblName.MouseMove += new MouseEventHandler(Move_Form);
            KeyDown += new KeyEventHandler(aboutWindow_KeyDown);
        }
        #endregion

        #region Startup Event
        private void aboutWindow_Load(object sender, EventArgs e)
        {
            lblBuild.Text = $"Build: { Program.APP_BUILD} ";
            FormatLinks();
        }
        #endregion

        #region Mouse Events
        private void Move_Form(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture(new HandleRef(this, Handle));
                NativeMethods.SendMessage(new HandleRef(this, Handle), Program.WM_NCLBUTTONDOWN, (IntPtr)Program.HT_CAPTION, (IntPtr)0);
            }
        }
        #endregion

        #region KeyDown Events
        private void aboutWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
        #endregion

        #region Button Events
        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region LinkLabel Events
        private void FormatLinks()
        {
            lnkUrls.Links.Clear();
            lnkUrls.Links.Add(0, 10, "mailto:qbug@tuta.io");
            lnkUrls.Links.Add(13, 11, "https://github.com/MuertoGB/MacEfiToolkit");
            lnkUrls.Links.Add(27, 6, "https://www.paypal.com/donate/?hosted_button_id=Z88F3UEZB47SQ");
        }
        private void lnkUrls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
        #endregion  

    }
}