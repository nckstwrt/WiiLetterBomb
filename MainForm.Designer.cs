
namespace WiiLetterBomb
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUS = new System.Windows.Forms.RadioButton();
            this.radioButtonEurope = new System.Windows.Forms.RadioButton();
            this.radioButtonJapan = new System.Windows.Forms.RadioButton();
            this.radioButtonKorea = new System.Windows.Forms.RadioButton();
            this.textBoxMACAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDriveLetters = new System.Windows.Forms.ComboBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.dateTimePickerExploit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentalControlCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerExploit);
            this.groupBox1.Controls.Add(this.buttonWrite);
            this.groupBox1.Controls.Add(this.comboBoxDriveLetters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxMACAddress);
            this.groupBox1.Controls.Add(this.radioButtonKorea);
            this.groupBox1.Controls.Add(this.radioButtonJapan);
            this.groupBox1.Controls.Add(this.radioButtonEurope);
            this.groupBox1.Controls.Add(this.radioButtonUS);
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LetterBomb";
            // 
            // radioButtonUS
            // 
            this.radioButtonUS.AutoSize = true;
            this.radioButtonUS.Location = new System.Drawing.Point(9, 43);
            this.radioButtonUS.Name = "radioButtonUS";
            this.radioButtonUS.Size = new System.Drawing.Size(40, 17);
            this.radioButtonUS.TabIndex = 0;
            this.radioButtonUS.TabStop = true;
            this.radioButtonUS.Text = "US";
            this.radioButtonUS.UseVisualStyleBackColor = true;
            // 
            // radioButtonEurope
            // 
            this.radioButtonEurope.AutoSize = true;
            this.radioButtonEurope.Location = new System.Drawing.Point(55, 42);
            this.radioButtonEurope.Name = "radioButtonEurope";
            this.radioButtonEurope.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEurope.TabIndex = 1;
            this.radioButtonEurope.TabStop = true;
            this.radioButtonEurope.Text = "Europe";
            this.radioButtonEurope.UseVisualStyleBackColor = true;
            // 
            // radioButtonJapan
            // 
            this.radioButtonJapan.AutoSize = true;
            this.radioButtonJapan.Location = new System.Drawing.Point(120, 42);
            this.radioButtonJapan.Name = "radioButtonJapan";
            this.radioButtonJapan.Size = new System.Drawing.Size(54, 17);
            this.radioButtonJapan.TabIndex = 2;
            this.radioButtonJapan.TabStop = true;
            this.radioButtonJapan.Text = "Japan";
            this.radioButtonJapan.UseVisualStyleBackColor = true;
            // 
            // radioButtonKorea
            // 
            this.radioButtonKorea.AutoSize = true;
            this.radioButtonKorea.Location = new System.Drawing.Point(180, 42);
            this.radioButtonKorea.Name = "radioButtonKorea";
            this.radioButtonKorea.Size = new System.Drawing.Size(53, 17);
            this.radioButtonKorea.TabIndex = 3;
            this.radioButtonKorea.TabStop = true;
            this.radioButtonKorea.Text = "Korea";
            this.radioButtonKorea.UseVisualStyleBackColor = true;
            // 
            // textBoxMACAddress
            // 
            this.textBoxMACAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMACAddress.Location = new System.Drawing.Point(9, 102);
            this.textBoxMACAddress.MaxLength = 12;
            this.textBoxMACAddress.Name = "textBoxMACAddress";
            this.textBoxMACAddress.Size = new System.Drawing.Size(293, 20);
            this.textBoxMACAddress.TabIndex = 4;
            this.textBoxMACAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select your region:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your 12 character mac address (e.g. AABBCCDDEEFF):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select the drive to write to:";
            // 
            // comboBoxDriveLetters
            // 
            this.comboBoxDriveLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriveLetters.FormattingEnabled = true;
            this.comboBoxDriveLetters.Location = new System.Drawing.Point(10, 152);
            this.comboBoxDriveLetters.Name = "comboBoxDriveLetters";
            this.comboBoxDriveLetters.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDriveLetters.TabIndex = 8;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(120, 235);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 9;
            this.buttonWrite.Text = "Write Exploit To Drive";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // dateTimePickerExploit
            // 
            this.dateTimePickerExploit.Location = new System.Drawing.Point(10, 201);
            this.dateTimePickerExploit.Name = "dateTimePickerExploit";
            this.dateTimePickerExploit.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerExploit.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select the date to use (default: yesterday):";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentalControlCodeToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.extrasToolStripMenuItem.Text = "E&xtras";
            // 
            // parentalControlCodeToolStripMenuItem
            // 
            this.parentalControlCodeToolStripMenuItem.Name = "parentalControlCodeToolStripMenuItem";
            this.parentalControlCodeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.parentalControlCodeToolStripMenuItem.Text = "Parental Control Code";
            this.parentalControlCodeToolStripMenuItem.Click += new System.EventHandler(this.parentalControlCodeToolStripMenuItem_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(137, 149);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(58, 27);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Wii LetterBomb";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUS;
        private System.Windows.Forms.RadioButton radioButtonEurope;
        private System.Windows.Forms.RadioButton radioButtonKorea;
        private System.Windows.Forms.RadioButton radioButtonJapan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMACAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerExploit;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.ComboBox comboBoxDriveLetters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentalControlCodeToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

