using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step4 : Step3, IStringCalculator
    {
        [TestMethod]
        public override void CheckFormat_NegativeNumber()
        {
            try
            {
                FormatNumber("-1");
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail();
        }

        public override string FormatNumber(string stringToProcess)
        {
            string number = string.Empty;
            char[] chars = stringToProcess.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 45 )
                {
                    throw new Exception("Negative number is not allowed");
                }
                else if (chars[i] >= 48 && chars[i] <= 57)
                {
                    number += chars[i].ToString();
                }
            }

            return number;
        }
    }
}
