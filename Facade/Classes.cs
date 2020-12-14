using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Class1
    {
        public string Operation1() => "Operation1";
        public string Operation2() => "Operation2";

    }
    class Class2
    {
        public string OperationA() => "OpA";
        public string OperationB() => "OpB";
    }
    class Facade
    {
        private Class1 _class1;
        private Class2 _class2;
        public Facade(Class1 class1, Class2 class2)
        {
            _class1 = class1;
            _class2 = class2;
        }
        public void MegaOperation()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_class1.Operation1()).Append(";").Append(_class1.Operation2() + ";");
            builder.Append(_class2.OperationA()).Append(";").Append(_class2.OperationB() + ";");
            Console.WriteLine(builder.ToString());
        }
    }
}
