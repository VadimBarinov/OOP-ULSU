using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public abstract class AllPlants
    {
        public virtual void Print() 
        {
            Console.WriteLine("Абстрактный метод");
        }

        public abstract string ToString();

        public static List<AllPlants> list = new List<AllPlants>();

        public static void AddToList(AllPlants plant)
        {
            list.Add(plant);
        }
        public static void PrintListAllPlants()
        {
            Console.WriteLine("Список объектов:");
            foreach (AllPlants plant in list)
            {
                Console.WriteLine(" - " + plant.ToString());
            }
        }
    }
}
