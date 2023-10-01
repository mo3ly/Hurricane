namespace Hurricane_DeveloperTool.Views
{
    partial class DashboardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelContentContainer = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.logPanel = new System.Windows.Forms.Panel();
            this.logsGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewImageColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.loadingProgressBar = new Hurricane_DeveloperTool.HurricaneControls.HurricaneProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarBasePanel = new System.Windows.Forms.Panel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.hurricaneButton3 = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.hurricaneButton2 = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.hurricaneButton1 = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.buttonGuide = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.hurricaneButton5 = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.hurricaneButton4 = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.buttonStatistics = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.buttonConnection = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.panelTitleHeader = new System.Windows.Forms.Panel();
            this.dropMenuButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.notifyTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownMenu = new Hurricane_DeveloperTool.HurricaneControls.HurricaneDropdownMenu(this.components);
            this.hideToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBase.SuspendLayout();
            this.panelContentContainer.SuspendLayout();
            this.logPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsGrid)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.sidebarBasePanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.panelTitleHeader.SuspendLayout();
            this.dropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.Transparent;
            this.panelBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBase.BackgroundImage")));
            this.panelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBase.Controls.Add(this.panelContentContainer);
            this.panelBase.Controls.Add(this.logPanel);
            this.panelBase.Controls.Add(this.footerPanel);
            this.panelBase.Controls.Add(this.sidebarBasePanel);
            this.panelBase.Controls.Add(this.panelTitleHeader);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1250, 850);
            this.panelBase.TabIndex = 0;
            // 
            // panelContentContainer
            // 
            this.panelContentContainer.Controls.Add(this.panelContent);
            this.panelContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentContainer.Location = new System.Drawing.Point(256, 64);
            this.panelContentContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContentContainer.Name = "panelContentContainer";
            this.panelContentContainer.Padding = new System.Windows.Forms.Padding(12, 12, 15, 15);
            this.panelContentContainer.Size = new System.Drawing.Size(994, 579);
            this.panelContentContainer.TabIndex = 4;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(967, 552);
            this.panelContent.TabIndex = 3;
            // 
            // logPanel
            // 
            this.logPanel.Controls.Add(this.logsGrid);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logPanel.Location = new System.Drawing.Point(256, 643);
            this.logPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(994, 178);
            this.logPanel.TabIndex = 3;
            // 
            // logsGrid
            // 
            this.logsGrid.AllowUserToAddRows = false;
            this.logsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.logsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logsGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.logsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.logsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.logsGrid.ColumnHeadersHeight = 28;
            this.logsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Message,
            this.Time});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.logsGrid.EnableHeadersVisualStyles = false;
            this.logsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.logsGrid.Location = new System.Drawing.Point(12, 10);
            this.logsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.logsGrid.MultiSelect = false;
            this.logsGrid.Name = "logsGrid";
            this.logsGrid.ReadOnly = true;
            this.logsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.logsGrid.RowHeadersVisible = false;
            this.logsGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.logsGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.logsGrid.RowTemplate.Height = 20;
            this.logsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logsGrid.Size = new System.Drawing.Size(965, 160);
            this.logsGrid.TabIndex = 48;
            // 
            // id
            // 
            this.id.FillWeight = 10F;
            this.id.HeaderText = "";
            this.id.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.FillWeight = 30F;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.label2);
            this.footerPanel.Controls.Add(this.loadingProgressBar);
            this.footerPanel.Controls.Add(this.label4);
            this.footerPanel.Controls.Add(this.label1);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(256, 821);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(994, 29);
            this.footerPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(471, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "90%";
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loadingProgressBar.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loadingProgressBar.ChannelHeight = 7;
            this.loadingProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingProgressBar.ForeBackColor = System.Drawing.Color.Transparent;
            this.loadingProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.loadingProgressBar.Location = new System.Drawing.Point(494, 8);
            this.loadingProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.ShowMaximun = false;
            this.loadingProgressBar.ShowValue = Hurricane_DeveloperTool.HurricaneControls.HurricaneProgressBar.TextPosition.None;
            this.loadingProgressBar.Size = new System.Drawing.Size(312, 9);
            this.loadingProgressBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.loadingProgressBar.SliderHeight = 7;
            this.loadingProgressBar.SymbolAfter = "";
            this.loadingProgressBar.SymbolBefore = "";
            this.loadingProgressBar.TabIndex = 71;
            this.loadingProgressBar.Value = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(934, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ver 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Copyright © HURRICANE 2022 — Powered by Exoria";
            // 
            // sidebarBasePanel
            // 
            this.sidebarBasePanel.Controls.Add(this.sidebarPanel);
            this.sidebarBasePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarBasePanel.Location = new System.Drawing.Point(0, 64);
            this.sidebarBasePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebarBasePanel.Name = "sidebarBasePanel";
            this.sidebarBasePanel.Size = new System.Drawing.Size(256, 786);
            this.sidebarBasePanel.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.sidebarPanel.Controls.Add(this.hurricaneButton3);
            this.sidebarPanel.Controls.Add(this.hurricaneButton2);
            this.sidebarPanel.Controls.Add(this.hurricaneButton1);
            this.sidebarPanel.Controls.Add(this.buttonGuide);
            this.sidebarPanel.Controls.Add(this.hurricaneButton5);
            this.sidebarPanel.Controls.Add(this.hurricaneButton4);
            this.sidebarPanel.Controls.Add(this.buttonStatistics);
            this.sidebarPanel.Controls.Add(this.buttonConnection);
            this.sidebarPanel.Location = new System.Drawing.Point(11, 12);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(236, 758);
            this.sidebarPanel.TabIndex = 0;
            // 
            // hurricaneButton3
            // 
            this.hurricaneButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hurricaneButton3.BorderRadius = 6;
            this.hurricaneButton3.BorderSize = 2;
            this.hurricaneButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurricaneButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.hurricaneButton3.FlatAppearance.BorderSize = 0;
            this.hurricaneButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hurricaneButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurricaneButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton3.Image = ((System.Drawing.Image)(resources.GetObject("hurricaneButton3.Image")));
            this.hurricaneButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hurricaneButton3.Location = new System.Drawing.Point(0, 300);
            this.hurricaneButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hurricaneButton3.Name = "hurricaneButton3";
            this.hurricaneButton3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hurricaneButton3.Size = new System.Drawing.Size(236, 50);
            this.hurricaneButton3.TabIndex = 9;
            this.hurricaneButton3.Text = "Realtime commands";
            this.hurricaneButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hurricaneButton3.TextColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton3.UseVisualStyleBackColor = false;
            // 
            // hurricaneButton2
            // 
            this.hurricaneButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hurricaneButton2.BorderRadius = 6;
            this.hurricaneButton2.BorderSize = 2;
            this.hurricaneButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurricaneButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hurricaneButton2.FlatAppearance.BorderSize = 0;
            this.hurricaneButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hurricaneButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurricaneButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton2.Image = ((System.Drawing.Image)(resources.GetObject("hurricaneButton2.Image")));
            this.hurricaneButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hurricaneButton2.Location = new System.Drawing.Point(0, 250);
            this.hurricaneButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hurricaneButton2.Name = "hurricaneButton2";
            this.hurricaneButton2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hurricaneButton2.Size = new System.Drawing.Size(236, 50);
            this.hurricaneButton2.TabIndex = 8;
            this.hurricaneButton2.Text = "Task schedular";
            this.hurricaneButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hurricaneButton2.TextColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton2.UseVisualStyleBackColor = false;
            // 
            // hurricaneButton1
            // 
            this.hurricaneButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hurricaneButton1.BorderRadius = 6;
            this.hurricaneButton1.BorderSize = 2;
            this.hurricaneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurricaneButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hurricaneButton1.FlatAppearance.BorderSize = 0;
            this.hurricaneButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hurricaneButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurricaneButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton1.Image = ((System.Drawing.Image)(resources.GetObject("hurricaneButton1.Image")));
            this.hurricaneButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hurricaneButton1.Location = new System.Drawing.Point(0, 200);
            this.hurricaneButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hurricaneButton1.Name = "hurricaneButton1";
            this.hurricaneButton1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hurricaneButton1.Size = new System.Drawing.Size(236, 50);
            this.hurricaneButton1.TabIndex = 7;
            this.hurricaneButton1.Text = "Settings";
            this.hurricaneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hurricaneButton1.TextColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton1.UseVisualStyleBackColor = false;
            // 
            // buttonGuide
            // 
            this.buttonGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGuide.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGuide.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonGuide.BorderRadius = 6;
            this.buttonGuide.BorderSize = 0;
            this.buttonGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGuide.FlatAppearance.BorderSize = 0;
            this.buttonGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuide.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGuide.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuide.Image")));
            this.buttonGuide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuide.Location = new System.Drawing.Point(0, 708);
            this.buttonGuide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGuide.Name = "buttonGuide";
            this.buttonGuide.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonGuide.Size = new System.Drawing.Size(236, 50);
            this.buttonGuide.TabIndex = 6;
            this.buttonGuide.Text = "Guides";
            this.buttonGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuide.TextColor = System.Drawing.Color.Gainsboro;
            this.buttonGuide.UseVisualStyleBackColor = false;
            // 
            // hurricaneButton5
            // 
            this.hurricaneButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hurricaneButton5.BorderRadius = 6;
            this.hurricaneButton5.BorderSize = 2;
            this.hurricaneButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurricaneButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.hurricaneButton5.FlatAppearance.BorderSize = 0;
            this.hurricaneButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hurricaneButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurricaneButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton5.Image = ((System.Drawing.Image)(resources.GetObject("hurricaneButton5.Image")));
            this.hurricaneButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hurricaneButton5.Location = new System.Drawing.Point(0, 150);
            this.hurricaneButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hurricaneButton5.Name = "hurricaneButton5";
            this.hurricaneButton5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hurricaneButton5.Size = new System.Drawing.Size(236, 50);
            this.hurricaneButton5.TabIndex = 5;
            this.hurricaneButton5.Text = "Database";
            this.hurricaneButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hurricaneButton5.TextColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton5.UseVisualStyleBackColor = false;
            // 
            // hurricaneButton4
            // 
            this.hurricaneButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hurricaneButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hurricaneButton4.BorderRadius = 6;
            this.hurricaneButton4.BorderSize = 2;
            this.hurricaneButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hurricaneButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.hurricaneButton4.FlatAppearance.BorderSize = 0;
            this.hurricaneButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hurricaneButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurricaneButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton4.Image = ((System.Drawing.Image)(resources.GetObject("hurricaneButton4.Image")));
            this.hurricaneButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hurricaneButton4.Location = new System.Drawing.Point(0, 100);
            this.hurricaneButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hurricaneButton4.Name = "hurricaneButton4";
            this.hurricaneButton4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hurricaneButton4.Size = new System.Drawing.Size(236, 50);
            this.hurricaneButton4.TabIndex = 4;
            this.hurricaneButton4.Text = "Services";
            this.hurricaneButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hurricaneButton4.TextColor = System.Drawing.Color.Gainsboro;
            this.hurricaneButton4.UseVisualStyleBackColor = false;
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonStatistics.BorderRadius = 6;
            this.buttonStatistics.BorderSize = 2;
            this.buttonStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStatistics.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatistics.Image")));
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatistics.Location = new System.Drawing.Point(0, 50);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStatistics.Size = new System.Drawing.Size(236, 50);
            this.buttonStatistics.TabIndex = 3;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.TextColor = System.Drawing.Color.Gainsboro;
            this.buttonStatistics.UseVisualStyleBackColor = false;
            // 
            // buttonConnection
            // 
            this.buttonConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.buttonConnection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.buttonConnection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonConnection.BorderRadius = 6;
            this.buttonConnection.BorderSize = 2;
            this.buttonConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConnection.FlatAppearance.BorderSize = 0;
            this.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonConnection.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnection.Image")));
            this.buttonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConnection.Location = new System.Drawing.Point(0, 0);
            this.buttonConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonConnection.Size = new System.Drawing.Size(236, 50);
            this.buttonConnection.TabIndex = 2;
            this.buttonConnection.Text = "Connection";
            this.buttonConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonConnection.UseVisualStyleBackColor = false;
            // 
            // panelTitleHeader
            // 
            this.panelTitleHeader.Controls.Add(this.dropMenuButton);
            this.panelTitleHeader.Controls.Add(this.minimizeButton);
            this.panelTitleHeader.Controls.Add(this.closeButton);
            this.panelTitleHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleHeader.Location = new System.Drawing.Point(0, 0);
            this.panelTitleHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitleHeader.Name = "panelTitleHeader";
            this.panelTitleHeader.Size = new System.Drawing.Size(1250, 64);
            this.panelTitleHeader.TabIndex = 0;
            this.panelTitleHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleHeader_MouseMove);
            // 
            // dropMenuButton
            // 
            this.dropMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropMenuButton.FlatAppearance.BorderSize = 0;
            this.dropMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dropMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dropMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropMenuButton.Location = new System.Drawing.Point(1091, 6);
            this.dropMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropMenuButton.Name = "dropMenuButton";
            this.dropMenuButton.Size = new System.Drawing.Size(32, 38);
            this.dropMenuButton.TabIndex = 14;
            this.dropMenuButton.UseVisualStyleBackColor = true;
            this.dropMenuButton.Click += new System.EventHandler(this.dropMenuButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(1154, 14);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 38);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1189, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 38);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // notifyTray
            // 
            this.notifyTray.BalloonTipText = "The application has been minimized to the taskbar.";
            this.notifyTray.BalloonTipTitle = "Hurricane";
            this.notifyTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTray.Icon")));
            this.notifyTray.Text = "Hurricane DeveloperTool";
            this.notifyTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyTray_MouseDoubleClick);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.testToolStripMenuItem.Text = "Settings";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.testToolStripMenuItem1.Text = "Create";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(191, 24);
            this.testToolStripMenuItem2.Text = "Hide Log";
            // 
            // testToolStripMenuItem4
            // 
            this.testToolStripMenuItem4.Name = "testToolStripMenuItem4";
            this.testToolStripMenuItem4.Size = new System.Drawing.Size(191, 24);
            this.testToolStripMenuItem4.Text = "Backup database";
            // 
            // dropDownMenu
            // 
            this.dropDownMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dropDownMenu.IsMainMenu = false;
            this.dropDownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.testToolStripMenuItem2,
            this.testToolStripMenuItem4,
            this.hideToTrayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.dropDownMenu.MenuItemHeight = 20;
            this.dropDownMenu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropDownMenu.Name = "hurricaneDropdownMenu1";
            this.dropDownMenu.PrimaryColor = System.Drawing.Color.Empty;
            this.dropDownMenu.Size = new System.Drawing.Size(192, 124);
            // 
            // hideToTrayToolStripMenuItem
            // 
            this.hideToTrayToolStripMenuItem.Name = "hideToTrayToolStripMenuItem";
            this.hideToTrayToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.hideToTrayToolStripMenuItem.Text = "Hide to tray";
            this.hideToTrayToolStripMenuItem.Click += new System.EventHandler(this.hideToTrayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 850);
            this.Controls.Add(this.panelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hurricane Developer Tool";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.DashboardView_Load);
            this.panelBase.ResumeLayout(false);
            this.panelContentContainer.ResumeLayout(false);
            this.logPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logsGrid)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.sidebarBasePanel.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.panelTitleHeader.ResumeLayout(false);
            this.dropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelTitleHeader;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel sidebarBasePanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContentContainer;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.DataGridView logsGrid;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button dropMenuButton;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem4;
        private HurricaneControls.HurricaneDropdownMenu dropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        internal HurricaneControls.HurricaneButton buttonConnection;
        internal HurricaneControls.HurricaneButton buttonStatistics;
        internal HurricaneControls.HurricaneButton hurricaneButton5;
        internal HurricaneControls.HurricaneButton hurricaneButton4;
        internal HurricaneControls.HurricaneButton buttonGuide;
        private HurricaneControls.HurricaneProgressBar loadingProgressBar;
        private System.Windows.Forms.Label label2;
        internal HurricaneControls.HurricaneButton hurricaneButton2;
        internal HurricaneControls.HurricaneButton hurricaneButton1;
        internal HurricaneControls.HurricaneButton hurricaneButton3;
        private System.Windows.Forms.NotifyIcon notifyTray;
        private System.Windows.Forms.ToolStripMenuItem hideToTrayToolStripMenuItem;
    }
}

