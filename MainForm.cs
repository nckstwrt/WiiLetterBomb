using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiiLetterBomb
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dateTimePickerExploit.Value = DateTime.UtcNow.AddDays(-1);

            RefreshDrives();
        }

        private void RefreshDrives()
        {
            comboBoxDriveLetters.Items.Clear();
            var driveList = DriveInfo.GetDrives();

            foreach (DriveInfo drive in driveList)
            {
                //if (drive.DriveType == DriveType.Removable)
                {
                    comboBoxDriveLetters.Items.Add(drive.RootDirectory);
                }    
            }

            if (comboBoxDriveLetters.Items.Count > 0)
                comboBoxDriveLetters.SelectedIndex = 0;
        }

        private void parentalControlCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentalControlCodeForm pccf = new ParentalControlCodeForm();
            pccf.ShowDialog();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            bool ret = false;
            try
            {
                var driveLetterRootDir = comboBoxDriveLetters.SelectedItem.ToString();

                if (Directory.Exists(Path.Combine(driveLetterRootDir, "private")))
                {
                    MessageBox.Show("Selected drive already has a \"private\" directory at its root. Please remove/rename this directory before proceeding", "Drive Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBoxMACAddress.Text.Length != 12)
                {
                    MessageBox.Show("MAC Address needs to be 12 characters in size!", "MAC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LetterBombExploit.Region region = LetterBombExploit.Region.USA;

                if (radioButtonUS.Checked)
                    region = LetterBombExploit.Region.USA;
                if (radioButtonEurope.Checked)
                    region = LetterBombExploit.Region.Europe;
                if (radioButtonJapan.Checked)
                    region = LetterBombExploit.Region.Japan;
                if (radioButtonKorea.Checked)
                    region = LetterBombExploit.Region.Korea;

                LetterBombExploit.SignTemplate(region, textBoxMACAddress.Text.ToUpper(), driveLetterRootDir, dateTimePickerExploit.Value);
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Thrown!\r\n\r\n" + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ret)
                MessageBox.Show("Success!\r\n\r\nExploit written to drive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDrives();
        }
    }
}
