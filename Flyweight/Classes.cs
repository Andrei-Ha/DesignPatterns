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
        private List<TreeType> list = new List<TreeType>();
        public TreeType GetTree(string sort, string color)
        {
            if(list.Where(p=>(p.Color==color && p.Sort==sort)).Count()>0)
            {
                return list.Where(p => (p.Color == color && p.Sort == sort)).FirstOrDefault();
            }
            TreeType  newTree = new TreeType() { Color = color, Sort = sort };
            list.Add(newTree);
            return newTree;
        }
        
    }
}
