using System.Collections.Generic;
using System.Linq;

namespace CmLibrary
{
    public class IntegerLibrary
    {
        /// <summary>
        /// Get the most occurance number(s)
        /// Need to sort the input numbers first if we need to have the ascending order of output
        /// </summary>
        /// <param name="numbers">List of numbers to check</param>
        /// <returns>List of the most occurance numbers</returns>
        public static int[] MostCommonNumbers(int[] numbers)
        {
            if (numbers.Count() == 0)
            {
                return new int[] {};
            }

            var counters = new Dictionary<int, int>();
            int maxOccuranceNumber = 0;

            // count all occurance
            foreach (var item in numbers)
            {
                if (counters.ContainsKey(item)) 
                {
                    counters[item] = counters[item] + 1;

                    if (counters[item] > maxOccuranceNumber)
                    {
                        maxOccuranceNumber = counters[item];
                    }
                }
                else 
                {
                    if (maxOccuranceNumber < 1)
                    {
                        maxOccuranceNumber = 1;
                    }

                    counters.Add(item, 1);
                }
            }

            var maxOccuranceItems = new List<int>();

            // check for duplicate max occurance
            foreach (var item in counters)
            {
                if (item.Value == maxOccuranceNumber)
                {
                    maxOccuranceItems.Add(item.Key);
                }
            }

            return maxOccuranceItems.ToArray();
        }

        /// <summary>
        /// Calculate positive divisors
        /// </summary>
        /// <param name="value">Number to calculate</param>
        /// <returns>The positive divisor(s)</returns>
        public static int[] PositiveDivisors(int value)
        {
            if (value <= 0) 
            {
                return new int[] { 0 };
            }

            if (value == 1)
            {
                return new int[] { 1 };
            }

            var divisors = new List<int>();

            divisors.Add(1);

            for (int index = 2; index < value; index++) 
            {
                if (value % index == 0) 
                {
                    divisors.Add(index);
                }
            }

            divisors.Add(value);

            return divisors.ToArray();
        }
    }
}