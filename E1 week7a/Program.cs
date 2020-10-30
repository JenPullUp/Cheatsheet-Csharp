using System;

namespace E1_week7a
{
    class Program
    {
        delegate int Convert(int i);
        static void Main(string[] args)
        {
            Convert convert = MySubtractTwo;
            Console.WriteLine(convert(4)); // 2
            Convert Anonymous = delegate (int i) { return i-2; }; //anonymous
            Convert Lambda = (x) => { return x-2; }; //lambda expression
            Func<int, int> substract2 = (x) => { return x - 2;}; //use of func with lambda
        }
        private static int MySubtractTwo(int i) { return i - 2; }

    }
}
