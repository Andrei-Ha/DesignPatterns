using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Product
    {
        public List<string> _allParts;
        public override string ToString()
        {
            string str = string.Empty;
            foreach (string s in _allParts)
                str += s+"; ";
            return str.Remove(str.Length-2);
        }
        public Product()
        {
            _allParts = new List<string>();
        }
        public void AddPart(string str)
        {
            _allParts.Add(str);
        }
    }
    interface IBuilder{
        public void Reset();
        void AddPart1();
        void AddPart2();
        void AddPart3();
    }
    class BuilderA:IBuilder
    {
        private Product _product = new Product();
        public void Reset()
        {
            _product = new Product();
        }
        public void AddPart1() => _product.AddPart("first");
        public void AddPart2() => _product.AddPart("second");
        public void AddPart3() => _product.AddPart("third");
        public Product GetProduct() => _product;
    }
    class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        public void ConstructAC()
        {
            _builder.Reset();
            _builder.AddPart1();
            _builder.AddPart3();
        }
        public void ConstructB()
        {
            _builder.Reset();
            _builder.AddPart2();
        }
    }
}
