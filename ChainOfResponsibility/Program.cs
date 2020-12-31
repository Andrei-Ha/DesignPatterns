using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentHandler bankHandler = new BankPaymentHandler();
            PaymentHandler moneyHandler = new MoneyPaymentHandler();
            PaymentHandler payPalHandler = new PayPayPaymentHandler();
            bankHandler.Successor = moneyHandler;
            moneyHandler.Successor = payPalHandler;
            bankHandler.Handle(new Receiver(false, true, true));
            Console.ReadKey();
        }
    }
}
