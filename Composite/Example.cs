using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    abstract class Component
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public Component(string name) => Name = name;
        public virtual void Print() => Console.WriteLine(Name);
        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }
    }
    class File : Component
    {
        public File(string name) : base(name) { }
    }
    class Folder: Component
    {
        private List<Component> children = new List<Component>();
        public Folder(string name) : base(name) { }
        public override void Add(Component component) => children.Add(component);
        public override void Remove(Component component) => children.Remove(component);
        public override void Print()
        {
            //string result = $"Название папки:{Name}. Содержимое: ";
            Console.WriteLine("Node:" + Name);
            Console.WriteLine("subnode:");
            foreach(Component child in children)
            {
                child.Print();
            }
        }
    }
}
