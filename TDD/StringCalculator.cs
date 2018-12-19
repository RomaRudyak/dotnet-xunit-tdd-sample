using System;
namespace TDD
{
    public class StringCalculator
    {
        public Int32 Add(String numbers)
        {
            String[] delimiters = new[] { ",", "\n" };
            String numbersWithoutDelimiter = numbers;
            if (numbers.StartsWith("//", StringComparison.InvariantCulture))
            {
                int delimiterIndex = numbers.IndexOf("//", StringComparison.InvariantCulture) + 2;
                delimiters = new[] { numbers.Substring(delimiterIndex, 1) };
                numbersWithoutDelimiter = numbers.Substring(numbers.IndexOf("\n", StringComparison.InvariantCulture) + 1);
            }
            return Add(numbersWithoutDelimiter, delimiters);
        }

        private static int Add(string numbers, String[] delimeters)
        {
            var result = 0;
            String[] numbersArray = numbers.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            foreach (String number in numbersArray)
            {
                if (String.IsNullOrEmpty(number))
                {
                    result += 0;
                    continue;
                }
                // If it is not a number, parseInt will throw an exception
                result += Int32.Parse(number);
            }

            return result;
        }
    }
}
