using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestBuzz() {
            Assert.AreEqual("BUZZ", getFizzBuzz(5));
        }
        [TestMethod]
        public void TestFizz()
        {
            Assert.AreEqual("FIZZ", getFizzBuzz(33));
        }
        [TestMethod]
        public void TestFizzBuzz()
        {
            Assert.AreEqual("FIZZBUZZ", getFizzBuzz(15));
        }
        [TestMethod]
        public void TestNoRetrieve()
        {
            Assert.AreEqual("17", getFizzBuzz(17));
        }


        string getFizzBuzz(int theNumber)
        {

            if (theNumber % 5 == 0 && theNumber % 3 == 0)
                return "FIZZBUZZ";

            if (theNumber % 5 == 0)
                return "BUZZ";

            if (theNumber % 3 == 0)
                return "FIZZ";

           return theNumber.ToString();
        }
    }
        }
    

