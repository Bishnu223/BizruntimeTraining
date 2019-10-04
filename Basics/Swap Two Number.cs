using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Swap_Two_Number
    {
        public void m2()
        {
            int x, y, z;
            Console.Write("Enter the Value of x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping x="+x+"y="+y);
            z = x;
            x = y;
            y = z;
            Console.WriteLine("After swapping x=" + x + "y=" + y);
        }
        
    }
}
