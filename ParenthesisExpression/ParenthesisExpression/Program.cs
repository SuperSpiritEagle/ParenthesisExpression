using System;

namespace ParenthesisExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string simbol = "(((())(())))";
            char leftSimbol = '(';
            char rightSimbol = ')';
            int countLeft = 0;
            int countRight = 0;
            int maximumDepth = 0;

            foreach (var item in simbol)
            {
                if (item == leftSimbol)
                {
                    countLeft++;
                }
                else if (item == rightSimbol)
                {
                    countRight++;
                }
            }

            Console.WriteLine();

            countLeft--;
            countRight--;
            maximumDepth = countRight;

            if (countLeft != countRight)
            {
                Console.WriteLine("строка не корректная");
            }
            else if (countLeft == countRight)
            {
                Console.WriteLine($"строка корректная и максимум глубины = {maximumDepth}");
            }
        }
    }
}
