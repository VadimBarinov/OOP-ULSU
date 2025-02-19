// Баринов Вадим, МОАИС-0-22/1
// Вариант 2

namespace Lab_5
{
    class Program()
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            // создание 3 массивов
            Array1<int> array1 = new Array1<int>(6, new int[]{ 1, 2, 3, 33, 4, 12});
            Array1<int> array2 = new Array1<int>(4, new int[]{ 44, 52, 11, 9});
            Array1<int> array3 = new Array1<int>(4, new int[]{ 44, 52, 11, 9});

            Console.WriteLine("Массив 1: " + string.Join(", ", array1.elements));
            Console.WriteLine("Массив 2: " + string.Join(", ", array2.elements));
            Console.WriteLine("Массив 3: " + string.Join(", ", array3.elements));
            
            // доступ по индексу
            Console.WriteLine("\nЭлемент по индексу 1 в Массив 1: {0}", array1[1]);

            // проверка на равенство
            Console.WriteLine("\nМассив 1 и Массив 2 равны? {0}", array1 == array2);
            Console.WriteLine("\nМассив 2 и Массив 3 равны? {0}", array2 == array3);

            // проверка на неравенство
            Console.WriteLine("\nМассив 1 и Массив 2 не равны? {0}", array1 != array2);
            Console.WriteLine("\nМассив 2 и Массив 3 не равны? {0}", array2 != array3);

            // объединение массивов
            Console.WriteLine("\nМассив 1 + Массив 2: " + string.Join(", ", (array1 + array2).elements));

            Console.ReadKey();
        }
    }
}