using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step7 : Step6, IStringCalculator
    {
        [TestMethod]
        public override void StringValidation_CustomDelims()
        {
            char[] customDelims = ("[***]").ToCharArray();

            string[] numbers = ValidateString("//[***]\n11***22***33", customDelims);
            foreach (var number in numbers)
            {
                Assert.AreEqual("//", numbers[0]);
                Assert.AreEqual("11", numbers[1]);
                Assert.AreEqual("22", numbers[2]);
                Assert.AreEqual("33", numbers[3]);
            }
        }
    }
}
