using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class OS
    {
        private static OS instance;
        public string NameOS { get; private set; }
        private OS(string n) {
            NameOS = n;
        }
        public static OS GetInstance(string nameOs)
        {
            if (instance == null)
                instance = new OS(nameOs);
            return instance;
        }
    }
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string nameOS)
        {
            OS = OS.GetInstance(nameOS);
        }
    }
}
