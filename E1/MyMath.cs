using System;
using System.Collections.Generic;
using System.Text;

namespace E1
{
    static class MyMath
    {
        public static int Abs(int x)
        {
            return Math.Abs(x);
        } // bepaal de absolute waarde van een integer.

        public static void AbsAlt(ref int x)
        {
            x = Math.Abs(x);
        } // verander x in de absolute waarde

        public static int Pow3(int x)
        {
            return (int)Math.Pow(x, 3);
        } // bereken x3

        public static void Pow3Alt(ref int x)
        {
            x = (int)Math.Pow(x, 3);
        } // verander x in x3
    }
}
