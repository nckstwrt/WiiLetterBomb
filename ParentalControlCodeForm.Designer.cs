
namespace WiiLetterBomb
{
    partial class ParentalControlCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentalControlCodeForm));
            this.textBoxConfirmationCode = new System.Windows.Forms.TextBox();
            this.textBoxResetCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxConfirmationCode
            // 
            this.textBoxConfirmationCode.Location = new System.Drawing.Point(12, 25);
            this.textBoxConfirmationCode.MaxLength = 8;
            this.textBoxConfirmationCode.Name = "textBoxConfirmationCode";
            this.textBoxConfirmationCode.Size = new System.Drawing.Size(210, 20);
            this.textBoxConfirmationCode.TabIndex = 0;
            this.textBoxConfirmationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxConfirmationCode.TextChanged += new System.EventHandler(this.textBoxConfirmationCode_TextChanged);
            // 
            // textBoxResetCode
            // 
            this.textBoxResetCode.Location = new System.Drawing.Point(12, 125);
            this.textBoxResetCode.Name = "textBoxResetCode";
            this.textBoxResetCode.ReadOnly = true;
            this.textBoxResetCode.Size = new System.Drawing.Size(210, 20);
            this.textBoxResetCode.TabIndex = 1;
            this.textBoxResetCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirmation Number (8 digits long):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reset Code:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 71);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Date in your timezone:";
            // 
            // ParentalControlCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 164);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResetCode);
            this.Controls.Add(this.textBoxConfirmationCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentalControlCodeForm";
            this.Text = "Parental Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConfirmationCode;
        private System.Windows.Forms.TextBox textBoxResetCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
    }
}