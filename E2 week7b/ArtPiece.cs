using System;
using System.Collections.Generic;
using System.Text;

namespace E2_week7b
{
    public enum ArtType
    {
        Painting,
        Statue,
        Performance
    }
    class ArtPiece
    {
        public ArtType ArtType { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public bool Sold { get; set; }

        public ArtPiece(ArtType artType, string name, int year, bool sold)
        {
            ArtType = artType;
            Name = name;
            Year = year;
            Sold = sold;
        }

        
        public override string ToString()
        {
            string s = $"Name = {Name}, ({ArtType}, Year = {Year}): ";
            if (Sold)
            {
                s += "sold";
            }
            else
            {
                s += "not sold";
            }

            return s;
        }
    }
}
