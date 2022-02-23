using System;

namespace Lesson5_HomeTask
{
    public static class Calculation
    {
        public static int GetSum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int GetMultiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double GetDivide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("Can not divide by zero");
            }

            return Math.Round((double)firstNumber / secondNumber, 2);
        }
    }
}
