using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)     //1.
        {
            foreach (bool item in vals)
            {
                if (item == false)
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)     //2.
        {
            if (numbers == null)
            {
                return false;
            }

            int sumOfOdds = numbers.Sum();

            if (sumOfOdds % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)     //3.
        {
            bool isLower = false;
            bool isUpper = false;
            bool isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }

                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }

            if (isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)       //4.
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)    //5.
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)     //6.
        {
            if (divisor == 0)
            {
                return 0;
            }
            
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)      //7.
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()       //8.
        {
            List<int> oddsBelow100 = new List<int>();

            for (int i = 0; i < 100; i++)
                if (i % 2 != 0)
                {
                    oddsBelow100.Add(i);
                }
            return oddsBelow100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)     //9.
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
            
        }
    }
}
