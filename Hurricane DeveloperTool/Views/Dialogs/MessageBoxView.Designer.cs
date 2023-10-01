namespace Hurricane_DeveloperTool.Views.Dialogs
{
    partial class MessageBoxView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOK = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.buttonCancel = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.buttonClose = new Hurricane_DeveloperTool.HurricaneControls.HurricaneButton();
            this.hurricaneTextBox5 = new Hurricane_DeveloperTool.HurricaneControls.HurricaneTextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelIcon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelIcon);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 124);
            this.panel1.TabIndex = 91;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelMessage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(68, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 71);
            this.panel4.TabIndex = 98;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMessage.Location = new System.Drawing.Point(0, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.labelMessage.Size = new System.Drawing.Size(499, 71);
            this.labelMessage.TabIndex = 92;
            this.labelMessage.Text = "message";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIcon
            // 
            this.panelIcon.Controls.Add(this.pictureBox1);
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIcon.Location = new System.Drawing.Point(0, 28);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(68, 71);
            this.panelIcon.TabIndex = 97;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.buttonOK);
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 25);
            this.panel3.TabIndex = 96;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(567, 28);
            this.panelHeader.TabIndex = 93;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Message Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 137);
            this.panel2.TabIndex = 93;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.buttonOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.buttonOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonOK.BorderRadius = 6;
            this.buttonOK.BorderSize = 2;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOK.Location = new System.Drawing.Point(233, 1);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(60, 24);
            this.buttonOK.TabIndex = 90;
            this.buttonOK.Tag = "Use system login credentials";
            this.buttonOK.Text = "Ok";
            this.buttonOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCancel.BorderRadius = 6;
            this.buttonCancel.BorderSize = 2;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCancel.Location = new System.Drawing.Point(299, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(60, 24);
            this.buttonCancel.TabIndex = 94;
            this.buttonCancel.Tag = "Use system login credentials";
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonClose.BorderRadius = 12;
            this.buttonClose.BorderSize = 0;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.Location = new System.Drawing.Point(535, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.buttonClose.Size = new System.Drawing.Size(22, 22);
            this.buttonClose.TabIndex = 91;
            this.buttonClose.Tag = "Use system login credentials";
            this.buttonClose.Text = "✖";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // hurricaneTextBox5
            // 
            this.hurricaneTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.hurricaneTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.hurricaneTextBox5.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(92)))));
            this.hurricaneTextBox5.BorderRadius = 12;
            this.hurricaneTextBox5.BorderSize = 2;
            this.hurricaneTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hurricaneTextBox5.Enabled = false;
            this.hurricaneTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurricaneTextBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.hurricaneTextBox5.Location = new System.Drawing.Point(0, 0);
            this.hurricaneTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.hurricaneTextBox5.Multiline = true;
            this.hurricaneTextBox5.Name = "hurricaneTextBox5";
            this.hurricaneTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.hurricaneTextBox5.PasswordChar = false;
            this.hurricaneTextBox5.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.hurricaneTextBox5.PlaceholderText = "";
            this.hurricaneTextBox5.Size = new System.Drawing.Size(580, 137);
            this.hurricaneTextBox5.TabIndex = 89;
            this.hurricaneTextBox5.Texts = "";
            this.hurricaneTextBox5.UnderlinedStyle = false;
            // 
            // MessageBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 137);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hurricaneTextBox5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelIcon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HurricaneControls.HurricaneTextBox hurricaneTextBox5;
        private HurricaneControls.HurricaneButton buttonOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHeader;
        private HurricaneControls.HurricaneButton buttonClose;
        private HurricaneControls.HurricaneButton buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}