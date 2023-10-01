namespace HurricaneServiceManager.Views.Pages
{
    partial class ConnectionPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionPage));
            this.sConnectionPanel = new System.Windows.Forms.Panel();
            this.lSQLPort = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tSQLPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tSQLDatabase = new System.Windows.Forms.TextBox();
            this.tSQLPassword = new System.Windows.Forms.TextBox();
            this.tSQLUser = new System.Windows.Forms.TextBox();
            this.tSQLHost = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ISQLStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bSQLDisconnect = new System.Windows.Forms.Button();
            this.pConnectionPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tPusherSecret = new System.Windows.Forms.TextBox();
            this.tPusherKey = new System.Windows.Forms.TextBox();
            this.tPusherID = new System.Windows.Forms.TextBox();
            this.tPusherPort = new System.Windows.Forms.TextBox();
            this.tPusherHost = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IPusherStatus = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bPusherDisconnect = new System.Windows.Forms.Button();
            this.bPusherConnect = new System.Windows.Forms.Button();
            this.bSQLConnect = new System.Windows.Forms.Button();
            this.sConnectionPanel.SuspendLayout();
            this.pConnectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sConnectionPanel
            // 
            this.sConnectionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sConnectionPanel.Controls.Add(this.lSQLPort);
            this.sConnectionPanel.Controls.Add(this.label9);
            this.sConnectionPanel.Controls.Add(this.tSQLPort);
            this.sConnectionPanel.Controls.Add(this.label4);
            this.sConnectionPanel.Controls.Add(this.label3);
            this.sConnectionPanel.Controls.Add(this.label2);
            this.sConnectionPanel.Controls.Add(this.label1);
            this.sConnectionPanel.Controls.Add(this.tSQLDatabase);
            this.sConnectionPanel.Controls.Add(this.tSQLPassword);
            this.sConnectionPanel.Controls.Add(this.tSQLUser);
            this.sConnectionPanel.Controls.Add(this.tSQLHost);
            this.sConnectionPanel.Location = new System.Drawing.Point(108, 170);
            this.sConnectionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sConnectionPanel.Name = "sConnectionPanel";
            this.sConnectionPanel.Size = new System.Drawing.Size(322, 318);
            this.sConnectionPanel.TabIndex = 32;
            // 
            // lSQLPort
            // 
            this.lSQLPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lSQLPort.AutoSize = true;
            this.lSQLPort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSQLPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lSQLPort.Location = new System.Drawing.Point(0, 58);
            this.lSQLPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSQLPort.Name = "lSQLPort";
            this.lSQLPort.Size = new System.Drawing.Size(80, 18);
            this.lSQLPort.TabIndex = 40;
            this.lSQLPort.Text = "MySQL Port";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.label9.Location = new System.Drawing.Point(108, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 14);
            this.label9.TabIndex = 39;
            this.label9.Text = "Hurricane";
            // 
            // tSQLPort
            // 
            this.tSQLPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tSQLPort.BackColor = System.Drawing.Color.White;
            this.tSQLPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSQLPort.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSQLPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tSQLPort.Location = new System.Drawing.Point(3, 78);
            this.tSQLPort.Margin = new System.Windows.Forms.Padding(2);
            this.tSQLPort.Name = "tSQLPort";
            this.tSQLPort.Size = new System.Drawing.Size(222, 24);
            this.tSQLPort.TabIndex = 39;
            this.tSQLPort.Text = "3306";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(0, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "MySQL Database";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(0, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "MySQL Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-1, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "MySQL User";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "MySQL Host";
            // 
            // tSQLDatabase
            // 
            this.tSQLDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tSQLDatabase.BackColor = System.Drawing.Color.White;
            this.tSQLDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSQLDatabase.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSQLDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tSQLDatabase.Location = new System.Drawing.Point(2, 232);
            this.tSQLDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.tSQLDatabase.Name = "tSQLDatabase";
            this.tSQLDatabase.Size = new System.Drawing.Size(222, 24);
            this.tSQLDatabase.TabIndex = 32;
            this.tSQLDatabase.Text = "hurricane_guard";
            // 
            // tSQLPassword
            // 
            this.tSQLPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tSQLPassword.BackColor = System.Drawing.Color.White;
            this.tSQLPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSQLPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSQLPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tSQLPassword.Location = new System.Drawing.Point(2, 179);
            this.tSQLPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tSQLPassword.Name = "tSQLPassword";
            this.tSQLPassword.PasswordChar = '*';
            this.tSQLPassword.Size = new System.Drawing.Size(222, 24);
            this.tSQLPassword.TabIndex = 29;
            // 
            // tSQLUser
            // 
            this.tSQLUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tSQLUser.BackColor = System.Drawing.Color.White;
            this.tSQLUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSQLUser.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSQLUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tSQLUser.Location = new System.Drawing.Point(2, 130);
            this.tSQLUser.Margin = new System.Windows.Forms.Padding(2);
            this.tSQLUser.Name = "tSQLUser";
            this.tSQLUser.Size = new System.Drawing.Size(222, 24);
            this.tSQLUser.TabIndex = 28;
            this.tSQLUser.Text = "root";
            // 
            // tSQLHost
            // 
            this.tSQLHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tSQLHost.BackColor = System.Drawing.Color.White;
            this.tSQLHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSQLHost.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSQLHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tSQLHost.Location = new System.Drawing.Point(2, 27);
            this.tSQLHost.Margin = new System.Windows.Forms.Padding(2);
            this.tSQLHost.Name = "tSQLHost";
            this.tSQLHost.Size = new System.Drawing.Size(222, 24);
            this.tSQLHost.TabIndex = 27;
            this.tSQLHost.Text = "127.0.0.1";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(109, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 2);
            this.panel1.TabIndex = 31;
            // 
            // ISQLStatus
            // 
            this.ISQLStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ISQLStatus.AutoSize = true;
            this.ISQLStatus.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISQLStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.ISQLStatus.Location = new System.Drawing.Point(105, 127);
            this.ISQLStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ISQLStatus.Name = "ISQLStatus";
            this.ISQLStatus.Size = new System.Drawing.Size(118, 23);
            this.ISQLStatus.TabIndex = 30;
            this.ISQLStatus.Text = "Disconnected";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(106, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "SQL status:";
            // 
            // bSQLDisconnect
            // 
            this.bSQLDisconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSQLDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSQLDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSQLDisconnect.ForeColor = System.Drawing.SystemColors.Control;
            this.bSQLDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("bSQLDisconnect.Image")));
            this.bSQLDisconnect.Location = new System.Drawing.Point(108, 475);
            this.bSQLDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.bSQLDisconnect.Name = "bSQLDisconnect";
            this.bSQLDisconnect.Size = new System.Drawing.Size(133, 34);
            this.bSQLDisconnect.TabIndex = 28;
            this.bSQLDisconnect.Text = "Disconnect";
            this.bSQLDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSQLDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSQLDisconnect.UseVisualStyleBackColor = false;
            this.bSQLDisconnect.Visible = false;
            this.bSQLDisconnect.Click += new System.EventHandler(this.bSQLDisconnect_Click);
            // 
            // pConnectionPanel
            // 
            this.pConnectionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pConnectionPanel.Controls.Add(this.label15);
            this.pConnectionPanel.Controls.Add(this.label16);
            this.pConnectionPanel.Controls.Add(this.label17);
            this.pConnectionPanel.Controls.Add(this.label18);
            this.pConnectionPanel.Controls.Add(this.label19);
            this.pConnectionPanel.Controls.Add(this.tPusherSecret);
            this.pConnectionPanel.Controls.Add(this.tPusherKey);
            this.pConnectionPanel.Controls.Add(this.tPusherID);
            this.pConnectionPanel.Controls.Add(this.tPusherPort);
            this.pConnectionPanel.Controls.Add(this.tPusherHost);
            this.pConnectionPanel.Location = new System.Drawing.Point(434, 170);
            this.pConnectionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pConnectionPanel.Name = "pConnectionPanel";
            this.pConnectionPanel.Size = new System.Drawing.Size(322, 318);
            this.pConnectionPanel.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(0, 212);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 18);
            this.label15.TabIndex = 37;
            this.label15.Text = "Pusher Secret";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(0, 159);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 18);
            this.label16.TabIndex = 38;
            this.label16.Text = "Pusher Key";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(0, 106);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 18);
            this.label17.TabIndex = 35;
            this.label17.Text = "Pusher ID";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(-1, 58);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 18);
            this.label18.TabIndex = 34;
            this.label18.Text = "Pusher Port";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(-1, 6);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 18);
            this.label19.TabIndex = 33;
            this.label19.Text = "Pusher Host";
            // 
            // tPusherSecret
            // 
            this.tPusherSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPusherSecret.BackColor = System.Drawing.Color.White;
            this.tPusherSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPusherSecret.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPusherSecret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tPusherSecret.Location = new System.Drawing.Point(2, 233);
            this.tPusherSecret.Margin = new System.Windows.Forms.Padding(2);
            this.tPusherSecret.Name = "tPusherSecret";
            this.tPusherSecret.Size = new System.Drawing.Size(222, 24);
            this.tPusherSecret.TabIndex = 31;
            // 
            // tPusherKey
            // 
            this.tPusherKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPusherKey.BackColor = System.Drawing.Color.White;
            this.tPusherKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPusherKey.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPusherKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tPusherKey.Location = new System.Drawing.Point(2, 180);
            this.tPusherKey.Margin = new System.Windows.Forms.Padding(2);
            this.tPusherKey.Name = "tPusherKey";
            this.tPusherKey.Size = new System.Drawing.Size(222, 24);
            this.tPusherKey.TabIndex = 32;
            this.tPusherKey.Text = "app-key";
            // 
            // tPusherID
            // 
            this.tPusherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPusherID.BackColor = System.Drawing.Color.White;
            this.tPusherID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPusherID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPusherID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tPusherID.Location = new System.Drawing.Point(2, 127);
            this.tPusherID.Margin = new System.Windows.Forms.Padding(2);
            this.tPusherID.Name = "tPusherID";
            this.tPusherID.PasswordChar = '*';
            this.tPusherID.Size = new System.Drawing.Size(222, 24);
            this.tPusherID.TabIndex = 29;
            // 
            // tPusherPort
            // 
            this.tPusherPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPusherPort.BackColor = System.Drawing.Color.White;
            this.tPusherPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPusherPort.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPusherPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tPusherPort.Location = new System.Drawing.Point(2, 78);
            this.tPusherPort.Margin = new System.Windows.Forms.Padding(2);
            this.tPusherPort.Name = "tPusherPort";
            this.tPusherPort.Size = new System.Drawing.Size(222, 24);
            this.tPusherPort.TabIndex = 28;
            this.tPusherPort.Text = "6001";
            // 
            // tPusherHost
            // 
            this.tPusherHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPusherHost.BackColor = System.Drawing.Color.White;
            this.tPusherHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPusherHost.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPusherHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tPusherHost.Location = new System.Drawing.Point(2, 27);
            this.tPusherHost.Margin = new System.Windows.Forms.Padding(2);
            this.tPusherHost.Name = "tPusherHost";
            this.tPusherHost.Size = new System.Drawing.Size(222, 24);
            this.tPusherHost.TabIndex = 27;
            this.tPusherHost.Text = "127.0.0.1";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(435, 152);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 2);
            this.panel3.TabIndex = 45;
            // 
            // IPusherStatus
            // 
            this.IPusherStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPusherStatus.AutoSize = true;
            this.IPusherStatus.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPusherStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.IPusherStatus.Location = new System.Drawing.Point(431, 127);
            this.IPusherStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPusherStatus.Name = "IPusherStatus";
            this.IPusherStatus.Size = new System.Drawing.Size(118, 23);
            this.IPusherStatus.TabIndex = 44;
            this.IPusherStatus.Text = "Disconnected";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(432, 115);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 14);
            this.label21.TabIndex = 43;
            this.label21.Text = "Pusher status:";
            // 
            // bPusherDisconnect
            // 
            this.bPusherDisconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bPusherDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bPusherDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPusherDisconnect.ForeColor = System.Drawing.SystemColors.Control;
            this.bPusherDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("bPusherDisconnect.Image")));
            this.bPusherDisconnect.Location = new System.Drawing.Point(434, 475);
            this.bPusherDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.bPusherDisconnect.Name = "bPusherDisconnect";
            this.bPusherDisconnect.Size = new System.Drawing.Size(133, 34);
            this.bPusherDisconnect.TabIndex = 42;
            this.bPusherDisconnect.Text = "Disconnect";
            this.bPusherDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPusherDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bPusherDisconnect.UseVisualStyleBackColor = false;
            this.bPusherDisconnect.Visible = false;
            this.bPusherDisconnect.Click += new System.EventHandler(this.bPusherDisconnect_Click);
            // 
            // bPusherConnect
            // 
            this.bPusherConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bPusherConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.bPusherConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPusherConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.bPusherConnect.Image = ((System.Drawing.Image)(resources.GetObject("bPusherConnect.Image")));
            this.bPusherConnect.Location = new System.Drawing.Point(433, 477);
            this.bPusherConnect.Margin = new System.Windows.Forms.Padding(2);
            this.bPusherConnect.Name = "bPusherConnect";
            this.bPusherConnect.Size = new System.Drawing.Size(134, 34);
            this.bPusherConnect.TabIndex = 47;
            this.bPusherConnect.Text = "Connect";
            this.bPusherConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPusherConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bPusherConnect.UseVisualStyleBackColor = false;
            this.bPusherConnect.Click += new System.EventHandler(this.bPusherConnect_Click);
            // 
            // bSQLConnect
            // 
            this.bSQLConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSQLConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.bSQLConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSQLConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.bSQLConnect.Image = ((System.Drawing.Image)(resources.GetObject("bSQLConnect.Image")));
            this.bSQLConnect.Location = new System.Drawing.Point(107, 477);
            this.bSQLConnect.Margin = new System.Windows.Forms.Padding(2);
            this.bSQLConnect.Name = "bSQLConnect";
            this.bSQLConnect.Size = new System.Drawing.Size(134, 34);
            this.bSQLConnect.TabIndex = 48;
            this.bSQLConnect.Text = "Connect";
            this.bSQLConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSQLConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSQLConnect.UseVisualStyleBackColor = false;
            this.bSQLConnect.Click += new System.EventHandler(this.bSQLConnect_Click);
            // 
            // ConnectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bSQLDisconnect);
            this.Controls.Add(this.bPusherDisconnect);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.IPusherStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ISQLStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bSQLConnect);
            this.Controls.Add(this.bPusherConnect);
            this.Controls.Add(this.pConnectionPanel);
            this.Controls.Add(this.sConnectionPanel);
            this.Name = "ConnectionPage";
            this.Size = new System.Drawing.Size(784, 610);
            this.sConnectionPanel.ResumeLayout(false);
            this.sConnectionPanel.PerformLayout();
            this.pConnectionPanel.ResumeLayout(false);
            this.pConnectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sConnectionPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSQLDatabase;
        private System.Windows.Forms.TextBox tSQLPassword;
        private System.Windows.Forms.TextBox tSQLUser;
        private System.Windows.Forms.TextBox tSQLHost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ISQLStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSQLDisconnect;
        private System.Windows.Forms.Panel pConnectionPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tPusherSecret;
        private System.Windows.Forms.TextBox tPusherKey;
        private System.Windows.Forms.TextBox tPusherID;
        private System.Windows.Forms.TextBox tPusherPort;
        private System.Windows.Forms.TextBox tPusherHost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label IPusherStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bPusherDisconnect;
        private System.Windows.Forms.Label lSQLPort;
        private System.Windows.Forms.TextBox tSQLPort;
        private System.Windows.Forms.Button bPusherConnect;
        private System.Windows.Forms.Button bSQLConnect;
    }
}
