using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnnualTaxCalculator.BLL;

namespace AnnualTaxCalculator.Tests
{
    [TestClass]
    public class TaxReliefCalculatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Construct_GivenInvalidAge_ShouldThrowException()
        {
            //---Setup----------------------------------------------
            int invalidAge = default(int);
            //---Execute--------------------------------------------
            var calculator = new TaxReliefCalculator(invalidAge);
            //---Assert---------------------------------------------
            Assert.Fail("Expected exception not thrown!");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Construct_GivenInvalidAge_LessThan_ShouldThrowException()
        {
            //---Setup----------------------------------------------
            int invalidAge = 17;
            //---Execute--------------------------------------------
            var calculator = new TaxReliefCalculator(invalidAge);
            //---Assert---------------------------------------------
            Assert.Fail("Expected exception not thrown!");
        }
        [TestMethod]
        public void Calculate_GivenAge_30_ShouldReturnMonthlySalaryRelief_2000()
        {
            //---Setup----------------------------------------------
            int age = 30;
            var calculator = new TaxReliefCalculator(age);
            //---Execute--------------------------------------------
            var relief = calculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(2000, relief.MonthlySalaryRelief);
        }
        [TestMethod]
        public void Calculate_GivenValidAge_30_ShouldReturnPercentageOfRelief_1()
        {
            //---Setup----------------------------------------------
            int age = 30;
            var calculator = new TaxReliefCalculator(age);
            //---Execute--------------------------------------------
            var relief = calculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(1, relief.PercentageOfDeduction);
        }
        [TestMethod]
        public void Calculate_GivenAge_55_ShouldReturnMonthlySalaryRelief_5000()
        {
            //---Setup----------------------------------------------
            int age = 55;
            var calculator = new TaxReliefCalculator(age);
            //---Execute--------------------------------------------
            var relief = calculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(5000, relief.MonthlySalaryRelief);
        }

        [TestMethod]
        public void Calculate_GivenAge_30_ShouldReturnPercentageOfRelief_0_85()
        {
            //---Setup----------------------------------------------
            int age = 55;
            var calculator = new TaxReliefCalculator(age);
            //---Execute--------------------------------------------
            var relief = calculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(0.85m, relief.PercentageOfDeduction);
        }
    }
}