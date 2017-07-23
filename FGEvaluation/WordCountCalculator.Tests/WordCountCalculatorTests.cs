using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace WordCountCalculator.Tests
{
    [TestClass]
    public class WordCountCalculatorTests
    {
        //[TestMethod]
        //public void Construct()
        //{
        //    //---Setup-------------------------------
        //    //---Execute-----------------------------
        //    var calculator = new WordCountCalculator(null);
        //    //---Assert------------------------------
        //    Assert.IsNotNull(calculator);
        //}

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Construct_GivenNoConsoleLogger_ShouldThrowException()
        {
            //---Setup-------------------------------
            //---Execute-----------------------------
            var calculator = new WordCountCalculator(null);
            //---Assert------------------------------
            Assert.Fail("Expected Exception Not Thrown!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Calculate_GivenNoPath_ShouldThrowException()
        {
            //---Setup-------------------------------
            var calculator = GetCalculator();
            //---Execute-----------------------------
            calculator.Calculate(null);
            //---Assert------------------------------
            Assert.Fail("Expected Exception Not Thrown!");
        }

        #region Factory Methods

        private WordCountCalculator GetCalculator()
        {
            return new WordCountCalculator(new ConsoleLoggerStub());
        }

        internal class ConsoleLoggerStub
            : IConsoleLogger
        {
            public void WriteLine(string input)
            {
                
            }

            public string Prompt(string input)
            {
                return string.Empty;
            }

            public string ReadLine()
            {
                return string.Empty;
            }
        }

        #endregion
    }

    public class WordCountCalculator
    {
        public WordCountCalculator(IConsoleLogger logger)
        {
            if (logger == null) throw new ArgumentNullException(nameof(logger));
        }

        public void Calculate(string path)
        {
            if(path == null) throw new ArgumentNullException(nameof(path));


        }
    }
}
