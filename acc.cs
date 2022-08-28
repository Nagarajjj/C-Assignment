using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
       
        abstract class acc
        {
            public int AccountNumber { get; set; }
            public string Name { get; set; }
            public double Balance { get; private set; } = 10000;
            public void Credit(double amount) => Balance += amount;

            public void Debit(double amount)
            {
                if (Balance < amount)
                {
                    throw new Exception("Insufficient funds!!!");
                }
                Balance -= amount;
            }
        static void Main(string[] args)
        {
            acc acc = new SBAccount();
            Console.WriteLine("enter account number");
            acc.AccountNumber = int.Parse (Console.ReadLine());
           
            Console.WriteLine("enter Name");
            acc.Name = Console.ReadLine();
            acc.CalculateInterest();
            Console.WriteLine("The Account Number is " +acc.AccountNumber + ", The name of the account Holder is "  + acc.Name +  " and Current balance is: " + acc.Balance);
        }

        public abstract void CalculateInterest();

        }

        class SBAccount : acc
        {
            
            public override void CalculateInterest()
            {
                double principle = Balance;
            Console.WriteLine("enter the Interest rate");
            double rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the duration");
            double term = float.Parse(Console.ReadLine());
          

                var interest = principle * rate * term ;
                Credit(interest);
            }
        }
   
    
}
