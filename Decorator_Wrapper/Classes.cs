using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Wrapper
{
    abstract class Pizza
    {
        public string Name { get; set; }
        public Pizza(string name)
        {
            Name = name;
        }
        public abstract int GetCoast();
    }
    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца") { }
        public override int GetCoast() => 100;
    }
    class BulgarianPizza : Pizza
    {
        public BulgarianPizza() : base("Болгарская пицца") { }
        public override int GetCoast() => 50;
    }
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;
        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            _pizza = pizza;
        }
    }
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza):base(pizza.Name+", с томатами",pizza) { }
        public override int GetCoast()
        {
            return _pizza.GetCoast() + 7;
        }
    }
    class CheesePizza: PizzaDecorator
    {
        public CheesePizza(Pizza pizza):base(pizza.Name + ", с сыром", pizza) { }
        public override int GetCoast()
        {
            return _pizza.GetCoast() + 3;
        }
    }
    class Client
    {
        public string Name { get; set; }
        private Pizza _pizza;
        public Client(string n, Pizza p)
        {
            Name = n;
            _pizza = p;
        } 
        public void SetPizza(Pizza pizza)
        {
            _pizza = pizza;
        }
        public void OrderInfo()
        {
            Console.WriteLine($"Клиент {Name} сделал заказ: {_pizza.Name} стоимостью {_pizza.GetCoast()}");
        }
    }
}
