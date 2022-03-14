using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four Numbers:");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string thirdNumber = Console.ReadLine();
            string fourthNumber = Console.ReadLine();
            int fNum = int.Parse(firstNumber);
            int secNum = int.Parse(secondNumber);
            int tNum = int.Parse(thirdNumber);
            int foNum = int.Parse(fourthNumber);
            Console.WriteLine("The Average of Numbers is:");
            int rezult =(fNum + secNum + tNum + foNum / 4);
            Console.WriteLine(rezult);
            if(fNum == 0 && secNum == 0 && tNum == 0 && foNum == 0 )
            {
                Console.WriteLine("Error, Cannot calculate the average of 0");
            }

        }
    }
}
