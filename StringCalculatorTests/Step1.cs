using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;
using System;
using System.Collections.Generic;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step1 : IStringCalculator
    {
        [TestMethod]
        public virtual void StringValidation_MoreThanTwo()
        {
            try
            {
                ValidateString("123,456,789");
            }
            catch (Exception)
            {

                return;
            }
            Assert.Fail();            
        }

        [TestMethod]
        public void StringValidation_LessThanTwo()
        {
            Assert.AreEqual(1, ValidateString("123").Length);
        }

        [TestMethod]
        public void StringValidation_ExactlyTwo()
        {
            Assert.AreEqual(2, ValidateString("123,456").Length);
        }

        [TestMethod]
        public void StringValidation_TwoNumbersAndCharacters()
        {
            string[] returnValue = ValidateString("123a, 456%");
            Assert.AreEqual("123a", returnValue[0]);
            Assert.AreEqual("456%", returnValue[1]);
        }

        [TestMethod]
        public void CheckFormat_NumberOnly()
        {
            Assert.AreEqual("123", FormatNumber("123"));
        }

        [TestMethod]
        public void CheckFormat_NumberAndLetter()
        {
            Assert.AreEqual("123", FormatNumber("123a"));
        }

        [TestMethod]
        public void CheckFormat_NumberAndSpaces()
        {
            Assert.AreEqual("123", FormatNumber("123   "));
        }

        [TestMethod]
        public virtual void CheckFormat_NegativeNumber()
        {
            Assert.AreEqual("-1", FormatNumber("-1"));
        }

        [TestMethod]
        public void CheckFormat_Character()
        {
            Assert.AreEqual("", FormatNumber("%"));
        }

        #region code
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringToValidate"></param>
        /// <returns></returns>
        public virtual string[] ValidateString(string stringToValidate)
        {
            char[] seperators = { ',', ' ', };
            string[] numbers = stringToValidate.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length > 2)
            {
                throw new Exception("There are more than 2 numbers in string");
            }

            return numbers;
        }

        public virtual string FormatNumber(string stringToProcess)
        {
            string number = string.Empty;
            char[] chars = stringToProcess.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 45 || (chars[i] >= 48 && chars[i] <= 57))
                {
                    number += chars[i].ToString();
                }
            }

            return number;
        }

        public virtual int AddNumbers(List<string> numbers)
        {
            int returnValue = 0;

            foreach (var number in numbers)
            {
                returnValue += Convert.ToInt32(number);
            }

            return returnValue;
        }

        [TestMethod]
        public int ProcessString(string stringToProcess)
        {
            List<string> entries = new List<string>();
            string number = string.Empty;
            
            foreach (var n in ValidateString(stringToProcess))
            {
                number = FormatNumber(n);
                entries.Add(number);
                number = string.Empty;
            }

            return AddNumbers(entries);
        }

        #endregion code
    }
}
