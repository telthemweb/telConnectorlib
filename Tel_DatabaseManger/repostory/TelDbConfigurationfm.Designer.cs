
namespace Tel_DatabaseManger
{
    partial class TelDbConfigurationfm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelDbConfigurationfm));
            this.telPanel = new System.Windows.Forms.Panel();
            this.tellabelCom = new System.Windows.Forms.Label();
            this.telpictureBox = new System.Windows.Forms.PictureBox();
            this.teltxtServername = new System.Windows.Forms.TextBox();
            this.teltxtDatabaseName = new System.Windows.Forms.TextBox();
            this.teltxtUsername = new System.Windows.Forms.TextBox();
            this.teltxtPassword = new System.Windows.Forms.TextBox();
            this.telcmbDbType = new System.Windows.Forms.ComboBox();
            this.teltxtPort = new System.Windows.Forms.TextBox();
            this.telLblDbTpe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.telPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // telPanel
            // 
            this.telPanel.BackColor = System.Drawing.Color.Navy;
            this.telPanel.Controls.Add(this.tellabelCom);
            this.telPanel.Controls.Add(this.telpictureBox);
            this.telPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.telPanel.ForeColor = System.Drawing.Color.White;
            this.telPanel.Location = new System.Drawing.Point(0, 0);
            this.telPanel.Margin = new System.Windows.Forms.Padding(6);
            this.telPanel.Name = "telPanel";
            this.telPanel.Size = new System.Drawing.Size(659, 59);
            this.telPanel.TabIndex = 0;
            // 
            // tellabelCom
            // 
            this.tellabelCom.AutoSize = true;
            this.tellabelCom.BackColor = System.Drawing.Color.Transparent;
            this.tellabelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellabelCom.Location = new System.Drawing.Point(60, 15);
            this.tellabelCom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tellabelCom.Name = "tellabelCom";
            this.tellabelCom.Size = new System.Drawing.Size(325, 29);
            this.tellabelCom.TabIndex = 2;
            this.tellabelCom.Text = "TelDatabase Configuration";
            // 
            // telpictureBox
            // 
            this.telpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.telpictureBox.Image = global::Tel_DatabaseManger.Properties.Resources.data_storage;
            this.telpictureBox.Location = new System.Drawing.Point(17, 8);
            this.telpictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.telpictureBox.Name = "telpictureBox";
            this.telpictureBox.Size = new System.Drawing.Size(55, 43);
            this.telpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.telpictureBox.TabIndex = 1;
            this.telpictureBox.TabStop = false;
            // 
            // teltxtServername
            // 
            this.teltxtServername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxtServername.Location = new System.Drawing.Point(185, 140);
            this.teltxtServername.Name = "teltxtServername";
            this.teltxtServername.Size = new System.Drawing.Size(406, 32);
            this.teltxtServername.TabIndex = 1;
            // 
            // teltxtDatabaseName
            // 
            this.teltxtDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxtDatabaseName.Location = new System.Drawing.Point(185, 180);
            this.teltxtDatabaseName.Name = "teltxtDatabaseName";
            this.teltxtDatabaseName.Size = new System.Drawing.Size(406, 32);
            this.teltxtDatabaseName.TabIndex = 2;
            // 
            // teltxtUsername
            // 
            this.teltxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxtUsername.Location = new System.Drawing.Point(185, 220);
            this.teltxtUsername.Name = "teltxtUsername";
            this.teltxtUsername.Size = new System.Drawing.Size(406, 32);
            this.teltxtUsername.TabIndex = 3;
            // 
            // teltxtPassword
            // 
            this.teltxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxtPassword.Location = new System.Drawing.Point(185, 260);
            this.teltxtPassword.Name = "teltxtPassword";
            this.teltxtPassword.Size = new System.Drawing.Size(406, 32);
            this.teltxtPassword.TabIndex = 4;
            // 
            // telcmbDbType
            // 
            this.telcmbDbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telcmbDbType.FormattingEnabled = true;
            this.telcmbDbType.Location = new System.Drawing.Point(185, 93);
            this.telcmbDbType.Name = "telcmbDbType";
            this.telcmbDbType.Size = new System.Drawing.Size(406, 33);
            this.telcmbDbType.TabIndex = 5;
            // 
            // teltxtPort
            // 
            this.teltxtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxtPort.Location = new System.Drawing.Point(185, 300);
            this.teltxtPort.Name = "teltxtPort";
            this.teltxtPort.Size = new System.Drawing.Size(406, 32);
            this.teltxtPort.TabIndex = 6;
            // 
            // telLblDbTpe
            // 
            this.telLblDbTpe.AutoSize = true;
            this.telLblDbTpe.Location = new System.Drawing.Point(28, 97);
            this.telLblDbTpe.Name = "telLblDbTpe";
            this.telLblDbTpe.Size = new System.Drawing.Size(141, 24);
            this.telLblDbTpe.TabIndex = 7;
            this.telLblDbTpe.Text = "Database Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Database Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Port Number#";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Green;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(185, 338);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(191, 39);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(382, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 39);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(492, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 39);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(495, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version 23.01.1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            this.err.Icon = ((System.Drawing.Icon)(resources.GetObject("err.Icon")));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(1, 425);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Developed by Innocent Tauzeni";
            // 
            // TelDbConfigurationfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 443);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telLblDbTpe);
            this.Controls.Add(this.teltxtPort);
            this.Controls.Add(this.telcmbDbType);
            this.Controls.Add(this.teltxtPassword);
            this.Controls.Add(this.teltxtUsername);
            this.Controls.Add(this.teltxtDatabaseName);
            this.Controls.Add(this.teltxtServername);
            this.Controls.Add(this.telPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelDbConfigurationfm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Version 23.01.1";
            this.Load += new System.EventHandler(this.TelDbConfigurationfm_Load);
            this.telPanel.ResumeLayout(false);
            this.telPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel telPanel;
        public System.Windows.Forms.Label tellabelCom;
        public System.Windows.Forms.PictureBox telpictureBox;
        public System.Windows.Forms.TextBox teltxtServername;
        public System.Windows.Forms.TextBox teltxtDatabaseName;
        public System.Windows.Forms.TextBox teltxtUsername;
        public System.Windows.Forms.TextBox teltxtPassword;
        public System.Windows.Forms.ComboBox telcmbDbType;
        public System.Windows.Forms.TextBox teltxtPort;
        public System.Windows.Forms.Label telLblDbTpe;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnTest;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider err;
        public System.Windows.Forms.Label label7;
    }
}