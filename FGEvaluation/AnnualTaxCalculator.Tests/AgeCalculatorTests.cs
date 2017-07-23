using System;
using AnnualTaxCalculator.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnnualTaxCalculator.Tests
{
    [TestClass]
    public class AgeCalculatorTests
    {
        /*
        [TestMethod]
        public void Construct_AgeCalculatorIsNotNull()
        {
            //---Setup----------------------------------------------

            //---Execute--------------------------------------------
            var ageCalculator = new AgeCalculator();
            //---Assert---------------------------------------------
            Assert.IsNotNull(ageCalculator);
        }*/


        //[TestMethod]
        //public void Construct_NoDateOfBirth_ThrowException()
        //{
        //    //---Setup--------------------------------------
        //    //---Execute--------------------------------------------
        //    var ageCalculator = new AgeCalculator(null);
        //    //---Assert---------------------------------------------
        //    Assert.Fail("Exception thrown");

        //}

        [TestMethod]
        public void Calculate_GivenDateOfBirth_ShouldReturnAge()
        {
            //---Setup--------------------------------------
            var dateOfBirth = new DateTime(1983,03,21);
            var ageCalculator = new AgeCalculator(dateOfBirth);
            //---Execute--------------------------------------------
            int age = ageCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(34,age);

        }
    }
}
