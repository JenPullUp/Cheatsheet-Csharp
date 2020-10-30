using System;
using System.Collections.Generic;

namespace E3_week7a
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> myListOfPersons = new List<Person> {
                new Person("Peters", "Frits", "Breda", "Zwijnsbergenstraat", 122),
                new Person("Kwak", "Johan", "Bavel", "Hoogstraat", 1),
                new Person("Brugman", "Jessica", "Zwolle", "Kerkstraat", 12),
                new Person("Boterenbrood", "Frank", "Meppel", "Huppelpad", 33),
            };
            Print(myListOfPersons);
            List<string> myListOfLastnames = Select<Person, string>(myListOfPersons, p =>
                p.Lastname);
            Print(myListOfLastnames);

            List<string> myListOfCitys = Select<Person, string>(myListOfPersons, p => p.City);
            Print(myListOfCitys);
            List<int> myListOfStreetNumbers = Select<Person, int>(myListOfPersons, p =>
                p.Number);
            Print(myListOfStreetNumbers);
            List<string> myListOfNames = Select<Person, string>(myListOfPersons, p =>
                p.Firstname + " " + p.Lastname);
            Print(myListOfNames);
        }

        public static List<U> Select<T, U>(List<T> listOfT, Func<T, U> select)
        {
            List<U> newList = new List<U>();
            for (int i = 0; i < listOfT.Count; i++)
            {
                newList.Add(select(listOfT[i]));
            }
            return newList;
        }
        public static void Print<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
