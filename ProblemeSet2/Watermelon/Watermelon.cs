using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermelon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForWatermelonParity()
        {
            string watermelon = verifyParity(2);
            Assert.AreEqual("NU", watermelon);
        }
        [TestMethod]
        public void TestForWatermelonParitySecond()
        {
            string watermelon = verifyParity(10);
            Assert.AreEqual("DA", watermelon);
        }
        [TestMethod]
        public void TestForWatermelonParityThird()
        {
            string watermelon = verifyParity(333);
            Assert.AreEqual("NU", watermelon);
        }

        string verifyParity(int watermelonWeight)
        {
            if (watermelonWeight > 2)
                if (watermelonWeight % 2 == 0)
                    return "DA";
            
            return "NU";           
        }
    }
}
