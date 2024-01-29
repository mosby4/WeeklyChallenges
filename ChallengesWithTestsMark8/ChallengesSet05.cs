using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n must be greater than 0.");
            }

            int remainder = startNumber % n;
            if (remainder == 0)
            {
                return startNumber;
            }

            return startNumber + n - remainder;
        }



        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }


        public bool IsAscendingOrder(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    return false;
                }
            }

            return true;
        }


        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }


        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            StringBuilder sentence = new StringBuilder();
            foreach (string word in words)
            {
                string trimmedWord = word.Trim();
                if (!string.IsNullOrEmpty(trimmedWord))
                {
                    if (sentence.Length > 0)
                    {
                        sentence.Append(" ");
                    }
                    sentence.Append(trimmedWord);
                }
            }

            if (sentence.Length > 0)
            {
                sentence.Append(".");
            }

            return sentence.ToString();
        }


        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] numbers, int targetNumber)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return false;
            }

            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int number in numbers)
            {
                int complement = targetNumber - number;
                if (seenNumbers.Contains(complement))
                {
                    return true;
                }
                seenNumbers.Add(number);
            }

            return false;
        }

    }
}
