using AnnualTaxCalculator.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnnualTaxCalculator.Tests
{
    [TestClass]
    public class AnnualTaxCalculatorTests
    {
        //[TestMethod]
        //public void Construct_ShouldNotBeNull()
        //{
        //    //---Setup----------------------------------------------
        //    //---Execute--------------------------------------------
        //    var annualTaxCalculator = new AnnualTaxCalculator();
        //    //---Assert---------------------------------------------
        //    Assert.IsNotNull(annualTaxCalculator);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        //public void Construct_NoAnnualSalary_ShouldThrowException()
        //{
        //    //---Setup----------------------------------------------

        //    //---Execute--------------------------------------------
        //    var annualTaxCalculator = new AnnualTaxCalculator(null);
        //    //---Assert---------------------------------------------
        //    Assert.Fail("Exception thrown");
        //}

        //[TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        //public void Construct_NoAge_ShouldThrowException()
        //{
        //    //---Setup----------------------------------------------
        //    double annualSalary = 300000;
        //    //---Execute--------------------------------------------
        //    var annualTaxCalculator = new AnnualTaxCalculator(annualSalary,null);
        //    //---Assert---------------------------------------------
        //    Assert.Fail("Exception thrown");
        //}

        [TestMethod]
        public void Calculate_GivenAge30AndAnnualSalary300000_ShouldReturnAnnualTax()
        {
            //---Setup----------------------------------------------
            decimal annualSalary = 300000m;
            decimal monthlySalary = annualSalary / 12;
            int age = 30;
            var taxReliefCalculator = new TaxReliefCalculator(age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new BLL.AnnualTaxCalculator(ageBasedRelief, monthlySalary);
            //---Execute--------------------------------------------
            decimal annualTax = annualTaxCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(24840, annualTax);
        }

        [TestMethod]
        public void Calculate_GivenAge55AndAnnualSalary300000_ShouldReturnAnnualTax()
        {
            //---Setup----------------------------------------------
            decimal annualSalary = 300000m;
            decimal monthlySalary = annualSalary / 12;
            int age = 55;
            var taxReliefCalculator = new TaxReliefCalculator(age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new BLL.AnnualTaxCalculator(ageBasedRelief, monthlySalary);
            //---Execute--------------------------------------------
            decimal annualTax = annualTaxCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(18360, annualTax);
        }

        [TestMethod]
        public void Calculate_GivenAge30AndAnnualSalary48000_ShouldReturnAnnualTax()
        {
            //---Setup----------------------------------------------
            decimal annualSalary = 48000m;
            decimal monthlySalary = annualSalary / 12;
            int age = 30;
            var taxReliefCalculator = new TaxReliefCalculator(age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new BLL.AnnualTaxCalculator(ageBasedRelief, monthlySalary);
            //---Execute--------------------------------------------
            decimal annualTax = annualTaxCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(0, annualTax);
        }

        [TestMethod]
        public void Calculate_GivenAge55AndAnnualSalary48000_ShouldReturnAnnualTax()
        {
            //---Setup----------------------------------------------
            decimal annualSalary = 48000m;
            decimal monthlySalary = annualSalary / 12;
            int age = 55;
            var taxReliefCalculator = new TaxReliefCalculator(age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new BLL.AnnualTaxCalculator(ageBasedRelief, monthlySalary);
            //---Execute--------------------------------------------
            decimal annualTax = annualTaxCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(0, annualTax);
        }


        [TestMethod]
        public void Calculate_GivenAge30AndAnnualSalary900000_ShouldReturnAnnualTax()
        {
            //---Setup----------------------------------------------
            decimal annualSalary = 900000m;
            decimal monthlySalary = annualSalary / 12;
            int age = 30;
            var taxReliefCalculator = new TaxReliefCalculator(age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new BLL.AnnualTaxCalculator(ageBasedRelief, monthlySalary);
            //---Execute--------------------------------------------
            decimal annualTax = annualTaxCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(262800, annualTax);
        }


        [TestMethod]
        public void Calculate_GivenAge55AndAnnualSalary900000_ShouldReturnAnnualTax()
        {
            //---Setup----------------------------------------------
            decimal annualSalary = 900000m;
            decimal monthlySalary = annualSalary / 12;
            int age = 55;
            var taxReliefCalculator = new TaxReliefCalculator(age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new BLL.AnnualTaxCalculator(ageBasedRelief, monthlySalary);
            //---Execute--------------------------------------------
            decimal annualTax = annualTaxCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(214200, annualTax);
        }
    }

}

