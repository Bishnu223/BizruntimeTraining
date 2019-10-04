using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Unary_Operators
    {
        public void m1()
        {
            int a = 10; 
             ++a;

            Console.WriteLine(a );
            a++; 
            Console.WriteLine(a);

           a--;
            Console.WriteLine(a);
           --a;
            Console.WriteLine(a);
        }
    }
}
