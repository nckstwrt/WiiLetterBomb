using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiiLetterBomb
{
    public class ParentalCodeCalc
    {
        static List<uint> CRCTable = null;

        public static string GetCode(DateTime dt, string confirmation_num)
        {
            uint crc, i, j;
            if (CRCTable == null)
            {
                CRCTable = new List<uint>();
                for (i = 0; i < 256; i++)
                {
                    crc = i;
                    for (j = 0; j < 8; j++)
                    {
                        if ((crc & 1) == 1)
                            crc = (crc >> 1) ^ 0xEDB88320;
                        else
                            crc >>= 1;
                    }
                    CRCTable.Add(crc);
                }
            }

            var fullnum = dt.ToString("MMdd") + confirmation_num.Substring(4, 4);

            crc = 0xffffffff;
            var count = fullnum.Length;
            i = 0;
            while (count != 0)
            {
                count -= 1;
                uint temp1 = (crc >> 8) & 0xFFFFFF;
                uint temp2 = CRCTable[((int)(crc ^ fullnum[(int)i])) & 0xFF];
                crc = temp1 ^ temp2;
                i += 1;
            }

            uint code = ((crc ^ 0xaaaa) + 0x14c1) % 100000;

            return string.Format("{0:00000}", code);
        }
    }
}
