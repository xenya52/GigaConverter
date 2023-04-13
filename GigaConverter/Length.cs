using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaConverter
{
    internal class Length
    {
        public double UserNumberInput { get; set; }
        
        //Kilometer
        public int KilometerUserInput { get; set; } // 0 = M, 1 = Dc, 2 = Cm, 3 = Mm, 4 = Mk, 5 = Nm,

        //KmCalculation
        public void KmCalculationMethod()
        {
            double solution = 0;

            switch (KilometerUserInput)
            {
                
                case 0: solution = UserNumberInput * 1000; break;
                case 1: solution = UserNumberInput * 10000; break;
                case 2: solution = UserNumberInput * 100000; break;
                case 3: solution = UserNumberInput * 1000000; break;
                case 4: solution = UserNumberInput * 1000000000; break;
                case 5: solution = UserNumberInput * 1000000000000; break;
            }
            UserNumberInput = solution;
        }
    }
}

/* 
 * 0Kilometer  (=> Meter * 1000 => => Dezimeter *10000 => Zentimeter 100000 => Millimeter 1* 10 hoch 6 => Mikrometer 1* 10 hoch 9 => Nanometer 1* 10 hoch 12)
 * 1Meter      (=> Kilometer /1000 => Zentimeter *100 => Millimeter *1000 => Mikrometer 1* 10 hoch 6 => Nanometer 1* 10 hoch 9)
 * 2Zentimeter (=> Kilometer /100000 => Meter /100 => Millimeter *10 => Mikrometer *10000 => Nanometer 1* hoch 7)
 * 3Millimeter (=> Kilometer 1* 10 hoch 6 => Meter *1000 => Zentimeter *10 => Mikrometer *1000 =>Nanometer => 1* 10 hoch 6)
 * 4Mikrometer (=> Kilometer=> Meter=> Zentimeter=> Millimeter =>Nanometer
 * 5Nanometer  (=> Kilometer=> Meter=> Zentimeter=> Millimeter =>Mikrometer
 */
