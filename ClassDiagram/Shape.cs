using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    class Shape : AbstractEntity
    {
        public double Area { get; }
        public double Circumference { get; }
        public int NumberOfSides { get; }
    }
}
