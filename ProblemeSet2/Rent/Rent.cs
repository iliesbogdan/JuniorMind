using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rent
{
    [TestClass]
    public class Rent
    {
        [TestMethod]
        public void TestMethod1()
        {
            float showHowMuchRent = calculateRent(100,5);
            Assert.AreEqual(10, showHowMuchRent);
        }
        float calculateRent (int rent, int days)
        {
            if (days <= 10)

                return (rent * 2 / 100 * days);

             if (days <= 30)

                return (rent * 5 / 100 * days);

             if (days <= 40)

                return (rent * 10 / 100 * days);

                return (rent * 100/100*days);
            
        }






    }



}
