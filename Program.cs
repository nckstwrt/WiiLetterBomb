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
            //LetterBombExploit.SignTemplate(LetterBombExploit.Region.Europe, "e00c7fd74d75", "E:\\", DateTime.UtcNow.AddDays(-1));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
