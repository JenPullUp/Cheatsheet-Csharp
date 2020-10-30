using System;
using System.Collections.Generic;
using System.Text;

namespace E3_week7a
{
    public class Person
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public Person(string lastname, string firstname, string city, string street, int number)
        {
            Lastname = lastname;
            Firstname = firstname;
            City = city;
            Street = street;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Lastname} {Firstname} {City}";
        }
    }
}
