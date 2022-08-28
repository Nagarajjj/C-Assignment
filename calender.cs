using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class calender
    {
        static int year = new int();
        static int month = new int();
        static int[,] calendar = new int[6, 7];

        static void Main(string[] args)
        {
            Calender();
            DrawCalendar();
            DrawHeader();
            FillCalendar();

        }

        public static void Calender()
        {
            Console.Write("Enter the year? ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month (January = 1, etc): ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }
        static void DrawHeader()
        {
            Console.Write("\n\n");
            Console.WriteLine("\t" + month);
            Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
        }

        static void FillCalendar()
        {
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay <= days; j++)
                {
                    if (i == 0 && month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay;
                        currentDay++;
                    }
                }
            }
        }
        static void DrawCalendar()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
    
}
