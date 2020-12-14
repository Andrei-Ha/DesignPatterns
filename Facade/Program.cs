using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade MyFacade = new Facade(new Class1(), new Class2());
            MyFacade.MegaOperation();
            Console.ReadKey();
        }
    }
}
