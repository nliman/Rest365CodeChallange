using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Step8: Step7, IStringCalculator
    {
        /// <summary>
        /// Method to Validate string's length and format, supports 1 custom delimiter and delimiter with any length
        /// </summary>
        /// <param name="stringToProcess">Provide string to be validated</param>
        /// <param name="customDelims">String Array of custom delimiters</param>
        /// <returns>Array of validated numbers</returns>
        public string[] ValidateString(string stringToValidate, string[] customDelims)
        {
            string[] numbers;

            try
            {
                numbers = stringToValidate.Split(customDelims, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (Exception e)
            {
                throw e;
            }

            return numbers;
        }
    }
}
