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

        string getFizzBuzz(int a)
        {

            if (a % 5 == 0 && a % 3 == 0)
                return "FIZZBUZZ";

            else if (a % 5 == 0)
                return "BUZZ";

            else if (a % 3 == 0)
                return "FIZZ";
            else return a.ToString();
        }
    }
        }
    

