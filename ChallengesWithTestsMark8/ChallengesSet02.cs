using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alphabet.Length; i++)    
            {
                if (alphabet[i] == c)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;


        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;    
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }

            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            { 
                return 0; 
            }   
            
            int sum = 0;
            
            for (int i=0; i <  numbers.Length; i++) 
            {
                sum += numbers[i];
            } 
            return sum;
            
            //return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Sum() % 2 != 0 )
            {
                return true;
            }

            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }

            else 
            {
                return number / 2;
            }
        }
    }
}
