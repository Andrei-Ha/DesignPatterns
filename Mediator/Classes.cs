using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
    abstract class Colleague
    {
        protected Mediator _mediator;
        public Colleague(Mediator med)
        {
            _mediator = med;
        }
        public virtual void Send(string msg)
        {
            _mediator.Send(msg, this);
        }
        public abstract void Notify(string message);
    }
    // class of Customer
    class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator) {
        }
        public override void Notify(string message) // Уведомление заказчику придет когда работа будет выполнена
        {
            Console.WriteLine("Сообщение заказчику: " + message);
        }
    }
    // Programmers class
    class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator): base(mediator) { }
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение программисту: "+ message);
        }
    }
    // Tester class
    class TesterColleague: Colleague
    {
        public TesterColleague(Mediator mediator) : base(mediator) { }
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение тестеру: " + message);
        }
    }
    class ManagerMediator: Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }
        public override void Send(string msg, Colleague colleague)
        {
            if (colleague == Customer)// если отправитель - заказчик, то отправляем  уведомление программисту
                Programmer.Notify("есть новый заказ на ПО");
            else if (colleague == Programmer)// уведомляем о готовности тестера
                Tester.Notify("необходимо протестировать ПО");
            else if (colleague == Tester)// уведомляем заказчика о готовности продукта
                Customer.Notify("Заказ выполнен!");
        }
    }
}
