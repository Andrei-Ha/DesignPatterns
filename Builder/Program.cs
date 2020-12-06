using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builderA = new BuilderA();
            Director director = new Director(builderA);
            director.ConstructAC();
            Console.WriteLine(builderA.GetProduct().ToString());
            director.ConstructB();
            Console.WriteLine(builderA.GetProduct().ToString());
            Console.ReadKey();
        }
    }
}
