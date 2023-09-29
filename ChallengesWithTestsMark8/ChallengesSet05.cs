using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var foundNextInt = 0;
            if (startNumber == 0)
            {
                return n;
            }
            while (startNumber % n == 1)
            {
                startNumber++;
            }
                if (startNumber % n == 0)
                {
                    return startNumber = foundNextInt;
                }
            
            return foundNextInt;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                  businesses[i].Name = "Closed";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i -1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers.Length == 0 || numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i -1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words.Length == 0 || words == null)
            {
                return "";
            }
            string blanks = "";
            foreach (var word in words)
            {
                if (word.Trim().Length> 0)
                {
                    blanks += word.Trim() + "";
                }
                if (blanks.Length == 0)
                {
                    return "";
                }
                blanks = blanks.Substring(0, blanks.Length - 1);
                blanks += ".";
                return blanks;
            }
         ;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
