using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class Program
    {
        private static IStringCalculator _iStringCalculator;

        public static void Main(string[] args)
        {
            bool isEnd = false;

            Console.WriteLine("Welcome to Nawa's String Calculator\r");
            Console.WriteLine("-----------------------------------\n");

            while (!isEnd)
            {
                try
                {
                    Console.WriteLine("Type two numbers seperated by a comma, then press Enter");
                    string stringToCheck = Console.ReadLine();

                    ProcessString(stringToCheck);

                    Console.WriteLine("-----------------------------------\n");
                    Console.Write("Press 'x' and Enter to close console app, or Enter to continue ");

                    if (Console.ReadLine() == "x") isEnd = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught - {0}", e.Message);
                }
            }
            return;
        }

        /// <summary>
        /// Method to process string, the following actions are inclusive:
        /// 1. Validation of string length (max 2) & format (comma as delimiter)
        /// 2. Use ASCII characters to determine numbers (-9 to 9) and supress non-numbers with 0
        /// 3. Summation of numbers in string
        /// </summary>
        /// <param name="stringToCheck"></param>
        private static void ProcessString(string stringToProcess)
        {
            _iStringCalculator = new Step1();

            List<string> entries = new List<string>();
            string number = string.Empty;

            try
            {
                foreach (var n in _iStringCalculator.ValidateString(stringToProcess))
                {
                    number = _iStringCalculator.FormatNumber(n);
                    entries.Add(number);
                    number = string.Empty;
                }

                _iStringCalculator.AddNumbers(entries);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
