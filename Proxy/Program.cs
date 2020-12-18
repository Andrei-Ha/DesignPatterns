using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject realSubject = new RealSubject();
            Console.WriteLine(realSubject.Request(3));
            Console.WriteLine( );
            Subject wiaProxy = new ProxySubject();
            Console.WriteLine(wiaProxy.Request(1));
            Console.WriteLine(wiaProxy.Request(2));
            Console.WriteLine(wiaProxy.Request(1));
            Console.WriteLine(wiaProxy.Request(0));
            Console.WriteLine(wiaProxy.Request(3));
            Console.WriteLine(wiaProxy.Request(2));
            Console.WriteLine(wiaProxy.Request(0));
            Console.WriteLine(wiaProxy.Request(3));
            Console.WriteLine(wiaProxy.Request(1));
        }
    }
}
