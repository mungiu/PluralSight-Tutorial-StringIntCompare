using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSStringIntCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string apple = "apple";
            string pear = "pear";

            DisplayOrder(apple, pear);
            DisplayOrder(pear, apple);
            DisplayOrder(apple, apple);

            DisplayOrder(3, 4);
            DisplayOrder(4, 3);
            DisplayOrder(3, 3);

            if (3.CompareTo(4) < 0)
            {
                Console.WriteLine("3 < 4");
            }
            if (3 < 4)
            {
                Console.WriteLine("3 < 4");
            }
        }

        static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result == 0)
                //{0,12} - first number "0" indicates which parameter, second number
                //"12" indicated that the object must be alligned to to right hand side
                // because it is a positive number, and be of "12" length (autocomplete)
                Console.WriteLine("{0,12} = {1}", x, y);
            else if (result > 0)
                Console.WriteLine("{0,12} > {1}", x, y);
            else
                Console.WriteLine("{0,12} < {1}", x, y);
        }
    }
}
