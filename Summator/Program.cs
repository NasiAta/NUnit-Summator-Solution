// See https://aka.ms/new-console-template for more information
using System;
namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new long[] { 1, 2, 3, 4, 5, 6 });
            if (result == 21)
            {
                Console.WriteLine("Test PASS");
            }
            else
            {
                Console.WriteLine("Test FAIL");
            }
            {
                int average = Summator.average(new int[] { 5, 10, 15 });
                if (average == 10)
                {
                    Console.WriteLine("Test PASS");
                }
                else
                {
                    Console.WriteLine("Test FAIL");
                }
            }
        }
    }
}



