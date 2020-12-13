using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component jpg = new File("pics.jpg",3);
            Component pdf = new File("readme.pdf",7);
            Component pictures = new Folder("MyPictures");
            pictures.Add(jpg);
            pictures.Add(pdf);
            Component temp_folder = new Folder("Temp");
            temp_folder.Add(new File("readme.txt",23));
            pictures.Add(temp_folder);

            Component c = new Folder("C");
            Component boot = new File("boot.ini",45);
            new Folder("");
            c.Add(boot);
            c.Add(pictures);
            c.Add(new File("cmd.exe",9));
            Component win_folder = new Folder("windows");
            win_folder.Add(new File("one.doc", 5));
            win_folder.Add(new Folder("system"));
            win_folder.Add(new File("two.docx", 3));
            c.Add(win_folder);
            c.RecalculateSize();
            c.Print();
            Console.ReadKey();
        }
    }
}
