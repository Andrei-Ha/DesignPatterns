using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator manager = new ManagerMediator();
            Colleague customer = new CustomerColleague(manager);
            manager.Customer = customer;
            Colleague programmer = new ProgrammerColleague(manager);
            manager.Programmer = programmer;
            Colleague tester = new TesterColleague(manager);
            manager.Tester = tester;
            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");
            Console.ReadLine();
        }
    }
}
