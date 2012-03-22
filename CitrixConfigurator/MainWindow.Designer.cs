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
            this.SuspendLayout();
            // 
            // rtbRegValue
            // 
            this.rtbRegValue.Location = new System.Drawing.Point(12, 12);
            this.rtbRegValue.Name = "rtbRegValue";
            this.rtbRegValue.Size = new System.Drawing.Size(534, 346);
            this.rtbRegValue.TabIndex = 0;
            this.rtbRegValue.Text = "";
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(471, 364);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(75, 23);
            this.bWrite.TabIndex = 1;
            this.bWrite.Text = "Write!";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // tbBinValue
            // 
            this.tbBinValue.BackColor = System.Drawing.Color.White;
            this.tbBinValue.Location = new System.Drawing.Point(12, 364);
            this.tbBinValue.Name = "tbBinValue";
            this.tbBinValue.ReadOnly = true;
            this.tbBinValue.Size = new System.Drawing.Size(372, 20);
            this.tbBinValue.TabIndex = 2;
            // 
            // bGetString
            // 
            this.bGetString.Location = new System.Drawing.Point(390, 364);
            this.bGetString.Name = "bGetString";
            this.bGetString.Size = new System.Drawing.Size(75, 23);
            this.bGetString.TabIndex = 3;
            this.bGetString.Text = "Get Hex";
            this.bGetString.UseVisualStyleBackColor = true;
            this.bGetString.Click += new System.EventHandler(this.bGetString_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 399);
            this.Controls.Add(this.bGetString);
            this.Controls.Add(this.tbBinValue);
            this.Controls.Add(this.bWrite);
            this.Controls.Add(this.rtbRegValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitrixConfigurator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRegValue;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.TextBox tbBinValue;
        private System.Windows.Forms.Button bGetString;
    }
}

