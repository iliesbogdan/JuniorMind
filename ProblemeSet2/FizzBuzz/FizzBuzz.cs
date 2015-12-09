using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestBuzzFizz() {
            string test = getFizzBuzz(10);
            Assert.AreEqual("BUZZ", test);
        }

        string getFizzBuzz(int a)
        {

            string f = "FIZZ";
            string b = "BUZZ";
            string fb = "FIZZBUZZ";

            if (a % 5 == 0 && a % 3 == 0)
                return fb;

            else
                if (a % 5 == 0)
                return b;

            else if (a % 3 == 0)
                return f;
            else return "none";

        }
    }
        }
    

