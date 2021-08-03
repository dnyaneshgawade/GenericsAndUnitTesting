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
                int result = max.MaximumInteger(100, 50, 25);
                Assert.AreEqual(100, result);
            }
            [TestMethod]
            public void GivenMaxNumSecondPostion_WhenFindMaxNum_shouldReturnsMaxSecond()
            {
                Maximum max = new Maximum();
                int result = max.MaximumInteger( 50, 100, 25);
                Assert.AreEqual(result,100);
            }
            [TestMethod]
            public void GivenMaxNumThirdPostion_WhenFindMaxNum_shouldReturnsMaxThird()
            {
                Maximum max = new Maximum();
                int result = max.MaximumInteger(50, 25, 100);
                Assert.AreEqual(result, 100);
            }

        }
        
    }
}
