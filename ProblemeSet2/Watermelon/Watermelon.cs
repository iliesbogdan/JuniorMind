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
            string watermelon = verifyParity(10);
            Assert.AreEqual("DA", watermelon);
        }
        string verifyParity(int watermelonWeight)
        {
            string d = "DA";
            string n = "NU";
            if (watermelonWeight % 2 == 0)
            {
                return d;
            }
            else
            {
                return n;
            }
        }
    }
}
