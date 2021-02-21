using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            return number1 += number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //if(number1 < number2)
            //{
            //    return number1;
            //}
            //return number2;

            return number1 < number2 ? number1 : number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            //var answer = factor1 * factor2;
            //return answer;

            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //Console.Write("What is your name?");
            //var name = Console.ReadLine();
            //GetGreeting(name);

            if(nameOfPerson != "")
            {
                return ($"Hello, {nameOfPerson}");
            }
            else
            {
                return "Hello!";
            }

        }

        public string GetHey()
        {
            return "HEY!";

        }
    }
}
