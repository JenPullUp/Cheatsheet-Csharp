using System;
using System.Collections.Generic;
using System.Text;

namespace E3_week_6a
{
    public enum GewichtsKlasse
    {
        Ondergewicht,
        Gezondgewicht,
        Overgewicht,
        Obesitas
    }
    class BMI
    {
        public GewichtsKlasse BepaalBMI(int gewicht, double lengte)
        {
            lengte /= 100;
            double bmi = ((double)gewicht / (lengte * lengte));
            /*if (bmi < 18.5)
            {
                return GewichtsKlasse.Ondergewicht;
            }
            else if (bmi < 24.9)
            {
                return GewichtsKlasse.Gezondgewicht;
            }
            else if (bmi < 29.9)
            {
                return GewichtsKlasse.Overgewicht;
            }
            else if (bmi >= 29.9)
            {
                return GewichtsKlasse.Obesitas;
            }
            else
            {
                return GewichtsKlasse.Gezondgewicht;
            }*/
            return bmi switch
            {
                { } n when (n < 18.5) => GewichtsKlasse.Ondergewicht,
                { } n when (n < 24.9) => GewichtsKlasse.Gezondgewicht,
                { } n when (n < 29.9) => GewichtsKlasse.Overgewicht,
                { } n when (n >= 29.9) => GewichtsKlasse.Obesitas,
                _ => GewichtsKlasse.Gezondgewicht,
            };
        }
    }
}
