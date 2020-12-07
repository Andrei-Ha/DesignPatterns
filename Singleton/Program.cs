using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Thread(() =>
            {
                Comp newComp = new Comp();
                newComp.Os = OS.GetInstance("Windows8");
                Console.WriteLine($"in new thread running \"{newComp.Os.Name}\"");
            })).Start();
            Thread.Sleep(1);
            Comp myComp = new Comp();
            myComp.Launch("Windows10");
            Console.WriteLine(myComp.Os.Name);
            myComp.Launch("Windows7");
            Console.WriteLine(myComp.Os.Name);
            Console.ReadKey();
        }
    }
}
