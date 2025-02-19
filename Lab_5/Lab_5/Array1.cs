﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Array1<T>
    {
        public int size;
        public T[] elements;

        // конструктор без заполнения
        public Array1(int N)
        {
            size = N;
            elements = new T[size];
        }

        // конструктор с заполнением
        public Array1(int N, T[] collection)
        {
            size = N;
            elements = new T[size];
            if (N == collection.Length)
            {
                for (int i = 0; i < size; i++)
                {
                    elements[i] = collection[i];
                }
            }
            else { throw new IndexOutOfRangeException("Введен неверный размер массива!!!"); }
        }

        // деструктор
        ~Array1() { }

        // перегрузка оператора [] для доступа по индексу
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if(i == index)
                        {
                            return elements[i];
                        }
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }

        // перегрузка оператора == проверки на равенство
        public static bool operator == (Array1<T> array1, Array1<T> array2)
        {
            return Enumerable.SequenceEqual(array1.elements, array2.elements);
        }

        // перегрузка оператора != проверки на равенство
        public static bool operator != (Array1<T> array1, Array1<T> array2)
        {
            return !Enumerable.SequenceEqual(array1.elements, array2.elements);
        }

        // перегрузка оператора + объединение массивов
        public static Array1<T> operator + (Array1<T> array1, Array1<T> array2)
        {
            Array1<T> result = new Array1<T> (array1.size + array2.size);
            result.elements = [.. array1.elements, .. array2.elements];
            return result;
        }

    }
}
