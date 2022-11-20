﻿namespace Flowframes.Forms
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsTabList = new Cyotek.Windows.Forms.TabList();
            this.generalTab = new Cyotek.Windows.Forms.TabListPage();
            this.custOutDirBrowseBtn = new HTAlt.WinForms.HTButton();
            this.custOutDir = new System.Windows.Forms.TextBox();
            this.outFolderLoc = new System.Windows.Forms.ComboBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.disablePreview = new System.Windows.Forms.CheckBox();
            this.label76 = new System.Windows.Forms.Label();
            this.modelDownloaderBtn = new HTAlt.WinForms.HTButton();
            this.exportNamePatternLoop = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.PictureBox();
            this.exportNamePattern = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.clearModelCacheBtn = new HTAlt.WinForms.HTButton();
            this.label64 = new System.Windows.Forms.Label();
            this.processingMode = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tempDirBrowseBtn = new HTAlt.WinForms.HTButton();
            this.tempDirCustom = new System.Windows.Forms.TextBox();
            this.keepTempFolder = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tempFolderLoc = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.maxVidHeight = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tabListPage2 = new Cyotek.Windows.Forms.TabListPage();
            this.autoEncBlockPanel = new System.Windows.Forms.Panel();
            this.label70 = new System.Windows.Forms.Label();
            this.alwaysWaitForAutoEnc = new System.Windows.Forms.CheckBox();
            this.label58 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.autoEncBackupMode = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.jpegFrames = new System.Windows.Forms.CheckBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.keepMeta = new System.Windows.Forms.CheckBox();
            this.sceneChangeFillMode = new System.Windows.Forms.ComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enableAlpha = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.keepSubs = new System.Windows.Forms.CheckBox();
            this.scnDetectValue = new System.Windows.Forms.NumericUpDown();
            this.sbsAllowAutoEnc = new System.Windows.Forms.CheckBox();
            this.dedupeSensLabel = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.autoEncMode = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.scnDetect = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.mpDedupePanel = new System.Windows.Forms.Panel();
            this.mpdecimateMode = new System.Windows.Forms.ComboBox();
            this.magickDedupePanel = new System.Windows.Forms.Panel();
            this.dedupThresh = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.enableLoop = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dedupMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keepAudio = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aiOptsPage = new Cyotek.Windows.Forms.TabListPage();
            this.label66 = new System.Windows.Forms.Label();
            this.rifeCudaFp16 = new System.Windows.Forms.CheckBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dainNcnnTilesize = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ncnnThreads = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.uhdThresh = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.torchGpus = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.ncnnGpus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.vidExportTab = new Cyotek.Windows.Forms.TabListPage();
            this.label73 = new System.Windows.Forms.Label();
            this.fixOutputDuration = new System.Windows.Forms.CheckBox();
            this.label72 = new System.Windows.Forms.Label();
            this.minOutVidLength = new System.Windows.Forms.NumericUpDown();
            this.loopMode = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.maxFps = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabListPage1 = new Cyotek.Windows.Forms.TabListPage();
            this.imgSeqQuality = new System.Windows.Forms.ComboBox();
            this.pixFmt = new System.Windows.Forms.ComboBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vp9Crf = new System.Windows.Forms.NumericUpDown();
            this.mp4Crf = new System.Windows.Forms.NumericUpDown();
            this.imgSeqFormat = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.gifDitherType = new System.Windows.Forms.ComboBox();
            this.aviColors = new System.Windows.Forms.ComboBox();
            this.aviCodec = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.proResProfile = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gifColors = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mp4Enc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.debugTab = new Cyotek.Windows.Forms.TabListPage();
            this.label7 = new System.Windows.Forms.Label();
            this.serverCombox = new System.Windows.Forms.ComboBox();
            this.ffEncArgs = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.ffEncPreset = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdDebugMode = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.resetBtn = new HTAlt.WinForms.HTButton();
            this.settingsTabList.SuspendLayout();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info1)).BeginInit();
            this.tabListPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scnDetectValue)).BeginInit();
            this.mpDedupePanel.SuspendLayout();
            this.magickDedupePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedupThresh)).BeginInit();
            this.aiOptsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncnnThreads)).BeginInit();
            this.vidExportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minOutVidLength)).BeginInit();
            this.tabListPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vp9Crf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp4Crf)).BeginInit();
            this.debugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTabList
            // 
            this.settingsTabList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.settingsTabList.Controls.Add(this.generalTab);
            this.settingsTabList.Controls.Add(this.tabListPage2);
            this.settingsTabList.Controls.Add(this.aiOptsPage);
            this.settingsTabList.Controls.Add(this.vidExportTab);
            this.settingsTabList.Controls.Add(this.tabListPage1);
            this.settingsTabList.Controls.Add(this.debugTab);
            this.settingsTabList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.settingsTabList.Location = new System.Drawing.Point(14, 57);
            this.settingsTabList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsTabList.Name = "settingsTabList";
            this.settingsTabList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsTabList.Size = new System.Drawing.Size(1106, 394);
            this.settingsTabList.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.generalTab.Controls.Add(this.custOutDirBrowseBtn);
            this.generalTab.Controls.Add(this.custOutDir);
            this.generalTab.Controls.Add(this.outFolderLoc);
            this.generalTab.Controls.Add(this.label78);
            this.generalTab.Controls.Add(this.label77);
            this.generalTab.Controls.Add(this.disablePreview);
            this.generalTab.Controls.Add(this.label76);
            this.generalTab.Controls.Add(this.modelDownloaderBtn);
            this.generalTab.Controls.Add(this.exportNamePatternLoop);
            this.generalTab.Controls.Add(this.label69);
            this.generalTab.Controls.Add(this.label68);
            this.generalTab.Controls.Add(this.info1);
            this.generalTab.Controls.Add(this.exportNamePattern);
            this.generalTab.Controls.Add(this.label67);
            this.generalTab.Controls.Add(this.clearModelCacheBtn);
            this.generalTab.Controls.Add(this.label64);
            this.generalTab.Controls.Add(this.processingMode);
            this.generalTab.Controls.Add(this.label39);
            this.generalTab.Controls.Add(this.tempDirBrowseBtn);
            this.generalTab.Controls.Add(this.tempDirCustom);
            this.generalTab.Controls.Add(this.keepTempFolder);
            this.generalTab.Controls.Add(this.label6);
            this.generalTab.Controls.Add(this.label36);
            this.generalTab.Controls.Add(this.tempFolderLoc);
            this.generalTab.Controls.Add(this.label34);
            this.generalTab.Controls.Add(this.panel10);
            this.generalTab.Controls.Add(this.maxVidHeight);
            this.generalTab.Controls.Add(this.label31);
            this.generalTab.ForeColor = System.Drawing.Color.White;
            this.generalTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(946, 386);
            this.generalTab.Text = "Application";
            // 
            // custOutDirBrowseBtn
            // 
            this.custOutDirBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custOutDirBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custOutDirBrowseBtn.ForeColor = System.Drawing.Color.White;
            this.custOutDirBrowseBtn.Location = new System.Drawing.Point(821, 88);
            this.custOutDirBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.custOutDirBrowseBtn.Name = "custOutDirBrowseBtn";
            this.custOutDirBrowseBtn.Size = new System.Drawing.Size(64, 21);
            this.custOutDirBrowseBtn.TabIndex = 93;
            this.custOutDirBrowseBtn.Text = "Browse";
            this.custOutDirBrowseBtn.UseVisualStyleBackColor = false;
            this.custOutDirBrowseBtn.Click += new System.EventHandler(this.custOutDirBrowseBtn_Click);
            // 
            // custOutDir
            // 
            this.custOutDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custOutDir.ForeColor = System.Drawing.Color.White;
            this.custOutDir.Location = new System.Drawing.Point(567, 90);
            this.custOutDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.custOutDir.MinimumSize = new System.Drawing.Size(4, 21);
            this.custOutDir.Name = "custOutDir";
            this.custOutDir.Size = new System.Drawing.Size(247, 21);
            this.custOutDir.TabIndex = 92;
            // 
            // outFolderLoc
            // 
            this.outFolderLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outFolderLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outFolderLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outFolderLoc.ForeColor = System.Drawing.Color.White;
            this.outFolderLoc.FormattingEnabled = true;
            this.outFolderLoc.Items.AddRange(new object[] {
            "Same As Input Directory",
            "Custom..."});
            this.outFolderLoc.Location = new System.Drawing.Point(327, 90);
            this.outFolderLoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outFolderLoc.Name = "outFolderLoc";
            this.outFolderLoc.Size = new System.Drawing.Size(233, 20);
            this.outFolderLoc.TabIndex = 91;
            this.outFolderLoc.SelectedIndexChanged += new System.EventHandler(this.outFolderLoc_SelectedIndexChanged);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(12, 92);
            this.label78.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(135, 12);
            this.label78.TabIndex = 90;
            this.label78.Text = "Default Output Location";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ForeColor = System.Drawing.Color.Silver;
            this.label77.Location = new System.Drawing.Point(359, 175);
            this.label77.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(321, 12);
            this.label77.TabIndex = 89;
            this.label77.Text = "You need to restart the application to apply this change.";
            // 
            // disablePreview
            // 
            this.disablePreview.AutoSize = true;
            this.disablePreview.Location = new System.Drawing.Point(327, 175);
            this.disablePreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.disablePreview.Name = "disablePreview";
            this.disablePreview.Size = new System.Drawing.Size(15, 14);
            this.disablePreview.TabIndex = 88;
            this.disablePreview.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(12, 175);
            this.label76.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(122, 12);
            this.label76.TabIndex = 87;
            this.label76.Text = "Disable Preview Tab";
            // 
            // modelDownloaderBtn
            // 
            this.modelDownloaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modelDownloaderBtn.FlatAppearance.BorderSize = 0;
            this.modelDownloaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelDownloaderBtn.ForeColor = System.Drawing.Color.White;
            this.modelDownloaderBtn.Location = new System.Drawing.Point(574, 198);
            this.modelDownloaderBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modelDownloaderBtn.Name = "modelDownloaderBtn";
            this.modelDownloaderBtn.Size = new System.Drawing.Size(240, 21);
            this.modelDownloaderBtn.TabIndex = 86;
            this.modelDownloaderBtn.Text = "Open Model Downloader";
            this.modelDownloaderBtn.UseVisualStyleBackColor = false;
            this.modelDownloaderBtn.Click += new System.EventHandler(this.modelDownloaderBtn_Click);
            // 
            // exportNamePatternLoop
            // 
            this.exportNamePatternLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportNamePatternLoop.ForeColor = System.Drawing.Color.White;
            this.exportNamePatternLoop.Location = new System.Drawing.Point(728, 145);
            this.exportNamePatternLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exportNamePatternLoop.MinimumSize = new System.Drawing.Size(4, 21);
            this.exportNamePatternLoop.Name = "exportNamePatternLoop";
            this.exportNamePatternLoop.Size = new System.Drawing.Size(116, 21);
            this.exportNamePatternLoop.TabIndex = 85;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(648, 148);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 9, 4, 6);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(72, 12);
            this.label69.TabIndex = 84;
            this.label69.Text = "Loop Suffix:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(323, 148);
            this.label68.Margin = new System.Windows.Forms.Padding(12, 9, 4, 6);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(38, 12);
            this.label68.TabIndex = 83;
            this.label68.Text = "Base:";
            // 
            // info1
            // 
            this.info1.BackgroundImage = global::Flowframes.Properties.Resources.questmark_72px_bordeer;
            this.info1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info1.Location = new System.Drawing.Point(852, 145);
            this.info1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(34, 19);
            this.info1.TabIndex = 82;
            this.info1.TabStop = false;
            this.toolTip1.SetToolTip(this.info1, resources.GetString("info1.ToolTip"));
            // 
            // exportNamePattern
            // 
            this.exportNamePattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportNamePattern.ForeColor = System.Drawing.Color.White;
            this.exportNamePattern.Location = new System.Drawing.Point(370, 145);
            this.exportNamePattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exportNamePattern.MinimumSize = new System.Drawing.Size(4, 21);
            this.exportNamePattern.Name = "exportNamePattern";
            this.exportNamePattern.Size = new System.Drawing.Size(270, 21);
            this.exportNamePattern.TabIndex = 81;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(12, 148);
            this.label67.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(122, 12);
            this.label67.TabIndex = 80;
            this.label67.Text = "Export Name Pattern";
            // 
            // clearModelCacheBtn
            // 
            this.clearModelCacheBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearModelCacheBtn.FlatAppearance.BorderSize = 0;
            this.clearModelCacheBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearModelCacheBtn.ForeColor = System.Drawing.Color.White;
            this.clearModelCacheBtn.Location = new System.Drawing.Point(327, 198);
            this.clearModelCacheBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearModelCacheBtn.Name = "clearModelCacheBtn";
            this.clearModelCacheBtn.Size = new System.Drawing.Size(240, 21);
            this.clearModelCacheBtn.TabIndex = 79;
            this.clearModelCacheBtn.Text = "Clear Model Cache";
            this.clearModelCacheBtn.UseVisualStyleBackColor = false;
            this.clearModelCacheBtn.Click += new System.EventHandler(this.clearModelCacheBtn_Click);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(12, 203);
            this.label64.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(195, 12);
            this.label64.TabIndex = 78;
            this.label64.Text = "Manage Downloaded Model Files";
            // 
            // processingMode
            // 
            this.processingMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.processingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processingMode.ForeColor = System.Drawing.Color.White;
            this.processingMode.FormattingEnabled = true;
            this.processingMode.Items.AddRange(new object[] {
            "Do All Steps At Once (Extract, Interpolate, Encode)",
            "Run Each Step Separately (For Manually Editing Frames)"});
            this.processingMode.Location = new System.Drawing.Point(327, 6);
            this.processingMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.processingMode.Name = "processingMode";
            this.processingMode.Size = new System.Drawing.Size(349, 20);
            this.processingMode.TabIndex = 72;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 9);
            this.label39.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(101, 12);
            this.label39.TabIndex = 71;
            this.label39.Text = "Processing Style";
            // 
            // tempDirBrowseBtn
            // 
            this.tempDirBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tempDirBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tempDirBrowseBtn.ForeColor = System.Drawing.Color.White;
            this.tempDirBrowseBtn.Location = new System.Drawing.Point(821, 60);
            this.tempDirBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tempDirBrowseBtn.Name = "tempDirBrowseBtn";
            this.tempDirBrowseBtn.Size = new System.Drawing.Size(64, 21);
            this.tempDirBrowseBtn.TabIndex = 70;
            this.tempDirBrowseBtn.Text = "Browse";
            this.tempDirBrowseBtn.UseVisualStyleBackColor = false;
            this.tempDirBrowseBtn.Click += new System.EventHandler(this.tempDirBrowseBtn_Click);
            // 
            // tempDirCustom
            // 
            this.tempDirCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tempDirCustom.ForeColor = System.Drawing.Color.White;
            this.tempDirCustom.Location = new System.Drawing.Point(567, 62);
            this.tempDirCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tempDirCustom.MinimumSize = new System.Drawing.Size(4, 21);
            this.tempDirCustom.Name = "tempDirCustom";
            this.tempDirCustom.Size = new System.Drawing.Size(247, 21);
            this.tempDirCustom.TabIndex = 69;
            // 
            // keepTempFolder
            // 
            this.keepTempFolder.AutoSize = true;
            this.keepTempFolder.Location = new System.Drawing.Point(327, 120);
            this.keepTempFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.keepTempFolder.Name = "keepTempFolder";
            this.keepTempFolder.Size = new System.Drawing.Size(15, 14);
            this.keepTempFolder.TabIndex = 68;
            this.keepTempFolder.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "Don\'t Delete Temp Folder After Interpolation";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(12, 65);
            this.label36.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(158, 12);
            this.label36.TabIndex = 66;
            this.label36.Text = "Temporary Folder Location";
            // 
            // tempFolderLoc
            // 
            this.tempFolderLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tempFolderLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tempFolderLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tempFolderLoc.ForeColor = System.Drawing.Color.White;
            this.tempFolderLoc.FormattingEnabled = true;
            this.tempFolderLoc.Items.AddRange(new object[] {
            "Same As Input Directory",
            "Parent Directory Of Output Folder",
            "Inside Output Folder",
            "Flowframes Program Folder",
            "Custom..."});
            this.tempFolderLoc.Location = new System.Drawing.Point(327, 62);
            this.tempFolderLoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tempFolderLoc.Name = "tempFolderLoc";
            this.tempFolderLoc.Size = new System.Drawing.Size(233, 20);
            this.tempFolderLoc.TabIndex = 65;
            this.tempFolderLoc.SelectedIndexChanged += new System.EventHandler(this.tempFolderLoc_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Silver;
            this.label34.Location = new System.Drawing.Point(481, 38);
            this.label34.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(329, 12);
            this.label34.TabIndex = 64;
            this.label34.Text = "Maximum Height. Video will be downscaled if it\'s bigger.";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(441, 34);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(24, 19);
            this.panel10.TabIndex = 61;
            this.toolTip1.SetToolTip(this.panel10, "Allows custom input.");
            // 
            // maxVidHeight
            // 
            this.maxVidHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxVidHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxVidHeight.ForeColor = System.Drawing.Color.White;
            this.maxVidHeight.FormattingEnabled = true;
            this.maxVidHeight.Items.AddRange(new object[] {
            "4320",
            "2160",
            "1440",
            "1080",
            "720",
            "540",
            "360"});
            this.maxVidHeight.Location = new System.Drawing.Point(327, 34);
            this.maxVidHeight.Margin = new System.Windows.Forms.Padding(4, 3, 9, 3);
            this.maxVidHeight.Name = "maxVidHeight";
            this.maxVidHeight.Size = new System.Drawing.Size(101, 20);
            this.maxVidHeight.TabIndex = 63;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 37);
            this.label31.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(207, 12);
            this.label31.TabIndex = 62;
            this.label31.Text = "Maximum Video Input Size (Height)";
            // 
            // tabListPage2
            // 
            this.tabListPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabListPage2.Controls.Add(this.autoEncBlockPanel);
            this.tabListPage2.Controls.Add(this.label70);
            this.tabListPage2.Controls.Add(this.alwaysWaitForAutoEnc);
            this.tabListPage2.Controls.Add(this.label58);
            this.tabListPage2.Controls.Add(this.pictureBox2);
            this.tabListPage2.Controls.Add(this.label41);
            this.tabListPage2.Controls.Add(this.autoEncBackupMode);
            this.tabListPage2.Controls.Add(this.label16);
            this.tabListPage2.Controls.Add(this.label74);
            this.tabListPage2.Controls.Add(this.jpegFrames);
            this.tabListPage2.Controls.Add(this.label63);
            this.tabListPage2.Controls.Add(this.label18);
            this.tabListPage2.Controls.Add(this.keepMeta);
            this.tabListPage2.Controls.Add(this.sceneChangeFillMode);
            this.tabListPage2.Controls.Add(this.label71);
            this.tabListPage2.Controls.Add(this.label4);
            this.tabListPage2.Controls.Add(this.enableAlpha);
            this.tabListPage2.Controls.Add(this.label25);
            this.tabListPage2.Controls.Add(this.keepSubs);
            this.tabListPage2.Controls.Add(this.scnDetectValue);
            this.tabListPage2.Controls.Add(this.sbsAllowAutoEnc);
            this.tabListPage2.Controls.Add(this.dedupeSensLabel);
            this.tabListPage2.Controls.Add(this.label53);
            this.tabListPage2.Controls.Add(this.autoEncMode);
            this.tabListPage2.Controls.Add(this.label49);
            this.tabListPage2.Controls.Add(this.panel14);
            this.tabListPage2.Controls.Add(this.label52);
            this.tabListPage2.Controls.Add(this.label51);
            this.tabListPage2.Controls.Add(this.scnDetect);
            this.tabListPage2.Controls.Add(this.label50);
            this.tabListPage2.Controls.Add(this.mpDedupePanel);
            this.tabListPage2.Controls.Add(this.magickDedupePanel);
            this.tabListPage2.Controls.Add(this.label24);
            this.tabListPage2.Controls.Add(this.enableLoop);
            this.tabListPage2.Controls.Add(this.label15);
            this.tabListPage2.Controls.Add(this.dedupMode);
            this.tabListPage2.Controls.Add(this.label2);
            this.tabListPage2.Controls.Add(this.keepAudio);
            this.tabListPage2.Controls.Add(this.label1);
            this.tabListPage2.ForeColor = System.Drawing.Color.White;
            this.tabListPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabListPage2.Name = "tabListPage2";
            this.tabListPage2.Size = new System.Drawing.Size(889, 387);
            this.tabListPage2.Text = "Interpolation";
            // 
            // autoEncBlockPanel
            // 
            this.autoEncBlockPanel.Location = new System.Drawing.Point(5, 305);
            this.autoEncBlockPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoEncBlockPanel.Name = "autoEncBlockPanel";
            this.autoEncBlockPanel.Size = new System.Drawing.Size(881, 79);
            this.autoEncBlockPanel.TabIndex = 94;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.ForeColor = System.Drawing.Color.Silver;
            this.label70.Location = new System.Drawing.Point(359, 360);
            this.label70.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(536, 12);
            this.label70.TabIndex = 93;
            this.label70.Text = "Avoids filling up your hard drive by temporarily pausing interpolation if encodin" +
    "g can\'t keep up";
            // 
            // alwaysWaitForAutoEnc
            // 
            this.alwaysWaitForAutoEnc.AutoSize = true;
            this.alwaysWaitForAutoEnc.Location = new System.Drawing.Point(327, 360);
            this.alwaysWaitForAutoEnc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alwaysWaitForAutoEnc.Name = "alwaysWaitForAutoEnc";
            this.alwaysWaitForAutoEnc.Size = new System.Drawing.Size(15, 14);
            this.alwaysWaitForAutoEnc.TabIndex = 92;
            this.alwaysWaitForAutoEnc.UseVisualStyleBackColor = true;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(12, 360);
            this.label58.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(270, 12);
            this.label58.TabIndex = 91;
            this.label58.Text = "Low Disk Space Mode (Wait For Auto-Encode)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Flowframes.Properties.Resources.questmark_72px_bordeer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(625, 330);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 19);
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.Silver;
            this.label41.Location = new System.Drawing.Point(674, 332);
            this.label41.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(186, 12);
            this.label41.TabIndex = 89;
            this.label41.Text = "Can cause slowdown on HDDs!";
            // 
            // autoEncBackupMode
            // 
            this.autoEncBackupMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoEncBackupMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoEncBackupMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoEncBackupMode.ForeColor = System.Drawing.Color.White;
            this.autoEncBackupMode.FormattingEnabled = true;
            this.autoEncBackupMode.Items.AddRange(new object[] {
            "Disabled",
            "Enabled (Only Video)",
            "Enabled (Complete - With Audio, Subtitles)"});
            this.autoEncBackupMode.Location = new System.Drawing.Point(327, 330);
            this.autoEncBackupMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoEncBackupMode.Name = "autoEncBackupMode";
            this.autoEncBackupMode.Size = new System.Drawing.Size(291, 20);
            this.autoEncBackupMode.TabIndex = 88;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 332);
            this.label16.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 12);
            this.label16.TabIndex = 87;
            this.label16.Text = "Auto-Encode Backups";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Silver;
            this.label74.Location = new System.Drawing.Point(359, 92);
            this.label74.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(523, 12);
            this.label74.TabIndex = 86;
            this.label74.Text = "Makes frame extraction faster and take up less disk space with no visible quality" +
    " reduction.";
            // 
            // jpegFrames
            // 
            this.jpegFrames.AutoSize = true;
            this.jpegFrames.Location = new System.Drawing.Point(327, 92);
            this.jpegFrames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jpegFrames.Name = "jpegFrames";
            this.jpegFrames.Size = new System.Drawing.Size(15, 14);
            this.jpegFrames.TabIndex = 85;
            this.jpegFrames.UseVisualStyleBackColor = true;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(12, 92);
            this.label63.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(199, 12);
            this.label63.TabIndex = 84;
            this.label63.Text = "Import HQ JPEGs instead of PNGs";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 138);
            this.label18.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 16);
            this.label18.TabIndex = 82;
            this.label18.Text = "Interpolation Helpers";
            // 
            // keepMeta
            // 
            this.keepMeta.AutoSize = true;
            this.keepMeta.Location = new System.Drawing.Point(545, 36);
            this.keepMeta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.keepMeta.Name = "keepMeta";
            this.keepMeta.Size = new System.Drawing.Size(150, 16);
            this.keepMeta.TabIndex = 81;
            this.keepMeta.Text = "Keep Metadata (MKV)";
            this.keepMeta.UseVisualStyleBackColor = true;
            // 
            // sceneChangeFillMode
            // 
            this.sceneChangeFillMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sceneChangeFillMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sceneChangeFillMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sceneChangeFillMode.ForeColor = System.Drawing.Color.White;
            this.sceneChangeFillMode.FormattingEnabled = true;
            this.sceneChangeFillMode.Items.AddRange(new object[] {
            "Basic (Duplicate Previous Frame)",
            "Fancy (Blend To Next Scene)"});
            this.sceneChangeFillMode.Location = new System.Drawing.Point(327, 246);
            this.sceneChangeFillMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sceneChangeFillMode.Name = "sceneChangeFillMode";
            this.sceneChangeFillMode.Size = new System.Drawing.Size(291, 20);
            this.sceneChangeFillMode.TabIndex = 80;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(12, 249);
            this.label71.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(146, 12);
            this.label71.TabIndex = 79;
            this.label71.Text = "Scene Change Fix Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(359, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 12);
            this.label4.TabIndex = 78;
            this.label4.Text = "Enables Transparency (Alpha) support for GIFs and PNG input";
            // 
            // enableAlpha
            // 
            this.enableAlpha.AutoSize = true;
            this.enableAlpha.Location = new System.Drawing.Point(327, 65);
            this.enableAlpha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enableAlpha.Name = "enableAlpha";
            this.enableAlpha.Size = new System.Drawing.Size(15, 14);
            this.enableAlpha.TabIndex = 77;
            this.enableAlpha.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 65);
            this.label25.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(215, 12);
            this.label25.TabIndex = 76;
            this.label25.Text = "Enable Transparency (Experimental)";
            // 
            // keepSubs
            // 
            this.keepSubs.AutoSize = true;
            this.keepSubs.Location = new System.Drawing.Point(428, 36);
            this.keepSubs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.keepSubs.Name = "keepSubs";
            this.keepSubs.Size = new System.Drawing.Size(105, 16);
            this.keepSubs.TabIndex = 75;
            this.keepSubs.Text = "Keep Subtitles";
            this.keepSubs.UseVisualStyleBackColor = true;
            // 
            // scnDetectValue
            // 
            this.scnDetectValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scnDetectValue.DecimalPlaces = 2;
            this.scnDetectValue.ForeColor = System.Drawing.Color.White;
            this.scnDetectValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.scnDetectValue.Location = new System.Drawing.Point(425, 220);
            this.scnDetectValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scnDetectValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.scnDetectValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.scnDetectValue.Name = "scnDetectValue";
            this.scnDetectValue.Size = new System.Drawing.Size(117, 21);
            this.scnDetectValue.TabIndex = 74;
            this.scnDetectValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // sbsAllowAutoEnc
            // 
            this.sbsAllowAutoEnc.AutoSize = true;
            this.sbsAllowAutoEnc.Location = new System.Drawing.Point(327, 305);
            this.sbsAllowAutoEnc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sbsAllowAutoEnc.Name = "sbsAllowAutoEnc";
            this.sbsAllowAutoEnc.Size = new System.Drawing.Size(15, 14);
            this.sbsAllowAutoEnc.TabIndex = 72;
            this.sbsAllowAutoEnc.UseVisualStyleBackColor = true;
            // 
            // dedupeSensLabel
            // 
            this.dedupeSensLabel.AutoSize = true;
            this.dedupeSensLabel.Location = new System.Drawing.Point(625, 167);
            this.dedupeSensLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dedupeSensLabel.Name = "dedupeSensLabel";
            this.dedupeSensLabel.Size = new System.Drawing.Size(66, 12);
            this.dedupeSensLabel.TabIndex = 29;
            this.dedupeSensLabel.Text = "Sensitivity:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(12, 305);
            this.label53.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(245, 12);
            this.label53.TabIndex = 71;
            this.label53.Text = "Allow Auto-Encode in Step-By-Step Mode";
            // 
            // autoEncMode
            // 
            this.autoEncMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoEncMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoEncMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoEncMode.ForeColor = System.Drawing.Color.White;
            this.autoEncMode.FormattingEnabled = true;
            this.autoEncMode.Items.AddRange(new object[] {
            "Disabled",
            "Enabled (Keep Interpolated Frames)",
            "Enabled (Delete Frames Once Encoded)"});
            this.autoEncMode.Location = new System.Drawing.Point(327, 274);
            this.autoEncMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoEncMode.Name = "autoEncMode";
            this.autoEncMode.Size = new System.Drawing.Size(291, 20);
            this.autoEncMode.TabIndex = 70;
            this.autoEncMode.SelectedIndexChanged += new System.EventHandler(this.autoEncMode_SelectedIndexChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(12, 277);
            this.label49.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(242, 12);
            this.label49.TabIndex = 69;
            this.label49.Text = "Auto-Encode (Encode While Interpolating)";
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Location = new System.Drawing.Point(554, 219);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(24, 19);
            this.panel14.TabIndex = 68;
            this.toolTip1.SetToolTip(this.panel14, "Allows custom input.");
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.Color.Silver;
            this.label52.Location = new System.Drawing.Point(594, 223);
            this.label52.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(271, 12);
            this.label52.TabIndex = 67;
            this.label52.Text = "Lower values will detect more scene changes.";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(351, 222);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(66, 12);
            this.label51.TabIndex = 66;
            this.label51.Text = "Sensitivity:";
            // 
            // scnDetect
            // 
            this.scnDetect.AutoSize = true;
            this.scnDetect.Location = new System.Drawing.Point(327, 222);
            this.scnDetect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scnDetect.Name = "scnDetect";
            this.scnDetect.Size = new System.Drawing.Size(15, 14);
            this.scnDetect.TabIndex = 64;
            this.scnDetect.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(12, 222);
            this.label50.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(157, 12);
            this.label50.TabIndex = 63;
            this.label50.Text = "Fix Scene Changes (Cuts)";
            // 
            // mpDedupePanel
            // 
            this.mpDedupePanel.Controls.Add(this.mpdecimateMode);
            this.mpDedupePanel.Location = new System.Drawing.Point(699, 163);
            this.mpDedupePanel.Margin = new System.Windows.Forms.Padding(0);
            this.mpDedupePanel.Name = "mpDedupePanel";
            this.mpDedupePanel.Size = new System.Drawing.Size(158, 19);
            this.mpDedupePanel.TabIndex = 61;
            // 
            // mpdecimateMode
            // 
            this.mpdecimateMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mpdecimateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mpdecimateMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpdecimateMode.ForeColor = System.Drawing.Color.White;
            this.mpdecimateMode.FormattingEnabled = true;
            this.mpdecimateMode.Items.AddRange(new object[] {
            "Normal",
            "Aggressive"});
            this.mpdecimateMode.Location = new System.Drawing.Point(0, 0);
            this.mpdecimateMode.Margin = new System.Windows.Forms.Padding(4, 3, 9, 3);
            this.mpdecimateMode.Name = "mpdecimateMode";
            this.mpdecimateMode.Size = new System.Drawing.Size(157, 20);
            this.mpdecimateMode.TabIndex = 28;
            // 
            // magickDedupePanel
            // 
            this.magickDedupePanel.Controls.Add(this.dedupThresh);
            this.magickDedupePanel.Controls.Add(this.panel3);
            this.magickDedupePanel.Location = new System.Drawing.Point(699, 163);
            this.magickDedupePanel.Margin = new System.Windows.Forms.Padding(0);
            this.magickDedupePanel.Name = "magickDedupePanel";
            this.magickDedupePanel.Size = new System.Drawing.Size(158, 19);
            this.magickDedupePanel.TabIndex = 60;
            // 
            // dedupThresh
            // 
            this.dedupThresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dedupThresh.DecimalPlaces = 1;
            this.dedupThresh.ForeColor = System.Drawing.Color.White;
            this.dedupThresh.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.dedupThresh.Location = new System.Drawing.Point(0, 1);
            this.dedupThresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dedupThresh.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dedupThresh.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.dedupThresh.Name = "dedupThresh";
            this.dedupThresh.Size = new System.Drawing.Size(120, 21);
            this.dedupThresh.TabIndex = 75;
            this.dedupThresh.Tag = "";
            this.dedupThresh.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(133, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 19);
            this.panel3.TabIndex = 57;
            this.toolTip1.SetToolTip(this.panel3, "Allows custom input.");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 9);
            this.label24.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 16);
            this.label24.TabIndex = 44;
            this.label24.Text = "Input Media";
            // 
            // enableLoop
            // 
            this.enableLoop.AutoSize = true;
            this.enableLoop.Location = new System.Drawing.Point(327, 194);
            this.enableLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enableLoop.Name = "enableLoop";
            this.enableLoop.Size = new System.Drawing.Size(15, 14);
            this.enableLoop.TabIndex = 31;
            this.enableLoop.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 194);
            this.label15.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(262, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "Loop Interpolation (Copy First Frame To End)";
            // 
            // dedupMode
            // 
            this.dedupMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dedupMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dedupMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dedupMode.ForeColor = System.Drawing.Color.White;
            this.dedupMode.FormattingEnabled = true;
            this.dedupMode.Items.AddRange(new object[] {
            "Disabled",
            "1: After Extraction - Slow, Accurate",
            "2: During Extraction - Fast, Less Accurate"});
            this.dedupMode.Location = new System.Drawing.Point(327, 163);
            this.dedupMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dedupMode.Name = "dedupMode";
            this.dedupMode.Size = new System.Drawing.Size(291, 20);
            this.dedupMode.TabIndex = 27;
            this.dedupMode.SelectedIndexChanged += new System.EventHandler(this.dedupMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Frame De-Duplication Mode";
            // 
            // keepAudio
            // 
            this.keepAudio.AutoSize = true;
            this.keepAudio.Location = new System.Drawing.Point(327, 36);
            this.keepAudio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.keepAudio.Name = "keepAudio";
            this.keepAudio.Size = new System.Drawing.Size(89, 16);
            this.keepAudio.TabIndex = 25;
            this.keepAudio.Text = "Keep Audio";
            this.keepAudio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "Input Media To Preserve";
            // 
            // aiOptsPage
            // 
            this.aiOptsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.aiOptsPage.Controls.Add(this.label66);
            this.aiOptsPage.Controls.Add(this.rifeCudaFp16);
            this.aiOptsPage.Controls.Add(this.label65);
            this.aiOptsPage.Controls.Add(this.label35);
            this.aiOptsPage.Controls.Add(this.panel12);
            this.aiOptsPage.Controls.Add(this.dainNcnnTilesize);
            this.aiOptsPage.Controls.Add(this.label27);
            this.aiOptsPage.Controls.Add(this.label26);
            this.aiOptsPage.Controls.Add(this.ncnnThreads);
            this.aiOptsPage.Controls.Add(this.label30);
            this.aiOptsPage.Controls.Add(this.panel6);
            this.aiOptsPage.Controls.Add(this.uhdThresh);
            this.aiOptsPage.Controls.Add(this.label29);
            this.aiOptsPage.Controls.Add(this.label28);
            this.aiOptsPage.Controls.Add(this.label44);
            this.aiOptsPage.Controls.Add(this.label43);
            this.aiOptsPage.Controls.Add(this.panel2);
            this.aiOptsPage.Controls.Add(this.panel1);
            this.aiOptsPage.Controls.Add(this.torchGpus);
            this.aiOptsPage.Controls.Add(this.label33);
            this.aiOptsPage.Controls.Add(this.ncnnGpus);
            this.aiOptsPage.Controls.Add(this.label5);
            this.aiOptsPage.Controls.Add(this.label32);
            this.aiOptsPage.ForeColor = System.Drawing.Color.White;
            this.aiOptsPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aiOptsPage.Name = "aiOptsPage";
            this.aiOptsPage.Size = new System.Drawing.Size(948, 386);
            this.aiOptsPage.Text = "AI Specific Options";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.Color.Silver;
            this.label66.Location = new System.Drawing.Point(359, 195);
            this.label66.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(544, 12);
            this.label66.TabIndex = 83;
            this.label66.Text = "Faster, uses less VRAM, but can cause glitches and flickering, especially on RIFE" +
    " 3.x models.";
            // 
            // rifeCudaFp16
            // 
            this.rifeCudaFp16.AutoSize = true;
            this.rifeCudaFp16.Location = new System.Drawing.Point(327, 194);
            this.rifeCudaFp16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rifeCudaFp16.Name = "rifeCudaFp16";
            this.rifeCudaFp16.Size = new System.Drawing.Size(15, 14);
            this.rifeCudaFp16.TabIndex = 82;
            this.rifeCudaFp16.UseVisualStyleBackColor = true;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(13, 194);
            this.label65.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(198, 12);
            this.label65.TabIndex = 81;
            this.label65.Text = "Half-Precision Mode (CUDA Only)";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Silver;
            this.label35.Location = new System.Drawing.Point(481, 269);
            this.label35.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(308, 12);
            this.label35.TabIndex = 80;
            this.label35.Text = "Lower values decrease VRAM usage but also speed.";
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(441, 265);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(24, 19);
            this.panel12.TabIndex = 78;
            this.toolTip1.SetToolTip(this.panel12, "Allows custom input.");
            // 
            // dainNcnnTilesize
            // 
            this.dainNcnnTilesize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dainNcnnTilesize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dainNcnnTilesize.ForeColor = System.Drawing.Color.White;
            this.dainNcnnTilesize.FormattingEnabled = true;
            this.dainNcnnTilesize.Items.AddRange(new object[] {
            "256",
            "384",
            "512",
            "768",
            "1024",
            "1536",
            "2048"});
            this.dainNcnnTilesize.Location = new System.Drawing.Point(327, 265);
            this.dainNcnnTilesize.Margin = new System.Windows.Forms.Padding(4, 3, 9, 3);
            this.dainNcnnTilesize.Name = "dainNcnnTilesize";
            this.dainNcnnTilesize.Size = new System.Drawing.Size(101, 20);
            this.dainNcnnTilesize.TabIndex = 79;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 268);
            this.label27.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 12);
            this.label27.TabIndex = 77;
            this.label27.Text = "Tile Size (Splitting)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(12, 240);
            this.label26.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(151, 16);
            this.label26.TabIndex = 76;
            this.label26.Text = "DAIN-NCNN Settings";
            // 
            // ncnnThreads
            // 
            this.ncnnThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ncnnThreads.ForeColor = System.Drawing.Color.White;
            this.ncnnThreads.Location = new System.Drawing.Point(327, 90);
            this.ncnnThreads.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ncnnThreads.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ncnnThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ncnnThreads.Name = "ncnnThreads";
            this.ncnnThreads.Size = new System.Drawing.Size(90, 21);
            this.ncnnThreads.TabIndex = 75;
            this.ncnnThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Silver;
            this.label30.Location = new System.Drawing.Point(481, 167);
            this.label30.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(420, 12);
            this.label30.TabIndex = 67;
            this.label30.Text = "Minimum height to enable UHD mode which helps high-res interpolations";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(441, 163);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 19);
            this.panel6.TabIndex = 65;
            this.toolTip1.SetToolTip(this.panel6, "Allows custom input.");
            // 
            // uhdThresh
            // 
            this.uhdThresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uhdThresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uhdThresh.ForeColor = System.Drawing.Color.White;
            this.uhdThresh.FormattingEnabled = true;
            this.uhdThresh.Items.AddRange(new object[] {
            "4320",
            "2160",
            "1440",
            "1080",
            "720"});
            this.uhdThresh.Location = new System.Drawing.Point(327, 163);
            this.uhdThresh.Margin = new System.Windows.Forms.Padding(4, 3, 9, 3);
            this.uhdThresh.Name = "uhdThresh";
            this.uhdThresh.Size = new System.Drawing.Size(101, 20);
            this.uhdThresh.TabIndex = 66;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 166);
            this.label29.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(175, 12);
            this.label29.TabIndex = 62;
            this.label29.Text = "UHD Mode Threshold (Height)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(12, 138);
            this.label28.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 16);
            this.label28.TabIndex = 61;
            this.label28.Text = "RIFE Settings";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.Silver;
            this.label44.Location = new System.Drawing.Point(432, 93);
            this.label44.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(430, 12);
            this.label44.TabIndex = 60;
            this.label44.Text = "Use 1 for small videos, 2 for >1080p, higher values might cause slowdown!";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(12, 92);
            this.label43.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(160, 12);
            this.label43.TabIndex = 58;
            this.label43.Text = "NCNN Processing Threads";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(625, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 19);
            this.panel2.TabIndex = 57;
            this.toolTip1.SetToolTip(this.panel2, "Allows custom input.");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(625, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 19);
            this.panel1.TabIndex = 56;
            this.toolTip1.SetToolTip(this.panel1, "Allows custom input.");
            // 
            // torchGpus
            // 
            this.torchGpus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.torchGpus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torchGpus.ForeColor = System.Drawing.Color.White;
            this.torchGpus.FormattingEnabled = true;
            this.torchGpus.Items.AddRange(new object[] {
            "0",
            "1",
            "0,1"});
            this.torchGpus.Location = new System.Drawing.Point(327, 34);
            this.torchGpus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.torchGpus.Name = "torchGpus";
            this.torchGpus.Size = new System.Drawing.Size(291, 20);
            this.torchGpus.TabIndex = 55;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 37);
            this.label33.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(245, 12);
            this.label33.TabIndex = 54;
            this.label33.Text = "Pytorch GPU IDs (For Multi GPU Systems)";
            // 
            // ncnnGpus
            // 
            this.ncnnGpus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ncnnGpus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ncnnGpus.ForeColor = System.Drawing.Color.White;
            this.ncnnGpus.FormattingEnabled = true;
            this.ncnnGpus.Items.AddRange(new object[] {
            "0",
            "1",
            "0,1"});
            this.ncnnGpus.Location = new System.Drawing.Point(327, 62);
            this.ncnnGpus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ncnnGpus.Name = "ncnnGpus";
            this.ncnnGpus.Size = new System.Drawing.Size(291, 20);
            this.ncnnGpus.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "NCNN GPU IDs (For Multi GPU Systems)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(12, 9);
            this.label32.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(161, 16);
            this.label32.TabIndex = 51;
            this.label32.Text = "AI Framework Settings";
            // 
            // vidExportTab
            // 
            this.vidExportTab.AutoScroll = true;
            this.vidExportTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.vidExportTab.Controls.Add(this.label73);
            this.vidExportTab.Controls.Add(this.fixOutputDuration);
            this.vidExportTab.Controls.Add(this.label72);
            this.vidExportTab.Controls.Add(this.minOutVidLength);
            this.vidExportTab.Controls.Add(this.loopMode);
            this.vidExportTab.Controls.Add(this.label55);
            this.vidExportTab.Controls.Add(this.panel8);
            this.vidExportTab.Controls.Add(this.panel7);
            this.vidExportTab.Controls.Add(this.label22);
            this.vidExportTab.Controls.Add(this.maxFps);
            this.vidExportTab.Controls.Add(this.label20);
            this.vidExportTab.Controls.Add(this.label21);
            this.vidExportTab.Controls.Add(this.label9);
            this.vidExportTab.Controls.Add(this.label8);
            this.vidExportTab.ForeColor = System.Drawing.Color.White;
            this.vidExportTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vidExportTab.Name = "vidExportTab";
            this.vidExportTab.Size = new System.Drawing.Size(913, 386);
            this.vidExportTab.Text = "Export Options";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.ForeColor = System.Drawing.Color.Silver;
            this.label73.Location = new System.Drawing.Point(359, 120);
            this.label73.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(388, 12);
            this.label73.TabIndex = 84;
            this.label73.Text = "Repeats the last frame so the output is exactly as long as the input.";
            // 
            // fixOutputDuration
            // 
            this.fixOutputDuration.AutoSize = true;
            this.fixOutputDuration.Location = new System.Drawing.Point(327, 120);
            this.fixOutputDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fixOutputDuration.Name = "fixOutputDuration";
            this.fixOutputDuration.Size = new System.Drawing.Size(15, 14);
            this.fixOutputDuration.TabIndex = 83;
            this.fixOutputDuration.UseVisualStyleBackColor = true;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(12, 120);
            this.label72.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(196, 12);
            this.label72.TabIndex = 76;
            this.label72.Text = "Make Output Match Input Duration";
            // 
            // minOutVidLength
            // 
            this.minOutVidLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minOutVidLength.ForeColor = System.Drawing.Color.White;
            this.minOutVidLength.Location = new System.Drawing.Point(327, 34);
            this.minOutVidLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minOutVidLength.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minOutVidLength.Name = "minOutVidLength";
            this.minOutVidLength.Size = new System.Drawing.Size(117, 21);
            this.minOutVidLength.TabIndex = 75;
            this.minOutVidLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // loopMode
            // 
            this.loopMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loopMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loopMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopMode.ForeColor = System.Drawing.Color.White;
            this.loopMode.FormattingEnabled = true;
            this.loopMode.Items.AddRange(new object[] {
            "Only Save Looped Video",
            "Save Both Original And Looped Video"});
            this.loopMode.Location = new System.Drawing.Point(327, 62);
            this.loopMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loopMode.Name = "loopMode";
            this.loopMode.Size = new System.Drawing.Size(466, 20);
            this.loopMode.TabIndex = 62;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(12, 65);
            this.label55.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(193, 12);
            this.label55.TabIndex = 61;
            this.label55.Text = "Minimum Length Encoding Mode";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(450, 90);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(24, 19);
            this.panel8.TabIndex = 60;
            this.toolTip1.SetToolTip(this.panel8, "Allows custom input.");
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Flowframes.Properties.Resources.baseline_create_white_18dp_semiTransparent;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(450, 34);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(24, 19);
            this.panel7.TabIndex = 59;
            this.toolTip1.SetToolTip(this.panel7, "Allows custom input.");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Silver;
            this.label22.Location = new System.Drawing.Point(490, 93);
            this.label22.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(361, 12);
            this.label22.TabIndex = 48;
            this.label22.Text = "Limit the final output video to this FPS. Leave empty to disable.";
            // 
            // maxFps
            // 
            this.maxFps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxFps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxFps.ForeColor = System.Drawing.Color.White;
            this.maxFps.FormattingEnabled = true;
            this.maxFps.Items.AddRange(new object[] {
            "0",
            "30",
            "60",
            "120"});
            this.maxFps.Location = new System.Drawing.Point(327, 90);
            this.maxFps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxFps.Name = "maxFps";
            this.maxFps.Size = new System.Drawing.Size(116, 20);
            this.maxFps.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 92);
            this.label20.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(171, 12);
            this.label20.TabIndex = 46;
            this.label20.Text = "Maximum Output Frame Rate";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(226, 16);
            this.label21.TabIndex = 45;
            this.label21.Text = "Length And Frame Rate Options";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(490, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(375, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "Output will be looped until it meets the specified minimum length.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "Minimum Loop Video Length (Seconds)";
            // 
            // tabListPage1
            // 
            this.tabListPage1.Controls.Add(this.imgSeqQuality);
            this.tabListPage1.Controls.Add(this.pixFmt);
            this.tabListPage1.Controls.Add(this.label75);
            this.tabListPage1.Controls.Add(this.label13);
            this.tabListPage1.Controls.Add(this.vp9Crf);
            this.tabListPage1.Controls.Add(this.mp4Crf);
            this.tabListPage1.Controls.Add(this.imgSeqFormat);
            this.tabListPage1.Controls.Add(this.label40);
            this.tabListPage1.Controls.Add(this.gifDitherType);
            this.tabListPage1.Controls.Add(this.aviColors);
            this.tabListPage1.Controls.Add(this.aviCodec);
            this.tabListPage1.Controls.Add(this.label60);
            this.tabListPage1.Controls.Add(this.proResProfile);
            this.tabListPage1.Controls.Add(this.label59);
            this.tabListPage1.Controls.Add(this.label57);
            this.tabListPage1.Controls.Add(this.label19);
            this.tabListPage1.Controls.Add(this.gifColors);
            this.tabListPage1.Controls.Add(this.label17);
            this.tabListPage1.Controls.Add(this.label14);
            this.tabListPage1.Controls.Add(this.label12);
            this.tabListPage1.Controls.Add(this.mp4Enc);
            this.tabListPage1.Controls.Add(this.label10);
            this.tabListPage1.ForeColor = System.Drawing.Color.White;
            this.tabListPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabListPage1.Name = "tabListPage1";
            this.tabListPage1.Size = new System.Drawing.Size(913, 386);
            this.tabListPage1.Text = "Encoding Settings";
            // 
            // imgSeqQuality
            // 
            this.imgSeqQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imgSeqQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgSeqQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgSeqQuality.ForeColor = System.Drawing.Color.White;
            this.imgSeqQuality.FormattingEnabled = true;
            this.imgSeqQuality.Items.AddRange(new object[] {
            "Maximum Quality",
            "High Quality",
            "Medium Quality",
            "Low Quality",
            "Lowest Quality"});
            this.imgSeqQuality.Location = new System.Drawing.Point(567, 228);
            this.imgSeqQuality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgSeqQuality.Name = "imgSeqQuality";
            this.imgSeqQuality.Size = new System.Drawing.Size(226, 20);
            this.imgSeqQuality.TabIndex = 116;
            // 
            // pixFmt
            // 
            this.pixFmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pixFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pixFmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pixFmt.ForeColor = System.Drawing.Color.White;
            this.pixFmt.FormattingEnabled = true;
            this.pixFmt.Items.AddRange(new object[] {
            "yuv420p (8-Bit Color, 4:2:0 Sampling - Recommended)",
            "yuv444p (8-Bit Color, 4:4:4 Sampling - May not work with some encoders!)",
            "yuv420p10le (10-Bit Color, 4:2:0 Sampling - May not work with some encoders!)",
            "yuv444p10le (10-Bit Color, 4:4:4 Sampling - May not work with some encoders!)"});
            this.pixFmt.Location = new System.Drawing.Point(327, 117);
            this.pixFmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pixFmt.Name = "pixFmt";
            this.pixFmt.Size = new System.Drawing.Size(466, 20);
            this.pixFmt.TabIndex = 115;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(12, 120);
            this.label75.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(221, 12);
            this.label75.TabIndex = 114;
            this.label75.Text = "MP4/MKV/WEBM/MOV: Color Format";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(458, 93);
            this.label13.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 12);
            this.label13.TabIndex = 113;
            this.label13.Text = "Lower means higher quality and bigger filesize.";
            // 
            // vp9Crf
            // 
            this.vp9Crf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vp9Crf.ForeColor = System.Drawing.Color.White;
            this.vp9Crf.Location = new System.Drawing.Point(327, 90);
            this.vp9Crf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vp9Crf.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.vp9Crf.Name = "vp9Crf";
            this.vp9Crf.Size = new System.Drawing.Size(117, 21);
            this.vp9Crf.TabIndex = 112;
            this.vp9Crf.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // mp4Crf
            // 
            this.mp4Crf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mp4Crf.ForeColor = System.Drawing.Color.White;
            this.mp4Crf.Location = new System.Drawing.Point(327, 63);
            this.mp4Crf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mp4Crf.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.mp4Crf.Name = "mp4Crf";
            this.mp4Crf.Size = new System.Drawing.Size(117, 21);
            this.mp4Crf.TabIndex = 111;
            this.mp4Crf.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // imgSeqFormat
            // 
            this.imgSeqFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imgSeqFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgSeqFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgSeqFormat.ForeColor = System.Drawing.Color.White;
            this.imgSeqFormat.FormattingEnabled = true;
            this.imgSeqFormat.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "WEBP"});
            this.imgSeqFormat.Location = new System.Drawing.Point(327, 228);
            this.imgSeqFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgSeqFormat.Name = "imgSeqFormat";
            this.imgSeqFormat.Size = new System.Drawing.Size(233, 20);
            this.imgSeqFormat.TabIndex = 110;
            this.imgSeqFormat.SelectedIndexChanged += new System.EventHandler(this.imgSeqFormat_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 231);
            this.label40.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(187, 12);
            this.label40.TabIndex = 109;
            this.label40.Text = "Image Sequence: Image Format";
            // 
            // gifDitherType
            // 
            this.gifDitherType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gifDitherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gifDitherType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gifDitherType.ForeColor = System.Drawing.Color.White;
            this.gifDitherType.FormattingEnabled = true;
            this.gifDitherType.Items.AddRange(new object[] {
            "bayer (Recommended)",
            "floyd_steinberg (Might cause problems with transparency)",
            "none (Strong banding, but better for flat colors)"});
            this.gifDitherType.Location = new System.Drawing.Point(450, 200);
            this.gifDitherType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gifDitherType.Name = "gifDitherType";
            this.gifDitherType.Size = new System.Drawing.Size(342, 20);
            this.gifDitherType.TabIndex = 108;
            // 
            // aviColors
            // 
            this.aviColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aviColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aviColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aviColors.ForeColor = System.Drawing.Color.White;
            this.aviColors.FormattingEnabled = true;
            this.aviColors.Items.AddRange(new object[] {
            "yuv420p",
            "yuv422p",
            "yuv444p",
            "rgb24"});
            this.aviColors.Location = new System.Drawing.Point(567, 173);
            this.aviColors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aviColors.Name = "aviColors";
            this.aviColors.Size = new System.Drawing.Size(226, 20);
            this.aviColors.TabIndex = 107;
            // 
            // aviCodec
            // 
            this.aviCodec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aviCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aviCodec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aviCodec.ForeColor = System.Drawing.Color.White;
            this.aviCodec.FormattingEnabled = true;
            this.aviCodec.Items.AddRange(new object[] {
            "ffv1",
            "huffyuv",
            "magicyuv",
            "rawvideo"});
            this.aviCodec.Location = new System.Drawing.Point(327, 173);
            this.aviCodec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aviCodec.Name = "aviCodec";
            this.aviCodec.Size = new System.Drawing.Size(233, 20);
            this.aviCodec.TabIndex = 106;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(12, 175);
            this.label60.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(156, 12);
            this.label60.TabIndex = 105;
            this.label60.Text = "AVI: Codec / Color Format";
            // 
            // proResProfile
            // 
            this.proResProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proResProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proResProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proResProfile.ForeColor = System.Drawing.Color.White;
            this.proResProfile.FormattingEnabled = true;
            this.proResProfile.Items.AddRange(new object[] {
            "0 (Proxy)",
            "1 (LT)",
            "2 (Standard)",
            "3 (HQ)",
            "4 (4444)",
            "5 (4444xq)"});
            this.proResProfile.Location = new System.Drawing.Point(327, 145);
            this.proResProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.proResProfile.Name = "proResProfile";
            this.proResProfile.Size = new System.Drawing.Size(466, 20);
            this.proResProfile.TabIndex = 104;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(12, 148);
            this.label59.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(164, 12);
            this.label59.TabIndex = 103;
            this.label59.Text = "MOV: ProRes Quality Profile";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(12, 92);
            this.label57.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(205, 12);
            this.label57.TabIndex = 99;
            this.label57.Text = "WEBM: Quality Level (CRF) for VP9";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 16);
            this.label19.TabIndex = 96;
            this.label19.Text = "Encoding Options";
            // 
            // gifColors
            // 
            this.gifColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gifColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gifColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gifColors.ForeColor = System.Drawing.Color.White;
            this.gifColors.FormattingEnabled = true;
            this.gifColors.Items.AddRange(new object[] {
            "256 (Max)",
            "128 (High)",
            "64 (Medium)",
            "32 (Low)",
            "16 (Very Low)"});
            this.gifColors.Location = new System.Drawing.Point(327, 200);
            this.gifColors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gifColors.Name = "gifColors";
            this.gifColors.Size = new System.Drawing.Size(116, 20);
            this.gifColors.TabIndex = 95;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 203);
            this.label17.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(205, 12);
            this.label17.TabIndex = 94;
            this.label17.Text = "GIF: Color Amount / Dithering Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(458, 66);
            this.label14.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(275, 12);
            this.label14.TabIndex = 92;
            this.label14.Text = "Lower means higher quality and bigger filesize.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(308, 12);
            this.label12.TabIndex = 88;
            this.label12.Text = "MP4/MKV: Quality Level (CRF) For Selected Encoder";
            // 
            // mp4Enc
            // 
            this.mp4Enc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mp4Enc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mp4Enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mp4Enc.ForeColor = System.Drawing.Color.White;
            this.mp4Enc.FormattingEnabled = true;
            this.mp4Enc.Items.AddRange(new object[] {
            "h264 - Fast, good compatibility, medium quality per filesize",
            "h265 - Slower, mixed compatibility, very good quality per filesize",
            "h264 NVENC - Fast GPU-accelerated encoding, worse compression than h264",
            "h265 NVENC - Fast GPU-accelerated encoding, worse compression than h265",
            "AV1 - Experimental, very slow, but most efficient compression"});
            this.mp4Enc.Location = new System.Drawing.Point(327, 34);
            this.mp4Enc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mp4Enc.Name = "mp4Enc";
            this.mp4Enc.Size = new System.Drawing.Size(466, 20);
            this.mp4Enc.TabIndex = 87;
            this.mp4Enc.SelectedIndexChanged += new System.EventHandler(this.mp4Enc_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 12);
            this.label10.TabIndex = 86;
            this.label10.Text = "MP4/MKV: Video Encoder";
            // 
            // debugTab
            // 
            this.debugTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.debugTab.Controls.Add(this.label7);
            this.debugTab.Controls.Add(this.serverCombox);
            this.debugTab.Controls.Add(this.ffEncArgs);
            this.debugTab.Controls.Add(this.label56);
            this.debugTab.Controls.Add(this.label54);
            this.debugTab.Controls.Add(this.ffEncPreset);
            this.debugTab.Controls.Add(this.label47);
            this.debugTab.Controls.Add(this.label46);
            this.debugTab.Controls.Add(this.label45);
            this.debugTab.Controls.Add(this.label3);
            this.debugTab.Controls.Add(this.cmdDebugMode);
            this.debugTab.ForeColor = System.Drawing.Color.White;
            this.debugTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(913, 386);
            this.debugTab.Text = "Developer Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 12);
            this.label7.TabIndex = 87;
            this.label7.Text = "Model Download Server";
            // 
            // serverCombox
            // 
            this.serverCombox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serverCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverCombox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverCombox.ForeColor = System.Drawing.Color.White;
            this.serverCombox.FormattingEnabled = true;
            this.serverCombox.Items.AddRange(new object[] {
            "Very Fast",
            "Faster",
            "Fast",
            "Medium",
            "Slow",
            "Slower",
            "Very Slow"});
            this.serverCombox.Location = new System.Drawing.Point(327, 62);
            this.serverCombox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serverCombox.Name = "serverCombox";
            this.serverCombox.Size = new System.Drawing.Size(291, 20);
            this.serverCombox.TabIndex = 86;
            // 
            // ffEncArgs
            // 
            this.ffEncArgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ffEncArgs.ForeColor = System.Drawing.Color.White;
            this.ffEncArgs.Location = new System.Drawing.Point(327, 166);
            this.ffEncArgs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ffEncArgs.MinimumSize = new System.Drawing.Size(4, 21);
            this.ffEncArgs.Name = "ffEncArgs";
            this.ffEncArgs.Size = new System.Drawing.Size(466, 21);
            this.ffEncArgs.TabIndex = 85;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(12, 169);
            this.label56.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(175, 12);
            this.label56.TabIndex = 84;
            this.label56.Text = "Additional (Output) Arguments";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.Color.Silver;
            this.label54.Location = new System.Drawing.Point(634, 142);
            this.label54.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(142, 12);
            this.label54.TabIndex = 82;
            this.label54.Text = "Slower is more efficient.\r\n";
            // 
            // ffEncPreset
            // 
            this.ffEncPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ffEncPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ffEncPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ffEncPreset.ForeColor = System.Drawing.Color.White;
            this.ffEncPreset.FormattingEnabled = true;
            this.ffEncPreset.Items.AddRange(new object[] {
            "Very Fast",
            "Faster",
            "Fast",
            "Medium",
            "Slow",
            "Slower",
            "Very Slow"});
            this.ffEncPreset.Location = new System.Drawing.Point(327, 138);
            this.ffEncPreset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ffEncPreset.Name = "ffEncPreset";
            this.ffEncPreset.Size = new System.Drawing.Size(291, 20);
            this.ffEncPreset.TabIndex = 78;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(12, 141);
            this.label47.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(208, 12);
            this.label47.TabIndex = 77;
            this.label47.Text = "Encoding Preset (Speed vs Quality)";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(12, 111);
            this.label46.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(64, 16);
            this.label46.TabIndex = 76;
            this.label46.Text = "FFmpeg";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(12, 9);
            this.label45.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(62, 16);
            this.label45.TabIndex = 75;
            this.label45.Text = "General";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 9, 12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Show Hidden CMD Windows ";
            // 
            // cmdDebugMode
            // 
            this.cmdDebugMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdDebugMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdDebugMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDebugMode.ForeColor = System.Drawing.Color.White;
            this.cmdDebugMode.FormattingEnabled = true;
            this.cmdDebugMode.Items.AddRange(new object[] {
            "No",
            "Yes, Close After Execution",
            "Yes, Keep Open After Process Has Exited"});
            this.cmdDebugMode.Location = new System.Drawing.Point(327, 34);
            this.cmdDebugMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdDebugMode.Name = "cmdDebugMode";
            this.cmdDebugMode.Size = new System.Drawing.Size(291, 20);
            this.cmdDebugMode.TabIndex = 27;
            this.cmdDebugMode.SelectedIndexChanged += new System.EventHandler(this.cmdDebugMode_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(14, 8);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(119, 40);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Settings";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.resetBtn.ButtonImage = global::Flowframes.Properties.Resources.baseline_restart_alt_white_48dp;
            this.resetBtn.DrawImage = true;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.ImageIndex = 0;
            this.resetBtn.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Zoom;
            this.resetBtn.Location = new System.Drawing.Point(1037, 11);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(47, 37);
            this.resetBtn.TabIndex = 39;
            this.toolTip1.SetToolTip(this.resetBtn, "Reset To Default");
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1133, 462);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.settingsTabList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flowframes Settings ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settingsTabList.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info1)).EndInit();
            this.tabListPage2.ResumeLayout(false);
            this.tabListPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scnDetectValue)).EndInit();
            this.mpDedupePanel.ResumeLayout(false);
            this.magickDedupePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dedupThresh)).EndInit();
            this.aiOptsPage.ResumeLayout(false);
            this.aiOptsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncnnThreads)).EndInit();
            this.vidExportTab.ResumeLayout(false);
            this.vidExportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minOutVidLength)).EndInit();
            this.tabListPage1.ResumeLayout(false);
            this.tabListPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vp9Crf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp4Crf)).EndInit();
            this.debugTab.ResumeLayout(false);
            this.debugTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cyotek.Windows.Forms.TabList settingsTabList;
        private Cyotek.Windows.Forms.TabListPage generalTab;
        private Cyotek.Windows.Forms.TabListPage tabListPage2;
        private Cyotek.Windows.Forms.TabListPage debugTab;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox keepAudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dedupMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmdDebugMode;
        private System.Windows.Forms.Label dedupeSensLabel;
        private System.Windows.Forms.CheckBox enableLoop;
        private System.Windows.Forms.Label label15;
        private Cyotek.Windows.Forms.TabListPage vidExportTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox maxFps;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private Cyotek.Windows.Forms.TabListPage aiOptsPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox torchGpus;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox ncnnGpus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox maxVidHeight;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox tempFolderLoc;
        private System.Windows.Forms.CheckBox keepTempFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tempDirCustom;
        private HTAlt.WinForms.HTButton tempDirBrowseBtn;
        private System.Windows.Forms.ComboBox processingMode;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel mpDedupePanel;
        private System.Windows.Forms.ComboBox mpdecimateMode;
        private System.Windows.Forms.Panel magickDedupePanel;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox ffEncPreset;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.CheckBox scnDetect;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox loopMode;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox autoEncMode;
        private System.Windows.Forms.CheckBox sbsAllowAutoEnc;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox uhdThresh;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox ffEncArgs;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label64;
        private HTAlt.WinForms.HTButton clearModelCacheBtn;
        private System.Windows.Forms.NumericUpDown scnDetectValue;
        private System.Windows.Forms.NumericUpDown dedupThresh;
        private System.Windows.Forms.NumericUpDown ncnnThreads;
        private System.Windows.Forms.NumericUpDown minOutVidLength;
        private System.Windows.Forms.CheckBox keepSubs;
        private System.Windows.Forms.CheckBox enableAlpha;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox dainNcnnTilesize;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox rifeCudaFp16;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox exportNamePattern;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.PictureBox info1;
        private System.Windows.Forms.TextBox exportNamePatternLoop;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.ComboBox sceneChangeFillMode;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.CheckBox fixOutputDuration;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.CheckBox keepMeta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.CheckBox jpegFrames;
        private System.Windows.Forms.Label label63;
        private Cyotek.Windows.Forms.TabListPage tabListPage1;
        private System.Windows.Forms.ComboBox gifDitherType;
        private System.Windows.Forms.ComboBox aviColors;
        private System.Windows.Forms.ComboBox aviCodec;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ComboBox proResProfile;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox gifColors;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox mp4Enc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox imgSeqFormat;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown mp4Crf;
        private System.Windows.Forms.NumericUpDown vp9Crf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox autoEncBackupMode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private HTAlt.WinForms.HTButton modelDownloaderBtn;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.CheckBox alwaysWaitForAutoEnc;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Panel autoEncBlockPanel;
        private HTAlt.WinForms.HTButton resetBtn;
        private System.Windows.Forms.ComboBox pixFmt;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.CheckBox disablePreview;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private HTAlt.WinForms.HTButton custOutDirBrowseBtn;
        private System.Windows.Forms.TextBox custOutDir;
        private System.Windows.Forms.ComboBox outFolderLoc;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox serverCombox;
        private System.Windows.Forms.ComboBox imgSeqQuality;
    }
}