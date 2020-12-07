using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class OS
    {
        private static object syncRoot = new object();
        private static OS _instance;
        public string Name { get; private set; }
        private OS(string name)
        {
            Name = name;
        }
        public static OS GetInstance(string n)
        {
            lock (syncRoot)
            {
                if (_instance == null)
                    _instance = new OS(n);
            }
            return _instance;
        }
    }
    class Comp
    {
        public OS Os { get; set; }
        public void Launch(string nameOs)
        {
            Os = OS.GetInstance(nameOs);
        }
    }
}
