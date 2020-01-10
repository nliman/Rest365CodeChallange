using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public interface IStringCalculator
    {
        int AddNumbers(List<string> numbers);
        string[] ValidateString(string stringToValidate);
        string FormatNumber(string stringToProcess);
    }
}
