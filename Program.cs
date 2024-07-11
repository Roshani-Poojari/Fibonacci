using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to view the fibonacci series :");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            if (myNumber <= 0)
            {
                Console.WriteLine("Enter a valid number!");
                return;
            }
            if (myNumber == 1)
            {
                Console.WriteLine("Series:\n"+a);
                return;
            }
            Console.WriteLine("Series:\n" + a + "\n" + b);
            for (int i = 3; i <= myNumber; i++)
            {
                c = a + b;
                Console.Write(c + "\n");
                a = b;
                b = c;
            }

        }
    }
}