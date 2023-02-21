using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaConverter
{
    internal class Length : Icalculation
    {
        public int I1
        {
            get; set;
        }
        public int I2
        {
            get; set;
        }
        public char Ic { get; set; }

        public void Calculation()
        {
            if (Ic == '/')
            {
                I1 = I1 / I2;
            }
            else
            {
                I1 = I1 * I2;
            }
        }
    }
}

/* Meter (=> Kilometer /1000 => Zentimeter *100 => Milimeter *1000 => 1* 10 hoch 6 
   Kilometer (=> Meter * 1000 => Zentimeter 100000 => 1* 10 hoch 6 => 1* 10 hoch 9
*/
