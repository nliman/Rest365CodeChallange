using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Step2 : Step1, IStringCalculator
    {
        /// <summary>
        /// Method to Validate string's length and format, without maximum constraint
        /// </summary>
        /// <param name="stringToProcess">Provide string to be validated</param>
        /// <returns>Array of validated numbers</returns>
        public override string[] ValidateString(string stringToValidate)
        {
            try
            {
                char[] seperators = { ',', ' ', };
                string[] numbers = stringToValidate.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                return numbers;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
