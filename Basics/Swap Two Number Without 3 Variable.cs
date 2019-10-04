using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Swap_Two_Number_Without_3_Variable
    {
        public void m3()
        {
            int x, y, z;
            Console.Write("Enter the Value of x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping x=" + x + "y=" + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swapping x=" + x + "y=" + y);
        }
    }
}
