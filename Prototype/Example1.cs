using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    interface IDevice
    {
        IDevice Clone();
        string Info();
    }
    class Workstation:IDevice
    {
        public Person person { get; set; }
        public string Name { get; set; }
        public int IP { get; set; }
        public IDevice Clone()
        {
            Workstation clone = (Workstation)this.MemberwiseClone();
            clone.person = new Person() { Name = this.person.Name, Age = this.person.Age };
            return clone;
        }
        public string Info()
        {
            return $"Device name:{Name}; IP:{IP}; Owner:{person.Name} - {person.Age} years old";
        }
    }
}
