using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Maximum<int> maxInt = new Maximum<int>(11,33,22);
            Console.WriteLine("Maximum value between 3 Integer is :");
            maxInt.MaxValue();
            Maximum<float> maxFloat = new Maximum<float>(11.1f, 33.3f, 22.2f);
            Console.WriteLine("Maximum value between 3 Floats is :");
            maxFloat.MaxValue();
            Maximum<string> maxChar = new Maximum<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum value between 3 String is :");
            maxChar.MaxValue();
        }
    }
}
