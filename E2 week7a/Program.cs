using System;
using System.Collections.Generic;
using System.Linq;

namespace E2_week7a
{
    class Program
    {
        public static void Main(string[] args)
        {
            var myListOfIntegers = new List<int> { 3, 5, 1, 12, 11 };
            Print(myListOfIntegers);
            Convert(myListOfIntegers, i => i * 2);
            Print(myListOfIntegers); // 6, 10, 2, 24, 22
            Convert(myListOfIntegers, i => i * i);
            Print(myListOfIntegers); // 36, 100, 4, 576, 484
            /*var myListStrings = new List<string> { "Jan", "Bas", "Rick" };
            Print(myListOfStrings);
            Convert(myListOfStrings, i => i.ToUpper());
            Print(myListOfStrings); // Converted to upperCase
            Convert(myListOfStrings, i => i.ToLower());
            Print(myListOfStrings); // Converted to lowerCase*/

        }

        public static void Convert<T>(List<T> list, Func<T, T> func)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = func(list[i]);
            }
        }

        public static void Print<T>(List<T> list )
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
