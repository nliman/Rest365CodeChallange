using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step5: Step4, IStringCalculator
    {
        [TestMethod]
        public void NumberSummation_HasLargeNumber()
        {
            List<string> numbers = new List<string>();
            numbers.Add("2");
            numbers.Add("1001");
            numbers.Add("6");
            Assert.AreEqual("8", AddNumbers(numbers).ToString());
        }
        public override int AddNumbers(List<string> numbers)
        {
            int returnValue = 0;

            foreach (var number in numbers)
            {
                if (Convert.ToInt32(number) <= 1000)
                {
                    returnValue += Convert.ToInt32(number);
                }
            }

            return returnValue;
        }
    }
}
