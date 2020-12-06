using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AbstractFactory!");

            var MyNewCar = new Car(new FactoryR());
            Console.WriteLine(MyNewCar.About());
            Console.WriteLine("-------------------");
            Car workCar = new Car(new FactoryV());
            Console.WriteLine(workCar.About());
            Console.ReadKey();
        }
    }
}
