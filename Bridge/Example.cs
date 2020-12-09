using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface ILanguage
    {
        public void Compile();
        public void Run();
    }
    class SePePe:ILanguage
    {
        public void Compile()
        {
            Console.WriteLine("Compile C++");
        }
        public void Run()
        {
            Console.WriteLine("Run C++ app");
        }
    }
    class Csharp:ILanguage
    {
        public void Compile() => Console.WriteLine("Compile C#");
        public void Run() => Console.WriteLine("Run app.exe");
    }
    abstract class Programmer
    {
        private ILanguage _ilanguage;
        public Programmer(ILanguage language) => _ilanguage = language;
        public ILanguage Language { set=> _ilanguage = value; }
        public virtual  void DoWork()
        {
            _ilanguage.Compile();
            _ilanguage.Run();
        }
        public abstract void EarnMoney();
    }
    class OfficeProgrammer:Programmer
    {
        public OfficeProgrammer(ILanguage language) : base(language) { }
        public override void DoWork()
        {
            base.DoWork();
        }
        public override void EarnMoney()
        {
            Console.WriteLine("will recive the earned money at the end of the month");
        }
    }
    class FreelanceProgrammer: Programmer
    {
        public FreelanceProgrammer(ILanguage language) : base(language) { }
        public override void EarnMoney()
        {
            Console.WriteLine("receiving money after completing the order");
        }
    }

}
