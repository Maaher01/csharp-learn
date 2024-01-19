using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Day_03_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 11, 5, 7 };
            List<Task> tasks = new List<Task>();
            
            foreach (int number in numbers) 
            { 
                tasks.Add(RunAsync(number));        
            }

            Task.WhenAll(tasks).Wait();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        static async Task RunAsync(int n)
        {
            long sum = await SumAsync(n);
            Console.WriteLine($"1+2+...+{n}={sum}");
        }

        static async Task<long> SumAsync(int number)
        {
            Console.WriteLine($"Sum thread: {Thread.CurrentThread.ManagedThreadId}, summing upto {number}");
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += i;
                await Task.Delay(250);
            }
            return sum;
        }
    }
}
