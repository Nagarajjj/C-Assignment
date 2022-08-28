using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Datatypes
    {
        static void data()
        {
            Console.WriteLine("the range of Float is from" + float.MinValue + "  to  "+ float.MaxValue);
            Console.WriteLine("the range of int is from" + int.MinValue + "  to  " + int.MaxValue);
            Console.WriteLine("the range of Double is from" + double.MinValue + "  to  " + double.MaxValue);
            Console.WriteLine("the range of Short is from" + short.MinValue + " to  " + short.MaxValue);
            Console.WriteLine("the range of Long is from" + long.MinValue + "  to  " + long.MaxValue);
            Console.WriteLine("the range of Unsigned Long is from" + ulong.MinValue + "to" + ulong.MaxValue);
            Console.WriteLine("the range of unsigned short is from" + ushort.MinValue + "to" + ushort.MaxValue);



        }
        static void Main(string[] args)
        {
            data();
        }
    }
}
