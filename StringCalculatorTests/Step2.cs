using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step2 : Step1, IStringCalculator
    {
        [TestMethod]
        public void FormatString_NoLimit()
        {
            Assert.AreEqual("12", ValidateString("1,2,3,4,5,6,7,8,9,10,11,12").Length.ToString());
        }

        public override void StringValidation_MoreThanTwo()
        {
            string[] returnValue = ValidateString("123,456,789");
            Assert.AreEqual("123", returnValue[0].ToString());
            Assert.AreEqual("456", returnValue[1].ToString());
            Assert.AreEqual("789", returnValue[2].ToString());
        }

        public override string[] ValidateString(string stringToValidate)
        {
            char[] seperators = { ',', ' ', };
            string[] numbers = stringToValidate.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }
    }
}
