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

/* 
 * Kilometer  (=> Meter * 1000 => Zentimeter 100000 => Millimeter 1* 10 hoch 6 => Mikrometer 1* 10 hoch 9 => Nanometer 1* 10 hoch 12)
 * Meter      (=> Kilometer /1000 => Zentimeter *100 => Millimeter *1000 => Mikrometer 1* 10 hoch 6 => Nanometer 1* 10 hoch 9)
 * Zentimeter (=> Kilometer /100000 => Meter /100 => Millimeter *10 => Mikrometer *10000 => Nanometer 1* hoch 7)
 * Millimeter (=> Kilometer 1* 10 hoch 6 => Meter *1000 => Zentimeter *10 => Mikrometer *1000 =>Nanometer => 1* 10 hoch 6)
 * Mikrometer (=> Kilometer=> Meter=> Zentimeter=> Millimeter =>Nanometer
 * Nanometer  (=> Kilometer=> Meter=> Zentimeter=> Millimeter =>Mikrometer
 */
