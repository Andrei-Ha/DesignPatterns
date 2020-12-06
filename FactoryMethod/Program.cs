using System;
namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryMethod!");
            Developer developer1 = new PanelDeveloper("SuperPanelDeveloper");
            Developer developer2 = new WoodDeveloper("CoolWoodDeveloper");
            developer1.Create();
            developer2.Create();

            var chairfactory = new ChairFactory("Ivach", 100);
            Furniture chair = chairfactory.Create();
            Console.WriteLine(chair.Send());
            IFurnitureFactory furnitureFactory = new TableFactory("Pinskdrev", 10);
            Furniture mytable = furnitureFactory.Create();
            Console.WriteLine(mytable.Send());
            var chairfactory2 = new ChairFactory("fdsf", 4);
            var newchair = chairfactory2.Create();
            Console.WriteLine(newchair.Send());
            Console.ReadKey();
        }
    }
}
