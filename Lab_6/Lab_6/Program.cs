// Баринов Вадим, МОАИС-0-22/1
// Вариант 2

namespace Lab_6
{
    class Program()
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            // создание 3 массивов
            Array1<int> array1 = new Array1<int>(6, new int[]{ -1, 20, 11, -9, 4, 12});
            Array1<double> array2 = new Array1<double>(4, new double[]{ 44.2, -52.45, 11.7, 90.1});
            Array1<Int> array3 = new Array1<Int>(5, new Int[]{ 
                new Int(44),
                new Int(23),
                new Int(56),
                new Int(78),
                new Int(-100),
            });

            Console.WriteLine("Массив 1: " + string.Join(", ", array1.elements));
            Console.WriteLine("Массив 2: " + string.Join(", ", array2.elements));
            Console.WriteLine("Массив 3: " + string.Join(", ", array3.elements.Select(s => Convert.ToString(s))));

            // проверка функции получения минимального значения
            Console.WriteLine($"Массив 1: минимальное значение = {Array1<int>.FindMin(array1)}");
            Console.WriteLine($"Массив 2: минимальное значение = {Array1<double>.FindMin(array2)}");
            Console.WriteLine($"Массив 3: минимальное значение = {Array1<Int>.FindMin(array3).GetValue()}");

            Console.ReadKey();
        }
    }
}