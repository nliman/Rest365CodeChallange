using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Step4 : Step3, IStringCalculator
    {
        /// <summary>
        /// Method to format numbers, throws error when any negative number is detected
        /// </summary>
        /// <param name="stringToProcess">string to be formatted</param>
        /// <returns>Formatted number</returns>
        public override string FormatNumber(string stringToProcess)
        {
            string number = string.Empty;

            try
            {
                char[] chars = stringToProcess.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 45)
                    {
                        throw new Exception("Negative number is not allowed");
                    }
                    else if (chars[i] >= 48 && chars[i] <= 57)
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
    }
}
