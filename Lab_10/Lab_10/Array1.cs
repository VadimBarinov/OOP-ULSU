using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_7
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
                        if (i == index)
                        {
                            return elements[i];
                        }
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }

        // перегрузка оператора == проверки на равенство
        public static bool operator ==(Array1<T> array1, Array1<T> array2)
        {
            return Enumerable.SequenceEqual(array1.elements, array2.elements);
        }

        // перегрузка оператора != проверки на равенство
        public static bool operator !=(Array1<T> array1, Array1<T> array2)
        {
            return !Enumerable.SequenceEqual(array1.elements, array2.elements);
        }

        // перегрузка оператора + объединение массивов
        public static Array1<T> operator +(Array1<T> array1, Array1<T> array2)
        {
            Array1<T> result = new Array1<T>(array1.size + array2.size);
            result.elements = [.. array1.elements, .. array2.elements];
            return result;
        }

        // перегрузка ++ инкремент
        public static Array1<T> operator ++(Array1<T> array1)
        {
            Array1<T> result = new Array1<T>(array1.size);
            for (int i = 0; i < array1.size; i++)
            {
                if (typeof(T) == typeof(int))
                    result.elements[i] = (dynamic)array1.elements[i] + 1;
                else if (typeof(T) == typeof(float))
                    result.elements[i] = (dynamic)array1.elements[i] + 1f;
                else if (typeof(T) == typeof(double))
                    result.elements[i] = (dynamic)array1.elements[i] + 1d;
            }
            return result;
        }

        // перегрузка -- декремент
        public static Array1<T> operator --(Array1<T> array1)
        {
            Array1<T> result = new Array1<T>(array1.size);
            for (int i = 0; i < array1.size; i++)
            {
                if (typeof(T) == typeof(int))
                    result.elements[i] = (dynamic)array1.elements[i] - 1;
                else if (typeof(T) == typeof(float))
                    result.elements[i] = (dynamic)array1.elements[i] - 1f;
                else if (typeof(T) == typeof(double))
                    result.elements[i] = (dynamic)array1.elements[i] - 1d;
            }
            return result;
        }


        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static T FindMin<T>(Array1<T> arr)
        {
            if (arr.size == 0)
            {
                throw new ArgumentException("Пустое множество");
            }

            T minValue = arr[0];

            for (int i = 1; i < arr.size; i++)
            {
                if (Convert.ToDouble(arr[i]) < Convert.ToDouble(minValue))
                {
                    minValue = arr[i];
                }
            }

            return minValue;

        }

        // метод для попытки получения элемента
        public bool TryGet(int i, out T foundItem)
        {
            if (i >= 0 && i < this.size)
            {
                foundItem = this.elements[i];
                return true;
            }
            else
            {
                foundItem = default(T);
                return false;
            }
        }

        // метод для попытки удаления из массива
        public bool TryRemove(ref T item)
        {
            if (this.elements.Contains(item))
            {
                var temp = new List<T>(this.elements);
                temp.Remove(item);
                this.elements = temp.ToArray();
                this.size = temp.Count();
                return true;
            }
            return false;
        }

        // метод для проверки, является ли элемент типом T
        public bool IsOfType<TType>(T item)
        {
            return item is TType;
        }

        // метод для попытки приведения  элемента к типу TType
        public bool TryCast<TType>(T item, out TType castedItem)
        {
            // если является, то преобразует в тип TType
            // и записывает в typeItem
            if (item is TType typeItem)
            {
                castedItem = typeItem;
                return true;
            }
            else
            {
                castedItem = default(TType);
                return false;
            }
        }


    }
}
