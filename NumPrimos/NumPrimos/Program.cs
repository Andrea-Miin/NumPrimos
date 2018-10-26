using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  NUMEROS PRIMOS  ");
            Console.WriteLine("* -------------- *");
            for (int i = 1; i <= 500; i++)
            {
                string text = i.ToString();
                if (text.EndsWith("00"))
                {
                    Console.WriteLine();
                }
                if (IsPrime(i) == true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
