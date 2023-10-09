using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)                             //1.
        {
            {
                int total = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        total += number;
                    }

                    if (number % 2 != 0)
                    {
                        total -= number;
                    }
                }

                return total;


            }
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)    //2.
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)        //3.
        {
            var list = new List<int>() { number1, number2, number3, number4 };

            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)           //4.
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)        //5.
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1 + sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1) 
            {
                return true;
            }

            return false;
        }

        public bool IsStringANumber(string input)                           //6.
        {
            bool isANumber = double.TryParse(input, out double number);

            return isANumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)         //7.
            {
                var amountOfElements = objs.Length;
                var majorityOfEs = (amountOfElements / 2) + 1;

                var count = 0;

                foreach (string item in objs)
                {
                    if (item == null)
                    {
                        count++;
                    }
                }

                if (count >= majorityOfEs)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



        public double AverageEvens(int[] numbers)                           //8.
            {
                double sumTotal = 0;
                double numOfElements = 0;

                if (numbers == null)
                {
                    return 0;
                }

                foreach (int item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        sumTotal += item; 
                        numOfElements++;
                    }
                }

                if (numOfElements > 0)
                {
                    return sumTotal / numOfElements;
                }
                else
                {
                    return 0;
                }
            }

        public int Factorial(int number)                                    //9.
        {
            int factoredNumber = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                factoredNumber *= i;
            }

            return factoredNumber;
        }
    }
}
