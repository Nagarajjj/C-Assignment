using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class interest
    {
        static void Main(string[] args)
        {
            princInt();
        }
        public static void princInt()
        {
            Console.WriteLine("enter principal amount");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Duration");
            int T = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            int R = int.Parse(Console.ReadLine());
            int interest = P * T * R / 100;
            Console.WriteLine( "the Total interest is  " + interest);
        }

    }
}
