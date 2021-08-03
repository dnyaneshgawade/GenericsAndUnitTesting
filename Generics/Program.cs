using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Maximum maximum = new Maximum();
            Console.WriteLine("Maximum value between 3 Integer is :");
            maximum.MaxValue(20, 30, 50);
            Console.WriteLine("Maximum value between 3 Floats is :");
            maximum.MaxValue(20.34, 70.34, 50.34);
            Console.WriteLine("Maximum value between 3 String is :");
            maximum.MaxValue("Apple", "Peach", "Banana");
        }
    }
}
