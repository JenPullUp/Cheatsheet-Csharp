using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace E4_week7a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> PlaatsNamen = new List<string> {"Zwolle", "Kampen", "Deventer", "Lelystad", "Leeuwarden", "Apeldoorn", "Epe", "Ermelo", "Ommen"};
            //A
            bool begintMetHoofdletter = PlaatsNamen.All(p => Char.IsUpper(p[0]));
            Console.WriteLine($"Alle plaatsen beginnen met een hoofdletter: {begintMetHoofdletter}");
            //B
            bool begintMetE = PlaatsNamen.Any(p => Char.ToLower(p[0]) == 'e');
            Console.WriteLine($"Er begint een plaats met E: {begintMetE}");
            //C
            bool begintMetIofU = PlaatsNamen.Any(p => Char.ToLower(p[0]) == 'i' || Char.ToLower(p[0]) == 'u');
            Console.WriteLine($"Er begint een plaats met I of U: {begintMetIofU}");
            //D
            Console.WriteLine("Eindigen met -en");
            List<string> plaatsNamenDieEindigenMetEn = PlaatsNamen.Where(p => p.EndsWith("en")).ToList();
            plaatsNamenDieEindigenMetEn.ForEach(p=> Console.WriteLine(p));
            //E
            int totaalAantalCharacters = PlaatsNamen.Sum(p => p.Length);
            Console.WriteLine($"Totale lengte: totaalAantalCharacters");
        }


    }
}
