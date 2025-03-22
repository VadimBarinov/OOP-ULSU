using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Int : IComparable<Int>, IConvertible
    {
        private int value; 

        public Int() 
        {
            value = 0;
            Console.WriteLine("Вызван конструктор без параметров");
        }
        public Int(int value)
        {
            Console.WriteLine("Вызван конструктор с параметром");
            this.value = value;
        }
        public Int(Int i)
        {
            Console.WriteLine("Вызван конструктор копирования");
            this.value = i.value;
        }
        ~Int()
        {
            Console.WriteLine("Вызван деструктор");
        }

        public void SetValueNull() { this.value = 0; }

        public void SetValue(int number) { this.value = number; }

        public int GetValue() { return this.value; }

        public void Print() { Console.WriteLine("Значение числа: {0}\n", this.value); }
        public void SumValues(Int first, Int second) { this.value = first.value + second.value; }

        public int CompareTo(Int? other)
        {
            return this.value.CompareTo(other?.value);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        public bool ToBoolean(IFormatProvider? provider)
        {
            if (this.value == 1)
            {
                return true;
            }
            else if (this.value == 0)
            {
                return false;
            }
            throw new InvalidCastException("Невозможно преобразовать Int в bool.");
        }

        public byte ToByte(IFormatProvider? provider)
        {
            throw new InvalidCastException("Невозможно преобразовать Int в byte.");
        }

        public char ToChar(IFormatProvider? provider)
        {
            throw new InvalidCastException("Невозможно преобразовать Int в char.");
        }

        public DateTime ToDateTime(IFormatProvider? provider)
        {
            throw new InvalidCastException("Невозможно преобразовать Int в DateTime.");
        }

        public decimal ToDecimal(IFormatProvider? provider)
        {
            throw new InvalidCastException("Невозможно преобразовать Int в decimal.");
        }

        public double ToDouble(IFormatProvider? provider)
        {
            return Convert.ToDouble(this.value);
        }

        public short ToInt16(IFormatProvider? provider)
        {
            return Convert.ToInt16(this.value);
        }

        public int ToInt32(IFormatProvider? provider)
        {
            return Convert.ToInt32(this.value);
        }

        public long ToInt64(IFormatProvider? provider)
        {
            return Convert.ToInt64(this.value);
        }

        public sbyte ToSByte(IFormatProvider? provider)
        {
            throw new InvalidCastException("Невозможно преобразовать Int в sbyte.");
        }

        public float ToSingle(IFormatProvider? provider)
        {
            return Convert.ToSingle(this.value);
        }

        public string ToString(IFormatProvider? provider)
        {
            return this.value.ToString();
        }

        public object ToType(Type conversionType, IFormatProvider? provider)
        {
            throw new InvalidCastException("Невозможно преобразовать Int в другой тип.");
        }

        public ushort ToUInt16(IFormatProvider? provider)
        {
            if (this.value >= 0)
            {
                return Convert.ToUInt16(this.value);
            }
            throw new InvalidCastException("Невозможно преобразовать Int в ushort.");
        }

        public uint ToUInt32(IFormatProvider? provider)
        {
            if (this.value >= 0)
            {
                return Convert.ToUInt32(this.value);
            }
            throw new InvalidCastException("Невозможно преобразовать Int в uint.");
        }

        public ulong ToUInt64(IFormatProvider? provider)
        {
            if (this.value >= 0)
            {
                return Convert.ToUInt64(this.value);
            }
            throw new InvalidCastException("Невозможно преобразовать Int в ulong.");
        }
    }
}
