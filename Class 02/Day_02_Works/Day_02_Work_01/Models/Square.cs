using System;

namespace Day_02_Work_01.Models
{
    internal class Square : IShape
    {
        private double _length;
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Length must be greater than 0");
                }
                else
                {
                    _length = value;
                }
            }
        }

        public double Circumference => 4 * Length;

        public double Area()
        {
            return Length * Length;
        }
    }
}
