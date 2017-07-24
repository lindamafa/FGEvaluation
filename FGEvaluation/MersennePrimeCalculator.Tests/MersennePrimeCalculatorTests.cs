using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MersennePrimeCalculator.Tests
{
    [TestClass]
    public class MersennePrimeCalculatorTests
    {
        [TestMethod]
        public void IsPrime_GivenNumber2_ShouldReturnTrue()
        {
            //---Setup-------------------------------
            int number = 2;
            //---Execute-----------------------------
            bool result = IsPrime(number);
            //---Assert------------------------------
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsPrime_GivenNumber4_ShouldReturnFalse()
        {
            //---Setup-------------------------------
            int number = 4;
            //---Execute-----------------------------
            bool result = IsPrime(number);
            //---Assert------------------------------
            Assert.AreEqual(false, result);
        }

        private bool IsPrime(int number)
        {
            if (number == 0)
                return false;

            if (number == 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0) return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }
}
