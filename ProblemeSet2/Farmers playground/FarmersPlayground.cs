using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Farmers_playground
{
    [TestClass]
    public class FarmersPlayground
    {
        public void CalculateAreaForInitialField()
        {
            Assert.AreEqual(4, CalculateAreaForSquare(10, 3));
        }
        double CalculateAreaForSquare(int Aria, int width)
        {
            double x = (-width + Math.Sqrt(width * width + 4 * Aria)) / 2;
            return x * x;
        }



    }
}
