using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(10);
            IPerimeter mySquare = new Square(20);
            Console.WriteLine("Area of square:" + mySquare.GetPerimeter());
            IPerimeter newCircle = new Adapter(myCircle);
            Console.WriteLine("Area of circle:" + newCircle.GetPerimeter());
            Console.ReadKey();
        }
    }
}
