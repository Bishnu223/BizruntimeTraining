using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Fibonacciseries
    {
        public void T1()
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(a + " " + b);
            int c;
            for(int i=1;i<=10;i++)
            {
                c = a + b;
                Console.WriteLine(" " + c);
                a = b;
                b = c;
            }
        }

    }
}
