using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            return true;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();

        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums[0];

        }

        public int[] GetOddsBelow100()
        {
            /* var odds = new int[50];
             if (% 2 == 1 < 100)
             {
                 odds.Add();

             }*/
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach (var item in words)
            {
                item.ToUpper();
            }
        }

    }
}