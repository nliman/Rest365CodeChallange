using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Step6 : Step5, IStringCalculator
    {
        /// <summary>
        /// Method to Validate string's length and format, supports 1 custom delimiter and delimiter with any length
        /// </summary>
        /// <param name="stringToProcess">Provide string to be validated</param>
        /// <param name="customDelims">Char Array of custom delimiters</param>
        /// <returns>Array of validated numbers</returns>
        public string[] ValidateString(string stringToValidate, char[] customDelims)
        {
            string[] numbers;

            try
            {
                char[] seperators = new char[] { ',', ' ', '\n' };
                char[] delims = new char[seperators.Length + customDelims.Length];

                var byteIndex = seperators.Length * sizeof(char);
                Buffer.BlockCopy(seperators, 0, delims, 0, byteIndex);
                Buffer.BlockCopy(customDelims, 0, delims, byteIndex, customDelims.Length * sizeof(char));

                numbers = stringToValidate.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (Exception e)
            {
                throw e;
            }
            return numbers;
        }
    }
}
