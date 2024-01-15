using Day_02_Work_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_02_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle { Length = 1, Width = 1 };

            Console.WriteLine($"Circumference: {r1.Circumference}, Area: {r1.Area()}");

            IShape[] rects = new Rectangle[] 
            { 
                new Rectangle { Length=1, Width=2 },
                new Rectangle { Length = 3, Width = 4 } 
            };

            rects.ToList().ForEach(r => Console.WriteLine($"Area: {r.Area()}, Circumference: {r.Circumference}"));

            List<IShape> shapes = new List<IShape>
            {
                new Rectangle { Length = 1, Width = 2 },
                new Rectangle { Length = 3, Width = 4 },
                new Rectangle { Length = 5, Width = 6 },
                new Square { Length = 7 }
            };

            shapes.ForEach( s => Console.WriteLine($"Area: {s.Area()}, Circumference: {s.Circumference}") );

            (from s in shapes 
             where s is Square 
             select new { s.Circumference, Area = s.Area() })
             .ToList()
             .ForEach(s => Console.WriteLine($"Area of square: {s.Area}, Circumference of square: {s.Circumference}"));

            var avgArea = shapes.Average(s => s.Area());
            var avgCir = shapes.Average(s => s.Circumference);

            Console.WriteLine($"Average area: {avgArea}, Average circumference: {avgCir}");
            Console.ReadLine();
        }
    }
}
