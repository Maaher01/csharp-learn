using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;

            Console.WriteLine(today.ToString("yyyy-MM-dd"));
            Console.WriteLine("{0:MMMM dd, yyyy hh:mm:ss tt}", now);
            Console.WriteLine($"{now.AddDays(1):ddd dd/MM/yyyy}");
            Console.WriteLine($"Time now:{now: hh:mm tt}");

            Console.ReadLine();
        }
    }
}
