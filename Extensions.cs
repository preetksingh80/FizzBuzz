using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FizzBuzz
{
    public static class Extensions
    {
        public static IList<string> FizzBuzz(this IEnumerable<int> numbers)
        {
            var result = new List<string>();
            numbers.ToList().ForEach(number=> result.Add(number.FizzBuzz()));
            return result;
        }

        public static string FizzBuzz(this int number)
        {
            var resultBuilder = new StringBuilder();
            if (number % 3 == 0)
            {
                resultBuilder.Append("fizz");
            }
            if (number % 5 == 0)
            {
                resultBuilder.Append("buzz");
            }
            
            if(resultBuilder.Length == 0){ resultBuilder.Append(Convert.ToString(number));}

            return resultBuilder.ToString();

        }
    }
}