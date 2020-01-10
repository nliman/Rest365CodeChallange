using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step3 : Step2, IStringCalculator
    {
        [TestMethod]
        public void CheckString_NonCommaDelimiter()
        {
            Assert.AreEqual(3, ValidateString("1\n2,3").Length);
        }

        public override string[] ValidateString(string stringToValidate)
        {
            char[] seperators = { ',', ' ', '\n' };
            string[] numbers = stringToValidate.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }
    }
}
