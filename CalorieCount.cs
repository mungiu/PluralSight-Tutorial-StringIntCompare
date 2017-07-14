using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSStringIntCompare
{
    //a struct that store the number of calories
    public struct CalorieCount : IComparable<CalorieCount>, IEquatable<CalorieCount>, IComparable
    {
        private float _value;
        //a property to expose the value
        public float Value { get { return _value; } }

        //constructor
        public CalorieCount(float value)
        {
            this._value = value;
        }

        //display method
        public override string ToString()
        {
            return _value + "cal";
        }

        //DOWN = modifying all operators explicitly
        public int CompareTo(CalorieCount other)
        {
            return this._value.CompareTo(other._value);
        }

        public static bool operator ==(CalorieCount x, CalorieCount y)
        {
            return x._value == y._value;
        }

        public static bool operator !=(CalorieCount x, CalorieCount y)
        {
            return x._value != y._value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is CalorieCount))
                return false;
            return _value == ((CalorieCount)obj)._value;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        //still requires override
        public bool Equals(CalorieCount other)
        {
            if (!base.Equals(other))
                return false;
            return this._value == other._value;
        }

        //different from CompareTo from up, not type safe
        //since it is not type safe we make sure it really is a calorie count
        public int CompareTo(object obj)
        {
            //null check
            if (obj == null)
                throw new ArgumentNullException("obj");
            //type check
            if (!(obj is CalorieCount))
                throw new ArgumentException("Expected CalorieCount instance", "obj");
            return CompareTo((CalorieCount)obj);
        }

        public static bool operator <(CalorieCount x, CalorieCount y)
        {
            return x._value < y._value;
        }

        public static bool operator >(CalorieCount x, CalorieCount y)
        {
            return x._value > y._value;
        }

        public static bool operator >=(CalorieCount x, CalorieCount y)
        {
            return x._value >= y._value;
        }

        public static bool operator <=(CalorieCount x, CalorieCount y)
        {
            return x._value <= y._value;
        }
    }
}
