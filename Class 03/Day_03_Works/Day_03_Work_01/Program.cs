using System;
using System.Threading;

namespace Day_03_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Sum(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static long Sum(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;
                Thread.Sleep(250);
            }
            return sum;
        }
    }
}
