using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Maximum
    {
        public static string all = "all are same";
        public string MaximumString(string firstNumber, string secondNumber, string thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                return secondNumber;
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                return thirdNumber;
            return all;
        }
    }
}
