using System;

namespace ParenthesisExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "()()())(()()()";
            char leftSimbol = '(';
            char rightSimbol = ')';
            int maximumDepth = 0;
            int dipth = 0;

            foreach (var simbol in text)
            {
                if (simbol == leftSimbol)
                {
                    dipth++;

                    if (dipth >maximumDepth)
                    {
                        maximumDepth = dipth;
                    }
                }
                else if (simbol == rightSimbol)
                {
                    dipth--;

                    if (dipth < 0)
                    {
                        break;
                    }
                }
            }

            if (dipth !=0)
            {
                Console.WriteLine("Не корректная запись.");
            }
            else
            {
                Console.WriteLine($"Строка корректная. Максимальная глубина : {maximumDepth}.");
            }
        }
    }
}
