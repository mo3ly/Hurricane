namespace HurricaneServiceManager
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HurricaneText = new System.Windows.Forms.PictureBox();
            this.pButtom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pDirShortcutsButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.HideAppButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.LogClear = new System.Windows.Forms.Button();
            this.pNavButtons = new System.Windows.Forms.Panel();
            this.sDataButton = new System.Windows.Forms.Button();
            this.pStatisticsButton = new System.Windows.Forms.Button();
            this.pConnectionButton = new System.Windows.Forms.Button();
            this.mContent = new System.Windows.Forms.Panel();
            this.sLogList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pLogList = new System.Windows.Forms.Panel();
            this.pManagmentButton = new System.Windows.Forms.Button();
            this.pSlideTimer = new System.Windows.Forms.Timer(this.components);
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HurricaneText)).BeginInit();
            this.pButtom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pNavButtons.SuspendLayout();
            this.pLogList.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HeaderPanel.Controls.Add(this.LogoLabel);
            this.HeaderPanel.Controls.Add(this.HurricaneText);
            this.HeaderPanel.Controls.Add(this.Logo);
            this.HeaderPanel.Controls.Add(this.minimizeButton);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(2, 2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1000, 40);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageLocation = "";
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(43, 40);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(938, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 40);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(969, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 40);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.White;
            this.LogoLabel.Location = new System.Drawing.Point(45, 23);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(90, 14);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Service Manager";
            // 
            // HurricaneText
            // 
            this.HurricaneText.Image = ((System.Drawing.Image)(resources.GetObject("HurricaneText.Image")));
            this.HurricaneText.ImageLocation = "";
            this.HurricaneText.InitialImage = ((System.Drawing.Image)(resources.GetObject("HurricaneText.InitialImage")));
            this.HurricaneText.Location = new System.Drawing.Point(43, -7);
            this.HurricaneText.Name = "HurricaneText";
            this.HurricaneText.Size = new System.Drawing.Size(167, 40);
            this.HurricaneText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HurricaneText.TabIndex = 9;
            this.HurricaneText.TabStop = false;
            // 
            // pButtom
            // 
            this.pButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pButtom.Controls.Add(this.label1);
            this.pButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtom.Location = new System.Drawing.Point(42, 664);
            this.pButtom.Name = "pButtom";
            this.pButtom.Size = new System.Drawing.Size(960, 15);
            this.pButtom.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Copyright © HURRICANE 2022 — Powered by Exoria";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.pDirShortcutsButton);
            this.panel2.Controls.Add(this.configButton);
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.HideAppButton);
            this.panel2.Controls.Add(this.LogButton);
            this.panel2.Controls.Add(this.MenuButton);
            this.panel2.Controls.Add(this.LogClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(2, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 637);
            this.panel2.TabIndex = 12;
            // 
            // pDirShortcutsButton
            // 
            this.pDirShortcutsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pDirShortcutsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDirShortcutsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pDirShortcutsButton.FlatAppearance.BorderSize = 0;
            this.pDirShortcutsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.pDirShortcutsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pDirShortcutsButton.Image = ((System.Drawing.Image)(resources.GetObject("pDirShortcutsButton.Image")));
            this.pDirShortcutsButton.Location = new System.Drawing.Point(0, 397);
            this.pDirShortcutsButton.Name = "pDirShortcutsButton";
            this.pDirShortcutsButton.Size = new System.Drawing.Size(40, 40);
            this.pDirShortcutsButton.TabIndex = 16;
            this.pDirShortcutsButton.Tag = "Directories shorcuts";
            this.pDirShortcutsButton.UseVisualStyleBackColor = false;
            this.pDirShortcutsButton.Click += new System.EventHandler(this.pDirShortcutsButton_Click);
            // 
            // configButton
            // 
            this.configButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.configButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.configButton.FlatAppearance.BorderSize = 0;
            this.configButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.Image = ((System.Drawing.Image)(resources.GetObject("configButton.Image")));
            this.configButton.Location = new System.Drawing.Point(0, 437);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(40, 40);
            this.configButton.TabIndex = 13;
            this.configButton.Tag = "Save config";
            this.configButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(0, 477);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(40, 40);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.Tag = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // HideAppButton
            // 
            this.HideAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.HideAppButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HideAppButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HideAppButton.FlatAppearance.BorderSize = 0;
            this.HideAppButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.HideAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideAppButton.Image = ((System.Drawing.Image)(resources.GetObject("HideAppButton.Image")));
            this.HideAppButton.Location = new System.Drawing.Point(0, 517);
            this.HideAppButton.Name = "HideAppButton";
            this.HideAppButton.Size = new System.Drawing.Size(40, 40);
            this.HideAppButton.TabIndex = 5;
            this.HideAppButton.Tag = "Hide appliction";
            this.HideAppButton.UseVisualStyleBackColor = false;
            // 
            // LogButton
            // 
            this.LogButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LogButton.FlatAppearance.BorderSize = 0;
            this.LogButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Image = ((System.Drawing.Image)(resources.GetObject("LogButton.Image")));
            this.LogButton.Location = new System.Drawing.Point(0, 557);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(40, 40);
            this.LogButton.TabIndex = 3;
            this.LogButton.Tag = "Show/Hide Log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.Location = new System.Drawing.Point(3, 6);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(34, 31);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // LogClear
            // 
            this.LogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.LogClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LogClear.FlatAppearance.BorderSize = 0;
            this.LogClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.LogClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogClear.Image = ((System.Drawing.Image)(resources.GetObject("LogClear.Image")));
            this.LogClear.Location = new System.Drawing.Point(0, 597);
            this.LogClear.Name = "LogClear";
            this.LogClear.Size = new System.Drawing.Size(40, 40);
            this.LogClear.TabIndex = 4;
            this.LogClear.Tag = "Clear Log";
            this.LogClear.UseVisualStyleBackColor = false;
            this.LogClear.Click += new System.EventHandler(this.LogClear_Click);
            // 
            // pNavButtons
            // 
            this.pNavButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pNavButtons.Controls.Add(this.pManagmentButton);
            this.pNavButtons.Controls.Add(this.sDataButton);
            this.pNavButtons.Controls.Add(this.pStatisticsButton);
            this.pNavButtons.Controls.Add(this.pConnectionButton);
            this.pNavButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pNavButtons.Location = new System.Drawing.Point(42, 42);
            this.pNavButtons.Name = "pNavButtons";
            this.pNavButtons.Size = new System.Drawing.Size(200, 622);
            this.pNavButtons.TabIndex = 15;
            // 
            // sDataButton
            // 
            this.sDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sDataButton.FlatAppearance.BorderSize = 0;
            this.sDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sDataButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDataButton.ForeColor = System.Drawing.Color.White;
            this.sDataButton.Image = ((System.Drawing.Image)(resources.GetObject("sDataButton.Image")));
            this.sDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sDataButton.Location = new System.Drawing.Point(0, 84);
            this.sDataButton.Name = "sDataButton";
            this.sDataButton.Size = new System.Drawing.Size(200, 42);
            this.sDataButton.TabIndex = 17;
            this.sDataButton.Text = "Data Analysis";
            this.sDataButton.UseVisualStyleBackColor = true;
            // 
            // pStatisticsButton
            // 
            this.pStatisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatisticsButton.FlatAppearance.BorderSize = 0;
            this.pStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pStatisticsButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pStatisticsButton.ForeColor = System.Drawing.Color.White;
            this.pStatisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("pStatisticsButton.Image")));
            this.pStatisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pStatisticsButton.Location = new System.Drawing.Point(0, 42);
            this.pStatisticsButton.Name = "pStatisticsButton";
            this.pStatisticsButton.Size = new System.Drawing.Size(200, 42);
            this.pStatisticsButton.TabIndex = 6;
            this.pStatisticsButton.Text = "Statistics";
            this.pStatisticsButton.UseVisualStyleBackColor = true;
            // 
            // pConnectionButton
            // 
            this.pConnectionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pConnectionButton.FlatAppearance.BorderSize = 0;
            this.pConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pConnectionButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pConnectionButton.ForeColor = System.Drawing.Color.White;
            this.pConnectionButton.Image = ((System.Drawing.Image)(resources.GetObject("pConnectionButton.Image")));
            this.pConnectionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pConnectionButton.Location = new System.Drawing.Point(0, 0);
            this.pConnectionButton.Name = "pConnectionButton";
            this.pConnectionButton.Size = new System.Drawing.Size(200, 42);
            this.pConnectionButton.TabIndex = 6;
            this.pConnectionButton.Text = "Connection";
            this.pConnectionButton.UseVisualStyleBackColor = true;
            // 
            // mContent
            // 
            this.mContent.BackColor = System.Drawing.SystemColors.Control;
            this.mContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mContent.Location = new System.Drawing.Point(242, 42);
            this.mContent.Margin = new System.Windows.Forms.Padding(2);
            this.mContent.Name = "mContent";
            this.mContent.Size = new System.Drawing.Size(760, 512);
            this.mContent.TabIndex = 16;
            // 
            // sLogList
            // 
            this.sLogList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sLogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sLogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.sLogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sLogList.ForeColor = System.Drawing.Color.White;
            this.sLogList.FullRowSelect = true;
            this.sLogList.GridLines = true;
            this.sLogList.HideSelection = false;
            this.sLogList.Location = new System.Drawing.Point(0, 0);
            this.sLogList.MultiSelect = false;
            this.sLogList.Name = "sLogList";
            this.sLogList.Size = new System.Drawing.Size(760, 110);
            this.sLogList.TabIndex = 10;
            this.sLogList.UseCompatibleStateImageBehavior = false;
            this.sLogList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Message";
            this.columnHeader6.Width = 600;
            // 
            // pLogList
            // 
            this.pLogList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pLogList.Controls.Add(this.sLogList);
            this.pLogList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLogList.ForeColor = System.Drawing.Color.White;
            this.pLogList.Location = new System.Drawing.Point(242, 554);
            this.pLogList.Name = "pLogList";
            this.pLogList.Size = new System.Drawing.Size(760, 110);
            this.pLogList.TabIndex = 17;
            // 
            // pManagmentButton
            // 
            this.pManagmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pManagmentButton.FlatAppearance.BorderSize = 0;
            this.pManagmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pManagmentButton.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pManagmentButton.ForeColor = System.Drawing.Color.White;
            this.pManagmentButton.Image = ((System.Drawing.Image)(resources.GetObject("pManagmentButton.Image")));
            this.pManagmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pManagmentButton.Location = new System.Drawing.Point(0, 126);
            this.pManagmentButton.Name = "pManagmentButton";
            this.pManagmentButton.Size = new System.Drawing.Size(200, 42);
            this.pManagmentButton.TabIndex = 23;
            this.pManagmentButton.Text = "Modules Manager";
            this.pManagmentButton.UseVisualStyleBackColor = true;
            // 
            // pSlideTimer
            // 
            this.pSlideTimer.Interval = 1;
            this.pSlideTimer.Tick += new System.EventHandler(this.pSlideTimer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1004, 681);
            this.Controls.Add(this.mContent);
            this.Controls.Add(this.pLogList);
            this.Controls.Add(this.pNavButtons);
            this.Controls.Add(this.pButtom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hurricane Service Manager";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HurricaneText)).EndInit();
            this.pButtom.ResumeLayout(false);
            this.pButtom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pNavButtons.ResumeLayout(false);
            this.pLogList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox HurricaneText;
        private System.Windows.Forms.Panel pButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button pDirShortcutsButton;
        internal System.Windows.Forms.Button configButton;
        internal System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button HideAppButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button LogClear;
        internal System.Windows.Forms.Panel pNavButtons;
        private System.Windows.Forms.Button sDataButton;
        internal System.Windows.Forms.Button pStatisticsButton;
        private System.Windows.Forms.Button pConnectionButton;
        private System.Windows.Forms.Panel mContent;
        private System.Windows.Forms.ListView sLogList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel pLogList;
        private System.Windows.Forms.Button pManagmentButton;
        private System.Windows.Forms.Timer pSlideTimer;
    }
}

