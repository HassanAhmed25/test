using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:     ");
            int fact = Convert.ToInt32(Console.ReadLine());
            for (int i = fact - 1 ; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.Write("Factorial is:    " + fact);
            Console.ReadKey();

        }
    }
}
