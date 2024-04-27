using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms for the Fibonacci series:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
