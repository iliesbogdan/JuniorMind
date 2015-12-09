using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermelon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int watermelon = verifyParity(10);
            Assert.AreEqual(1, watermelon);
        }
        int verifyParity(int watermelonWeight)
        {
            
            if (watermelonWeight % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
