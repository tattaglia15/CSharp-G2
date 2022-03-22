using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = new int[6];
            int sum = 0;
            for (int i = 0; i <arrayOfNums.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                string numbers = Console.ReadLine();
                bool ifNumberParsed = int.TryParse(numbers, out int parsedNumber);
                if(!ifNumberParsed || parsedNumber <= 0)
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
                if(parsedNumber % 2 == 0)
                {
                    sum += parsedNumber;
                }
            }
            Console.WriteLine($"The sum of all even numbers is {sum}");
            


        }
    }
}
