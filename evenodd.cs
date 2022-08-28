using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class evenodd
    {
        public static void Evenodd()
        {
            //int Even = 0;
            //int Odd = 0;

            int[] array = new int[5];

            Console.WriteLine("Enter the number");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]+" Number is Even");
                }
                else
                {
                    Console.WriteLine(array[i]+" Number is Odd");
                }
            }
        }
        static void Main(string[] args)
        {
            Evenodd();
        }
    }
}


