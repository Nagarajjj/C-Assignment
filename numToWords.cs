using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class numToWords
    {
       
		static void convert_to_words(char[] num)
		{
			
			int len = num.Length;

			
			if (len == 0)
			{
				Console.WriteLine("empty string");
				return;
			}
			if (len > 8)
			{
				Console.WriteLine("Length more than "
								+ "4 is not supported");
				return;
			}

			
			string[] single_digits = new string[] {
			"zero", "one", "two", "three", "four",
			"five", "six", "seven", "eight", "nine"
		};

			
			string[] two_digits = new string[] {
			"",      "ten",  "eleven", "twelve",
			"thirteen", "fourteen", "fifteen", "sixteen",
			"seventeen", "eighteen", "nineteen"
		};

		
			string[] tens_multiple = new string[] {
			"",  "",     "twenty", "thirty", "forty",
			"fifty", "sixty", "seventy", "eighty", "ninety"
		};

			string[] tens_power
				= new string[] { "hundred", "thousand" , "tenthousand" , "lac" , "tenlac" , "crore" };

		
			Console.WriteLine((new string(num)) + ": ");

			
			if (len == 1)
			{
				Console.WriteLine(single_digits[num[0] - '0']);
				return;
			}

			
			int x = 0;
			while (x < num.Length)
			{

				
				if (len >= 3)
				{
					if (num[x] - '0' != 0)
					{
						Console.Write(
							single_digits[num[x] - '0'] + " ");
						Console.WriteLine(tens_power[len - 3]
									+ " ");

						
					}
					--len;
				}

				
				else
				{
					
					if (num[x] - '0' == 1)
					{
						int sum = num[x] - '0' + num[x + 1] - '0';
						Console.WriteLine(two_digits[sum]);
						return;
					}

					
					else if (num[x] - '0' == 2
							&& num[x + 1] - '0' == 0)
					{
						Console.WriteLine("twenty");
						return;
					}

					
					else
					{
						int i = (num[x] - '0');
						if (i > 0)
							Console.WriteLine(tens_multiple[i]
										+ " ");
						else
							Console.WriteLine("");
						++x;
						if (num[x] - '0' != 0)
							Console.WriteLine(
								single_digits[num[x] - '0']);
					}
				}
				++x;
			}
		}
		public static void Main()
		{
			convert_to_words("1231".ToCharArray());
			convert_to_words("0".ToCharArray());
			convert_to_words("10000".ToCharArray());
			convert_to_words("43".ToCharArray());
		}
	}

	

}

