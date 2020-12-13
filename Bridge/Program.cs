using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new OfficeProgrammer(new SePePe());
            programmer.DoWork();
            programmer.EarnMoney();
            programmer.Language = new Csharp();
            programmer.DoWork();
            programmer.EarnMoney();
            Programmer frilancer = new FreelanceProgrammer(new Csharp());
            frilancer.DoWork();
            frilancer.EarnMoney();
            Console.ReadKey();
        }
    }
}
