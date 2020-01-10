using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step6 : Step5, IStringCalculator
    {
        [TestMethod]
        public virtual void StringValidation_CustomDelims()
        {
            char[] customDelims = { '#' };
            string[] numbers = ValidateString("//#\n2,3#5", customDelims);
            foreach (var number in numbers)
            {
                Assert.AreEqual("//", numbers[0]);
                Assert.AreEqual("2", numbers[1]);
                Assert.AreEqual("3", numbers[2]);
                Assert.AreEqual("5", numbers[3]);
            }
        }

        public string[] ValidateString(string stringToValidate, char[] customDelims)
        {
            char[] seperators = new char[] { ',', ' ', '\n' };

            char[] delims = new char[seperators.Length + customDelims.Length];

            var byteIndex = seperators.Length * sizeof(char);
            Buffer.BlockCopy(seperators, 0, delims, 0, byteIndex);
            Buffer.BlockCopy(customDelims, 0, delims, byteIndex, customDelims.Length * sizeof(char));
            
            string[] numbers = stringToValidate.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }
    }
}
