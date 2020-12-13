using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Square: IPerimeter
    {
        public int Side_length { get; set; }
        public Square(int i) => Side_length = i;
        public double GetPerimeter()
        {
            return 4*Side_length;
        }
    }
    interface IPerimeter
    {
        double GetPerimeter();
    }
    class Circle
    {
        public int Radius { get; set; }
        public Circle(int i) => Radius = i;
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    class Adapter : IPerimeter
    {
        private Circle _circle;
        public Adapter(Circle circle)
        {
            _circle = circle;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * _circle.Radius;
        }
    }
}
