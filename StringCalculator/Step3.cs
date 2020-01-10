using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Step3 : Step2, IStringCalculator
    {
        /// <summary>
        /// Method to Validate string's length and format, supports newline character as new delimiter
        /// </summary>
        /// <param name="stringToProcess">Provide string to be validated</param>
        /// <returns>Array of validated numbers</returns>
        public override string[] ValidateString(string stringToValidate)
        {
            string[] numbers;

            try
            {
                char[] seperators = { ',', ' ', '\n' };
                numbers = stringToValidate.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (Exception e)
            {
                throw e;
            }

            return numbers;
        }
    }
}
