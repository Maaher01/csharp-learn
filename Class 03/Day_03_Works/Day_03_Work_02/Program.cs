using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day_03_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Task.Run(() =>
            {
                var result = Sum(20);
                Console.WriteLine(result);
            });

            Console.WriteLine("Waiting...");
            Console.ReadLine();
        }

        static long Sum(int num)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
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
