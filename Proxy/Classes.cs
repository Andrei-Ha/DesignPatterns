using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    static class Book
    {
        private static List<string> listReal = new List<string>(new string[]{"spring", "summer", "autumn", "winter"});
        public static string GetPage(int i) => listReal[i];
    }
    abstract class Subject
    {
        abstract public string Request(int i);
    }
    class RealSubject: Subject
    {
        public override string Request(int i)
        {
            return ($"page number {i}:" +Book.GetPage(i));
        }
    }
    class ProxySubject: Subject
    {
        RealSubject realSubject;
        Dictionary<int, string> dict;
        public ProxySubject()
        {
            if (realSubject == null)
                realSubject = new RealSubject();
        }
        public override string Request(int i)
        {
            if (dict == null)
                dict = new Dictionary<int, string>();
            string dictResult;
            if (!dict.TryGetValue(i, out dictResult))
            {
                string result = realSubject.Request(i);
                dict.Add(i, result);
                return result;
            }
            else
                return dictResult + " from cache";
        }
    }
}
