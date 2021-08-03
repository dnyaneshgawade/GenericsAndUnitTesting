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
                double result = max.MaximumFloat(100.4, 50.5, 25.8);
                Assert.AreEqual(100.4, result);
            }
            [TestMethod]
            public void GivenMaxNumSecondPostion_WhenFindMaxNum_shouldReturnsMaxSecond()
            {
                Maximum max = new Maximum();
                double result = max.MaximumFloat( 50.5, 100.4, 25.8);
                Assert.AreEqual(100.4, result);
            }
            [TestMethod]
            public void GivenMaxNumThirdPostion_WhenFindMaxNum_shouldReturnsMaxThird()
            {
                Maximum max = new Maximum();
                double result = max.MaximumFloat(50.4, 25.8, 100.4);
                Assert.AreEqual(100.4, result);
            }

        }
        
    }
}
