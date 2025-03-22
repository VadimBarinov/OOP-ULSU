// Баринов Вадим, МОАИС-0-22/1
// Вариант 2

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // создаем экземпяры классов-наследников
            Plant plant = new Plant("Пальма", "Дерево");
            Wood wood = new Wood("Дуб", "Дерево", 12);
            Flower flower = new Flower("Диантуз", "Цветок", 11.3);
            Rose rose1 = new Rose("Роза кустовая", "Роза", 22.3, "Красная");
            Rose rose2 = new Rose("Чайная роза", "Роза", 20.1, "Красная");
            Rose rose3 = new Rose("Роза кустовая", "Роза", 10.0, "Белая");
            Rose rose4 = new Rose("Чайная роза", "Роза", 25.2, "Розовая");
            Rose rose5 = new Rose("Роза российская", "Роза", 12.7, "Красная");
            Rose rose6 = new Rose("Чайная роза", "Роза", 14.6, "Красная");

            // помещаем объекты в список
            AllPlants.AddToList(plant);
            AllPlants.AddToList(wood);
            AllPlants.AddToList(flower);
            AllPlants.AddToList(rose1);
            AllPlants.AddToList(rose2);
            AllPlants.AddToList(rose3);
            AllPlants.AddToList(rose4);
            AllPlants.AddToList(rose5);
            AllPlants.AddToList(rose6);

            // выводим список
            AllPlants.PrintListAllPlants();

            // вызываем фукнции 
            Console.WriteLine("\nВсе чайные розы с длиной стебля большей, чем задал пользователь: ");
            Console.WriteLine(string.Join("\n", AllPlants.GetTeaRoseStemLength(22.0)));

            Console.WriteLine("\nКоличество роз заданного цвета: ");
            Console.WriteLine(string.Join("\n", AllPlants.GetColorRoseCount("Зеленый")));

            Console.ReadKey();
        }
    }
}