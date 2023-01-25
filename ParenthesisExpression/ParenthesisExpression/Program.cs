using System;

namespace ParenthesisExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Divider = 2;
            const int Deductible = 1;

            string simbol = "()";
            char leftSimbol = '(';
            char rightSimbol = ')';
            int maximumDepth = 0;

            foreach (var item in simbol)
            {
                if (item == leftSimbol)
                {
                    maximumDepth++;
                }
                else if (item == rightSimbol)
                {
                    maximumDepth++;
                }
            }

            if (maximumDepth % Divider == 0)
            {
                maximumDepth = maximumDepth / Divider - Deductible;

                Console.WriteLine($"строка корректная и максимум глубины = {maximumDepth / Divider}");
            }
            else
            {
                Console.WriteLine("строка не корректная");
            }
        }
    }
}
