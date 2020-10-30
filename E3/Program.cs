using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI mBmi = new BMI();
            Console.WriteLine(mBmi.BepaalBMI(75, 185).ToString());
            
        }
    }
}
