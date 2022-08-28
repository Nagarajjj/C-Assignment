using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class calculator
    {
        static void Main(string[] args)
        {
            calc();

        }
        public static void calc()
        {

            {
                double x, y;
                char operation;
              while (true)
                {
                    Console.WriteLine("Input first number: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Input second number: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input operation: +  _  /  * ");
                    operation = Convert.ToChar(Console.ReadLine());

                    if (operation == '+')
                        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                    else if (operation == '-')
                        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                    else if ((operation == 'x') || (operation == '*'))
                        Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                    else if (operation == '/')
                        Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                    
                    else
                        Console.WriteLine("Wrong Character");
                }
            }
        }
    }

    }
