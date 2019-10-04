using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Type_Casting
    {
        public void A1()
        {
            int i = 57;
            double d = 510.23;

            long l = i;

            float f = (float) d;

            Console.WriteLine("Int value " + i);
            Console.WriteLine("Long value " + l);
            Console.WriteLine("Float value " + f);
        }
    }
}
