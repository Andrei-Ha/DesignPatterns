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
            pictures.Add(jpg);
            pictures.Add(pdf);
            Component temp_folder = new Folder("Temp");
            temp_folder.Add(new File("readmi.txt"));
            pictures.Add(temp_folder);

            Component c = new Folder("C");
            Component boot = new File("boot.ini");
            
            c.Add(boot);
            c.Add(pictures);
            c.Add(temp_folder);
            c.Print();
            Console.ReadKey();
        }
    }
}
