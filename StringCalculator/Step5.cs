using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Step5 : Step4, IStringCalculator
    {
        /// <summary>
        /// Method to add all numbers provided in a list, exclude any number that's greater than 1000
        /// </summary>
        /// <param name="numbers">Collection of numbers to be added</param>
        /// <returns>Total of provided numbers </returns>
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
