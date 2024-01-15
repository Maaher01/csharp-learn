using System;

namespace Day_02_Work_01.Models
{
    internal class Rectangle : IShape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get
            { 
                return _length; 
            }
            set
            {
                if (value <= 0) {
                    throw new Exception("Length must be greater than 0");
                } else {
                    _length = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width must be greater than 0");
                }
                else
                {
                    _width = value;
                }
            }
        }

        public double Circumference { 
            get
            {
                return (2 * Length + 2 * Width);
            }
        }

        public double Area()
        {
            return Length * Width;
        }
    }
}
