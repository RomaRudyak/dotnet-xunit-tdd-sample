using System;
namespace TDD
{
    public class StringCalculator
    {
        public Int32 Add(String numbers)
        {
            String[] numbersArray = numbers.Split(',', StringSplitOptions.RemoveEmptyEntries);
            if (numbersArray.Length > 2)
            {
                throw new InvalidOperationException("Up to 2 numbers separated by comma (,) are allowed");
            }
            else
            {
                foreach (String number in numbersArray)
                {
                    // If it is not a number, parseInt will throw an exception
                    Int32.Parse(number);
                }
            }
            return 0;
        }
    }
}
