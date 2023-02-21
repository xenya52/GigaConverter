using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaConverter
{
    internal interface Icalculation
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
