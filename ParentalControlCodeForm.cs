using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiiLetterBomb
{
    public partial class ParentalControlCodeForm : Form
    {
        public ParentalControlCodeForm()
        {
            InitializeComponent();
        }

        private void textBoxConfirmationCode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConfirmationCode.Text.Length == 8)
            {
                try
                {
                    textBoxResetCode.Text = ParentalCodeCalc.GetCode(dateTimePicker.Value, textBoxConfirmationCode.Text);
                }
                catch
                {
                    textBoxResetCode.Text = "";
                }
            }
            else
                textBoxResetCode.Text = "";
        }
    }
}
