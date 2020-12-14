
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Flyweight
{
    class TreeType
    {
        public string Sort { get; set; }
        public string Color { get; set; }
    }
    class Tree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TreeType LinkType;
    }
    class TreeFactory
    {
        private static List<TreeType> list = new List<TreeType>();
        public static TreeType GetTree(string sort, string color)
        {
            if(list.Where(p=>(p.Color==color && p.Sort==sort)).Count()>0)
            {
                return list.Where(p => (p.Color == color && p.Sort == sort)).FirstOrDefault();
            }
            TreeType  newTree = new TreeType() { Color = color, Sort = sort };
            list.Add(newTree);
            return newTree;
        }
        public static void ShowAllModel()
        {
            foreach(TreeType t in list)
            {
                Console.WriteLine($"All models: {t.Sort}; {t.Color}\n");
            }
        }
    }
    class Forest
    {
        public List<Tree> forest = new List<Tree>();
        public void PlantTree(int x, int y, string sort, string color)
        {
            forest.Add(new Tree() { X = x, Y = y, LinkType = TreeFactory.GetTree(sort, color) });
        }
        public void ShowForest()
        {
            foreach (Tree tr in forest) {
                Console.WriteLine($"x={tr.X}; y={tr.Y}; {tr.LinkType.Sort}; {tr.LinkType.Color}\n");
            }
        }
    }
}
