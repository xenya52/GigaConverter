using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaConverter
{
    internal class Length : Icalculation
    {
        //Eingabe des Users
        public int Input
        {
            get; set;
        }
        //Wert für die Umwandlung der Eingabe
        public /*just 4 the test public*/ int[] Lengths { get; set; } = new int[5];
        //Umwandlung der Eingabe
        public void Convert()
        {
            switch (Lengths[0])
            {
                case 1:
                    Console.WriteLine("Km in Meter");
                    break;
                case 2:
                    Console.WriteLine("Km in Zentimeter");
                    break;
                case 3:
                    Console.WriteLine("Km in Millimeter");
                    break;
                case 4:
                    Console.WriteLine("Km in Mikrometer");
                    break;
                case 5:
                    Console.WriteLine("Km in Nanometer");
                    break;
            }
        }
    }
}

/* 
 * 0Kilometer  (=> Meter * 1000 => Zentimeter 100000 => Millimeter 1* 10 hoch 6 => Mikrometer 1* 10 hoch 9 => Nanometer 1* 10 hoch 12)
 * 1Meter      (=> Kilometer /1000 => Zentimeter *100 => Millimeter *1000 => Mikrometer 1* 10 hoch 6 => Nanometer 1* 10 hoch 9)
 * 2Zentimeter (=> Kilometer /100000 => Meter /100 => Millimeter *10 => Mikrometer *10000 => Nanometer 1* hoch 7)
 * 3Millimeter (=> Kilometer 1* 10 hoch 6 => Meter *1000 => Zentimeter *10 => Mikrometer *1000 =>Nanometer => 1* 10 hoch 6)
 * 4Mikrometer (=> Kilometer=> Meter=> Zentimeter=> Millimeter =>Nanometer
 * 5Nanometer  (=> Kilometer=> Meter=> Zentimeter=> Millimeter =>Mikrometer
 */
