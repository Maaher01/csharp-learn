using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day_03_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
            int[] numbers = { 9, 11, 5, 7 };

            foreach ( int number in numbers ) {
                SumAsync(number).ContinueWith(
                    t => Print($"1+2+...+{number}", t.Result)
                );
            }

            Console.WriteLine("Waiting...");
            Console.ReadLine();
        }

        static void Print(string label, long result)
        {
            Console.WriteLine($"{label} = {result}");
        }

        static async Task<long> SumAsync(int n)
        {
            Console.WriteLine($"Sum thread id: {Thread.CurrentThread.ManagedThreadId}");
            long sum = 0;

            for (int i = 0; i <= n; i++) {
                sum += i;
                await Task.Delay(250);
            }

            return sum;
        }
    }
}
