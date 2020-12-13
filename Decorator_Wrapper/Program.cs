using System;

namespace Decorator_Wrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza italiano = new ItalianPizza();
            Client andrei = new Client("Andrei", italiano);
            andrei.OrderInfo();
            TomatoPizza tp = new TomatoPizza(italiano);
            andrei.SetPizza(tp);
            andrei.OrderInfo();
            andrei.SetPizza(new CheesePizza(tp));
            andrei.OrderInfo();
            andrei.SetPizza(new TomatoPizza(new CheesePizza(new BulgarianPizza())));
            andrei.OrderInfo();
            Client Polya = new Client("Polina", italiano);
            Polya.OrderInfo();
            Console.ReadKey();
        }
    }
}
