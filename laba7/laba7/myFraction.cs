﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;
namespace laba7
{
    class myFraction : IFormattable, IComparable<myFraction>, IConvertible
    {
        private long numerator;
        private long denominator;

        public myFraction(string s)
        {
            var another = s.Split("/");
            if (another.Length != 2)
            {
                throw new Exception("Mistake");
            }
            try
            {
                numerator = Convert.ToInt64(another[0]);
                denominator = Convert.ToInt64(another[1]);
            }
            catch
            {
                throw new Exception("Mistake");
            }
        }

        public myFraction(long numerator, long denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public myFraction(myFraction obj)
        {
            numerator = obj.numerator;
            denominator = obj.denominator;
        }

        private long GCD(long a, long b)
        {
            while (b != 0)
            {
                a %= b;
                long temp = a;
                a = b;
                b = temp;
            }
            return a;
        }

        private long LCM(long a, long b)
        {
            return a / GCD(a, b) * b;
        }

        public override string ToString()
        {
            return this.ToString("I");
        }

        public string ToString(string format, IFormatProvider formatProvider=null)
        {
            if (String.IsNullOrEmpty(format)) format = "F";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;
            switch (format)
            {
                case "I":
                    return numerator.ToString() + " / " + denominator.ToString();
                case "F":
                    double div = (double)numerator / denominator;
                    return div.ToString();
                case "D":
                    double div2 = (double)numerator / denominator;
                    div2 = Convert.ToInt64(div2);
                    return div2.ToString();
                default:
                    throw new Exception("Mistake");
            }
        }

        public static myFraction Parse(string str)
        {
            Regex pattern1 = new Regex(@"^(\d*)[/](\d*)$");
            Regex pattern2 = new Regex(@"^\d*$");
            Regex pattern3 = new Regex(@"^(\d*)[.](\d*)$");
            if (pattern1.IsMatch(str))
            {
                var another = str.Split("/");
                return new myFraction(Convert.ToInt64(another[0]), Convert.ToInt64(another[1]));
            }
            if (pattern2.IsMatch(str))
            {
                return new myFraction(Convert.ToInt64(str), 1);
            }
            if (pattern3.IsMatch(str))
            {
                var another = str.Split(".");
                string temp = another[0] + another[1];
                long temp2 = 1;
                for (int i = 0; i < another[1].Length; i++)
                {
                    temp2 *= 10;
                }
                return new myFraction(Convert.ToInt64(temp), temp2);
            }
            throw new Exception("Mistake");
        }

        public int CompareTo(myFraction obj)
        {
            long tempDen = this.LCM(this.denominator, obj.denominator);
            long tempNum1 = (tempDen / this.denominator) * this.numerator;
            long tempNum2= (tempDen / obj.denominator) * obj.numerator;
            return tempNum1.CompareTo(tempNum2);
        }

        public override bool Equals(object obj)
        {
            return obj is myFraction fraction && numerator == fraction.numerator && denominator == fraction.denominator;
        }

        public override int GetHashCode()
        {
            double res = (double)(numerator /denominator);
            return res.GetHashCode();
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return numerator == 1;
        }

        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((double)this, provider);
        }

        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((double)this, provider);
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((double)this, provider);
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((double)this, provider);
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16((double)this, provider);
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((double)this, provider);
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((double)this, provider);
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((double)this, provider);
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((double)this, provider);
        }

        public string ToString(IFormatProvider provider)
        {
            return this.ToString("F", null);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((double)this, conversionType);
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16((double)this, provider);
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((double)this, provider);
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((double)this, provider);
        }

        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((double)this, provider);
        }

        public static myFraction operator +(myFraction first, myFraction second)
        {
            myFraction another = new myFraction();
            another.denominator = another.LCM(first.denominator, second.denominator);
            another.numerator = Convert.ToInt64(another.denominator/first.denominator) * first.numerator + Convert.ToInt64(another.denominator /second.denominator) * second.numerator;
            return another;
        }

        public static myFraction operator -(myFraction first, myFraction second)
        {
            myFraction another = new myFraction();
            another.denominator = another.LCM(first.denominator, second.denominator);
            another.numerator = Convert.ToInt64(another.denominator / first.denominator) * first.numerator - Convert.ToInt64(another.denominator / second.denominator) * second.numerator;
            return another;
        }

        public static myFraction operator *(myFraction first, myFraction second)
        {
            long newNumerator = first.numerator * second.numerator;
            long newDenominator = first.denominator * second.denominator;
            return new myFraction(newNumerator, newDenominator);
        }

        public static myFraction operator /(myFraction first, myFraction second)
        {
            long newNumerator = first.numerator / second.numerator;
            long newDenominator = first.denominator / second.denominator;
            return new myFraction(newNumerator, newDenominator);
        }

        public static bool operator <(myFraction first, myFraction second)
        {

            return first.CompareTo(second) == -1;
        }

        public static bool operator <=(myFraction first, myFraction second)
        {
            return first.CompareTo(second) != 1;
        }

        public static bool operator >=(myFraction first, myFraction second)
        {
            return first.CompareTo(second) != -1;
        }

        public static bool operator >(myFraction first, myFraction second)
        {
            return first.CompareTo(second) == 1;
        }

        public static bool operator ==(myFraction first, myFraction second)
        {
            return first.Equals(second) == true;
        }

        public static bool operator !=(myFraction first, myFraction second)
        {
            return first.Equals(second) == false;
        }

        public static explicit operator int(myFraction temp)
        {
            return Convert.ToInt32(temp.numerator/temp.denominator);
        }

        public static explicit operator double(myFraction temp)
        {
             return (double)temp.numerator /temp.denominator;
        }

        public static explicit operator decimal(myFraction temp)
        {
            return Convert.ToDecimal(temp.numerator/temp.denominator);
        }

        public static explicit operator long(myFraction temp)
        {
            return Convert.ToInt64(temp.numerator / temp.denominator);
        }
    }
}
