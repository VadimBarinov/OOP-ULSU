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
            Console.WriteLine("Экземпляр класса: Растение");
            Plant plant = new Plant("Пальма", "Дерево");
            plant.Print();
            Console.WriteLine();

            Console.WriteLine("Экземпляр класса: Дерево");
            Wood wood = new Wood("Дуб", "Дерево", 12);
            wood.Print();
            Console.WriteLine();

            Console.WriteLine("Экземпляр класса: Цветок");
            Flower flower = new Flower("Диантуз", "Цветок", 11.3);
            flower.Print();
            Console.WriteLine();

            Console.WriteLine("Экземпляр класса: Роза");
            Rose rose = new Rose("Роза кустовая", "Цветок", 22.3, "Красная");
            rose.Print();
            Console.WriteLine();

            // помещаем объекты в список
            AllPlants.AddToList(plant);
            AllPlants.AddToList(wood);
            AllPlants.AddToList(flower);
            AllPlants.AddToList(rose);

            // выводим список
            AllPlants.PrintListAllPlants();

            Console.ReadKey();
        }
    }
}