using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 2 numbers:");
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            int fNum = int.Parse(firstNum);
            int sNum = int.Parse(secondNum);
            Console.WriteLine("Enter the operator");
            string enterOperator = Console.ReadLine();
            if (enterOperator == "+" )
            {
                Console.WriteLine(fNum + sNum);
            } else if (enterOperator == "-" )
            {
                Console.WriteLine(fNum - sNum);
            } else if(enterOperator == "*")
            {
                Console.WriteLine(fNum * sNum);
            } else if ( enterOperator ==  "/")
            {
                Console.WriteLine(fNum / sNum);
            } else
            {
                Console.WriteLine("Invalid Operator");
            }
                
        }
    }
}
