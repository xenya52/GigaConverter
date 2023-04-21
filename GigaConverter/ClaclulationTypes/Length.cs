using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaConverter
{
    internal class Length : InputAndSolution
    {
        
        // Längen =  Km, 1000; M, 10; Dm, 10; Cm, 10; Mm 10; Mk, 1000; Nm, 1000;
        private int[] LengthsChain = new int[7]
        {
            1000, //Km
            10, //M
            10, //Dm
            10, //Cm
            10, //Mm
            1000, //Mk
            1000, //Nm
        };
        public void PositiveLengthCalculationMethod()   // UserDesicion = 0, KM; 1, M; 2, Dc; 3, Cm; 4, Mm; 5, Mk; 6, Nm;
        {
            for (int i = UserDesicionInput; i < UserDesicionOutput; i++)
            {
                UserNumberInput = UserNumberInput * LengthsChain[i];
            }
            solution = UserNumberInput;
            Console.WriteLine(solution+" positive");
            }
        public void NegativeLengthCalculationMethod()   // UserDesicion = 0, KM; 1, M; 2, Dc; 3, Cm; 4, Mm; 5, Mk; 6, Nm;
        {
            for (int i =UserDesicionInput; i > UserDesicionOutput; i--)
            {
                UserNumberInput = UserNumberInput / LengthsChain[i];
            }
            solution = UserNumberInput;
            Console.WriteLine(solution + " negative");
        }
    }
}

