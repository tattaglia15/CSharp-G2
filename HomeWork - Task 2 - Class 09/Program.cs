using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork___Task_2___Class_09
{
    internal class Program
    {
        private static int num;

        static void Main(string[] args)
        {
            Console.WriteLine("List of 10 numbers");
            List<int> listOfNumbers = new List<int>()
            {
                {15},
                {17},
                {2},
                {4},
                {5},
                {6},
                {7},
                {8},
                {9},
                {10},
            };
            List<int> squareNums = listOfNumbers.Select(num => num * 2).ToList();
            foreach(int num in squareNums)
            {
                Console.WriteLine($"The Square Of Numbers in List:{num}");
            }
        }
    }
}
