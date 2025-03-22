// Баринов Вадим, МОАИС-0-22/1
// Вариант 2

using System.Collections.Generic;
using System.Drawing;

namespace Lab_7
{
    class Program()
    {
        static (List<int>, List<double>, List<Int>) ReadValuesFromFile(string filePath)
        {
            List<int> ints = new List<int> { };
            List<double> doubles = new List<double> { };
            List<Int> myInts = new List<Int>();


            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(';');

                        if (values.Count() != 0)
                        {
                            foreach (string item in values)
                            {
                                if (int.TryParse(item, out int value))
                                {

                                    ints.Add(value);
                                }
                                else
                                {
                                    throw new FormatException("Неверный формат во входном файле для int");
                                }
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Недопустимое количество значений во входном файле");
                        }

                        line = reader.ReadLine();
                        values = line.Split(';');
                        if (values.Count() != 0)
                        {
                            foreach (string item in values)
                            {
                                if (double.TryParse(item, out double value))
                                {

                                    doubles.Add(value);
                                }
                                else
                                {
                                    throw new FormatException("Неверный формат во входном файле для double");
                                }
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Недопустимое количество значений во входном файле");
                        }


                        line = reader.ReadLine();
                        values = line.Split(';');
                        if (values.Count() != 0)
                        {
                            foreach (string item in values)
                            {
                                if (int.TryParse(item, out int value))
                                {

                                    myInts.Add(new Int(value));
                                }
                                else
                                {
                                    throw new FormatException("Неверный формат во входном файле для пользовательского класса Int");
                                }
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Недопустимое количество значений во входном файле");
                        }

                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Входной файл не найден");
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка чтения входного файла");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка в формате входного файла: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка в формате выходного файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }

            return (ints, doubles, myInts);
        }

        static void WriteOutputToFile(List<String> answers, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (String answer in answers)
                    {
                        writer.WriteLine(answer);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка записи в выходной файл");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            
            string inputFilePath = "C:/Users/vadim/Desktop/6 семестр/Шевченко ООП/Лабы/Lab_7/input.txt";
            string outputFilePath = "C:/Users/vadim/Desktop/6 семестр/Шевченко ООП/Лабы/Lab_7/output.txt";


            List<string> output = new List<string>();


            var input = ReadValuesFromFile(inputFilePath);
            List<int> ints = input.Item1;
            List<double> doubles = input.Item2;
            List<Int> myInts = input.Item3;


            Array1<int> intArray = new Array1<int>(ints.Count(), [.. ints]);
            Array1<double> doubleArray = new Array1<double>(doubles.Count(), [.. doubles]);
            Array1<Int> myIntArray = new Array1<Int>(myInts.Count(), [.. myInts]);

            output.Add("Массив 1: " + string.Join(", ", intArray.elements));
            output.Add("Массив 2: " + string.Join(", ", doubleArray.elements));
            output.Add("Массив 3: " + string.Join(", ", myIntArray.elements.Select(s => Convert.ToString(s))));
            output.Add("");
            output.Add($"Минимальное значение в 1 массиве(int): {Array1<int>.FindMin(intArray)}");
            output.Add($"Минимальное значение во 2 массиве(double): {Array1<double>.FindMin(doubleArray)}");
            output.Add($"Минимальное значение в 3 массиве(Int пользовательский): {Array1<Int>.FindMin(myIntArray).GetValue()}");

            WriteOutputToFile(output, outputFilePath);

        }

    }
}