using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(() =>
            {
                Thread.Sleep(190);
                Computer comp2 = new Computer();
                comp2.Launch("Windows10");
                Console.WriteLine("MyComp2" + comp2.OS.NameOS);
            });
            myThread.Start();
            Thread.Sleep(200);
            Computer computer = new Computer();
            computer.Launch("Windows7");
            Console.WriteLine(computer.OS.NameOS);
            computer.Launch("Windows10");
            computer.OS = OS.GetInstance("WindowsServer2003"); 
            Console.WriteLine(computer.OS.NameOS);
            Console.ReadKey();
        }
    }
}
