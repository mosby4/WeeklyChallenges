using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var evenSum = 0;
            var oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                if (numbers[i] % 2 == 1)
                {
                    oddSum += numbers[i];
                }

            }
            return evenSum - oddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> myList = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return myList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);

            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return(sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1+ sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1); 
        }

        public bool IsStringANumber(string input)
        {
            var isANumber = double.TryParse(input, out double number);
            return isANumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objects)
        {
            if (objects == null || objects.Length == 0)
            {
                return false;
            }

            int nullCount = 0;
            foreach (var obj in objects)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }

            return nullCount > objects.Length / 2;
        }


        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var n = numbers.Where(num => num % 2 == 0);
            if (n.Count() == 0)
            {
                return 0;
            }
            return n.Average();
        }
        
        
        public int Factorial(int number)
        {
            if (number  == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
