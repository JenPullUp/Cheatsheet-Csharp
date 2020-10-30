using System;
using System.Collections.Generic;
using System.Linq;

namespace E5_week7a
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<MenuItem>()
            {
                new MenuItem("Hamburger",  562,  9.4,   2.5, false, true),
                new MenuItem("Milkshake",  344,   54,  0.51, true,  false),
                new MenuItem("Friet",      330,  0.4,  0.53, true,  false),
                new MenuItem("Vegaburger", 421,    7,   2.2, true,  true),
                new MenuItem("Salade",     137,  7.4,  0.66, false, true)
            };
            //A
            //menu.OrderBy(o => o.Omschrijving).ToList().ForEach(o => Console.WriteLine(o.ToString()));
            //B
            //menu.OrderByDescending(c => c.KCal).Select(o => o.Omschrijving).ToList().ForEach(o=> Console.WriteLine(o.ToString()));
            //C
            //menu.OrderBy(o => o.Omschrijving).Where(v => v.Vegetarisch).Select(o => o.Omschrijving).ToList().ForEach(o => Console.WriteLine(o.ToString()));
            //D
            //menu.Where(o => o.Vegetarisch && o.Suikers<1).ToList().ForEach(o => Console.WriteLine(o.ToString()));
            //E
            //Console.WriteLine(menu.Where(o => o.Vegetarisch || !o.BevatGluten).ToList().Count);
            //F
            //Console.WriteLine(menu.Where(v => v.Vegetarisch).Average(c => c.KCal));

        }
    }
}
