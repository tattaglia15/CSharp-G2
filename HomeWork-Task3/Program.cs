using System;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 2 Numbers:");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            int fNum = int.Parse(firstNumber);
            int secNum = int.Parse(secondNumber);
            int swap;
            swap = fNum;
            fNum = secNum;
            secNum = swap;
            Console.WriteLine("After Swapping");
            Console.WriteLine($"First number is: {fNum}");
            Console.WriteLine($"Second Number is: {secNum}");
            
        }
    }
}
