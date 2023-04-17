using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaConverter
{
    internal class Length : InputAndSolution
    {
        
        //Kilometer
        public void KmCalculationMethod()
        {
            switch (UserDesicion)
            {
                case 0: solution = UserNumberInput; break;
                case 1: solution = UserNumberInput * 1000; break;
                case 2: solution = UserNumberInput * 10000; break;
                case 3: solution = UserNumberInput * 100000; break;
                case 4: solution = UserNumberInput * 1000000; break;
                case 5: solution = UserNumberInput * 1000000000; break;
                case 6: solution = UserNumberInput * 1000000000000; break;
            }
            UserNumberInput = solution;

        }
        //Meter
        public void MCalculationMethod()
        {
            switch (UserDesicion)
            {
                
                case 0: solution = UserNumberInput / 1000; break;
                case 1: solution = UserNumberInput; break;
                case 2: solution = UserNumberInput * 10; break;
                case 3: solution = UserNumberInput * 100; break;
                case 4: solution = UserNumberInput * 1000; break;
                case 5: solution = UserNumberInput * 1000000; break;
                case 6: solution = UserNumberInput * 1000000000; break;
            }
            UserNumberInput = solution;
        }
        
        //Decimeter
        public void DmCalculationMethod()
        {
            switch (UserDesicion)
            {
                
                case 0: solution = UserNumberInput / 10000; break;
                case 1: solution = UserNumberInput / 10; break;
                case 2: solution = UserNumberInput; break;
                case 3: solution = UserNumberInput * 10; break;
                case 4: solution = UserNumberInput * 100; break;
                case 5: solution = UserNumberInput * 100000; break;
                case 6: solution = UserNumberInput * 100000000; break;
            }
            UserNumberInput = solution;
        }
        
        //Centimeter
        public void CmCalculationMethod()
        {
            switch (UserDesicion)
            {
                
                case 0: solution = UserNumberInput / 100000; break;
                case 1: solution = UserNumberInput / 100; break;
                case 2: solution = UserNumberInput / 10; break;
                case 3: solution = UserNumberInput; break;
                case 4: solution = UserNumberInput * 10; break;
                case 5: solution = UserNumberInput * 10000; break;
                case 6: solution = UserNumberInput * 10000000; break;
            }
            UserNumberInput = solution;
        }
        
        //Millimeter
        public void MmCalculationMethod()
        {
            switch (UserDesicion)
            {
                
                case 0: solution = UserNumberInput / 1000000; break;
                case 1: solution = UserNumberInput / 1000; break;
                case 2: solution = UserNumberInput / 100; break;
                case 3: solution = UserNumberInput / 10; break;
                case 4: solution = UserNumberInput; break;
                case 5: solution = UserNumberInput * 1000; break;
                case 6: solution = UserNumberInput * 1000000; break;
            }
            UserNumberInput = solution;
        }
        
        //Mikrometer
        public void MkCalculationMethod()
        {
            switch (UserDesicion)
            {
                
                case 0: solution = UserNumberInput / 1000000000; break;
                case 1: solution = UserNumberInput / 1000000; break;
                case 3: solution = UserNumberInput / 100000; break;
                case 4: solution = UserNumberInput / 10000; break;
                case 5: solution = UserNumberInput / 1000; break;
                case 2: solution = UserNumberInput; break;
                case 6: solution = UserNumberInput * 1000; break;
            }
            UserNumberInput = solution;
        }
        
        //Nanometer
        public void NmCalculationMethod()
        {
            switch (UserDesicion)
            {
                
                case 0: solution = UserNumberInput / 1000000000000; break;
                case 1: solution = UserNumberInput / 1000000000; break;
                case 2: solution = UserNumberInput / 100000000; break;
                case 3: solution = UserNumberInput / 10000000; break;
                case 4: solution = UserNumberInput / 1000000; break;
                case 5: solution = UserNumberInput / 1000; break;
                case 6: solution = UserNumberInput; break;
            }
            UserNumberInput = solution;
        }
    }
}

/* Längen =  Km, 1000; M, 10; Dm, 10; Cm, 10; Mm 10; Mk, 1000; Nm, 1000; */
