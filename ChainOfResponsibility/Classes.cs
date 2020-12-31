using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Classes
    {
    }
    class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPalTransfer { get; set; }
        public Receiver(bool bt, bool mt, bool pt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = pt;
        }
    }
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
    class BankPaymentHandler: PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("we carry out a bank transfer");
            else if (this.Successor != null)
                this.Successor.Handle(receiver);
        }
    }
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("we carry out a money transfer");
            else if (this.Successor != null)
                this.Successor.Handle(receiver);
        }
    }
    class PayPayPaymentHandler: PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("we carry out a PayPal transfer");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
