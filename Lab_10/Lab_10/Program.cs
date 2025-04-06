// Баринов Вадим, МОАИС-0-22/1
// Вариант 2

using System.Collections.Generic;
using System.Drawing;

namespace Lab_7
{
    class Program()
    {
        static void Main(string[] args)
        {
            var array = new Array1<int>(
                6, 
                [ 1, 2, 3, 4, 5, 6, ]
            );

            Console.WriteLine("\nМассив:");
            Console.WriteLine(string.Join(", ", array.elements));

            // Использование out параметра
            if (array.TryGet(2, out var foundItem))
            {
                Console.WriteLine($"Получен элемент: {foundItem}");
            }
            else
            {
                Console.WriteLine("Такого элемента нет.");
            }

            // Использование ref параметра
            int itemToRemove = 2;
            if (array.TryRemove(ref itemToRemove))
            {
                Console.WriteLine($"Удален элемент: {itemToRemove}");
            }
            else
            {
                Console.WriteLine("Элемент не удален.");
            }
            Console.WriteLine("После попытки удаления:");
            Console.WriteLine(string.Join(", ", array.elements));

            // Использование оператора is
            if (array.IsOfType<int>(1))
            {
                Console.WriteLine("Элемент является типом int.");
            }

            // Использование оператора as
            if (array.TryCast<int>(1, out var castedItem))
            {
                Console.WriteLine($"Приведение к типу int успешно: {castedItem}");
            }
            else
            {
                Console.WriteLine("Приведение к типу int не удалось.");
            }

            // Обработка ошибок
            try
            {
                // Попытка добавить элемент на несуществующую позицию
                array.elements[10] = 22;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

    }
}