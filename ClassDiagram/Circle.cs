using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
