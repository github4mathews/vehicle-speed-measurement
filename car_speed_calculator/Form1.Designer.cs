﻿namespace car_speed_calculator
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("شناسه خودرو", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ناحیه موردنظر", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("موقعیت قبلی", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("موقعیت فعلی", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("شناسه خودرو", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ناحیه موردنظر", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("موقعیت قبلی", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("موقعیت فعلی", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("شناسه خودرو", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("ناحیه موردنظر", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("موقعیت قبلی", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("موقعیت فعلی", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Vehicle ID", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("ROI", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Prev. location", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Curr. location", System.Windows.Forms.HorizontalAlignment.Center);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_select_video = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.KMPHLabel = new System.Windows.Forms.Label();
            this.SourceSelectLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_ROI_size = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFps = new System.Windows.Forms.Label();
            this.labelTotalFrames = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarErode = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarGaussian = new System.Windows.Forms.TrackBar();
            this.trackBarRoiWidth = new System.Windows.Forms.TrackBar();
            this.trackBarRoiH = new System.Windows.Forms.TrackBar();
            this.trackBarRoiY = new System.Windows.Forms.TrackBar();
            this.trackBarRoiX = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxGaussianEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxErode = new System.Windows.Forms.CheckBox();
            this.checkBoxDilate = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBarDilate = new System.Windows.Forms.TrackBar();
            this.checkBoxOpening = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBarOpening = new System.Windows.Forms.TrackBar();
            this.labelOpeningValue = new System.Windows.Forms.Label();
            this.labelClosingValue = new System.Windows.Forms.Label();
            this.checkBoxClosing = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.trackBarClosing = new System.Windows.Forms.TrackBar();
            this.labelErodeValue = new System.Windows.Forms.Label();
            this.labelDilateValue = new System.Windows.Forms.Label();
            this.labelGaussianValue = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxDiffrence = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxPreprocess = new System.Windows.Forms.PictureBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.labelMotionThresholdValue = new System.Windows.Forms.Label();
            this.trackBarMotionThreshold = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.listViewTracking = new System.Windows.Forms.ListView();
            this.columnVehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnROI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPPrev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPCurr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxROI = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listViewViolation = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackBarViolationSet = new System.Windows.Forms.TrackBar();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.labelViolationSet = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewCalculatedXML = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadCalculatedXMLButton = new System.Windows.Forms.Button();
            this.textBoxCalculatedXMLLoader = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.listViewXMLLoad = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadXMLButton = new System.Windows.Forms.Button();
            this.TextboxXMLLoader = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.CalibrationConstantButton = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.CalibrationConstantTextbox = new System.Windows.Forms.TextBox();
            this.labelPixelDensity = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Button_Ref_meter_Change = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.labelROI_H = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_Ref_meter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelVideoW = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelVideoH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.trackBar_mog_noiseSigma = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.label_mog_noiseSigma_ = new System.Windows.Forms.Label();
            this.trackBar_mog_backgroundRatio = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.label_mog_backgroundRatio = new System.Windows.Forms.Label();
            this.trackBar_mog_nMixtures = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label_mog_nMixtures = new System.Windows.Forms.Label();
            this.trackBar_mog_history = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label_mog_history = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.trackBarFillHoles = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBoxFillHoles = new System.Windows.Forms.CheckBox();
            this.labelFillHolesValue = new System.Windows.Forms.Label();
            this.فایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازکردنویدئوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کیلدهایراهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.راهنماToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.میانبرهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ImageSet = new System.Windows.Forms.Button();
            this.labelROIEnabled = new System.Windows.Forms.Label();
            this.checkBoxROIEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarErode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGaussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClosing)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiffrence)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreprocess)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMotionThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROI)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViolationSet)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_noiseSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_backgroundRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_nMixtures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_history)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFillHoles)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_select_video
            // 
            this.button_select_video.BackColor = System.Drawing.Color.Transparent;
            this.button_select_video.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_video.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_select_video.Location = new System.Drawing.Point(1174, 57);
            this.button_select_video.Name = "button_select_video";
            this.button_select_video.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_select_video.Size = new System.Drawing.Size(133, 31);
            this.button_select_video.TabIndex = 4;
            this.button_select_video.Text = "Choose Video ...";
            this.button_select_video.UseVisualStyleBackColor = false;
            this.button_select_video.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(921, 545);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(16, 490);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(162, 22);
            this.labelSpeed.TabIndex = 29;
            this.labelSpeed.Text = "Calculated Speed:";
            // 
            // labelSpeedValue
            // 
            this.labelSpeedValue.AutoSize = true;
            this.labelSpeedValue.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedValue.Location = new System.Drawing.Point(222, 490);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(21, 22);
            this.labelSpeedValue.TabIndex = 30;
            this.labelSpeedValue.Text = "0";
            // 
            // KMPHLabel
            // 
            this.KMPHLabel.AutoSize = true;
            this.KMPHLabel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMPHLabel.Location = new System.Drawing.Point(288, 490);
            this.KMPHLabel.Name = "KMPHLabel";
            this.KMPHLabel.Size = new System.Drawing.Size(61, 22);
            this.KMPHLabel.TabIndex = 31;
            this.KMPHLabel.Text = "Km/h";
            // 
            // SourceSelectLabel
            // 
            this.SourceSelectLabel.AutoSize = true;
            this.SourceSelectLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SourceSelectLabel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceSelectLabel.Location = new System.Drawing.Point(1104, 22);
            this.SourceSelectLabel.Name = "SourceSelectLabel";
            this.SourceSelectLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SourceSelectLabel.Size = new System.Drawing.Size(126, 22);
            this.SourceSelectLabel.TabIndex = 37;
            this.SourceSelectLabel.Text = "Select Source";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1171, 661);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(176, 16);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "a.tourani1991@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_ROI_size
            // 
            this.label_ROI_size.AutoSize = true;
            this.label_ROI_size.BackColor = System.Drawing.Color.Transparent;
            this.label_ROI_size.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ROI_size.Location = new System.Drawing.Point(15, 620);
            this.label_ROI_size.Name = "label_ROI_size";
            this.label_ROI_size.Size = new System.Drawing.Size(109, 20);
            this.label_ROI_size.TabIndex = 45;
            this.label_ROI_size.Text = "ROI Settings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 659);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1009, 141);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Frame-rate (FPS):";
            // 
            // labelFps
            // 
            this.labelFps.AutoSize = true;
            this.labelFps.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFps.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFps.Location = new System.Drawing.Point(1284, 141);
            this.labelFps.Name = "labelFps";
            this.labelFps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFps.Size = new System.Drawing.Size(13, 17);
            this.labelFps.TabIndex = 54;
            this.labelFps.Text = "-";
            // 
            // labelTotalFrames
            // 
            this.labelTotalFrames.AutoSize = true;
            this.labelTotalFrames.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotalFrames.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFrames.Location = new System.Drawing.Point(1284, 167);
            this.labelTotalFrames.Name = "labelTotalFrames";
            this.labelTotalFrames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTotalFrames.Size = new System.Drawing.Size(13, 17);
            this.labelTotalFrames.TabIndex = 56;
            this.labelTotalFrames.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1009, 167);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Number of frames:";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPlay.Location = new System.Drawing.Point(1084, 94);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(78, 31);
            this.buttonPlay.TabIndex = 57;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPause.Location = new System.Drawing.Point(1174, 94);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(68, 31);
            this.buttonPause.TabIndex = 58;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(1004, 94);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(74, 31);
            this.buttonPrevious.TabIndex = 59;
            this.buttonPrevious.Text = "Prev.";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(1248, 94);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonNext.Size = new System.Drawing.Size(59, 31);
            this.buttonNext.TabIndex = 60;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCurrent.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.Location = new System.Drawing.Point(1283, 192);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCurrent.Size = new System.Drawing.Size(13, 17);
            this.labelCurrent.TabIndex = 62;
            this.labelCurrent.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1008, 192);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Current frame:";
            // 
            // trackBarErode
            // 
            this.trackBarErode.LargeChange = 4;
            this.trackBarErode.Location = new System.Drawing.Point(116, 186);
            this.trackBarErode.Maximum = 12;
            this.trackBarErode.Minimum = 2;
            this.trackBarErode.Name = "trackBarErode";
            this.trackBarErode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarErode.Size = new System.Drawing.Size(232, 56);
            this.trackBarErode.SmallChange = 2;
            this.trackBarErode.TabIndex = 64;
            this.trackBarErode.Value = 10;
            this.trackBarErode.Scroll += new System.EventHandler(this.trackBarErode_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 183);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Erode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 294);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Gaussian";
            // 
            // trackBarGaussian
            // 
            this.trackBarGaussian.LargeChange = 10;
            this.trackBarGaussian.Location = new System.Drawing.Point(116, 284);
            this.trackBarGaussian.Maximum = 40;
            this.trackBarGaussian.Minimum = 5;
            this.trackBarGaussian.Name = "trackBarGaussian";
            this.trackBarGaussian.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarGaussian.Size = new System.Drawing.Size(232, 56);
            this.trackBarGaussian.SmallChange = 5;
            this.trackBarGaussian.TabIndex = 69;
            this.trackBarGaussian.Value = 10;
            this.trackBarGaussian.Scroll += new System.EventHandler(this.trackBarGaussian_Scroll);
            // 
            // trackBarRoiWidth
            // 
            this.trackBarRoiWidth.LargeChange = 10;
            this.trackBarRoiWidth.Location = new System.Drawing.Point(498, 621);
            this.trackBarRoiWidth.Margin = new System.Windows.Forms.Padding(1);
            this.trackBarRoiWidth.Maximum = 300;
            this.trackBarRoiWidth.Name = "trackBarRoiWidth";
            this.trackBarRoiWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarRoiWidth.RightToLeftLayout = true;
            this.trackBarRoiWidth.Size = new System.Drawing.Size(172, 56);
            this.trackBarRoiWidth.SmallChange = 5;
            this.trackBarRoiWidth.TabIndex = 72;
            this.trackBarRoiWidth.Value = 200;
            this.trackBarRoiWidth.Scroll += new System.EventHandler(this.trackBarRoiWidth_Scroll);
            // 
            // trackBarRoiH
            // 
            this.trackBarRoiH.LargeChange = 10;
            this.trackBarRoiH.Location = new System.Drawing.Point(275, 621);
            this.trackBarRoiH.Margin = new System.Windows.Forms.Padding(1);
            this.trackBarRoiH.Maximum = 300;
            this.trackBarRoiH.Name = "trackBarRoiH";
            this.trackBarRoiH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarRoiH.RightToLeftLayout = true;
            this.trackBarRoiH.Size = new System.Drawing.Size(181, 56);
            this.trackBarRoiH.SmallChange = 5;
            this.trackBarRoiH.TabIndex = 73;
            this.trackBarRoiH.Value = 200;
            this.trackBarRoiH.Scroll += new System.EventHandler(this.trackBarRoiH_Scroll);
            // 
            // trackBarRoiY
            // 
            this.trackBarRoiY.LargeChange = 10;
            this.trackBarRoiY.Location = new System.Drawing.Point(717, 621);
            this.trackBarRoiY.Margin = new System.Windows.Forms.Padding(1);
            this.trackBarRoiY.Maximum = 300;
            this.trackBarRoiY.Name = "trackBarRoiY";
            this.trackBarRoiY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarRoiY.RightToLeftLayout = true;
            this.trackBarRoiY.Size = new System.Drawing.Size(183, 56);
            this.trackBarRoiY.SmallChange = 5;
            this.trackBarRoiY.TabIndex = 77;
            this.trackBarRoiY.Value = 200;
            this.trackBarRoiY.Scroll += new System.EventHandler(this.trackBarRoiY_Scroll);
            // 
            // trackBarRoiX
            // 
            this.trackBarRoiX.LargeChange = 10;
            this.trackBarRoiX.Location = new System.Drawing.Point(928, 621);
            this.trackBarRoiX.Margin = new System.Windows.Forms.Padding(1);
            this.trackBarRoiX.Maximum = 500;
            this.trackBarRoiX.Name = "trackBarRoiX";
            this.trackBarRoiX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarRoiX.RightToLeftLayout = true;
            this.trackBarRoiX.Size = new System.Drawing.Size(192, 56);
            this.trackBarRoiX.SmallChange = 5;
            this.trackBarRoiX.TabIndex = 76;
            this.trackBarRoiX.Value = 200;
            this.trackBarRoiX.Scroll += new System.EventHandler(this.trackBarRoiX_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(734, 659);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 75;
            this.label11.Text = "Vertical Relocation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(939, 658);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 17);
            this.label12.TabIndex = 74;
            this.label12.Text = "Horizontal Relocation";
            // 
            // checkBoxGaussianEnabled
            // 
            this.checkBoxGaussianEnabled.AutoSize = true;
            this.checkBoxGaussianEnabled.Location = new System.Drawing.Point(11, 293);
            this.checkBoxGaussianEnabled.Name = "checkBoxGaussianEnabled";
            this.checkBoxGaussianEnabled.Size = new System.Drawing.Size(18, 17);
            this.checkBoxGaussianEnabled.TabIndex = 79;
            this.checkBoxGaussianEnabled.UseVisualStyleBackColor = true;
            this.checkBoxGaussianEnabled.CheckedChanged += new System.EventHandler(this.checkBoxGaussianEnabled_CheckedChanged);
            // 
            // checkBoxErode
            // 
            this.checkBoxErode.AutoSize = true;
            this.checkBoxErode.Location = new System.Drawing.Point(11, 183);
            this.checkBoxErode.Name = "checkBoxErode";
            this.checkBoxErode.Size = new System.Drawing.Size(18, 17);
            this.checkBoxErode.TabIndex = 80;
            this.checkBoxErode.UseVisualStyleBackColor = true;
            this.checkBoxErode.CheckedChanged += new System.EventHandler(this.checkBoxErode_CheckedChanged);
            // 
            // checkBoxDilate
            // 
            this.checkBoxDilate.AutoSize = true;
            this.checkBoxDilate.Location = new System.Drawing.Point(11, 236);
            this.checkBoxDilate.Name = "checkBoxDilate";
            this.checkBoxDilate.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDilate.TabIndex = 83;
            this.checkBoxDilate.UseVisualStyleBackColor = true;
            this.checkBoxDilate.CheckedChanged += new System.EventHandler(this.checkBoxDilate_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 236);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 82;
            this.label14.Text = "Dilate";
            // 
            // trackBarDilate
            // 
            this.trackBarDilate.LargeChange = 4;
            this.trackBarDilate.Location = new System.Drawing.Point(116, 235);
            this.trackBarDilate.Maximum = 12;
            this.trackBarDilate.Minimum = 2;
            this.trackBarDilate.Name = "trackBarDilate";
            this.trackBarDilate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarDilate.Size = new System.Drawing.Size(232, 56);
            this.trackBarDilate.SmallChange = 2;
            this.trackBarDilate.TabIndex = 81;
            this.trackBarDilate.Value = 12;
            this.trackBarDilate.Scroll += new System.EventHandler(this.trackBarDilate_Scroll);
            // 
            // checkBoxOpening
            // 
            this.checkBoxOpening.AutoSize = true;
            this.checkBoxOpening.Checked = true;
            this.checkBoxOpening.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpening.Location = new System.Drawing.Point(11, 128);
            this.checkBoxOpening.Name = "checkBoxOpening";
            this.checkBoxOpening.Size = new System.Drawing.Size(18, 17);
            this.checkBoxOpening.TabIndex = 87;
            this.checkBoxOpening.UseVisualStyleBackColor = true;
            this.checkBoxOpening.CheckedChanged += new System.EventHandler(this.checkBoxOpening_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 128);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 86;
            this.label15.Text = "Opening";
            // 
            // trackBarOpening
            // 
            this.trackBarOpening.LargeChange = 3;
            this.trackBarOpening.Location = new System.Drawing.Point(116, 125);
            this.trackBarOpening.Maximum = 30;
            this.trackBarOpening.Minimum = 1;
            this.trackBarOpening.Name = "trackBarOpening";
            this.trackBarOpening.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarOpening.Size = new System.Drawing.Size(232, 56);
            this.trackBarOpening.TabIndex = 85;
            this.trackBarOpening.Value = 10;
            this.trackBarOpening.Scroll += new System.EventHandler(this.trackBarOpening_Scroll);
            // 
            // labelOpeningValue
            // 
            this.labelOpeningValue.AutoSize = true;
            this.labelOpeningValue.BackColor = System.Drawing.Color.Transparent;
            this.labelOpeningValue.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpeningValue.Location = new System.Drawing.Point(354, 128);
            this.labelOpeningValue.Name = "labelOpeningValue";
            this.labelOpeningValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelOpeningValue.Size = new System.Drawing.Size(13, 16);
            this.labelOpeningValue.TabIndex = 88;
            this.labelOpeningValue.Text = "-";
            this.labelOpeningValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClosingValue
            // 
            this.labelClosingValue.AutoSize = true;
            this.labelClosingValue.BackColor = System.Drawing.Color.Transparent;
            this.labelClosingValue.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClosingValue.Location = new System.Drawing.Point(354, 23);
            this.labelClosingValue.Name = "labelClosingValue";
            this.labelClosingValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelClosingValue.Size = new System.Drawing.Size(13, 16);
            this.labelClosingValue.TabIndex = 92;
            this.labelClosingValue.Text = "-";
            this.labelClosingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxClosing
            // 
            this.checkBoxClosing.AutoSize = true;
            this.checkBoxClosing.Checked = true;
            this.checkBoxClosing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClosing.Location = new System.Drawing.Point(11, 23);
            this.checkBoxClosing.Name = "checkBoxClosing";
            this.checkBoxClosing.Size = new System.Drawing.Size(18, 17);
            this.checkBoxClosing.TabIndex = 91;
            this.checkBoxClosing.UseVisualStyleBackColor = true;
            this.checkBoxClosing.CheckedChanged += new System.EventHandler(this.checkBoxClosing_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(39, 23);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(60, 17);
            this.label18.TabIndex = 90;
            this.label18.Text = "Closing";
            // 
            // trackBarClosing
            // 
            this.trackBarClosing.LargeChange = 3;
            this.trackBarClosing.Location = new System.Drawing.Point(116, 19);
            this.trackBarClosing.Maximum = 30;
            this.trackBarClosing.Minimum = 1;
            this.trackBarClosing.Name = "trackBarClosing";
            this.trackBarClosing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarClosing.Size = new System.Drawing.Size(233, 56);
            this.trackBarClosing.TabIndex = 89;
            this.trackBarClosing.Value = 10;
            this.trackBarClosing.Scroll += new System.EventHandler(this.trackBarClosing_Scroll);
            // 
            // labelErodeValue
            // 
            this.labelErodeValue.AutoSize = true;
            this.labelErodeValue.BackColor = System.Drawing.Color.Transparent;
            this.labelErodeValue.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErodeValue.Location = new System.Drawing.Point(354, 186);
            this.labelErodeValue.Name = "labelErodeValue";
            this.labelErodeValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelErodeValue.Size = new System.Drawing.Size(13, 16);
            this.labelErodeValue.TabIndex = 93;
            this.labelErodeValue.Text = "-";
            this.labelErodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDilateValue
            // 
            this.labelDilateValue.AutoSize = true;
            this.labelDilateValue.BackColor = System.Drawing.Color.Transparent;
            this.labelDilateValue.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDilateValue.Location = new System.Drawing.Point(354, 236);
            this.labelDilateValue.Name = "labelDilateValue";
            this.labelDilateValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDilateValue.Size = new System.Drawing.Size(13, 16);
            this.labelDilateValue.TabIndex = 94;
            this.labelDilateValue.Text = "-";
            this.labelDilateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGaussianValue
            // 
            this.labelGaussianValue.AutoSize = true;
            this.labelGaussianValue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGaussianValue.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGaussianValue.Location = new System.Drawing.Point(354, 294);
            this.labelGaussianValue.Name = "labelGaussianValue";
            this.labelGaussianValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelGaussianValue.Size = new System.Drawing.Size(13, 16);
            this.labelGaussianValue.TabIndex = 95;
            this.labelGaussianValue.Text = "-";
            this.labelGaussianValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage9);
            this.tabControl.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(938, 585);
            this.tabControl.TabIndex = 96;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Video";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBoxDiffrence);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Frame Difference";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDiffrence
            // 
            this.pictureBoxDiffrence.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDiffrence.Name = "pictureBoxDiffrence";
            this.pictureBoxDiffrence.Size = new System.Drawing.Size(921, 545);
            this.pictureBoxDiffrence.TabIndex = 17;
            this.pictureBoxDiffrence.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBoxPreprocess);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(930, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPreprocess
            // 
            this.pictureBoxPreprocess.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPreprocess.Name = "pictureBoxPreprocess";
            this.pictureBoxPreprocess.Size = new System.Drawing.Size(921, 545);
            this.pictureBoxPreprocess.TabIndex = 18;
            this.pictureBoxPreprocess.TabStop = false;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Transparent;
            this.tabPage7.Controls.Add(this.labelMotionThresholdValue);
            this.tabPage7.Controls.Add(this.trackBarMotionThreshold);
            this.tabPage7.Controls.Add(this.label25);
            this.tabPage7.Controls.Add(this.listViewTracking);
            this.tabPage7.Controls.Add(this.pictureBoxROI);
            this.tabPage7.Controls.Add(this.labelSpeed);
            this.tabPage7.Controls.Add(this.labelSpeedValue);
            this.tabPage7.Controls.Add(this.KMPHLabel);
            this.tabPage7.Location = new System.Drawing.Point(4, 26);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(930, 555);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Speed Calculation";
            // 
            // labelMotionThresholdValue
            // 
            this.labelMotionThresholdValue.AutoSize = true;
            this.labelMotionThresholdValue.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotionThresholdValue.Location = new System.Drawing.Point(507, 490);
            this.labelMotionThresholdValue.Name = "labelMotionThresholdValue";
            this.labelMotionThresholdValue.Size = new System.Drawing.Size(16, 22);
            this.labelMotionThresholdValue.TabIndex = 103;
            this.labelMotionThresholdValue.Text = "-";
            // 
            // trackBarMotionThreshold
            // 
            this.trackBarMotionThreshold.LargeChange = 50;
            this.trackBarMotionThreshold.Location = new System.Drawing.Point(212, 401);
            this.trackBarMotionThreshold.Maximum = 300;
            this.trackBarMotionThreshold.Minimum = 1;
            this.trackBarMotionThreshold.Name = "trackBarMotionThreshold";
            this.trackBarMotionThreshold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarMotionThreshold.Size = new System.Drawing.Size(327, 56);
            this.trackBarMotionThreshold.TabIndex = 102;
            this.trackBarMotionThreshold.Value = 3;
            this.trackBarMotionThreshold.Scroll += new System.EventHandler(this.trackBarMotionThreshold_Scroll);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(16, 410);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(190, 20);
            this.label25.TabIndex = 54;
            this.label25.Text = "ROI to Threshold ratio:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listViewTracking
            // 
            this.listViewTracking.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewTracking.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewTracking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVehicleID,
            this.columnROI,
            this.columnPPrev,
            this.columnPCurr});
            this.listViewTracking.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTracking.FullRowSelect = true;
            this.listViewTracking.GridLines = true;
            listViewGroup1.Header = "شناسه خودرو";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "VehicleID";
            listViewGroup2.Header = "ناحیه موردنظر";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "ROI";
            listViewGroup3.Header = "موقعیت قبلی";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "PreviousLocation";
            listViewGroup4.Header = "موقعیت فعلی";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "CurrentLocation";
            this.listViewTracking.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listViewTracking.HideSelection = false;
            this.listViewTracking.HoverSelection = true;
            this.listViewTracking.Location = new System.Drawing.Point(559, 16);
            this.listViewTracking.Name = "listViewTracking";
            this.listViewTracking.Size = new System.Drawing.Size(351, 517);
            this.listViewTracking.TabIndex = 53;
            this.listViewTracking.UseCompatibleStateImageBehavior = false;
            this.listViewTracking.View = System.Windows.Forms.View.Details;
            // 
            // columnVehicleID
            // 
            this.columnVehicleID.Text = "ID";
            this.columnVehicleID.Width = 61;
            // 
            // columnROI
            // 
            this.columnROI.Text = "Lane";
            this.columnROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnROI.Width = 62;
            // 
            // columnPPrev
            // 
            this.columnPPrev.Text = "Frame";
            this.columnPPrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPPrev.Width = 77;
            // 
            // columnPCurr
            // 
            this.columnPCurr.Text = "Relocation (pixels)";
            this.columnPCurr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPCurr.Width = 110;
            // 
            // pictureBoxROI
            // 
            this.pictureBoxROI.Location = new System.Drawing.Point(20, 16);
            this.pictureBoxROI.Name = "pictureBoxROI";
            this.pictureBoxROI.Size = new System.Drawing.Size(519, 365);
            this.pictureBoxROI.TabIndex = 20;
            this.pictureBoxROI.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.listViewViolation);
            this.tabPage4.Controls.Add(this.trackBarViolationSet);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.labelViolationSet);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(930, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Detected Violations";
            // 
            // listViewViolation
            // 
            this.listViewViolation.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewViolation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewViolation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader14,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewViolation.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewViolation.FullRowSelect = true;
            this.listViewViolation.GridLines = true;
            listViewGroup5.Header = "شناسه خودرو";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "VehicleID";
            listViewGroup6.Header = "ناحیه موردنظر";
            listViewGroup6.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup6.Name = "ROI";
            listViewGroup7.Header = "موقعیت قبلی";
            listViewGroup7.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup7.Name = "PreviousLocation";
            listViewGroup8.Header = "موقعیت فعلی";
            listViewGroup8.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup8.Name = "CurrentLocation";
            this.listViewViolation.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.listViewViolation.HideSelection = false;
            this.listViewViolation.Location = new System.Drawing.Point(19, 68);
            this.listViewViolation.Name = "listViewViolation";
            this.listViewViolation.Size = new System.Drawing.Size(886, 466);
            this.listViewViolation.TabIndex = 106;
            this.listViewViolation.UseCompatibleStateImageBehavior = false;
            this.listViewViolation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vehicle image";
            this.columnHeader5.Width = 176;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 5;
            this.columnHeader7.Text = "ID";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 117;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 4;
            this.columnHeader6.Text = "Lane";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Frame number";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 143;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 2;
            this.columnHeader8.Text = "Speed";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 143;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 1;
            this.columnHeader9.Text = "Violations?";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 143;
            // 
            // trackBarViolationSet
            // 
            this.trackBarViolationSet.LargeChange = 10;
            this.trackBarViolationSet.Location = new System.Drawing.Point(418, 6);
            this.trackBarViolationSet.Maximum = 120;
            this.trackBarViolationSet.Minimum = 40;
            this.trackBarViolationSet.Name = "trackBarViolationSet";
            this.trackBarViolationSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarViolationSet.Size = new System.Drawing.Size(498, 56);
            this.trackBarViolationSet.SmallChange = 5;
            this.trackBarViolationSet.TabIndex = 105;
            this.trackBarViolationSet.Value = 90;
            this.trackBarViolationSet.Scroll += new System.EventHandler(this.trackBarViolationSet_Scroll);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(264, 20);
            this.label27.Name = "label27";
            this.label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label27.Size = new System.Drawing.Size(55, 20);
            this.label27.TabIndex = 103;
            this.label27.Text = "Km/h";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(15, 20);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label26.Size = new System.Drawing.Size(162, 20);
            this.label26.TabIndex = 102;
            this.label26.Text = "Max allowed speed:";
            // 
            // labelViolationSet
            // 
            this.labelViolationSet.AutoSize = true;
            this.labelViolationSet.BackColor = System.Drawing.Color.Transparent;
            this.labelViolationSet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViolationSet.Location = new System.Drawing.Point(214, 20);
            this.labelViolationSet.Name = "labelViolationSet";
            this.labelViolationSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelViolationSet.Size = new System.Drawing.Size(15, 20);
            this.labelViolationSet.TabIndex = 104;
            this.labelViolationSet.Text = "-";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Transparent;
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Controls.Add(this.listViewCalculatedXML);
            this.tabPage9.Controls.Add(this.LoadCalculatedXMLButton);
            this.tabPage9.Controls.Add(this.textBoxCalculatedXMLLoader);
            this.tabPage9.Controls.Add(this.label28);
            this.tabPage9.Controls.Add(this.listViewXMLLoad);
            this.tabPage9.Controls.Add(this.LoadXMLButton);
            this.tabPage9.Controls.Add(this.TextboxXMLLoader);
            this.tabPage9.Controls.Add(this.label24);
            this.tabPage9.Location = new System.Drawing.Point(4, 26);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(930, 555);
            this.tabPage9.TabIndex = 5;
            this.tabPage9.Text = "Accuracy Asessment";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(417, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 113;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewCalculatedXML
            // 
            this.listViewCalculatedXML.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewCalculatedXML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewCalculatedXML.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewCalculatedXML.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCalculatedXML.FullRowSelect = true;
            this.listViewCalculatedXML.GridLines = true;
            listViewGroup9.Header = "شناسه خودرو";
            listViewGroup9.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup9.Name = "VehicleID";
            listViewGroup10.Header = "ناحیه موردنظر";
            listViewGroup10.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup10.Name = "ROI";
            listViewGroup11.Header = "موقعیت قبلی";
            listViewGroup11.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup11.Name = "PreviousLocation";
            listViewGroup12.Header = "موقعیت فعلی";
            listViewGroup12.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup12.Name = "CurrentLocation";
            this.listViewCalculatedXML.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
            this.listViewCalculatedXML.HideSelection = false;
            this.listViewCalculatedXML.Location = new System.Drawing.Point(15, 77);
            this.listViewCalculatedXML.MultiSelect = false;
            this.listViewCalculatedXML.Name = "listViewCalculatedXML";
            this.listViewCalculatedXML.Size = new System.Drawing.Size(396, 458);
            this.listViewCalculatedXML.TabIndex = 112;
            this.listViewCalculatedXML.UseCompatibleStateImageBehavior = false;
            this.listViewCalculatedXML.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "VehicleID";
            this.columnHeader10.Width = 84;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ROI";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 44;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Exit frame";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 99;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Calculated Speed";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 161;
            // 
            // LoadCalculatedXMLButton
            // 
            this.LoadCalculatedXMLButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCalculatedXMLButton.Location = new System.Drawing.Point(15, 40);
            this.LoadCalculatedXMLButton.Name = "LoadCalculatedXMLButton";
            this.LoadCalculatedXMLButton.Size = new System.Drawing.Size(56, 31);
            this.LoadCalculatedXMLButton.TabIndex = 110;
            this.LoadCalculatedXMLButton.Text = "Load";
            this.LoadCalculatedXMLButton.UseVisualStyleBackColor = true;
            this.LoadCalculatedXMLButton.Click += new System.EventHandler(this.LoadCalculatedXMLButton_Click);
            // 
            // textBoxCalculatedXMLLoader
            // 
            this.textBoxCalculatedXMLLoader.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalculatedXMLLoader.Location = new System.Drawing.Point(77, 44);
            this.textBoxCalculatedXMLLoader.Name = "textBoxCalculatedXMLLoader";
            this.textBoxCalculatedXMLLoader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCalculatedXMLLoader.Size = new System.Drawing.Size(334, 23);
            this.textBoxCalculatedXMLLoader.TabIndex = 111;
            this.textBoxCalculatedXMLLoader.Text = "E:\\Dataset\\Dataset II - Speed Measurement\\Report.xml";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(11, 13);
            this.label28.Name = "label28";
            this.label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label28.Size = new System.Drawing.Size(263, 20);
            this.label28.TabIndex = 109;
            this.label28.Text = "Select calculated speed data (XML):";
            // 
            // listViewXMLLoad
            // 
            this.listViewXMLLoad.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewXMLLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listViewXMLLoad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewXMLLoad.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewXMLLoad.FullRowSelect = true;
            this.listViewXMLLoad.GridLines = true;
            listViewGroup13.Header = "Vehicle ID";
            listViewGroup13.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup13.Name = "VehicleID";
            listViewGroup14.Header = "ROI";
            listViewGroup14.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup14.Name = "ROI";
            listViewGroup15.Header = "Prev. location";
            listViewGroup15.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup15.Name = "PreviousLocation";
            listViewGroup16.Header = "Curr. location";
            listViewGroup16.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup16.Name = "CurrentLocation";
            this.listViewXMLLoad.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16});
            this.listViewXMLLoad.HideSelection = false;
            this.listViewXMLLoad.Location = new System.Drawing.Point(539, 77);
            this.listViewXMLLoad.MultiSelect = false;
            this.listViewXMLLoad.Name = "listViewXMLLoad";
            this.listViewXMLLoad.Size = new System.Drawing.Size(378, 458);
            this.listViewXMLLoad.TabIndex = 108;
            this.listViewXMLLoad.UseCompatibleStateImageBehavior = false;
            this.listViewXMLLoad.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lane";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Enter frame";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Exit frame";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ground-truth speed";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 138;
            // 
            // LoadXMLButton
            // 
            this.LoadXMLButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadXMLButton.Location = new System.Drawing.Point(539, 40);
            this.LoadXMLButton.Name = "LoadXMLButton";
            this.LoadXMLButton.Size = new System.Drawing.Size(56, 31);
            this.LoadXMLButton.TabIndex = 106;
            this.LoadXMLButton.Text = "Load";
            this.LoadXMLButton.UseVisualStyleBackColor = true;
            this.LoadXMLButton.Click += new System.EventHandler(this.LoadXMLButton_Click);
            // 
            // TextboxXMLLoader
            // 
            this.TextboxXMLLoader.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxXMLLoader.Location = new System.Drawing.Point(601, 45);
            this.TextboxXMLLoader.Name = "TextboxXMLLoader";
            this.TextboxXMLLoader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextboxXMLLoader.Size = new System.Drawing.Size(316, 23);
            this.TextboxXMLLoader.TabIndex = 107;
            this.TextboxXMLLoader.Text = "E:\\Dataset\\Dataset II - Speed Measurement\\Set01_video01.xml";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(535, 13);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label24.Size = new System.Drawing.Size(235, 20);
            this.label24.TabIndex = 101;
            this.label24.Text = "Enter ground-truth data (XML):";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(952, 231);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 379);
            this.tabControl1.TabIndex = 97;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage8.Controls.Add(this.CalibrationConstantButton);
            this.tabPage8.Controls.Add(this.label29);
            this.tabPage8.Controls.Add(this.CalibrationConstantTextbox);
            this.tabPage8.Controls.Add(this.labelPixelDensity);
            this.tabPage8.Controls.Add(this.label22);
            this.tabPage8.Controls.Add(this.Button_Ref_meter_Change);
            this.tabPage8.Controls.Add(this.label21);
            this.tabPage8.Controls.Add(this.labelROI_H);
            this.tabPage8.Controls.Add(this.label19);
            this.tabPage8.Controls.Add(this.textBox_Ref_meter);
            this.tabPage8.Controls.Add(this.label9);
            this.tabPage8.Controls.Add(this.labelVideoW);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.labelVideoH);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Location = new System.Drawing.Point(4, 26);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(392, 349);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Basic Settings";
            // 
            // CalibrationConstantButton
            // 
            this.CalibrationConstantButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibrationConstantButton.Location = new System.Drawing.Point(299, 148);
            this.CalibrationConstantButton.Name = "CalibrationConstantButton";
            this.CalibrationConstantButton.Size = new System.Drawing.Size(73, 31);
            this.CalibrationConstantButton.TabIndex = 111;
            this.CalibrationConstantButton.Text = "Set";
            this.CalibrationConstantButton.UseVisualStyleBackColor = true;
            this.CalibrationConstantButton.Click += new System.EventHandler(this.CalibrationConstantButton_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(11, 156);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label29.Size = new System.Drawing.Size(133, 17);
            this.label29.TabIndex = 113;
            this.label29.Text = "Calibration Const:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalibrationConstantTextbox
            // 
            this.CalibrationConstantTextbox.Location = new System.Drawing.Point(188, 152);
            this.CalibrationConstantTextbox.Name = "CalibrationConstantTextbox";
            this.CalibrationConstantTextbox.Size = new System.Drawing.Size(105, 25);
            this.CalibrationConstantTextbox.TabIndex = 112;
            this.CalibrationConstantTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPixelDensity
            // 
            this.labelPixelDensity.AutoSize = true;
            this.labelPixelDensity.BackColor = System.Drawing.Color.Transparent;
            this.labelPixelDensity.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPixelDensity.Location = new System.Drawing.Point(327, 195);
            this.labelPixelDensity.Name = "labelPixelDensity";
            this.labelPixelDensity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPixelDensity.Size = new System.Drawing.Size(13, 17);
            this.labelPixelDensity.TabIndex = 110;
            this.labelPixelDensity.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 195);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(159, 17);
            this.label22.TabIndex = 109;
            this.label22.Text = "Meters to Pixels ratio:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Ref_meter_Change
            // 
            this.Button_Ref_meter_Change.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Ref_meter_Change.Location = new System.Drawing.Point(299, 107);
            this.Button_Ref_meter_Change.Name = "Button_Ref_meter_Change";
            this.Button_Ref_meter_Change.Size = new System.Drawing.Size(73, 31);
            this.Button_Ref_meter_Change.TabIndex = 99;
            this.Button_Ref_meter_Change.Text = "Set";
            this.Button_Ref_meter_Change.UseVisualStyleBackColor = true;
            this.Button_Ref_meter_Change.Click += new System.EventHandler(this.Button_Ref_meter_Change_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 114);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(100, 17);
            this.label21.TabIndex = 108;
            this.label21.Text = "ROI (meters):";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelROI_H
            // 
            this.labelROI_H.AutoSize = true;
            this.labelROI_H.BackColor = System.Drawing.Color.Transparent;
            this.labelROI_H.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelROI_H.Location = new System.Drawing.Point(325, 75);
            this.labelROI_H.Name = "labelROI_H";
            this.labelROI_H.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelROI_H.Size = new System.Drawing.Size(13, 17);
            this.labelROI_H.TabIndex = 107;
            this.labelROI_H.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 76);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(116, 17);
            this.label19.TabIndex = 106;
            this.label19.Text = "ROI Resolution:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Ref_meter
            // 
            this.textBox_Ref_meter.Location = new System.Drawing.Point(188, 111);
            this.textBox_Ref_meter.Name = "textBox_Ref_meter";
            this.textBox_Ref_meter.Size = new System.Drawing.Size(105, 25);
            this.textBox_Ref_meter.TabIndex = 105;
            this.textBox_Ref_meter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 41);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 104;
            this.label9.Text = "Width:";
            // 
            // labelVideoW
            // 
            this.labelVideoW.AutoSize = true;
            this.labelVideoW.BackColor = System.Drawing.Color.Transparent;
            this.labelVideoW.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideoW.Location = new System.Drawing.Point(107, 41);
            this.labelVideoW.Name = "labelVideoW";
            this.labelVideoW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVideoW.Size = new System.Drawing.Size(13, 17);
            this.labelVideoW.TabIndex = 103;
            this.labelVideoW.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(185, 41);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 102;
            this.label16.Text = "Height:";
            // 
            // labelVideoH
            // 
            this.labelVideoH.AutoSize = true;
            this.labelVideoH.BackColor = System.Drawing.Color.Transparent;
            this.labelVideoH.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideoH.Location = new System.Drawing.Point(280, 41);
            this.labelVideoH.Name = "labelVideoH";
            this.labelVideoH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVideoH.Size = new System.Drawing.Size(13, 17);
            this.labelVideoH.TabIndex = 99;
            this.labelVideoH.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 101;
            this.label7.Text = "Resolution (pixels):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.trackBar_mog_noiseSigma);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label_mog_noiseSigma_);
            this.tabPage5.Controls.Add(this.trackBar_mog_backgroundRatio);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label_mog_backgroundRatio);
            this.tabPage5.Controls.Add(this.trackBar_mog_nMixtures);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label_mog_nMixtures);
            this.tabPage5.Controls.Add(this.trackBar_mog_history);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label_mog_history);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(392, 349);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Background Subtraction";
            // 
            // trackBar_mog_noiseSigma
            // 
            this.trackBar_mog_noiseSigma.LargeChange = 2;
            this.trackBar_mog_noiseSigma.Location = new System.Drawing.Point(21, 283);
            this.trackBar_mog_noiseSigma.Maximum = 2;
            this.trackBar_mog_noiseSigma.Name = "trackBar_mog_noiseSigma";
            this.trackBar_mog_noiseSigma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_mog_noiseSigma.Size = new System.Drawing.Size(273, 56);
            this.trackBar_mog_noiseSigma.TabIndex = 108;
            this.trackBar_mog_noiseSigma.Scroll += new System.EventHandler(this.trackBar_mog_noiseSigma_Scroll);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 257);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(86, 17);
            this.label20.TabIndex = 109;
            this.label20.Text = "Noise sigma:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mog_noiseSigma_
            // 
            this.label_mog_noiseSigma_.AutoSize = true;
            this.label_mog_noiseSigma_.BackColor = System.Drawing.Color.Transparent;
            this.label_mog_noiseSigma_.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mog_noiseSigma_.Location = new System.Drawing.Point(342, 283);
            this.label_mog_noiseSigma_.Name = "label_mog_noiseSigma_";
            this.label_mog_noiseSigma_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_mog_noiseSigma_.Size = new System.Drawing.Size(13, 16);
            this.label_mog_noiseSigma_.TabIndex = 110;
            this.label_mog_noiseSigma_.Text = "-";
            this.label_mog_noiseSigma_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_mog_backgroundRatio
            // 
            this.trackBar_mog_backgroundRatio.LargeChange = 2;
            this.trackBar_mog_backgroundRatio.Location = new System.Drawing.Point(21, 187);
            this.trackBar_mog_backgroundRatio.Name = "trackBar_mog_backgroundRatio";
            this.trackBar_mog_backgroundRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_mog_backgroundRatio.Size = new System.Drawing.Size(273, 56);
            this.trackBar_mog_backgroundRatio.TabIndex = 105;
            this.trackBar_mog_backgroundRatio.Value = 5;
            this.trackBar_mog_backgroundRatio.Scroll += new System.EventHandler(this.trackBar_mog_backgroundRatio_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 167);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(121, 17);
            this.label17.TabIndex = 106;
            this.label17.Text = "Background ratio:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mog_backgroundRatio
            // 
            this.label_mog_backgroundRatio.AutoSize = true;
            this.label_mog_backgroundRatio.BackColor = System.Drawing.Color.Transparent;
            this.label_mog_backgroundRatio.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mog_backgroundRatio.Location = new System.Drawing.Point(342, 187);
            this.label_mog_backgroundRatio.Name = "label_mog_backgroundRatio";
            this.label_mog_backgroundRatio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_mog_backgroundRatio.Size = new System.Drawing.Size(13, 16);
            this.label_mog_backgroundRatio.TabIndex = 107;
            this.label_mog_backgroundRatio.Text = "-";
            this.label_mog_backgroundRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_mog_nMixtures
            // 
            this.trackBar_mog_nMixtures.Location = new System.Drawing.Point(21, 104);
            this.trackBar_mog_nMixtures.Maximum = 20;
            this.trackBar_mog_nMixtures.Minimum = 1;
            this.trackBar_mog_nMixtures.Name = "trackBar_mog_nMixtures";
            this.trackBar_mog_nMixtures.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_mog_nMixtures.Size = new System.Drawing.Size(273, 56);
            this.trackBar_mog_nMixtures.SmallChange = 2;
            this.trackBar_mog_nMixtures.TabIndex = 102;
            this.trackBar_mog_nMixtures.Value = 15;
            this.trackBar_mog_nMixtures.Scroll += new System.EventHandler(this.trackBar_mog_nMixtures_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 84);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(208, 17);
            this.label13.TabIndex = 103;
            this.label13.Text = "Max no. of Gaussian parameters:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mog_nMixtures
            // 
            this.label_mog_nMixtures.AutoSize = true;
            this.label_mog_nMixtures.BackColor = System.Drawing.Color.Transparent;
            this.label_mog_nMixtures.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mog_nMixtures.Location = new System.Drawing.Point(341, 104);
            this.label_mog_nMixtures.Name = "label_mog_nMixtures";
            this.label_mog_nMixtures.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_mog_nMixtures.Size = new System.Drawing.Size(13, 16);
            this.label_mog_nMixtures.TabIndex = 104;
            this.label_mog_nMixtures.Text = "-";
            this.label_mog_nMixtures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_mog_history
            // 
            this.trackBar_mog_history.LargeChange = 50;
            this.trackBar_mog_history.Location = new System.Drawing.Point(21, 37);
            this.trackBar_mog_history.Maximum = 300;
            this.trackBar_mog_history.Minimum = 10;
            this.trackBar_mog_history.Name = "trackBar_mog_history";
            this.trackBar_mog_history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_mog_history.Size = new System.Drawing.Size(273, 56);
            this.trackBar_mog_history.SmallChange = 5;
            this.trackBar_mog_history.TabIndex = 99;
            this.trackBar_mog_history.Value = 15;
            this.trackBar_mog_history.Scroll += new System.EventHandler(this.trackBar_mog_history_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(232, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Number of applied previous frames:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mog_history
            // 
            this.label_mog_history.AutoSize = true;
            this.label_mog_history.BackColor = System.Drawing.Color.Transparent;
            this.label_mog_history.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mog_history.Location = new System.Drawing.Point(342, 37);
            this.label_mog_history.Name = "label_mog_history";
            this.label_mog_history.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_mog_history.Size = new System.Drawing.Size(13, 16);
            this.label_mog_history.TabIndex = 101;
            this.label_mog_history.Text = "-";
            this.label_mog_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.trackBarFillHoles);
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.checkBoxFillHoles);
            this.tabPage6.Controls.Add(this.labelFillHolesValue);
            this.tabPage6.Controls.Add(this.trackBarClosing);
            this.tabPage6.Controls.Add(this.labelGaussianValue);
            this.tabPage6.Controls.Add(this.checkBoxGaussianEnabled);
            this.tabPage6.Controls.Add(this.labelDilateValue);
            this.tabPage6.Controls.Add(this.trackBarOpening);
            this.tabPage6.Controls.Add(this.labelErodeValue);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.trackBarGaussian);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.checkBoxDilate);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.labelClosingValue);
            this.tabPage6.Controls.Add(this.trackBarDilate);
            this.tabPage6.Controls.Add(this.checkBoxOpening);
            this.tabPage6.Controls.Add(this.checkBoxErode);
            this.tabPage6.Controls.Add(this.checkBoxClosing);
            this.tabPage6.Controls.Add(this.labelOpeningValue);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.trackBarErode);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(392, 349);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Filters";
            // 
            // trackBarFillHoles
            // 
            this.trackBarFillHoles.Location = new System.Drawing.Point(116, 69);
            this.trackBarFillHoles.Maximum = 100;
            this.trackBarFillHoles.Minimum = 1;
            this.trackBarFillHoles.Name = "trackBarFillHoles";
            this.trackBarFillHoles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarFillHoles.Size = new System.Drawing.Size(232, 56);
            this.trackBarFillHoles.TabIndex = 96;
            this.trackBarFillHoles.Value = 10;
            this.trackBarFillHoles.Scroll += new System.EventHandler(this.trackBarFillHoles_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(39, 73);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(31, 17);
            this.label23.TabIndex = 97;
            this.label23.Text = "Fill";
            // 
            // checkBoxFillHoles
            // 
            this.checkBoxFillHoles.AutoSize = true;
            this.checkBoxFillHoles.Location = new System.Drawing.Point(11, 73);
            this.checkBoxFillHoles.Name = "checkBoxFillHoles";
            this.checkBoxFillHoles.Size = new System.Drawing.Size(18, 17);
            this.checkBoxFillHoles.TabIndex = 98;
            this.checkBoxFillHoles.UseVisualStyleBackColor = true;
            this.checkBoxFillHoles.CheckedChanged += new System.EventHandler(this.checkBoxFillHoles_CheckedChanged);
            // 
            // labelFillHolesValue
            // 
            this.labelFillHolesValue.AutoSize = true;
            this.labelFillHolesValue.BackColor = System.Drawing.Color.Transparent;
            this.labelFillHolesValue.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFillHolesValue.Location = new System.Drawing.Point(353, 72);
            this.labelFillHolesValue.Name = "labelFillHolesValue";
            this.labelFillHolesValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFillHolesValue.Size = new System.Drawing.Size(13, 16);
            this.labelFillHolesValue.TabIndex = 99;
            this.labelFillHolesValue.Text = "-";
            this.labelFillHolesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // فایلToolStripMenuItem
            // 
            this.فایلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بازکردنویدئوToolStripMenuItem});
            this.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            this.فایلToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.فایلToolStripMenuItem.Text = "File";
            // 
            // بازکردنویدئوToolStripMenuItem
            // 
            this.بازکردنویدئوToolStripMenuItem.Name = "بازکردنویدئوToolStripMenuItem";
            this.بازکردنویدئوToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.بازکردنویدئوToolStripMenuItem.Text = "Open Video ...";
            this.بازکردنویدئوToolStripMenuItem.Click += new System.EventHandler(this.بازکردنویدئوToolStripMenuItem_Click);
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کیلدهایراهنماToolStripMenuItem});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.راهنماToolStripMenuItem.Text = "Edit";
            // 
            // کیلدهایراهنماToolStripMenuItem
            // 
            this.کیلدهایراهنماToolStripMenuItem.Name = "کیلدهایراهنماToolStripMenuItem";
            this.کیلدهایراهنماToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.کیلدهایراهنماToolStripMenuItem.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فایلToolStripMenuItem,
            this.راهنماToolStripMenuItem,
            this.راهنماToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1364, 25);
            this.menuStrip1.TabIndex = 98;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // راهنماToolStripMenuItem1
            // 
            this.راهنماToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.میانبرهاToolStripMenuItem,
            this.دربارهToolStripMenuItem});
            this.راهنماToolStripMenuItem1.Name = "راهنماToolStripMenuItem1";
            this.راهنماToolStripMenuItem1.Size = new System.Drawing.Size(51, 21);
            this.راهنماToolStripMenuItem1.Text = "Help";
            // 
            // میانبرهاToolStripMenuItem
            // 
            this.میانبرهاToolStripMenuItem.Name = "میانبرهاToolStripMenuItem";
            this.میانبرهاToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.میانبرهاToolStripMenuItem.Text = "Shortcuts";
            this.میانبرهاToolStripMenuItem.Click += new System.EventHandler(this.میانبرهاToolStripMenuItem_Click);
            // 
            // دربارهToolStripMenuItem
            // 
            this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
            this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.دربارهToolStripMenuItem.Text = "About";
            this.دربارهToolStripMenuItem.Click += new System.EventHandler(this.دربارهToolStripMenuItem_Click);
            // 
            // button_ImageSet
            // 
            this.button_ImageSet.BackColor = System.Drawing.Color.Transparent;
            this.button_ImageSet.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ImageSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ImageSet.Location = new System.Drawing.Point(1004, 57);
            this.button_ImageSet.Name = "button_ImageSet";
            this.button_ImageSet.Size = new System.Drawing.Size(158, 31);
            this.button_ImageSet.TabIndex = 99;
            this.button_ImageSet.Text = "Choose Image-set";
            this.button_ImageSet.UseVisualStyleBackColor = false;
            this.button_ImageSet.Click += new System.EventHandler(this.button_ImageSet_Click);
            // 
            // labelROIEnabled
            // 
            this.labelROIEnabled.AutoSize = true;
            this.labelROIEnabled.BackColor = System.Drawing.Color.Transparent;
            this.labelROIEnabled.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelROIEnabled.Location = new System.Drawing.Point(55, 650);
            this.labelROIEnabled.Name = "labelROIEnabled";
            this.labelROIEnabled.Size = new System.Drawing.Size(130, 16);
            this.labelROIEnabled.TabIndex = 100;
            this.labelROIEnabled.Text = "Enable/Disable ROI";
            // 
            // checkBoxROIEnabled
            // 
            this.checkBoxROIEnabled.AutoSize = true;
            this.checkBoxROIEnabled.Checked = true;
            this.checkBoxROIEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxROIEnabled.Location = new System.Drawing.Point(31, 649);
            this.checkBoxROIEnabled.Name = "checkBoxROIEnabled";
            this.checkBoxROIEnabled.Size = new System.Drawing.Size(18, 17);
            this.checkBoxROIEnabled.TabIndex = 100;
            this.checkBoxROIEnabled.UseVisualStyleBackColor = true;
            this.checkBoxROIEnabled.CheckedChanged += new System.EventHandler(this.checkBoxROIEnabled_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1364, 683);
            this.Controls.Add(this.checkBoxROIEnabled);
            this.Controls.Add(this.labelROIEnabled);
            this.Controls.Add(this.button_ImageSet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.trackBarRoiX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelTotalFrames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ROI_size);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SourceSelectLabel);
            this.Controls.Add(this.button_select_video);
            this.Controls.Add(this.trackBarRoiY);
            this.Controls.Add(this.trackBarRoiWidth);
            this.Controls.Add(this.trackBarRoiH);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Vehicle Speed Calculation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarErode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGaussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoiX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClosing)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiffrence)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreprocess)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMotionThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROI)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarViolationSet)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_noiseSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_backgroundRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_nMixtures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mog_history)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFillHoles)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_select_video;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSpeedValue;
        private System.Windows.Forms.Label KMPHLabel;
        private System.Windows.Forms.Label SourceSelectLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_ROI_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFps;
        private System.Windows.Forms.Label labelTotalFrames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarErode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarGaussian;
        private System.Windows.Forms.TrackBar trackBarRoiWidth;
        private System.Windows.Forms.TrackBar trackBarRoiH;
        private System.Windows.Forms.TrackBar trackBarRoiY;
        private System.Windows.Forms.TrackBar trackBarRoiX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxGaussianEnabled;
        private System.Windows.Forms.CheckBox checkBoxErode;
        private System.Windows.Forms.CheckBox checkBoxDilate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBarDilate;
        private System.Windows.Forms.CheckBox checkBoxOpening;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trackBarOpening;
        private System.Windows.Forms.Label labelOpeningValue;
        private System.Windows.Forms.Label labelClosingValue;
        private System.Windows.Forms.CheckBox checkBoxClosing;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackBarClosing;
        private System.Windows.Forms.Label labelErodeValue;
        private System.Windows.Forms.Label labelDilateValue;
        private System.Windows.Forms.Label labelGaussianValue;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxDiffrence;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBoxPreprocess;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ToolStripMenuItem فایلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کیلدهایراهنماToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem میانبرهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازکردنویدئوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar_mog_history;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_mog_history;
        private System.Windows.Forms.TrackBar trackBar_mog_nMixtures;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_mog_nMixtures;
        private System.Windows.Forms.TrackBar trackBar_mog_backgroundRatio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_mog_backgroundRatio;
        private System.Windows.Forms.TrackBar trackBar_mog_noiseSigma;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_mog_noiseSigma_;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox pictureBoxROI;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelVideoW;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelVideoH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Ref_meter;
        private System.Windows.Forms.Label labelROI_H;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Button_Ref_meter_Change;
        private System.Windows.Forms.Label labelPixelDensity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TrackBar trackBarFillHoles;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox checkBoxFillHoles;
        private System.Windows.Forms.Label labelFillHolesValue;
        private System.Windows.Forms.Button button_ImageSet;
        private System.Windows.Forms.ListView listViewTracking;
        private System.Windows.Forms.ColumnHeader columnVehicleID;
        private System.Windows.Forms.ColumnHeader columnROI;
        private System.Windows.Forms.ColumnHeader columnPPrev;
        private System.Windows.Forms.ColumnHeader columnPCurr;
        private System.Windows.Forms.Label labelROIEnabled;
        private System.Windows.Forms.CheckBox checkBoxROIEnabled;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button LoadXMLButton;
        private System.Windows.Forms.TextBox TextboxXMLLoader;
        private System.Windows.Forms.ListView listViewXMLLoad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TrackBar trackBarMotionThreshold;
        private System.Windows.Forms.TrackBar trackBarViolationSet;
        private System.Windows.Forms.Label labelViolationSet;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListView listViewViolation;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView listViewCalculatedXML;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button LoadCalculatedXMLButton;
        private System.Windows.Forms.TextBox textBoxCalculatedXMLLoader;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CalibrationConstantButton;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox CalibrationConstantTextbox;
        private System.Windows.Forms.Label labelMotionThresholdValue;
    }
}

