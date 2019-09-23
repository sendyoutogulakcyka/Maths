using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1 = 0;
            int iNum2 = 0;
            int iAnswer = 0;
            Console.WriteLine("Please input the first number that you want to add up ");
            iNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the second number that you want to add up");
            iNum2 = int.Parse(Console.ReadLine());

            iAnswer = iNum1 + iNum2;

            Console.WriteLine("The answer to " + iNum1 + " + " + iNum2 + " is " + iAnswer);
            //Or Console.Writeline("The answer to {0} + {1} is {2}" , iNum1, iNum2, iAnswer;
            Console.ReadLine();
        }
    }
}
