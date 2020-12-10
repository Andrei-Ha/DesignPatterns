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
        private int _size=0;
        public string Name { get => _name; set => _name = value; }
        public int Size { get => _size; set => _size = value; }
        public Component(string name) => Name = name;
        public virtual void Print(int i=0) => Console.WriteLine(Andr.Tab(i) + Name);
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
        public override void Print(int i)
        {
            //string result = $"Название папки:{Name}. Содержимое: ";
            //Console.WriteLine(i.ToString() + Name);
            //Console.WriteLine("subnode:");
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
