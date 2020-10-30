using System;
using System.Collections.Generic;
using System.Text;

namespace E5_week7a
{
    class MenuItem
    {
        public string Omschrijving { get; set; }
        public int KCal { get; set; }
        public double Suikers { get; set; }
        public double Zout { get; set; }
        public bool Vegetarisch { get; set; }
        public bool BevatGluten { get; set; }

        public MenuItem(string omschrijving, int kcal, double suikers, double zout, bool vegetarisch, bool bevatGluten)
        {
            Omschrijving = omschrijving;
            KCal = kcal;
            Suikers = suikers;
            Zout = zout;
            Vegetarisch = vegetarisch;
            BevatGluten = bevatGluten;
        }

        public string ToString()
        {
            return $"Omschrijving: {Omschrijving}, KCal: {KCal}, Suiker: {Suikers}, Zout: {Zout}, Vegetarisch: {Vegetarisch}, BevatGluten: {BevatGluten}";
        }


    }
}
