using System;
using System.Collections.Generic;
using System.Text;

namespace E2_E3_week_6b
{
    public class ArrayTools
    {
        //a
        public static int[] ReverseArray(int[] lijst)
        {
            for (int i = 0; i < lijst.Length / 2; i++)
            {
                int tmp = lijst[i];
                lijst[i] = lijst[lijst.Length - i - 1];
                lijst[lijst.Length - i - 1] = tmp;
            }

            return lijst;
        }

        //b
        public static int AmountOfEven(int[] lijst)
        {
            int counter = 0;
            foreach (int item in lijst)
            {
                if (item % 2 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        //c
        public static int[] CreateArray(int count)
        {
            int[] returnArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                returnArray[i] = i;
            }

            return returnArray;
        }

        //d
        public static int CountDifference(int[] array1, int[] array2)
        {
            if (array1.Length == array2.Length)
            {
                int counter = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    int sum = array1[i] - array2[i];
                    if ( sum <=2 && sum >=-2)
                    {
                        counter++;
                    }
                }
                return counter;

            }
            else
            {
                throw new Exception("Arrays are not the same length");
            }
        }

        //e
        public static bool IsOveral(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int prev = 1;
                int next = 1;
                if (array[i] != value)
                {
                    if (i < array.Length - 1) { next = array[i + 1]; }
                    if (i > 0) { prev = array[i - 1]; }

                    if (!(prev == 1 && next == 1))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //f
        public static bool Two(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int prev =0;
                int next =0;
                if (array[i] == 2)
                {
                    if (i < array.Length - 1) { next = array[i + 1]; }
                    if (i > 0) { prev = array[i - 1]; }

                    if (!(prev == 2 || next == 2))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        

    }
}
