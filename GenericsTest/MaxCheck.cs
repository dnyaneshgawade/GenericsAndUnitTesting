using Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsTest
{
    public class MaxCheck
    {
        [TestClass]
        public class FindMaxTest
        {


            [TestMethod]
            public void GivenMaxNumFirstPostion_WhenFindMaxNum_shouldReturnsMaxFirst()
            {
                Maximum max = new Maximum();
                string result = max.MaximumString("Peach", "Apple",  "Banana");
                Assert.AreEqual("Peach", result);
            }
            [TestMethod]
            public void GivenMaxNumSecondPostion_WhenFindMaxNum_shouldReturnsMaxSecond()
            {
                Maximum max = new Maximum();
                string result = max.MaximumString("Apple", "Peach", "Banana");
                Assert.AreEqual("Peach", result);
            }
            [TestMethod]
            public void GivenMaxNumThirdPostion_WhenFindMaxNum_shouldReturnsMaxThird()
            {
                Maximum max = new Maximum();
                string result = max.MaximumString("Apple", "Banana", "Peach");
                Assert.AreEqual("Peach", result);
            }

        }
        
    }
}
