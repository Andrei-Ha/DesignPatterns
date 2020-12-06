using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string Name)
        {
            this.Name = Name;
        }
        abstract public House Create();
    }
    ///
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name) { }
        public override House Create()
        {
            return new PanelHouse();
        }
    }
    /// 
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n) { }
        public override House Create()
        {
            return new WoodHouse();
        }
    }
    /// 
    interface House { }
    ///
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
    // /
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
