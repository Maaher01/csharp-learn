using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_02_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rainfall> rainfalls = new List<Rainfall>()
            {
                new Rainfall() { District="Dhaka", Precipitation=78.90 },
                new Rainfall() { District="Comilla", Precipitation=67.88 },
                new Rainfall() { District="Sylhet", Precipitation=71.22 },
                new Rainfall() { District="Rajshahi", Precipitation=34.55 }
            };

            rainfalls.ForEach(r => Console.WriteLine($"District: {r.District}, Rainfall: {r.Precipitation}"));

            Console.WriteLine();

            rainfalls.OrderByDescending(r => r.Precipitation)
                .ToList()
                .ForEach(r => Console.WriteLine($"District: {r.District}, Rainfall: {r.Precipitation}"));

            var highest = rainfalls.Max(r => r.Precipitation);

            Console.WriteLine();

            Console.WriteLine($"Highest precipitation value: {highest}");

            //var highDist = (from r in rainfalls
            // where (r.Precipitation == rainfalls.Max(x => x.Precipitation))
            // select r).SingleOrDefault();

            var highDist = rainfalls.Where(r => r.Precipitation == rainfalls.Max(x => x.Precipitation)).SingleOrDefault();

            Console.WriteLine();

            Console.WriteLine($"District with highest precipitation value: {highDist?.District}");

            Console.ReadLine();
        }
    }
    public class Rainfall
    {
        public string District { get; set; }

        public double Precipitation { get; set; }
    }
}
