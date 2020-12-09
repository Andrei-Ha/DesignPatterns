using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component jpg = new File("pics.jpg");
            Component pdf = new File("readme.pdf");
            Component pictures = new Folder("MyPictures");
            Component c = new Folder("C");
            Component boot = new File("boot.ini");
            pictures.Add(jpg);
            pictures.Add(pdf);
            c.Add(boot);
            c.Add(pictures);
            c.Print();
            Console.ReadKey();
        }
    }
}
