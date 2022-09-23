using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WiiLetterBomb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ParentalCodeCalc.GetCode(new DateTime(2022, 9, 1), "44556677");
            //LetterBombExploit.SignTemplate(LetterBombExploit.Region.Europe, "010203040506", "c:\\");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
