using System;
namespace TDD
{
    public class StringCalculator
    {
        public Int32 Add(String numbers)
        {
            var result = 0;
            String[] numbersArray = numbers.Split(new[] { ",", "\n" }, StringSplitOptions.RemoveEmptyEntries);
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
