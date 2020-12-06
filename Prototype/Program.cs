using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Workstation myComp = new Workstation() { 
                Name = "Andr", IP = 222, person = new Person() { Name = "Андрей", Age = 36 } 
            };
            Console.WriteLine(myComp.Info());
            IDevice LudaComp = myComp.Clone();
            Console.WriteLine(LudaComp.Info());

            myComp.Name = "nata";
            myComp.IP = 40;
            myComp.person.Name = "Наташа";
            myComp.person.Age = 50;
            Console.WriteLine(myComp.Info());

            Console.WriteLine(LudaComp.Info());
            Console.ReadKey();
        }
    }
}
