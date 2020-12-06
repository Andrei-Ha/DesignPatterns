using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    interface ISend
    {
        string Send();
    }
    abstract class Furniture : ISend
    {
        public int Price { get; }
        public abstract string Send();
        public Furniture(int p)
        {
            Price = p;
        }
    }
    class Table : Furniture
    {
        public override string Send()
        {
            return $"Table was sent, price is {Price}";
        }
        public Table(int pp) : base(pp) { }
    }
    class Chair : Furniture
    {
        public override string Send()
        {
            return $"Chair was sent, price is {Price}";
        }
        public Chair(int ii) : base(ii) { }
    }

    interface IFurnitureFactory
    {
        public Furniture Create();
    }
    abstract class BaseFactory : IFurnitureFactory
    {
        public string Name { get; }
        public int Distance;
        public abstract Furniture Create();
        public BaseFactory(string n, int d)
        {
            Name = n;
            Distance = d;
        }
    }
    class TableFactory : BaseFactory
    {
        public TableFactory(string n, int d) : base(n, d) { }
        public override Furniture Create()
        {

            return new Table(Distance*5);
        }
    }
    class ChairFactory: BaseFactory
    {
        public ChairFactory(string n, int d) : base(n, d) { }
        public override Furniture Create()
        {
            return new Chair(Distance*2);
        }
    }

}
