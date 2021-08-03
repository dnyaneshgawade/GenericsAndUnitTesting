using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Maximum
    {
        public void MaxValue<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                Console.WriteLine(firstValue + " : is maximum");
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                Console.WriteLine(secondValue + " : is maximum");
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                Console.WriteLine(thirdValue + " : is maximum");
        }
    }
}
