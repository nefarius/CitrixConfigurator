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
            this.rtbRegValue = new System.Windows.Forms.RichTextBox();
            this.bWrite = new System.Windows.Forms.Button();
            this.tbBinValue = new System.Windows.Forms.TextBox();
            this.bGetString = new System.Windows.Forms.Button();
            this.gbFetch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbConvert = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.gbFetch.SuspendLayout();
            this.gbConvert.SuspendLayout();
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbRegValue
            // 
            this.rtbRegValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRegValue.Location = new System.Drawing.Point(6, 64);
            this.rtbRegValue.Name = "rtbRegValue";
            this.rtbRegValue.Size = new System.Drawing.Size(538, 294);
            this.rtbRegValue.TabIndex = 0;
            this.rtbRegValue.Text = "";
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
            // gbFetch
            // 
            this.gbFetch.Controls.Add(this.label1);
            this.gbFetch.Controls.Add(this.btnRead);
            this.gbFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFetch.Location = new System.Drawing.Point(12, 12);
            this.gbFetch.Name = "gbFetch";
            this.gbFetch.Size = new System.Drawing.Size(550, 88);
            this.gbFetch.TabIndex = 4;
            this.gbFetch.TabStop = false;
            this.gbFetch.Text = "1. Fetch configuration from registry";
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
            // gbConvert
            // 
            this.gbConvert.Controls.Add(this.label2);
            this.gbConvert.Controls.Add(this.rtbRegValue);
            this.gbConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConvert.Location = new System.Drawing.Point(12, 106);
            this.gbConvert.Name = "gbConvert";
            this.gbConvert.Size = new System.Drawing.Size(550, 364);
            this.gbConvert.TabIndex = 5;
            this.gbConvert.TabStop = false;
            this.gbConvert.Text = "2. Edit converted configuration";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.label3);
            this.gbSave.Controls.Add(this.tbBinValue);
            this.gbSave.Controls.Add(this.bWrite);
            this.gbSave.Controls.Add(this.bGetString);
            this.gbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSave.Location = new System.Drawing.Point(12, 478);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(550, 104);
            this.gbSave.TabIndex = 6;
            this.gbSave.TabStop = false;
            this.gbSave.Text = "3. Save changes";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 612);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.gbSave);
            this.Controls.Add(this.gbConvert);
            this.Controls.Add(this.gbFetch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitrixConfigurator - Enslave your Program Neighborhood Agent";
            this.gbFetch.ResumeLayout(false);
            this.gbConvert.ResumeLayout(false);
            this.gbSave.ResumeLayout(false);
            this.gbSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRegValue;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.TextBox tbBinValue;
        private System.Windows.Forms.Button bGetString;
        private System.Windows.Forms.GroupBox gbFetch;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
    }
}

