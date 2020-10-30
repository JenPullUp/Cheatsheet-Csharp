using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Munt munt = new Munt();
            Console.WriteLine(munt.SimulateThrows(100000));
        }
    }
}
