using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    static class Andr
    {
        public static string Tab(int q)
        {
            string result = "";
            for (int i = 0; i < q; i++)
                result += "     ";
            return result;
        }
    }
    abstract class Component
    {
        private string _name;
        private int _size = 0;
        public string Name { get => _name; set => _name = value; }
        public int Size { get => _size; set => _size = value; }
        public Component(string name, int size)
        {
            Name = name;
            Size = size;
        }
        public virtual void Print(int i=0) => Console.WriteLine(Andr.Tab(i) + $"{Name}({Size})");
        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }
        public virtual void RecalculateSize() { }
        public virtual bool IsFolder() => false;
    }
    class File : Component
    {
        public File(string name, int size) : base(name,size) { }

    }
    class Folder: Component
    {
        private List<Component> children = new List<Component>();
        public Folder(string name) : base(name, 0) { }
        public override void Add(Component component) => children.Add(component);
        public override void Remove(Component component) => children.Remove(component);
        public override bool IsFolder() => true;
        public override void RecalculateSize()
        {
                Size = 0;
            foreach (Component child in children)
            {
                if (child.IsFolder())
                    child.RecalculateSize();
                Size += child.Size;
            }
        }
        public override void Print(int i)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(i);
            Console.ForegroundColor = ConsoleColor.White;
            foreach(Component child in children)
            {
                child.Print(i+1);
            }
        }
    }
}
