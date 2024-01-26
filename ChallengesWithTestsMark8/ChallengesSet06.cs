using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
            {
                return false;
            }

            if (ignoreCase)
            {
                return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return words.Contains(word);
            }
        }


        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }
            if ((num == 2) || (num ==3))
            {
                isPrime = true;
            }
            if (num == 1)
            {
                isPrime = false;
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            for (int i = 0; i < str.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    index = i;
                }
            }

            return index;
        }


        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            maxCount = Math.Max(maxCount, currentCount);

            return maxCount;
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            // Return an empty array if the input list is null or n is not a valid index
            if (elements == null || n <= 0 || n > elements.Count)
            {
                return new double[0];
            }

            List<double> nthElements = new List<double>();

            // Iterate through the list, starting from the (n-1)th element
            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElements.Add(elements[i]);
            }

            return nthElements.ToArray();
        }

    }
}
