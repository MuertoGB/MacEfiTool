﻿
namespace Mac_EFI_Toolkit.WinForms
{
    partial class settingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsWindow));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.cmdDefaults = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            this.cmdCloseForm = new System.Windows.Forms.Button();
            this.pnlTitleMenuSplit = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDac = new System.Windows.Forms.TableLayoutPanel();
            this.lblDacText = new System.Windows.Forms.Label();
            this.cbxDisableLzmaFsSearch = new Mac_EFI_Toolkit.UI.METCheckbox();
            this.tlpDwf = new System.Windows.Forms.TableLayoutPanel();
            this.lblDwfText = new System.Windows.Forms.Label();
            this.cbxDisableFlashingUI = new Mac_EFI_Toolkit.UI.METCheckbox();
            this.lblApplicationText = new System.Windows.Forms.Label();
            this.lblStartupText = new System.Windows.Forms.Label();
            this.tlpDvc = new System.Windows.Forms.TableLayoutPanel();
            this.lblDvcText = new System.Windows.Forms.Label();
            this.cbxDisableVersionCheck = new Mac_EFI_Toolkit.UI.METCheckbox();
            this.tlpCif = new System.Windows.Forms.TableLayoutPanel();
            this.lnlCifText = new System.Windows.Forms.Label();
            this.cmdEditCustomPath = new System.Windows.Forms.Button();
            this.tlpDfe = new System.Windows.Forms.TableLayoutPanel();
            this.lblDfeText = new System.Windows.Forms.Label();
            this.cbxDisableFsysEnforce = new Mac_EFI_Toolkit.UI.METCheckbox();
            this.tlpDde = new System.Windows.Forms.TableLayoutPanel();
            this.lblDdeText = new System.Windows.Forms.Label();
            this.cbxDisableDescriptorEnforce = new Mac_EFI_Toolkit.UI.METCheckbox();
            this.tlpDcd = new System.Windows.Forms.TableLayoutPanel();
            this.lblDcdText = new System.Windows.Forms.Label();
            this.cbxDisableConfDiag = new Mac_EFI_Toolkit.UI.METCheckbox();
            this.lblFirmwareText = new System.Windows.Forms.Label();
            this.lblSettingsApplied = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpDac.SuspendLayout();
            this.tlpDwf.SuspendLayout();
            this.tlpDvc.SuspendLayout();
            this.tlpCif.SuspendLayout();
            this.tlpDfe.SuspendLayout();
            this.tlpDde.SuspendLayout();
            this.tlpDcd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.cmdClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(1, 1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(408, 40);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(368, 40);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Settings";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.Color.White;
            this.cmdClose.Location = new System.Drawing.Point(368, 0);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.cmdClose.Size = new System.Drawing.Size(40, 40);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.TabStop = false;
            this.cmdClose.Text = "✕";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpButtons.Controls.Add(this.cmdDefaults, 0, 0);
            this.tlpButtons.Controls.Add(this.cmdApply, 3, 0);
            this.tlpButtons.Controls.Add(this.cmdCloseForm, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtons.Location = new System.Drawing.Point(1, 449);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(408, 50);
            this.tlpButtons.TabIndex = 2;
            // 
            // cmdDefaults
            // 
            this.cmdDefaults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.cmdDefaults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmdDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDefaults.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDefaults.ForeColor = System.Drawing.Color.White;
            this.cmdDefaults.Location = new System.Drawing.Point(10, 8);
            this.cmdDefaults.Margin = new System.Windows.Forms.Padding(0);
            this.cmdDefaults.Name = "cmdDefaults";
            this.cmdDefaults.Size = new System.Drawing.Size(100, 34);
            this.cmdDefaults.TabIndex = 0;
            this.cmdDefaults.Text = "Reset";
            this.cmdDefaults.UseVisualStyleBackColor = false;
            this.cmdDefaults.Click += new System.EventHandler(this.cmdDefaults_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.cmdApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmdApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdApply.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdApply.ForeColor = System.Drawing.Color.White;
            this.cmdApply.Location = new System.Drawing.Point(298, 8);
            this.cmdApply.Margin = new System.Windows.Forms.Padding(0);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(100, 34);
            this.cmdApply.TabIndex = 2;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = false;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // cmdCloseForm
            // 
            this.cmdCloseForm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.cmdCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmdCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCloseForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCloseForm.ForeColor = System.Drawing.Color.White;
            this.cmdCloseForm.Location = new System.Drawing.Point(188, 8);
            this.cmdCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.cmdCloseForm.Name = "cmdCloseForm";
            this.cmdCloseForm.Size = new System.Drawing.Size(100, 34);
            this.cmdCloseForm.TabIndex = 1;
            this.cmdCloseForm.Text = "Close";
            this.cmdCloseForm.UseVisualStyleBackColor = false;
            this.cmdCloseForm.Click += new System.EventHandler(this.cmdCloseForm_Click);
            // 
            // pnlTitleMenuSplit
            // 
            this.pnlTitleMenuSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.pnlTitleMenuSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleMenuSplit.Location = new System.Drawing.Point(1, 41);
            this.pnlTitleMenuSplit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitleMenuSplit.Name = "pnlTitleMenuSplit";
            this.pnlTitleMenuSplit.Size = new System.Drawing.Size(408, 2);
            this.pnlTitleMenuSplit.TabIndex = 92;
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpDac, 0, 14);
            this.tlpMain.Controls.Add(this.tlpDwf, 0, 6);
            this.tlpMain.Controls.Add(this.lblApplicationText, 0, 4);
            this.tlpMain.Controls.Add(this.lblStartupText, 0, 0);
            this.tlpMain.Controls.Add(this.tlpDvc, 0, 2);
            this.tlpMain.Controls.Add(this.tlpCif, 0, 10);
            this.tlpMain.Controls.Add(this.tlpDfe, 0, 16);
            this.tlpMain.Controls.Add(this.tlpDde, 0, 18);
            this.tlpMain.Controls.Add(this.tlpDcd, 0, 8);
            this.tlpMain.Controls.Add(this.lblFirmwareText, 0, 12);
            this.tlpMain.Controls.Add(this.lblSettingsApplied, 0, 22);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(1, 43);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 23;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(408, 406);
            this.tlpMain.TabIndex = 93;
            // 
            // tlpDac
            // 
            this.tlpDac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tlpDac.ColumnCount = 2;
            this.tlpDac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpDac.Controls.Add(this.lblDacText, 0, 0);
            this.tlpDac.Controls.Add(this.cbxDisableLzmaFsSearch, 1, 0);
            this.tlpDac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDac.Location = new System.Drawing.Point(0, 229);
            this.tlpDac.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDac.Name = "tlpDac";
            this.tlpDac.RowCount = 1;
            this.tlpDac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDac.Size = new System.Drawing.Size(408, 30);
            this.tlpDac.TabIndex = 4;
            // 
            // lblDacText
            // 
            this.lblDacText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDacText.AutoSize = true;
            this.lblDacText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDacText.ForeColor = System.Drawing.Color.White;
            this.lblDacText.Location = new System.Drawing.Point(3, 5);
            this.lblDacText.Name = "lblDacText";
            this.lblDacText.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblDacText.Size = new System.Drawing.Size(288, 20);
            this.lblDacText.TabIndex = 1;
            this.lblDacText.Text = "Disable APFS check in compressed DXE:";
            // 
            // cbxDisableLzmaFsSearch
            // 
            this.cbxDisableLzmaFsSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDisableLzmaFsSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbxDisableLzmaFsSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbxDisableLzmaFsSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbxDisableLzmaFsSearch.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.cbxDisableLzmaFsSearch.ClientColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbxDisableLzmaFsSearch.ClientColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbxDisableLzmaFsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDisableLzmaFsSearch.Location = new System.Drawing.Point(370, 4);
            this.cbxDisableLzmaFsSearch.Name = "cbxDisableLzmaFsSearch";
            this.cbxDisableLzmaFsSearch.Size = new System.Drawing.Size(21, 21);
            this.cbxDisableLzmaFsSearch.TabIndex = 7;
            // 
            // tlpDwf
            // 
            this.tlpDwf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tlpDwf.ColumnCount = 2;
            this.tlpDwf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDwf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpDwf.Controls.Add(this.lblDwfText, 0, 0);
            this.tlpDwf.Controls.Add(this.cbxDisableFlashingUI, 1, 0);
            this.tlpDwf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDwf.Location = new System.Drawing.Point(0, 101);
            this.tlpDwf.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDwf.Name = "tlpDwf";
            this.tlpDwf.RowCount = 1;
            this.tlpDwf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDwf.Size = new System.Drawing.Size(408, 30);
            this.tlpDwf.TabIndex = 1;
            // 
            // lblDwfText
            // 
            this.lblDwfText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDwfText.AutoSize = true;
            this.lblDwfText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDwfText.ForeColor = System.Drawing.Color.White;
            this.lblDwfText.Location = new System.Drawing.Point(3, 5);
            this.lblDwfText.Name = "lblDwfText";
            this.lblDwfText.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblDwfText.Size = new System.Drawing.Size(214, 20);
            this.lblDwfText.TabIndex = 1;
            this.lblDwfText.Text = "Disable flashing UI elements:";
            // 
            // cbxDisableFlashingUI
            // 
            this.cbxDisableFlashingUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDisableFlashingUI.BackColor = System.Drawing.Color.Transparent;
            this.cbxDisableFlashingUI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbxDisableFlashingUI.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbxDisableFlashingUI.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.cbxDisableFlashingUI.ClientColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbxDisableFlashingUI.ClientColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbxDisableFlashingUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDisableFlashingUI.Location = new System.Drawing.Point(370, 4);
            this.cbxDisableFlashingUI.Name = "cbxDisableFlashingUI";
            this.cbxDisableFlashingUI.Size = new System.Drawing.Size(21, 21);
            this.cbxDisableFlashingUI.TabIndex = 4;
            // 
            // lblApplicationText
            // 
            this.lblApplicationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblApplicationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.lblApplicationText.Location = new System.Drawing.Point(0, 66);
            this.lblApplicationText.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationText.Name = "lblApplicationText";
            this.lblApplicationText.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblApplicationText.Size = new System.Drawing.Size(408, 34);
            this.lblApplicationText.TabIndex = 3;
            this.lblApplicationText.Text = "Application:";
            this.lblApplicationText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartupText
            // 
            this.lblStartupText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblStartupText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartupText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.lblStartupText.Location = new System.Drawing.Point(0, 0);
            this.lblStartupText.Margin = new System.Windows.Forms.Padding(0);
            this.lblStartupText.Name = "lblStartupText";
            this.lblStartupText.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblStartupText.Size = new System.Drawing.Size(408, 34);
            this.lblStartupText.TabIndex = 0;
            this.lblStartupText.Text = "Startup:";
            this.lblStartupText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpDvc
            // 
            this.tlpDvc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tlpDvc.ColumnCount = 2;
            this.tlpDvc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDvc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpDvc.Controls.Add(this.lblDvcText, 0, 0);
            this.tlpDvc.Controls.Add(this.cbxDisableVersionCheck, 1, 0);
            this.tlpDvc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDvc.Location = new System.Drawing.Point(0, 35);
            this.tlpDvc.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDvc.Name = "tlpDvc";
            this.tlpDvc.RowCount = 1;
            this.tlpDvc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDvc.Size = new System.Drawing.Size(408, 30);
            this.tlpDvc.TabIndex = 0;
            // 
            // lblDvcText
            // 
            this.lblDvcText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDvcText.AutoSize = true;
            this.lblDvcText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvcText.ForeColor = System.Drawing.Color.White;
            this.lblDvcText.Location = new System.Drawing.Point(3, 5);
            this.lblDvcText.Name = "lblDvcText";
            this.lblDvcText.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblDvcText.Size = new System.Drawing.Size(170, 20);
            this.lblDvcText.TabIndex = 1;
            this.lblDvcText.Text = "Disable version check:";
            // 
            // cbxDisableVersionCheck
            // 
            this.cbxDisableVersionCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDisableVersionCheck.BackColor = System.Drawing.Color.Transparent;
            this.cbxDisableVersionCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbxDisableVersionCheck.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbxDisableVersionCheck.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.cbxDisableVersionCheck.ClientColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbxDisableVersionCheck.ClientColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbxDisableVersionCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDisableVersionCheck.Location = new System.Drawing.Point(370, 4);
            this.cbxDisableVersionCheck.Name = "cbxDisableVersionCheck";
            this.cbxDisableVersionCheck.Size = new System.Drawing.Size(21, 21);
            this.cbxDisableVersionCheck.TabIndex = 3;
            // 
            // tlpCif
            // 
            this.tlpCif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tlpCif.ColumnCount = 2;
            this.tlpCif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpCif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCif.Controls.Add(this.lnlCifText, 0, 0);
            this.tlpCif.Controls.Add(this.cmdEditCustomPath, 1, 0);
            this.tlpCif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCif.Location = new System.Drawing.Point(0, 163);
            this.tlpCif.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCif.Name = "tlpCif";
            this.tlpCif.RowCount = 1;
            this.tlpCif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCif.Size = new System.Drawing.Size(408, 30);
            this.tlpCif.TabIndex = 3;
            // 
            // lnlCifText
            // 
            this.lnlCifText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnlCifText.AutoSize = true;
            this.lnlCifText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlCifText.ForeColor = System.Drawing.Color.White;
            this.lnlCifText.Location = new System.Drawing.Point(3, 5);
            this.lnlCifText.Name = "lnlCifText";
            this.lnlCifText.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lnlCifText.Size = new System.Drawing.Size(195, 20);
            this.lnlCifText.TabIndex = 1;
            this.lnlCifText.Text = "Custom initial folder path:";
            // 
            // cmdEditCustomPath
            // 
            this.cmdEditCustomPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.cmdEditCustomPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditCustomPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmdEditCustomPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditCustomPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditCustomPath.ForeColor = System.Drawing.Color.White;
            this.cmdEditCustomPath.Location = new System.Drawing.Point(354, 0);
            this.cmdEditCustomPath.Margin = new System.Windows.Forms.Padding(0);
            this.cmdEditCustomPath.Name = "cmdEditCustomPath";
            this.cmdEditCustomPath.Size = new System.Drawing.Size(54, 30);
            this.cmdEditCustomPath.TabIndex = 6;
            this.cmdEditCustomPath.Text = "Edit";
            this.cmdEditCustomPath.UseVisualStyleBackColor = false;
            this.cmdEditCustomPath.Click += new System.EventHandler(this.cmdEditCustomPath_Click);
            // 
            // tlpDfe
            // 
            this.tlpDfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tlpDfe.ColumnCount = 2;
            this.tlpDfe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDfe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpDfe.Controls.Add(this.lblDfeText, 0, 0);
            this.tlpDfe.Controls.Add(this.cbxDisableFsysEnforce, 1, 0);
            this.tlpDfe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDfe.Location = new System.Drawing.Point(0, 260);
            this.tlpDfe.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDfe.Name = "tlpDfe";
            this.tlpDfe.RowCount = 1;
            this.tlpDfe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDfe.Size = new System.Drawing.Size(408, 30);
            this.tlpDfe.TabIndex = 5;
            // 
            // lblDfeText
            // 
            this.lblDfeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDfeText.AutoSize = true;
            this.lblDfeText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfeText.ForeColor = System.Drawing.Color.White;
            this.lblDfeText.Location = new System.Drawing.Point(3, 5);
            this.lblDfeText.Name = "lblDfeText";
            this.lblDfeText.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblDfeText.Size = new System.Drawing.Size(232, 20);
            this.lblDfeText.TabIndex = 1;
            this.lblDfeText.Text = "Disable valid Fsys enforcement:";
            // 
            // cbxDisableFsysEnforce
            // 
            this.cbxDisableFsysEnforce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDisableFsysEnforce.BackColor = System.Drawing.Color.Transparent;
            this.cbxDisableFsysEnforce.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbxDisableFsysEnforce.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbxDisableFsysEnforce.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.cbxDisableFsysEnforce.ClientColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbxDisableFsysEnforce.ClientColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbxDisableFsysEnforce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDisableFsysEnforce.Location = new System.Drawing.Point(370, 4);
            this.cbxDisableFsysEnforce.Name = "cbxDisableFsysEnforce";
            this.cbxDisableFsysEnforce.Size = new System.Drawing.Size(21, 21);
            this.cbxDisableFsysEnforce.TabIndex = 8;
            // 
            // tlpDde
            // 
            this.tlpDde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tlpDde.ColumnCount = 2;
            this.tlpDde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpDde.Controls.Add(this.lblDdeText, 0, 0);
            this.tlpDde.Controls.Add(this.cbxDisableDescriptorEnforce, 1, 0);
            this.tlpDde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDde.Location = new System.Drawing.Point(0, 291);
            this.tlpDde.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDde.Name = "tlpDde";
            this.tlpDde.RowCount = 1;
            this.tlpDde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDde.Size = new System.Drawing.Size(408, 30);
            this.tlpDde.TabIndex = 6;
            // 
            // lblDdeText
            // 
            this.lblDdeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDdeText.AutoSize = true;
            this.lblDdeText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDdeText.ForeColor = System.Drawing.Color.White;
            this.lblDdeText.Location = new System.Drawing.Point(3, 5);
            this.lblDdeText.Name = "lblDdeText";
            this.lblDdeText.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblDdeText.Size = new System.Drawing.Size(273, 20);
            this.lblDdeText.TabIndex = 1;
            this.lblDdeText.Text = "Disable valid descriptor enforcement:";
            // 
            // cbxDisableDescriptorEnforce
            // 
            this.cbxDisableDescriptorEnforce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDisableDescriptorEnforce.BackColor = System.Drawing.Color.Transparent;
            this.cbxDisableDescriptorEnforce.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbxDisableDescriptorEnforce.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbxDisableDescriptorEnforce.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.cbxDisableDescriptorEnforce.ClientColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbxDisableDescriptorEnforce.ClientColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbxDisableDescriptorEnforce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDisableDescriptorEnforce.Location = new System.Drawing.Point(370, 4);
            this.cbxDisableDescriptorEnforce.Name = "cbxDisableDescriptorEnforce";
            this.cbxDisableDescriptorEnforce.Size = new System.Drawing.Size(21, 21);
            this.cbxDisableDescriptorEnforce.TabIndex = 9;
            // 
            // tlpDcd
            // 
            this.tlpDcd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tlpDcd.ColumnCount = 2;
            this.tlpDcd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDcd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpDcd.Controls.Add(this.lblDcdText, 0, 0);
            this.tlpDcd.Controls.Add(this.cbxDisableConfDiag, 1, 0);
            this.tlpDcd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDcd.Location = new System.Drawing.Point(0, 132);
            this.tlpDcd.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDcd.Name = "tlpDcd";
            this.tlpDcd.RowCount = 1;
            this.tlpDcd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDcd.Size = new System.Drawing.Size(408, 30);
            this.tlpDcd.TabIndex = 2;
            // 
            // lblDcdText
            // 
            this.lblDcdText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDcdText.AutoSize = true;
            this.lblDcdText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDcdText.ForeColor = System.Drawing.Color.White;
            this.lblDcdText.Location = new System.Drawing.Point(3, 5);
            this.lblDcdText.Name = "lblDcdText";
            this.lblDcdText.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblDcdText.Size = new System.Drawing.Size(217, 20);
            this.lblDcdText.TabIndex = 1;
            this.lblDcdText.Text = "Disable confirmation dialogs:";
            // 
            // cbxDisableConfDiag
            // 
            this.cbxDisableConfDiag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDisableConfDiag.BackColor = System.Drawing.Color.Transparent;
            this.cbxDisableConfDiag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.cbxDisableConfDiag.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbxDisableConfDiag.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.cbxDisableConfDiag.ClientColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbxDisableConfDiag.ClientColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbxDisableConfDiag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDisableConfDiag.Location = new System.Drawing.Point(370, 4);
            this.cbxDisableConfDiag.Name = "cbxDisableConfDiag";
            this.cbxDisableConfDiag.Size = new System.Drawing.Size(21, 21);
            this.cbxDisableConfDiag.TabIndex = 5;
            // 
            // lblFirmwareText
            // 
            this.lblFirmwareText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblFirmwareText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirmwareText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmwareText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.lblFirmwareText.Location = new System.Drawing.Point(0, 194);
            this.lblFirmwareText.Margin = new System.Windows.Forms.Padding(0);
            this.lblFirmwareText.Name = "lblFirmwareText";
            this.lblFirmwareText.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblFirmwareText.Size = new System.Drawing.Size(408, 34);
            this.lblFirmwareText.TabIndex = 11;
            this.lblFirmwareText.Text = "Firmware:";
            this.lblFirmwareText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSettingsApplied
            // 
            this.lblSettingsApplied.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSettingsApplied.AutoSize = true;
            this.lblSettingsApplied.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsApplied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(235)))));
            this.lblSettingsApplied.Location = new System.Drawing.Point(134, 368);
            this.lblSettingsApplied.Name = "lblSettingsApplied";
            this.lblSettingsApplied.Size = new System.Drawing.Size(139, 23);
            this.lblSettingsApplied.TabIndex = 12;
            this.lblSettingsApplied.Text = "Settings Applied!";
            // 
            // settingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(410, 500);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.pnlTitleMenuSplit);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 500);
            this.Name = "settingsWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.pnlTitle.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpDac.ResumeLayout(false);
            this.tlpDac.PerformLayout();
            this.tlpDwf.ResumeLayout(false);
            this.tlpDwf.PerformLayout();
            this.tlpDvc.ResumeLayout(false);
            this.tlpDvc.PerformLayout();
            this.tlpCif.ResumeLayout(false);
            this.tlpCif.PerformLayout();
            this.tlpDfe.ResumeLayout(false);
            this.tlpDfe.PerformLayout();
            this.tlpDde.ResumeLayout(false);
            this.tlpDde.PerformLayout();
            this.tlpDcd.ResumeLayout(false);
            this.tlpDcd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button cmdDefaults;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Button cmdCloseForm;
        internal System.Windows.Forms.Panel pnlTitleMenuSplit;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblStartupText;
        private System.Windows.Forms.TableLayoutPanel tlpDvc;
        private System.Windows.Forms.Label lblDvcText;
        private UI.METCheckbox cbxDisableVersionCheck;
        private System.Windows.Forms.Label lblApplicationText;
        private System.Windows.Forms.TableLayoutPanel tlpDwf;
        private System.Windows.Forms.Label lblDwfText;
        private UI.METCheckbox cbxDisableFlashingUI;
        private System.Windows.Forms.TableLayoutPanel tlpCif;
        private System.Windows.Forms.Label lnlCifText;
        private System.Windows.Forms.Button cmdEditCustomPath;
        private System.Windows.Forms.TableLayoutPanel tlpDac;
        private System.Windows.Forms.Label lblDacText;
        private UI.METCheckbox cbxDisableLzmaFsSearch;
        private System.Windows.Forms.TableLayoutPanel tlpDfe;
        private System.Windows.Forms.Label lblDfeText;
        private UI.METCheckbox cbxDisableFsysEnforce;
        private System.Windows.Forms.TableLayoutPanel tlpDde;
        private System.Windows.Forms.Label lblDdeText;
        private UI.METCheckbox cbxDisableDescriptorEnforce;
        private System.Windows.Forms.TableLayoutPanel tlpDcd;
        private System.Windows.Forms.Label lblDcdText;
        private UI.METCheckbox cbxDisableConfDiag;
        private System.Windows.Forms.Label lblFirmwareText;
        private System.Windows.Forms.Label lblSettingsApplied;
    }
}