using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class reverseString
    {
        static void Main(string[] args)
        {
            Reverse();
        }
        public static void Reverse()
        {
            string s = "Hey hi, .Net developer here";

            string[] words = s.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }

            Console.WriteLine(sb);
        }
    }
}
