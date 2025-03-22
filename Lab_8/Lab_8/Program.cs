using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        //---------------------------------------------------------------------------------------
        // Задания А-Д для Dictionary<int, int>
        //---------------------------------------------------------------------------------------

        // Задание А
        Dictionary<int, int> dictInt = new Dictionary<int, int>() 
        {
            {1, 45},
            {34, 345},
            {12, 55},
            {166, 636352},
            {2, 2343462},
            {5, 242},
            {6, 15235},
            {65, 636},
            {612, 134124},
        };


        Console.WriteLine("\nDictionary (int):");
        PrintDictionary(dictInt);

        // Задание Б
        dictInt.Remove(34);
        dictInt.Add(555, 777);

        ReplaceElement(dictInt, 2, 99, 5666);
        Console.WriteLine("\nИзмененный dict (int):");
        PrintDictionary(dictInt);

        // Задание В
        Console.WriteLine("\nDict (int) с итераторами:");
        PrintDictionaryWithIterator(dictInt);

        // Задание Г
        int key = 12; // Заданный элемент (ключ)
        int n = 2; // Количество элементов для удаления после заданного

        deleteAftenKey(dictInt, key, n);

        Console.WriteLine($"\nDict (int) после удаления {n} элементов после элемента {key}:");
        PrintDictionary(dictInt);

        // Задание Д
        Dictionary<int, int> sortedDict = new Dictionary<int, int>(dictInt.OrderByDescending(x => x.Key));
        Console.WriteLine("\nСортированный dict (int):");
        PrintDictionary(sortedDict);


        //---------------------------------------------------------------------------------------
        // Задание Е (пункты А-Д для пользовательского класса)
        //---------------------------------------------------------------------------------------

        // Задание А
        Dictionary<Int, Int> dictMyInt = new Dictionary<Int, Int>()
        {
            {new Int(1), new Int(45)},
            {new Int(34), new Int(634)},
            {new Int(767), new Int(1235)},
            {new Int(3), new Int(8888)},
            {new Int(22), new Int(134235)},
            {new Int(12), new Int(11)},
            {new Int(78), new Int(5)},
            {new Int(999), new Int(754)},
            {new Int(9), new Int(22345)},
        };


        Console.WriteLine("\nDictionary (Int пользовательский класс):");
        PrintDictionary(dictMyInt);

        // Задание Б
        dictMyInt.Remove(new Int(1));
        dictMyInt.Add(new Int(555), new Int(777));

        ReplaceElement(dictMyInt, new Int(3), new Int(99), new Int(5666));
        Console.WriteLine("\nИзмененный dict (Int пользовательский класс):");
        PrintDictionary(dictMyInt);

        // Задание В
        Console.WriteLine("\nDict (int) с итераторами:");
        PrintDictionaryWithIterator(dictMyInt);

        // Задание Г
        Int keyMyInt = new Int(99); // Заданный элемент (ключ)
        n = 2; // Количество элементов для удаления после заданного

        deleteAftenKey(dictMyInt, keyMyInt, n);

        Console.WriteLine($"\nDict (Int пользовательский класс) после удаления {n} элементов после элемента {keyMyInt}:");
        PrintDictionary(dictMyInt);

        // Задание 5
        Dictionary<Int, Int> sortedDictMyInt = new Dictionary<Int, Int>(dictMyInt.OrderByDescending(x => x.Key));
        Console.WriteLine("\nСортированный dict (Int пользовательский класс):");
        PrintDictionary(sortedDictMyInt);

        //---------------------------------------------------------------------------------------
        // Задания Ж, З
        //---------------------------------------------------------------------------------------

        // Задание Ж
        KeyValuePair<Int, Int> searchElement = new(new Int(99), new Int(5666));
        Int foundValue = new Int(dictMyInt[searchElement.Key]);
        Console.WriteLine($"\nНайденный элемент в dict (Int пользовательский класс): {foundValue}");

        // Задание З
        int count = dictInt.Count(x => x.Value > 1000);
        Console.WriteLine($"\nКоличество элементов больше 1000 в контейнере (int): {count}");
        int myClassCount = dictMyInt.Count(x => x.Value.GetValue() > 1000);
        Console.WriteLine($"\nКоличество элементов больше 1000 в контейнере (Int пользовательский класс): {myClassCount}");

    }


    static void PrintDictionary<K, V>(Dictionary<K, V> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine(item);
        }
    }


    static void PrintDictionaryWithIterator<K, V>(Dictionary<K, V> dict)
    {
        IEnumerator enumerator = dict.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }


    static void deleteAftenKey<K, V>(Dictionary<K, V> mainDict, K key, int n)
    {
        bool flag = false;
        int count = 0;
        foreach (var item in mainDict)
        {
            if (count == n)
            {
                break;
            }
            if (flag)
            {
                mainDict.Remove(item.Key);
                count++;
            }
            if (item.Key.Equals(key))
            {
                flag = true;
            }
        }
    }


    static void ReplaceElement<K, V>(Dictionary<K, V> mainDictionary, K positionKey, K newKey, V newValue)
    {
        if (mainDictionary.ContainsKey(positionKey))
        {
            mainDictionary.Remove(positionKey);
            mainDictionary.Add(newKey, newValue);
        }
    }
}

