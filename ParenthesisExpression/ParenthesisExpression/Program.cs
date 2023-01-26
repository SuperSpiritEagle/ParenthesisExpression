using System;

namespace ParenthesisExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string simbol = "()";
            char leftSimbol = '(';
            char rightSimbol = ')';
            int maximumDepth = 0;
            int divider = 2;
            int deductible = 1;

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
            
            if (maximumDepth%divider==0)
            {
                maximumDepth = maximumDepth / divider - deductible;

                Console.WriteLine($"строка корректная и максимум глубины = {maximumDepth}");
            }
            else
            {
                Console.WriteLine("строка не корректная");
            }
        }
    }
}
