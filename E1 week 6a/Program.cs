using System;
using System.Collections.Generic;

namespace E1_week_6a
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            MyMath.Pow3Alt(ref x);
            Console.WriteLine(x);
        }
    }
}
