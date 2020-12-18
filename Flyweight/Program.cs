using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            forest.PlantTree(2, 3, "дуб", "зеленый");
            forest.PlantTree(1, 1, "bereza", "red");
            forest.PlantTree(22, 23, "дуб", "зеленый");
            forest.PlantTree(2, 3, "дуб", "зеленый");
            forest.PlantTree(1, 1, "bereza", "red");
            forest.PlantTree(22, 23, "sosna", "зеленый");
            forest.PlantTree(2, 3, "дуб", "зеленый");
            forest.PlantTree(1, 1, "bereza", "red");
            forest.PlantTree(22, 23, "дуб", "yellow");
            TypeFactory.LoadBaseModel();
            forest.PlantTree(33, 3, "1");
            forest.PlantTree(33, 55, "3");
            forest.PlantTree(33, 55, "2"); 
            forest.PlantTree(33, 3, "1");
            forest.PlantTree(33, 55, "3");
            forest.PlantTree(33, 55, "2");
            forest.ShowForest();
            Console.WriteLine("!--------------------------!");
            TypeFactory.ShowAllModel();
        }
    }
}
