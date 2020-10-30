using System;

namespace E2_E3_week_6b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {2,2,2,3,2,2};
            int[] array2 = {2,4,8};
            //Console.WriteLine(ArrayTools.IsOveral(array1, 1));
            Console.WriteLine(ArrayTools.CountDifference(array1, array2));
            
        }
    }
}
