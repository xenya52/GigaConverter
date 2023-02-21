using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaConverter
{
    internal interface Iinput
    {
        public int i1 { get; set; }
        public int i2 { get; set; }
        public char ic { get; set; }

        public void Calculation()
        {
            if (ic == '/')
            {
                i1 = i1 / i2;
            }
            else
            {
                i1 = i1 * i2;
            }
        }
    }
}
