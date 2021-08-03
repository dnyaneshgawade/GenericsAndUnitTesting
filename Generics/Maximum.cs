using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Maximum<T> where T:IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public Maximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public void MaxValue()
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
