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
            float showHowMuchRent = calculateRentPenalties(100,5);
            Assert.AreEqual(10, showHowMuchRent);
        }
        float calculateRentPenalties (int rent, int days)
        {
            // int theRentPenalties
            if (days <= 10)

           return (rent * 2 / 100 * days); //theRentPenalties = (rent * 2 / 100 * days);

            if (days <= 30)

           return (rent * 5 / 100 * days);

             if (days <= 40)

           return (rent * 10 / 100 * days);

           return (rent * 100 / 100 * days);
          // trying to change the return with an variable, and save the result in it
          //then use it      
        }
        float theFinalRentPrice(float finalRent)
        {
            // trying to find a method to get the value from the function calculateRentPenalties
            // and then to find the final price for the final rent, and then test it.

        }


    }



}
