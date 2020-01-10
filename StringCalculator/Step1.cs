using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Step1 : IStringCalculator
    {
        /// <summary>
        /// Method to add all numbers provided in a list 
        /// </summary>
        /// <param name="numbers">Collection of numbers to be added</param>
        /// <returns>Total of provided numbers </returns>
        public virtual int AddNumbers(List<string> numbers)
        {
            int returnValue = 0;

            foreach (var number in numbers)
            {
                returnValue += Convert.ToInt32(number);
            }

            Console.WriteLine("Sum of numbers is {0} ", returnValue);
            return returnValue;
        }

        /// <summary>
        /// Method to Validate string's length and format
        /// </summary>
        /// <param name="stringToProcess">Provide string to be validated</param>
        /// <returns>Array of validated numbers</returns>
        public virtual string[] ValidateString(string stringToValidate)
        {
            string[] numbers;
            try
            {
                char[] seperators = { ',', ' ', };
                numbers = stringToValidate.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                if (numbers.Length > 2)
                {
                    throw new Exception("There are more than 2 numbers in string");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return numbers;
        }

        /// <summary>
        /// Method to format numbers
        /// </summary>
        /// <param name="stringToProcess">string to be formatted</param>
        /// <returns>Formatted number</returns>
        public virtual string FormatNumber(string stringToProcess)
        {
            string number = string.Empty;

            try
            {
                char[] chars = stringToProcess.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 45 || (chars[i] >= 48 && chars[i] <= 57))
                    {
                        number += chars[i].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return number;
        }

        /// <summary>
        /// Test Method for Step 1
        /// </summary>
        /// <param name="stringToProcess"></param>
        public void ProcessString(string stringToProcess)
        {
            List<string> entries = new List<string>();
            string number = string.Empty;

            try
            {
                foreach (var n in ValidateString(stringToProcess))
                {
                    number = FormatNumber(n);
                    entries.Add(number);
                    number = string.Empty;
                }

                AddNumbers(entries);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
