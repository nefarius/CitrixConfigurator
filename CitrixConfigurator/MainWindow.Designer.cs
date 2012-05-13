namespace CitrixConfigurator
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.bWrite = new System.Windows.Forms.Button();
            this.tbBinValue = new System.Windows.Forms.TextBox();
            this.bGetString = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DesktopDisplayEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DesktopName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LogonMethod = new System.Windows.Forms.ComboBox();
            this.ReconnectFromButtonActive = new System.Windows.Forms.CheckBox();
            this.ReconnectFromButtonDisconnected = new System.Windows.Forms.CheckBox();
            this.ReconnectFromLogonActive = new System.Windows.Forms.CheckBox();
            this.ReconnectFromLogonDisconnected = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerURLEntered = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerURLListUsers = new System.Windows.Forms.RichTextBox();
            this.StartMenuDisplayEnabled = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StartMenuRoot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartMenuDisplayRootFolder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PS_DesktopName = new System.Windows.Forms.TextBox();
            this.PS_DesktopNameModifiable = new System.Windows.Forms.CheckBox();
            this.PS_ServerURL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PS_ServerURLModifiable = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PS_ServerURLListBackup = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PS_StartMenuDisplayRootFolder = new System.Windows.Forms.TextBox();
            this.PS_StartMenuRootFolderModifiable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bWrite
            // 
            this.bWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bWrite.Location = new System.Drawing.Point(459, 74);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(75, 23);
            this.bWrite.TabIndex = 1;
            this.bWrite.Text = "Write back";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // tbBinValue
            // 
            this.tbBinValue.BackColor = System.Drawing.Color.White;
            this.tbBinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBinValue.Location = new System.Drawing.Point(6, 76);
            this.tbBinValue.Name = "tbBinValue";
            this.tbBinValue.ReadOnly = true;
            this.tbBinValue.Size = new System.Drawing.Size(366, 20);
            this.tbBinValue.TabIndex = 2;
            // 
            // bGetString
            // 
            this.bGetString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGetString.Location = new System.Drawing.Point(378, 74);
            this.bGetString.Name = "bGetString";
            this.bGetString.Size = new System.Drawing.Size(75, 23);
            this.bGetString.TabIndex = 3;
            this.bGetString.Text = "Get Hex";
            this.bGetString.UseVisualStyleBackColor = true;
            this.bGetString.Click += new System.EventHandler(this.bGetString_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Fetch configuration from registry";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(459, 59);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 364);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Edit converted configuration";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbBinValue);
            this.groupBox3.Controls.Add(this.bWrite);
            this.groupBox3.Controls.Add(this.bGetString);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 104);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Save changes";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Location = new System.Drawing.Point(416, 590);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(146, 13);
            this.linkLabelAbout.TabIndex = 7;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "(cc) Benjamin Höglinger 2012";
            this.linkLabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 339);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StartMenuDisplayRootFolder);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.StartMenuRoot);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.StartMenuDisplayEnabled);
            this.tabPage1.Controls.Add(this.ServerURLListUsers);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ServerURLEntered);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ReconnectFromLogonDisconnected);
            this.tabPage1.Controls.Add(this.ReconnectFromLogonActive);
            this.tabPage1.Controls.Add(this.ReconnectFromButtonDisconnected);
            this.tabPage1.Controls.Add(this.ReconnectFromButtonActive);
            this.tabPage1.Controls.Add(this.LogonMethod);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.DesktopName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DesktopDisplayEnabled);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Blob";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PS_StartMenuRootFolderModifiable);
            this.tabPage2.Controls.Add(this.PS_StartMenuDisplayRootFolder);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.PS_ServerURLListBackup);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.PS_ServerURLModifiable);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.PS_ServerURL);
            this.tabPage2.Controls.Add(this.PS_DesktopNameModifiable);
            this.tabPage2.Controls.Add(this.PS_DesktopName);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Primary Server Blob";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DesktopDisplayEnabled
            // 
            this.DesktopDisplayEnabled.AutoSize = true;
            this.DesktopDisplayEnabled.Location = new System.Drawing.Point(16, 23);
            this.DesktopDisplayEnabled.Name = "DesktopDisplayEnabled";
            this.DesktopDisplayEnabled.Size = new System.Drawing.Size(139, 17);
            this.DesktopDisplayEnabled.TabIndex = 0;
            this.DesktopDisplayEnabled.Text = "DesktopDisplayEnabled";
            this.DesktopDisplayEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DesktopName";
            // 
            // DesktopName
            // 
            this.DesktopName.Location = new System.Drawing.Point(94, 50);
            this.DesktopName.Name = "DesktopName";
            this.DesktopName.Size = new System.Drawing.Size(100, 20);
            this.DesktopName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "LogonMethod";
            // 
            // LogonMethod
            // 
            this.LogonMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LogonMethod.FormattingEnabled = true;
            this.LogonMethod.Location = new System.Drawing.Point(94, 86);
            this.LogonMethod.Name = "LogonMethod";
            this.LogonMethod.Size = new System.Drawing.Size(61, 21);
            this.LogonMethod.TabIndex = 4;
            // 
            // ReconnectFromButtonActive
            // 
            this.ReconnectFromButtonActive.AutoSize = true;
            this.ReconnectFromButtonActive.Location = new System.Drawing.Point(18, 123);
            this.ReconnectFromButtonActive.Name = "ReconnectFromButtonActive";
            this.ReconnectFromButtonActive.Size = new System.Drawing.Size(163, 17);
            this.ReconnectFromButtonActive.TabIndex = 5;
            this.ReconnectFromButtonActive.Text = "ReconnectFromButtonActive";
            this.ReconnectFromButtonActive.UseVisualStyleBackColor = true;
            // 
            // ReconnectFromButtonDisconnected
            // 
            this.ReconnectFromButtonDisconnected.AutoSize = true;
            this.ReconnectFromButtonDisconnected.Location = new System.Drawing.Point(18, 146);
            this.ReconnectFromButtonDisconnected.Name = "ReconnectFromButtonDisconnected";
            this.ReconnectFromButtonDisconnected.Size = new System.Drawing.Size(199, 17);
            this.ReconnectFromButtonDisconnected.TabIndex = 6;
            this.ReconnectFromButtonDisconnected.Text = "ReconnectFromButtonDisconnected";
            this.ReconnectFromButtonDisconnected.UseVisualStyleBackColor = true;
            // 
            // ReconnectFromLogonActive
            // 
            this.ReconnectFromLogonActive.AutoSize = true;
            this.ReconnectFromLogonActive.Location = new System.Drawing.Point(18, 169);
            this.ReconnectFromLogonActive.Name = "ReconnectFromLogonActive";
            this.ReconnectFromLogonActive.Size = new System.Drawing.Size(162, 17);
            this.ReconnectFromLogonActive.TabIndex = 7;
            this.ReconnectFromLogonActive.Text = "ReconnectFromLogonActive";
            this.ReconnectFromLogonActive.UseVisualStyleBackColor = true;
            // 
            // ReconnectFromLogonDisconnected
            // 
            this.ReconnectFromLogonDisconnected.AutoSize = true;
            this.ReconnectFromLogonDisconnected.Location = new System.Drawing.Point(18, 192);
            this.ReconnectFromLogonDisconnected.Name = "ReconnectFromLogonDisconnected";
            this.ReconnectFromLogonDisconnected.Size = new System.Drawing.Size(198, 17);
            this.ReconnectFromLogonDisconnected.TabIndex = 8;
            this.ReconnectFromLogonDisconnected.Text = "ReconnectFromLogonDisconnected";
            this.ReconnectFromLogonDisconnected.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ServerURLEntered";
            // 
            // ServerURLEntered
            // 
            this.ServerURLEntered.Location = new System.Drawing.Point(121, 213);
            this.ServerURLEntered.Name = "ServerURLEntered";
            this.ServerURLEntered.Size = new System.Drawing.Size(100, 20);
            this.ServerURLEntered.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ServerURLListUsers";
            // 
            // ServerURLListUsers
            // 
            this.ServerURLListUsers.Location = new System.Drawing.Point(259, 50);
            this.ServerURLListUsers.Name = "ServerURLListUsers";
            this.ServerURLListUsers.Size = new System.Drawing.Size(211, 57);
            this.ServerURLListUsers.TabIndex = 12;
            this.ServerURLListUsers.Text = "";
            // 
            // StartMenuDisplayEnabled
            // 
            this.StartMenuDisplayEnabled.AutoSize = true;
            this.StartMenuDisplayEnabled.Location = new System.Drawing.Point(259, 123);
            this.StartMenuDisplayEnabled.Name = "StartMenuDisplayEnabled";
            this.StartMenuDisplayEnabled.Size = new System.Drawing.Size(148, 17);
            this.StartMenuDisplayEnabled.TabIndex = 13;
            this.StartMenuDisplayEnabled.Text = "StartMenuDisplayEnabled";
            this.StartMenuDisplayEnabled.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "StartMenuRoot";
            // 
            // StartMenuRoot
            // 
            this.StartMenuRoot.Location = new System.Drawing.Point(344, 144);
            this.StartMenuRoot.Name = "StartMenuRoot";
            this.StartMenuRoot.Size = new System.Drawing.Size(100, 20);
            this.StartMenuRoot.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "StartMenuDisplayRootFolder";
            // 
            // StartMenuDisplayRootFolder
            // 
            this.StartMenuDisplayRootFolder.Location = new System.Drawing.Point(407, 167);
            this.StartMenuDisplayRootFolder.Name = "StartMenuDisplayRootFolder";
            this.StartMenuDisplayRootFolder.Size = new System.Drawing.Size(100, 20);
            this.StartMenuDisplayRootFolder.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "DesktopName";
            // 
            // PS_DesktopName
            // 
            this.PS_DesktopName.Location = new System.Drawing.Point(100, 24);
            this.PS_DesktopName.Name = "PS_DesktopName";
            this.PS_DesktopName.Size = new System.Drawing.Size(100, 20);
            this.PS_DesktopName.TabIndex = 1;
            // 
            // PS_DesktopNameModifiable
            // 
            this.PS_DesktopNameModifiable.AutoSize = true;
            this.PS_DesktopNameModifiable.Location = new System.Drawing.Point(22, 59);
            this.PS_DesktopNameModifiable.Name = "PS_DesktopNameModifiable";
            this.PS_DesktopNameModifiable.Size = new System.Drawing.Size(142, 17);
            this.PS_DesktopNameModifiable.TabIndex = 2;
            this.PS_DesktopNameModifiable.Text = "DesktopNameModifiable";
            this.PS_DesktopNameModifiable.UseVisualStyleBackColor = true;
            // 
            // PS_ServerURL
            // 
            this.PS_ServerURL.Location = new System.Drawing.Point(85, 87);
            this.PS_ServerURL.Name = "PS_ServerURL";
            this.PS_ServerURL.Size = new System.Drawing.Size(100, 20);
            this.PS_ServerURL.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "ServerURL";
            // 
            // PS_ServerURLModifiable
            // 
            this.PS_ServerURLModifiable.AutoSize = true;
            this.PS_ServerURLModifiable.Location = new System.Drawing.Point(22, 122);
            this.PS_ServerURLModifiable.Name = "PS_ServerURLModifiable";
            this.PS_ServerURLModifiable.Size = new System.Drawing.Size(127, 17);
            this.PS_ServerURLModifiable.TabIndex = 5;
            this.PS_ServerURLModifiable.Text = "ServerURLModifiable";
            this.PS_ServerURLModifiable.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "ServerURLListBackup";
            // 
            // PS_ServerURLListBackup
            // 
            this.PS_ServerURLListBackup.Location = new System.Drawing.Point(25, 188);
            this.PS_ServerURLListBackup.Name = "PS_ServerURLListBackup";
            this.PS_ServerURLListBackup.Size = new System.Drawing.Size(175, 96);
            this.PS_ServerURLListBackup.TabIndex = 7;
            this.PS_ServerURLListBackup.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "StartMenuDisplayRootFolder";
            // 
            // PS_StartMenuDisplayRootFolder
            // 
            this.PS_StartMenuDisplayRootFolder.Location = new System.Drawing.Point(383, 24);
            this.PS_StartMenuDisplayRootFolder.Name = "PS_StartMenuDisplayRootFolder";
            this.PS_StartMenuDisplayRootFolder.Size = new System.Drawing.Size(100, 20);
            this.PS_StartMenuDisplayRootFolder.TabIndex = 9;
            // 
            // PS_StartMenuRootFolderModifiable
            // 
            this.PS_StartMenuRootFolderModifiable.AutoSize = true;
            this.PS_StartMenuRootFolderModifiable.Location = new System.Drawing.Point(238, 59);
            this.PS_StartMenuRootFolderModifiable.Name = "PS_StartMenuRootFolderModifiable";
            this.PS_StartMenuRootFolderModifiable.Size = new System.Drawing.Size(175, 17);
            this.PS_StartMenuRootFolderModifiable.TabIndex = 10;
            this.PS_StartMenuRootFolderModifiable.Text = "StartMenuRootFolderModifiable";
            this.PS_StartMenuRootFolderModifiable.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 612);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitrixConfigurator - Enslave your Program Neighborhood Agent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.TextBox tbBinValue;
        private System.Windows.Forms.Button bGetString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox DesktopDisplayEnabled;
        private System.Windows.Forms.TextBox DesktopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LogonMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ReconnectFromButtonActive;
        private System.Windows.Forms.CheckBox ReconnectFromButtonDisconnected;
        private System.Windows.Forms.CheckBox ReconnectFromLogonActive;
        private System.Windows.Forms.CheckBox ReconnectFromLogonDisconnected;
        private System.Windows.Forms.TextBox ServerURLEntered;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ServerURLListUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox StartMenuDisplayEnabled;
        private System.Windows.Forms.TextBox StartMenuRoot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StartMenuDisplayRootFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PS_DesktopName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox PS_DesktopNameModifiable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PS_ServerURL;
        private System.Windows.Forms.CheckBox PS_ServerURLModifiable;
        private System.Windows.Forms.RichTextBox PS_ServerURLListBackup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PS_StartMenuDisplayRootFolder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox PS_StartMenuRootFolderModifiable;
    }
}

