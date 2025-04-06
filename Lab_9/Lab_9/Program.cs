// Баринов Вадим, МОАИС-0-22/1
// Вариант 2

using Lab_9;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();

            try
            {
                Wood wood = new Wood("Дуб", "Дерево", 12);
                Flower flower = new Flower("Диантуз", "Цветок", 11.3);
                Rose rose = new Rose("Роза кустовая", "Роза", 22.3, "Красная");
                Rose kellie = new Kellie("Kellie", "Роза", 20.1, "Красная");

                plants.Add(wood);
                plants.Add(flower);
                plants.Add(rose);
                plants.Add(kellie);

                foreach (var plant in plants)
                {
                    plant.PrintDetails();
                }

                // Использование ref параметра
                int additionalAge = 50;
                wood.IncreaseAge(ref additionalAge);
                Console.WriteLine($"Обновленное количество лет для wood: {additionalAge}");

                // Использование out параметра
                string getColor;
                rose.GetColor(out getColor);
                Console.WriteLine($"Цвет rose: {getColor}");

                Rose.PrintObjectCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа выполнена успешно");
            }


        }
    }
}