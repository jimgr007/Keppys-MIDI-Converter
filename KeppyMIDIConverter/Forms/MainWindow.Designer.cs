﻿namespace KeppyMIDIConverter
{
    partial class MainWindow
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MIDIImport = new System.Windows.Forms.OpenFileDialog();
            this.RenderingTimer = new System.Windows.Forms.Timer(this.components);
            this.UsedVoices = new System.Windows.Forms.Label();
            this.MIDIList = new System.Windows.Forms.ListBox();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.AdvSettingsButton = new System.Windows.Forms.Button();
            this.VoiceLimit = new System.Windows.Forms.NumericUpDown();
            this.VoiceLabel = new System.Windows.Forms.Label();
            this.CurrentStatus = new System.Windows.Forms.ProgressBar();
            this.ExportWhere = new System.Windows.Forms.SaveFileDialog();
            this.labelRMS = new System.Windows.Forms.Label();
            this.CurrentStatusText = new System.Windows.Forms.Label();
            this.RealTimePlayBack = new System.ComponentModel.BackgroundWorker();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.VolumeTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingpic = new System.Windows.Forms.PictureBox();
            this.ConverterProcess = new System.ComponentModel.BackgroundWorker();
            this.DefaultMenu = new System.Windows.Forms.MainMenu(this.components);
            this.ActionsStrip = new System.Windows.Forms.MenuItem();
            this.importMIDIsToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.removeSelectedMIDIsToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.clearMIDIsListToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.openTheSoundfontsManagerToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.startRenderingWAVToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.startRenderingOGGToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.playInRealtimeBetaToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.abortRenderingToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.OptionsStrip = new System.Windows.Forms.MenuItem();
            this.AutoUpdatesCheckStrip = new System.Windows.Forms.MenuItem();
            this.enabledToolStripMenuItem3 = new System.Windows.Forms.MenuItem();
            this.disabledToolStripMenuItem3 = new System.Windows.Forms.MenuItem();
            this.AutomaticShutdownStrip = new System.Windows.Forms.MenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.ClearListAutomaticallyStrip = new System.Windows.Forms.MenuItem();
            this.enabledToolStripMenuItem1 = new System.Windows.Forms.MenuItem();
            this.disabledToolStripMenuItem1 = new System.Windows.Forms.MenuItem();
            this.ConvPosOrTimeLeft = new System.Windows.Forms.MenuItem();
            this.enabledToolStripMenuItem2 = new System.Windows.Forms.MenuItem();
            this.disabledToolStripMenuItem2 = new System.Windows.Forms.MenuItem();
            this.AudioEventsStrip = new System.Windows.Forms.MenuItem();
            this.enabledToolStripMenuItem4 = new System.Windows.Forms.MenuItem();
            this.disabledToolStripMenuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.OverrideStrip = new System.Windows.Forms.MenuItem();
            this.enabledToolStripMenuItem5 = new System.Windows.Forms.MenuItem();
            this.disabledToolStripMenuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.BengaliOverride = new System.Windows.Forms.MenuItem();
            this.DutchOverride = new System.Windows.Forms.MenuItem();
            this.EnglishOverride = new System.Windows.Forms.MenuItem();
            this.EstonianOverride = new System.Windows.Forms.MenuItem();
            this.FrenchOverride = new System.Windows.Forms.MenuItem();
            this.GermanOverride = new System.Windows.Forms.MenuItem();
            this.ItalianOverride = new System.Windows.Forms.MenuItem();
            this.IndonesianOverride = new System.Windows.Forms.MenuItem();
            this.JapaneseOverride = new System.Windows.Forms.MenuItem();
            this.KoreanOverride = new System.Windows.Forms.MenuItem();
            this.ChineseCNOverride = new System.Windows.Forms.MenuItem();
            this.SpanishOverride = new System.Windows.Forms.MenuItem();
            this.TurkishOverride = new System.Windows.Forms.MenuItem();
            this.ChineseHKOverride = new System.Windows.Forms.MenuItem();
            this.ChineseTWOverride = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.forceCloseTheApplicationToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.HelpStrip = new System.Windows.Forms.MenuItem();
            this.informationAboutTheProgramToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.supportTheDeveloperWithADonationToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.FL12Discount = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.KaleidonKep99sGitHubPageToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.KaleidonKep99sYouTubeChannelToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.DefMenu = new System.Windows.Forms.ContextMenu();
            this.ImportMIDIsRightClick = new System.Windows.Forms.MenuItem();
            this.RemoveMIDIsRightClick = new System.Windows.Forms.MenuItem();
            this.ClearMIDIsListRightClick = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.MoveUpMIDIRightClick = new System.Windows.Forms.MenuItem();
            this.MoveDownMIDIRightClick = new System.Windows.Forms.MenuItem();
            this.VistaMenuSys = new wyDay.Controls.VistaMenu(this.components);
            this.RussianOverride = new System.Windows.Forms.MenuItem();
            this.SettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoiceLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaMenuSys)).BeginInit();
            this.SuspendLayout();
            // 
            // MIDIImport
            // 
            this.MIDIImport.Filter = "MIDI files|*.mid;*.midi;*.rmi";
            this.MIDIImport.Multiselect = true;
            this.MIDIImport.RestoreDirectory = true;
            this.MIDIImport.Title = "Import MIDIs to the conversion list..";
            // 
            // RenderingTimer
            // 
            this.RenderingTimer.Enabled = true;
            this.RenderingTimer.Interval = 1;
            this.RenderingTimer.Tick += new System.EventHandler(this.RenderingTimer_Tick);
            // 
            // UsedVoices
            // 
            this.UsedVoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UsedVoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedVoices.Location = new System.Drawing.Point(341, 302);
            this.UsedVoices.Name = "UsedVoices";
            this.UsedVoices.Size = new System.Drawing.Size(161, 13);
            this.UsedVoices.TabIndex = 8;
            this.UsedVoices.Text = "Voices: 100000/100000";
            this.UsedVoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MIDIList
            // 
            this.MIDIList.AllowDrop = true;
            this.MIDIList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MIDIList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MIDIList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MIDIList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIDIList.FormattingEnabled = true;
            this.MIDIList.HorizontalScrollbar = true;
            this.MIDIList.IntegralHeight = false;
            this.MIDIList.ItemHeight = 16;
            this.MIDIList.Location = new System.Drawing.Point(12, 12);
            this.MIDIList.Name = "MIDIList";
            this.MIDIList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MIDIList.Size = new System.Drawing.Size(628, 276);
            this.MIDIList.TabIndex = 11;
            this.MIDIList.DragDrop += new System.Windows.Forms.DragEventHandler(this.MIDIList_DragDrop);
            this.MIDIList.DragEnter += new System.Windows.Forms.DragEventHandler(this.MIDIList_DragEnter);
            this.MIDIList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MIDIList_KeyPress);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsBox.Controls.Add(this.AdvSettingsButton);
            this.SettingsBox.Controls.Add(this.VoiceLimit);
            this.SettingsBox.Controls.Add(this.VoiceLabel);
            this.SettingsBox.Location = new System.Drawing.Point(490, 324);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(150, 70);
            this.SettingsBox.TabIndex = 12;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Settings";
            // 
            // AdvSettingsButton
            // 
            this.AdvSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AdvSettingsButton.Location = new System.Drawing.Point(6, 40);
            this.AdvSettingsButton.Name = "AdvSettingsButton";
            this.AdvSettingsButton.Size = new System.Drawing.Size(137, 23);
            this.AdvSettingsButton.TabIndex = 2;
            this.AdvSettingsButton.Text = "Advanced settings";
            this.AdvSettingsButton.UseVisualStyleBackColor = true;
            this.AdvSettingsButton.Click += new System.EventHandler(this.AdvSettingsButton_Click);
            // 
            // VoiceLimit
            // 
            this.VoiceLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VoiceLimit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoiceLimit.Location = new System.Drawing.Point(95, 16);
            this.VoiceLimit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.VoiceLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VoiceLimit.Name = "VoiceLimit";
            this.VoiceLimit.Size = new System.Drawing.Size(50, 18);
            this.VoiceLimit.TabIndex = 1;
            this.VoiceLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VoiceLimit.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.VoiceLimit.ValueChanged += new System.EventHandler(this.VoiceLimit_ValueChanged);
            // 
            // VoiceLabel
            // 
            this.VoiceLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoiceLabel.Location = new System.Drawing.Point(1, 18);
            this.VoiceLabel.Name = "VoiceLabel";
            this.VoiceLabel.Size = new System.Drawing.Size(97, 13);
            this.VoiceLabel.TabIndex = 0;
            this.VoiceLabel.Text = "Voice limit:";
            this.VoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CurrentStatus.Location = new System.Drawing.Point(0, 405);
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.Size = new System.Drawing.Size(652, 23);
            this.CurrentStatus.Step = 1;
            this.CurrentStatus.TabIndex = 14;
            // 
            // ExportWhere
            // 
            this.ExportWhere.AddExtension = false;
            this.ExportWhere.Filter = "Select a folder|*.*";
            this.ExportWhere.OverwritePrompt = false;
            this.ExportWhere.RestoreDirectory = true;
            this.ExportWhere.Title = "Where do you want to export?";
            this.ExportWhere.ValidateNames = false;
            // 
            // labelRMS
            // 
            this.labelRMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRMS.Location = new System.Drawing.Point(12, 302);
            this.labelRMS.Name = "labelRMS";
            this.labelRMS.Size = new System.Drawing.Size(329, 13);
            this.labelRMS.TabIndex = 17;
            this.labelRMS.Text = "Root mean square: -0.0 dB | Average: -0.0 dB | Peak: -0.0 dB";
            // 
            // CurrentStatusText
            // 
            this.CurrentStatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStatusText.BackColor = System.Drawing.Color.Transparent;
            this.CurrentStatusText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStatusText.Location = new System.Drawing.Point(0, 0);
            this.CurrentStatusText.Name = "CurrentStatusText";
            this.CurrentStatusText.Size = new System.Drawing.Size(407, 60);
            this.CurrentStatusText.TabIndex = 7;
            this.CurrentStatusText.Text = "Loading... Please wait...";
            this.CurrentStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RealTimePlayBack
            // 
            this.RealTimePlayBack.WorkerReportsProgress = true;
            this.RealTimePlayBack.WorkerSupportsCancellation = true;
            this.RealTimePlayBack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RealTimePlayBackBeta_DoWork);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.AutoSize = false;
            this.VolumeBar.LargeChange = 1;
            this.VolumeBar.Location = new System.Drawing.Point(510, 303);
            this.VolumeBar.Maximum = 10000;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(130, 20);
            this.VolumeBar.TabIndex = 18;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(510, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Volume:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeTip
            // 
            this.VolumeTip.AutomaticDelay = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.loadingpic);
            this.panel1.Controls.Add(this.CurrentStatusText);
            this.panel1.Location = new System.Drawing.Point(12, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 64);
            this.panel1.TabIndex = 13;
            // 
            // loadingpic
            // 
            this.loadingpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadingpic.Image = global::KeppyMIDIConverter.Properties.Resources.convpause;
            this.loadingpic.InitialImage = null;
            this.loadingpic.Location = new System.Drawing.Point(408, 0);
            this.loadingpic.Name = "loadingpic";
            this.loadingpic.Size = new System.Drawing.Size(60, 60);
            this.loadingpic.TabIndex = 8;
            this.loadingpic.TabStop = false;
            // 
            // ConverterProcess
            // 
            this.ConverterProcess.WorkerReportsProgress = true;
            this.ConverterProcess.WorkerSupportsCancellation = true;
            this.ConverterProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConverterProcess_DoWork);
            // 
            // DefaultMenu
            // 
            this.DefaultMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ActionsStrip,
            this.OptionsStrip,
            this.HelpStrip});
            // 
            // ActionsStrip
            // 
            this.ActionsStrip.Index = 0;
            this.ActionsStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.importMIDIsToolStripMenuItem,
            this.removeSelectedMIDIsToolStripMenuItem,
            this.clearMIDIsListToolStripMenuItem,
            this.menuItem5,
            this.openTheSoundfontsManagerToolStripMenuItem,
            this.menuItem7,
            this.startRenderingWAVToolStripMenuItem,
            this.startRenderingOGGToolStripMenuItem,
            this.playInRealtimeBetaToolStripMenuItem,
            this.abortRenderingToolStripMenuItem,
            this.menuItem12,
            this.exitToolStripMenuItem});
            this.ActionsStrip.Text = "Actions";
            // 
            // importMIDIsToolStripMenuItem
            // 
            this.importMIDIsToolStripMenuItem.DefaultItem = true;
            this.VistaMenuSys.SetImage(this.importMIDIsToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.add_icon);
            this.importMIDIsToolStripMenuItem.Index = 0;
            this.importMIDIsToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.importMIDIsToolStripMenuItem.Text = "Import MIDIs";
            this.importMIDIsToolStripMenuItem.Click += new System.EventHandler(this.importMIDIsToolStripMenuItem_Click);
            // 
            // removeSelectedMIDIsToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.removeSelectedMIDIsToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.delete_icon);
            this.removeSelectedMIDIsToolStripMenuItem.Index = 1;
            this.removeSelectedMIDIsToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.removeSelectedMIDIsToolStripMenuItem.Text = "Remove selected MIDIs";
            this.removeSelectedMIDIsToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedMIDIsToolStripMenuItem_Click);
            // 
            // clearMIDIsListToolStripMenuItem
            // 
            this.clearMIDIsListToolStripMenuItem.Index = 2;
            this.clearMIDIsListToolStripMenuItem.Text = "Clear MIDIs list";
            this.clearMIDIsListToolStripMenuItem.Click += new System.EventHandler(this.clearMIDIsListToolStripMenuItem_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "-";
            // 
            // openTheSoundfontsManagerToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.openTheSoundfontsManagerToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.configure_icon);
            this.openTheSoundfontsManagerToolStripMenuItem.Index = 4;
            this.openTheSoundfontsManagerToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
            this.openTheSoundfontsManagerToolStripMenuItem.Text = "Open the soundfonts/VST DSP manager";
            this.openTheSoundfontsManagerToolStripMenuItem.Click += new System.EventHandler(this.openTheSoundfontsManagerToolStripMenuItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 5;
            this.menuItem7.Text = "-";
            // 
            // startRenderingWAVToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.startRenderingWAVToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.audio_icon);
            this.startRenderingWAVToolStripMenuItem.Index = 6;
            this.startRenderingWAVToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.startRenderingWAVToolStripMenuItem.Text = "Render files to Wave (.WAV)";
            this.startRenderingWAVToolStripMenuItem.Click += new System.EventHandler(this.startRenderingWAVToolStripMenuItem_Click);
            // 
            // startRenderingOGGToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.startRenderingOGGToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.audio_icon);
            this.startRenderingOGGToolStripMenuItem.Index = 7;
            this.startRenderingOGGToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.startRenderingOGGToolStripMenuItem.Text = "Render files to Vorbis (.OGG)";
            this.startRenderingOGGToolStripMenuItem.Click += new System.EventHandler(this.startRenderingOGGToolStripMenuItem_Click);
            // 
            // playInRealtimeBetaToolStripMenuItem
            // 
            this.playInRealtimeBetaToolStripMenuItem.Index = 8;
            this.playInRealtimeBetaToolStripMenuItem.Text = "Preview files (Real-time playback)";
            this.playInRealtimeBetaToolStripMenuItem.Click += new System.EventHandler(this.playInRealtimeBetaToolStripMenuItem_Click);
            // 
            // abortRenderingToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.abortRenderingToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.delete_icon);
            this.abortRenderingToolStripMenuItem.Index = 9;
            this.abortRenderingToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlDel;
            this.abortRenderingToolStripMenuItem.Text = "Abort rendering/preview";
            this.abortRenderingToolStripMenuItem.Click += new System.EventHandler(this.abortRenderingToolStripMenuItem_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 10;
            this.menuItem12.Text = "-";
            // 
            // exitToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.exitToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.back_icon);
            this.exitToolStripMenuItem.Index = 11;
            this.exitToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // OptionsStrip
            // 
            this.OptionsStrip.Index = 1;
            this.OptionsStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.AutoUpdatesCheckStrip,
            this.AutomaticShutdownStrip,
            this.ClearListAutomaticallyStrip,
            this.ConvPosOrTimeLeft,
            this.AudioEventsStrip,
            this.menuItem13,
            this.OverrideStrip,
            this.menuItem2,
            this.forceCloseTheApplicationToolStripMenuItem});
            this.OptionsStrip.Text = "Options";
            // 
            // AutoUpdatesCheckStrip
            // 
            this.AutoUpdatesCheckStrip.Index = 0;
            this.AutoUpdatesCheckStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.enabledToolStripMenuItem3,
            this.disabledToolStripMenuItem3});
            this.AutoUpdatesCheckStrip.Text = "Automatically check for updates when starting the converter";
            // 
            // enabledToolStripMenuItem3
            // 
            this.enabledToolStripMenuItem3.Index = 0;
            this.enabledToolStripMenuItem3.Text = "Enabled";
            this.enabledToolStripMenuItem3.Click += new System.EventHandler(this.enabledToolStripMenuItem3_Click);
            // 
            // disabledToolStripMenuItem3
            // 
            this.disabledToolStripMenuItem3.Index = 1;
            this.disabledToolStripMenuItem3.Text = "Disabled";
            this.disabledToolStripMenuItem3.Click += new System.EventHandler(this.disabledToolStripMenuItem3_Click);
            // 
            // AutomaticShutdownStrip
            // 
            this.AutomaticShutdownStrip.Index = 1;
            this.AutomaticShutdownStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.enabledToolStripMenuItem,
            this.disabledToolStripMenuItem});
            this.AutomaticShutdownStrip.Text = "Automatic shutdown after rendering";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Index = 0;
            this.enabledToolStripMenuItem.Text = "Enabled";
            this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.Index = 1;
            this.disabledToolStripMenuItem.Text = "Disabled";
            this.disabledToolStripMenuItem.Click += new System.EventHandler(this.disabledToolStripMenuItem_Click);
            // 
            // ClearListAutomaticallyStrip
            // 
            this.ClearListAutomaticallyStrip.Index = 2;
            this.ClearListAutomaticallyStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.enabledToolStripMenuItem1,
            this.disabledToolStripMenuItem1});
            this.ClearListAutomaticallyStrip.Text = "Clear MIDIs list after rendering";
            // 
            // enabledToolStripMenuItem1
            // 
            this.enabledToolStripMenuItem1.Index = 0;
            this.enabledToolStripMenuItem1.Text = "Enabled";
            this.enabledToolStripMenuItem1.Click += new System.EventHandler(this.enabledToolStripMenuItem1_Click);
            // 
            // disabledToolStripMenuItem1
            // 
            this.disabledToolStripMenuItem1.Index = 1;
            this.disabledToolStripMenuItem1.Text = "Disabled";
            this.disabledToolStripMenuItem1.Click += new System.EventHandler(this.disabledToolStripMenuItem1_Click);
            // 
            // ConvPosOrTimeLeft
            // 
            this.ConvPosOrTimeLeft.Index = 3;
            this.ConvPosOrTimeLeft.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.enabledToolStripMenuItem2,
            this.disabledToolStripMenuItem2});
            this.ConvPosOrTimeLeft.Text = "Show conversion position instead of time left";
            // 
            // enabledToolStripMenuItem2
            // 
            this.enabledToolStripMenuItem2.Index = 0;
            this.enabledToolStripMenuItem2.Text = "Enabled";
            this.enabledToolStripMenuItem2.Click += new System.EventHandler(this.enabledToolStripMenuItem2_Click);
            // 
            // disabledToolStripMenuItem2
            // 
            this.disabledToolStripMenuItem2.Index = 1;
            this.disabledToolStripMenuItem2.Text = "Disabled";
            this.disabledToolStripMenuItem2.Click += new System.EventHandler(this.disabledToolStripMenuItem2_Click);
            // 
            // AudioEventsStrip
            // 
            this.AudioEventsStrip.Index = 4;
            this.AudioEventsStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.enabledToolStripMenuItem4,
            this.disabledToolStripMenuItem4});
            this.AudioEventsStrip.Text = "Conversion started/finished/failed sounds";
            // 
            // enabledToolStripMenuItem4
            // 
            this.enabledToolStripMenuItem4.Index = 0;
            this.enabledToolStripMenuItem4.Text = "Enabled";
            this.enabledToolStripMenuItem4.Click += new System.EventHandler(this.enabledToolStripMenuItem4_Click);
            // 
            // disabledToolStripMenuItem4
            // 
            this.disabledToolStripMenuItem4.Index = 1;
            this.disabledToolStripMenuItem4.Text = "Disabled";
            this.disabledToolStripMenuItem4.Click += new System.EventHandler(this.disabledToolStripMenuItem4_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 5;
            this.menuItem13.Text = "-";
            // 
            // OverrideStrip
            // 
            this.VistaMenuSys.SetImage(this.OverrideStrip, global::KeppyMIDIConverter.Properties.Resources.configure_icon);
            this.OverrideStrip.Index = 6;
            this.OverrideStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.enabledToolStripMenuItem5,
            this.disabledToolStripMenuItem5,
            this.menuItem20,
            this.BengaliOverride,
            this.DutchOverride,
            this.EnglishOverride,
            this.EstonianOverride,
            this.FrenchOverride,
            this.GermanOverride,
            this.ItalianOverride,
            this.IndonesianOverride,
            this.JapaneseOverride,
            this.KoreanOverride,
            this.RussianOverride,
            this.ChineseCNOverride,
            this.SpanishOverride,
            this.TurkishOverride,
            this.ChineseHKOverride,
            this.ChineseTWOverride});
            this.OverrideStrip.Text = "Override language";
            // 
            // enabledToolStripMenuItem5
            // 
            this.enabledToolStripMenuItem5.Index = 0;
            this.enabledToolStripMenuItem5.Text = "Enabled";
            this.enabledToolStripMenuItem5.Click += new System.EventHandler(this.enabledToolStripMenuItem5_Click);
            // 
            // disabledToolStripMenuItem5
            // 
            this.disabledToolStripMenuItem5.Checked = true;
            this.disabledToolStripMenuItem5.Index = 1;
            this.disabledToolStripMenuItem5.Text = "Disabled";
            this.disabledToolStripMenuItem5.Click += new System.EventHandler(this.disabledToolStripMenuItem5_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 2;
            this.menuItem20.Text = "-";
            // 
            // BengaliOverride
            // 
            this.BengaliOverride.Enabled = false;
            this.BengaliOverride.Index = 3;
            this.BengaliOverride.Text = "Bengali (বাঙালি)";
            this.BengaliOverride.Click += new System.EventHandler(this.Bengali_Click);
            // 
            // DutchOverride
            // 
            this.DutchOverride.Enabled = false;
            this.DutchOverride.Index = 4;
            this.DutchOverride.Text = "Dutch (Nederlands)";
            this.DutchOverride.Click += new System.EventHandler(this.DutchOverride_Click);
            // 
            // EnglishOverride
            // 
            this.EnglishOverride.Enabled = false;
            this.EnglishOverride.Index = 5;
            this.EnglishOverride.Text = "English (English)";
            this.EnglishOverride.Click += new System.EventHandler(this.EnglishOverride_Click);
            // 
            // EstonianOverride
            // 
            this.EstonianOverride.Enabled = false;
            this.EstonianOverride.Index = 6;
            this.EstonianOverride.Text = "Estonian (Eesti)";
            this.EstonianOverride.Click += new System.EventHandler(this.EstonianOverride_Click);
            // 
            // FrenchOverride
            // 
            this.FrenchOverride.Enabled = false;
            this.FrenchOverride.Index = 7;
            this.FrenchOverride.Text = "French (Français)";
            this.FrenchOverride.Click += new System.EventHandler(this.FrenchOverride_Click);
            // 
            // GermanOverride
            // 
            this.GermanOverride.Enabled = false;
            this.GermanOverride.Index = 8;
            this.GermanOverride.Text = "German (Deutsch)";
            this.GermanOverride.Click += new System.EventHandler(this.GermanOverride_Click);
            // 
            // ItalianOverride
            // 
            this.ItalianOverride.Enabled = false;
            this.ItalianOverride.Index = 9;
            this.ItalianOverride.Text = "Italian (Italiano)";
            this.ItalianOverride.Click += new System.EventHandler(this.ItalianOverride_Click);
            // 
            // IndonesianOverride
            // 
            this.IndonesianOverride.Enabled = false;
            this.IndonesianOverride.Index = 10;
            this.IndonesianOverride.Text = "Indonesian (Bahasa Indonesia)";
            this.IndonesianOverride.Click += new System.EventHandler(this.IndonesianOverride_Click);
            // 
            // JapaneseOverride
            // 
            this.JapaneseOverride.Enabled = false;
            this.JapaneseOverride.Index = 11;
            this.JapaneseOverride.Text = "Japanese (日本語)";
            this.JapaneseOverride.Click += new System.EventHandler(this.JapaneseOverride_Click);
            // 
            // KoreanOverride
            // 
            this.KoreanOverride.Enabled = false;
            this.KoreanOverride.Index = 12;
            this.KoreanOverride.Text = "Korean (한국어)";
            this.KoreanOverride.Click += new System.EventHandler(this.KoreanOverride_Click);
            // 
            // ChineseCNOverride
            // 
            this.ChineseCNOverride.Enabled = false;
            this.ChineseCNOverride.Index = 14;
            this.ChineseCNOverride.Text = "Simplified Chinese (简化字, PRC)";
            this.ChineseCNOverride.Click += new System.EventHandler(this.ChineseCN_Click);
            // 
            // SpanishOverride
            // 
            this.SpanishOverride.Enabled = false;
            this.SpanishOverride.Index = 15;
            this.SpanishOverride.Text = "Spanish (Español)";
            this.SpanishOverride.Click += new System.EventHandler(this.SpanishOverride_Click);
            // 
            // TurkishOverride
            // 
            this.TurkishOverride.Enabled = false;
            this.TurkishOverride.Index = 16;
            this.TurkishOverride.Text = "Turkish (Türkçe)";
            this.TurkishOverride.Click += new System.EventHandler(this.TurkishOverride_Click);
            // 
            // ChineseHKOverride
            // 
            this.ChineseHKOverride.Enabled = false;
            this.ChineseHKOverride.Index = 17;
            this.ChineseHKOverride.Text = "Traditional Chinese (廣東話, Hong Kong)";
            this.ChineseHKOverride.Click += new System.EventHandler(this.ChineseHK_Click);
            // 
            // ChineseTWOverride
            // 
            this.ChineseTWOverride.Enabled = false;
            this.ChineseTWOverride.Index = 18;
            this.ChineseTWOverride.Text = "Traditional Chinese (台灣, Taiwan)";
            this.ChineseTWOverride.Click += new System.EventHandler(this.ChineseTW_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 7;
            this.menuItem2.Text = "-";
            // 
            // forceCloseTheApplicationToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.forceCloseTheApplicationToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.delete_icon);
            this.forceCloseTheApplicationToolStripMenuItem.Index = 8;
            this.forceCloseTheApplicationToolStripMenuItem.Text = "Crash the application";
            this.forceCloseTheApplicationToolStripMenuItem.Click += new System.EventHandler(this.forceCloseTheApplicationToolStripMenuItem_Click);
            // 
            // HelpStrip
            // 
            this.HelpStrip.Index = 2;
            this.HelpStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.informationAboutTheProgramToolStripMenuItem,
            this.supportTheDeveloperWithADonationToolStripMenuItem,
            this.menuItem17,
            this.FL12Discount,
            this.menuItem3,
            this.KaleidonKep99sGitHubPageToolStripMenuItem,
            this.KaleidonKep99sYouTubeChannelToolStripMenuItem});
            this.HelpStrip.Text = "Help";
            // 
            // informationAboutTheProgramToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.informationAboutTheProgramToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.information_icon);
            this.informationAboutTheProgramToolStripMenuItem.Index = 0;
            this.informationAboutTheProgramToolStripMenuItem.Text = "Information about the program";
            this.informationAboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.informationsToolStripMenuItem_Click);
            // 
            // supportTheDeveloperWithADonationToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.supportTheDeveloperWithADonationToolStripMenuItem, global::KeppyMIDIConverter.Properties.Resources.edit_icon);
            this.supportTheDeveloperWithADonationToolStripMenuItem.Index = 1;
            this.supportTheDeveloperWithADonationToolStripMenuItem.Text = "Support the developer with a donation";
            this.supportTheDeveloperWithADonationToolStripMenuItem.Click += new System.EventHandler(this.makeADonationToSupportTheDeveloperToolStripMenuItem_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "-";
            // 
            // FL12Discount
            // 
            this.VistaMenuSys.SetImage(this.FL12Discount, ((System.Drawing.Image)(resources.GetObject("FL12Discount.Image"))));
            this.FL12Discount.Index = 3;
            this.FL12Discount.Text = "Get a discount on a FL Studio license";
            this.FL12Discount.Click += new System.EventHandler(this.FL12Discount_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "-";
            // 
            // KaleidonKep99sGitHubPageToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.KaleidonKep99sGitHubPageToolStripMenuItem, ((System.Drawing.Image)(resources.GetObject("KaleidonKep99sGitHubPageToolStripMenuItem.Image"))));
            this.KaleidonKep99sGitHubPageToolStripMenuItem.Index = 5;
            this.KaleidonKep99sGitHubPageToolStripMenuItem.Text = "KaleidonKep99\'s GitHub Page";
            this.KaleidonKep99sGitHubPageToolStripMenuItem.Click += new System.EventHandler(this.KaleidonKep99sGitHubPageToolStripMenuItem_Click);
            // 
            // KaleidonKep99sYouTubeChannelToolStripMenuItem
            // 
            this.VistaMenuSys.SetImage(this.KaleidonKep99sYouTubeChannelToolStripMenuItem, ((System.Drawing.Image)(resources.GetObject("KaleidonKep99sYouTubeChannelToolStripMenuItem.Image"))));
            this.KaleidonKep99sYouTubeChannelToolStripMenuItem.Index = 6;
            this.KaleidonKep99sYouTubeChannelToolStripMenuItem.Text = "KaleidonKep99\'s YouTube Channel";
            this.KaleidonKep99sYouTubeChannelToolStripMenuItem.Click += new System.EventHandler(this.kaleidonKep99sYouTubeChannelToolStripMenuItem_Click);
            // 
            // DefMenu
            // 
            this.DefMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImportMIDIsRightClick,
            this.RemoveMIDIsRightClick,
            this.ClearMIDIsListRightClick,
            this.menuItem16,
            this.MoveUpMIDIRightClick,
            this.MoveDownMIDIRightClick});
            // 
            // ImportMIDIsRightClick
            // 
            this.ImportMIDIsRightClick.Index = 0;
            this.ImportMIDIsRightClick.Text = "Import MIDIs";
            this.ImportMIDIsRightClick.Click += new System.EventHandler(this.importMIDIsToolStripMenuItem_Click);
            // 
            // RemoveMIDIsRightClick
            // 
            this.RemoveMIDIsRightClick.Index = 1;
            this.RemoveMIDIsRightClick.Text = "Remove selected MIDIs";
            this.RemoveMIDIsRightClick.Click += new System.EventHandler(this.removeSelectedMIDIsToolStripMenuItem_Click);
            // 
            // ClearMIDIsListRightClick
            // 
            this.ClearMIDIsListRightClick.Index = 2;
            this.ClearMIDIsListRightClick.Text = "Clear MIDIs list";
            this.ClearMIDIsListRightClick.Click += new System.EventHandler(this.clearMIDIsListToolStripMenuItem_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 3;
            this.menuItem16.Text = "-";
            // 
            // MoveUpMIDIRightClick
            // 
            this.MoveUpMIDIRightClick.Index = 4;
            this.MoveUpMIDIRightClick.Text = "Move up (One item)";
            this.MoveUpMIDIRightClick.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // MoveDownMIDIRightClick
            // 
            this.MoveDownMIDIRightClick.Index = 5;
            this.MoveDownMIDIRightClick.Text = "Move down (One item)";
            this.MoveDownMIDIRightClick.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // VistaMenuSys
            // 
            this.VistaMenuSys.ContainerControl = this;
            // 
            // RussianOverride
            // 
            this.RussianOverride.Enabled = false;
            this.RussianOverride.Index = 13;
            this.RussianOverride.Text = "Russian (Pу́сский)";
            this.RussianOverride.Click += new System.EventHandler(this.RussianOverride_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(652, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.UsedVoices);
            this.Controls.Add(this.labelRMS);
            this.Controls.Add(this.MIDIList);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.CurrentStatus);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(668, 467);
            this.Name = "MainWindow";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keppy\'s MIDI Converter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SettingsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VoiceLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaMenuSys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog MIDIImport;
        private System.Windows.Forms.Timer RenderingTimer;
        private System.Windows.Forms.Label UsedVoices;
        private System.Windows.Forms.Label CurrentStatusText;
        private System.Windows.Forms.ListBox MIDIList;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Button AdvSettingsButton;
        private System.Windows.Forms.NumericUpDown VoiceLimit;
        private System.Windows.Forms.Label VoiceLabel;
        private System.Windows.Forms.ProgressBar CurrentStatus;
        private System.Windows.Forms.SaveFileDialog ExportWhere;
        private System.Windows.Forms.Label labelRMS;
        public System.ComponentModel.BackgroundWorker RealTimePlayBack;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip VolumeTip;
        private System.Windows.Forms.Panel panel1;
        public System.ComponentModel.BackgroundWorker ConverterProcess;
        private System.Windows.Forms.MainMenu DefaultMenu;
        private System.Windows.Forms.MenuItem ActionsStrip;
        private System.Windows.Forms.MenuItem importMIDIsToolStripMenuItem;
        private System.Windows.Forms.MenuItem removeSelectedMIDIsToolStripMenuItem;
        private System.Windows.Forms.MenuItem clearMIDIsListToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem openTheSoundfontsManagerToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem startRenderingWAVToolStripMenuItem;
        private System.Windows.Forms.MenuItem startRenderingOGGToolStripMenuItem;
        private System.Windows.Forms.MenuItem playInRealtimeBetaToolStripMenuItem;
        private System.Windows.Forms.MenuItem abortRenderingToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuItem OptionsStrip;
        private System.Windows.Forms.MenuItem AutoUpdatesCheckStrip;
        private System.Windows.Forms.MenuItem AutomaticShutdownStrip;
        private System.Windows.Forms.MenuItem ClearListAutomaticallyStrip;
        private System.Windows.Forms.MenuItem ConvPosOrTimeLeft;
        private System.Windows.Forms.MenuItem AudioEventsStrip;
        private System.Windows.Forms.MenuItem forceCloseTheApplicationToolStripMenuItem;
        private System.Windows.Forms.MenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.MenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.MenuItem enabledToolStripMenuItem1;
        private System.Windows.Forms.MenuItem disabledToolStripMenuItem1;
        private System.Windows.Forms.MenuItem enabledToolStripMenuItem2;
        private System.Windows.Forms.MenuItem disabledToolStripMenuItem2;
        private System.Windows.Forms.MenuItem enabledToolStripMenuItem4;
        private System.Windows.Forms.MenuItem disabledToolStripMenuItem4;
        private System.Windows.Forms.MenuItem enabledToolStripMenuItem3;
        private System.Windows.Forms.MenuItem disabledToolStripMenuItem3;
        private System.Windows.Forms.MenuItem HelpStrip;
        private System.Windows.Forms.MenuItem informationAboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.MenuItem supportTheDeveloperWithADonationToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem KaleidonKep99sYouTubeChannelToolStripMenuItem;
        private System.Windows.Forms.ContextMenu DefMenu;
        private System.Windows.Forms.MenuItem ImportMIDIsRightClick;
        private System.Windows.Forms.MenuItem RemoveMIDIsRightClick;
        private System.Windows.Forms.MenuItem ClearMIDIsListRightClick;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem MoveUpMIDIRightClick;
        private System.Windows.Forms.MenuItem MoveDownMIDIRightClick;
        private wyDay.Controls.VistaMenu VistaMenuSys;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem KaleidonKep99sGitHubPageToolStripMenuItem;
        private System.Windows.Forms.MenuItem OverrideStrip;
        private System.Windows.Forms.MenuItem ItalianOverride;
        private System.Windows.Forms.MenuItem EnglishOverride;
        private System.Windows.Forms.MenuItem SpanishOverride;
        private System.Windows.Forms.MenuItem GermanOverride;
        private System.Windows.Forms.MenuItem EstonianOverride;
        private System.Windows.Forms.MenuItem DutchOverride;
        private System.Windows.Forms.MenuItem IndonesianOverride;
        private System.Windows.Forms.MenuItem FrenchOverride;
        private System.Windows.Forms.MenuItem TurkishOverride;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem enabledToolStripMenuItem5;
        private System.Windows.Forms.MenuItem disabledToolStripMenuItem5;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem ChineseCNOverride;
        private System.Windows.Forms.MenuItem ChineseTWOverride;
        private System.Windows.Forms.MenuItem ChineseHKOverride;
        private System.Windows.Forms.MenuItem JapaneseOverride;
        private System.Windows.Forms.MenuItem KoreanOverride;
        private System.Windows.Forms.MenuItem BengaliOverride;
        private System.Windows.Forms.MenuItem FL12Discount;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.PictureBox loadingpic;
        private System.Windows.Forms.MenuItem RussianOverride;
    }
}
