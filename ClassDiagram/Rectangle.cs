using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculateCircumference()
        {
            return (2 * Length) + (2 * Width);
        }
    }
}
