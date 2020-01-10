using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class Step8 : Step7, IStringCalculator
    {
        [TestMethod]
        public override void StringValidation_CustomDelims()
        {
            char[] seperators = new char[] { ',', ' ', '\n' };
            string[] customDelims = new string[] { "[*]", "[!!]", "[r9r]", "r9r", "*hh*", "!!" };

            //char[][] char2dArray = new char[customDelims.Length + seperators.Length][];
            //int counter = 0;
            //for (int i = 0; i < seperators.Length; i++)
            //{
            //    char2dArray[i] = seperators[i].ToString().ToCharArray();
            //    counter = i;
            //}
            //counter++;
            //for (int i = 0; i < customDelims.Length; i++)
            //{
            //    char2dArray[counter] = customDelims[i].ToCharArray();
            //    counter++;
            //}

            string[] delims = new string[seperators.Length + customDelims.Length];

            Array.Copy(customDelims, delims, customDelims.Length);
            int counter = customDelims.Length;
            for (int i = 0; i < seperators.Length; i++)
            {
                delims[counter] = seperators[i].ToString();
                counter++;
            }

            string[] numbers = ValidateString(("//[*][!!][r9r]\n11r9r22*hh*33!!44"), delims);
            foreach (var number in numbers)
            {
                Assert.AreEqual("//", numbers[0]);
                Assert.AreEqual("11", numbers[1]);
                Assert.AreEqual("22", numbers[2]);
                Assert.AreEqual("33", numbers[3]);
                Assert.AreEqual("44", numbers[4]);
            }
        }

        public string[] ValidateString(string stringToValidate, string[] customDelims)
        {
            string[] numbers = stringToValidate.Split(customDelims, StringSplitOptions.RemoveEmptyEntries);
            return numbers;
        }
    }
}
