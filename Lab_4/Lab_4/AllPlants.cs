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

        public virtual string? GetColor(){ return null; }
        public virtual double? GetSemLength(){ return null; }
        public virtual string? GetName(){ return null; }

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

        // количество роз заданного цвета
        public static IEnumerable<int> GetColorRoseCount(string color)
        {
            int count = 0;

            foreach (AllPlants plant in list)
            {
                if (plant is Rose && plant.GetColor() == color)
                {
                    count++;
                }
            }
            yield return count;
        }

        // все чайные розы с длиной стебля большей, чем задал пользователь
        public static IEnumerable<string> GetTeaRoseStemLength(double stemLength)
        {   
            foreach (AllPlants plant in list)
            {
                if (plant is Rose && plant.GetSemLength() > stemLength && plant.GetName() == "Чайная роза")
                {
                    yield return " - " + plant.ToString();   
                }
            }
        }

    }
}
