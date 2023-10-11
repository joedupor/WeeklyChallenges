using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)         // 1.
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)         // or since a bool could write this line in shorthand of "if (ignoreCase)" 
            {
                word = word.ToLower();      // converts case of "word" to lower case

                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)                                                                  // 2.
        {
            bool isPrimeNum = false;

            if (num > 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrimeNum = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                isPrimeNum = true;
            }

            if (num == 1)
            {
                isPrimeNum = false;
            }

            return isPrimeNum;
        }

        public int IndexOfLastUniqueLetter(string str)                                                      // 3.
        {
            int index = -1;
            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)                                                       // 4.
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)                                    // 5.
        {
            List<double> nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();   // this works here because nthElement is currently empty as at this point as created on line 114
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }
            }
            return nthElement.ToArray();
        }
    }
}
