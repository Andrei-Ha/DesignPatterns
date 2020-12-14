
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
        public TreeType(string s, string c)
        {
            Sort = s; Color = c;
        } 
    }
    class Tree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TreeType LinkType;
    }
    class TypeFactory
    {
        private static List<TreeType> list = new List<TreeType>();
        public static TreeType GetType(string sort, string color)
        {
            if(list.Where(p=>(p.Color==color && p.Sort==sort)).Count()>0)
            {
                return list.Where(p => (p.Color == color && p.Sort == sort)).FirstOrDefault();
            }
            TreeType  newType = new TreeType(sort,color) ;
            list.Add(newType);
            return newType;
        }
        public static void ShowAllModel()
        {
            foreach(TreeType t in list)
            {
                Console.WriteLine($"All models: {t.Sort}; {t.Color}\n");
            }
        }
        public static Dictionary<string, TreeType> dict = new Dictionary<string, TreeType>();
        public static void LoadBaseModel()
        {
            dict.Add("1",new TreeType( "olha", "red"));
            dict.Add("2", new TreeType("yasen", "gold"));
            dict.Add("3", new TreeType("pihta", "green"));
        }
        public static TreeType GetTreeFromDict(string str)
        {
            return dict[str];
        }
    }
    class Forest
    {
        public List<Tree> forest = new List<Tree>();
        public void PlantTree(int x, int y, string sort, string color)
        {
            forest.Add(new Tree() { X = x, Y = y, LinkType = TypeFactory.GetType(sort, color) });
        }
        public void PlantTree(int x, int y , string dict)
        {
            if(TypeFactory.GetTreeFromDict(dict)!=null)
                forest.Add(new Tree() { X = x, Y = y, LinkType = TypeFactory.GetTreeFromDict(dict) });
        }
        public void ShowForest()
        {
            int i = 1;
            foreach (Tree tr in forest) {
                Console.WriteLine($"{i}:   x={tr.X}; y={tr.Y}; {tr.LinkType.Sort}; {tr.LinkType.Color}\n");
                i++;
            }
        }
    }
}
