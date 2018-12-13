# Test Driven Development

This project is made for illustrate how TDD works. Sample was taken from [here](https://technologyconversations.com/2013/12/20/test-driven-development-tdd-example-walkthrough/)

## How to use this case study

Project has 7 steps which represented in brunches. Follow from 1 to 7. Each branch will have changes made in order to feet requirements by using TDD.

## Requirements

- Create a simple String calculator with a method int Add(string numbers)
- The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
- Allow the Add method to handle an unknown amount of numbers
- Allow the Add method to handle new lines between numbers (instead of commas).
- The following input is ok: “1\n2,3” (will equal 6)
- Support different delimiters. To change a delimiter, the beginning of the string will contain a separate line that looks like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ . 
- The first line is optional. 
- All existing scenarios should still be supported
- Calling Add with a negative number will throw an exception “negatives not allowed” – and the negative that was passed. If there are multiple negatives, show all of them in the exception message stop here if you are a beginner.