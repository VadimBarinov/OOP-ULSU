// Баринов Вадим, МОАИС-0-22/1
// Вариант 2

using System.Drawing;

namespace Lab_1
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine();

            // Общее задание
            Int intValue1 = new Int();
            intValue1.Print();

            Int intValue2 = new Int(20);
            intValue2.Print();

            Int intValue3 = new Int(intValue2);
            intValue3.Print();

            // Индивидуальное задание
            Int number1 = new Int();
            number1.SetValue(133);
            number1.Print();
            Int number2 = new Int();
            number2.SetValue(-42);
            number2.Print();
            Int number3 = new Int();
            number3.SumValues(number1, number2);
            number3.Print();

            Console.ReadKey();
        }
    }

}