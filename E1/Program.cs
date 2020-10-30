using System;
using System.Collections.Generic;

namespace E1
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
