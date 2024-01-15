using System;

namespace Class_01_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            Console.WriteLine(today);

            DateTime now = DateTime.Now;

            Console.WriteLine(today.ToString("yyyy-MM-dd hh:mm tt"));
            Console.WriteLine("{0:MMMM dd, yyyy hh:mm:ss tt}", now);
            Console.WriteLine($"{now.AddHours(12):ddd dd/MM/yyyy HH:MM}");
            Console.WriteLine($@"Time now:{now: hh:mm tt}");

            Console.ReadLine();
        }
    }
}
