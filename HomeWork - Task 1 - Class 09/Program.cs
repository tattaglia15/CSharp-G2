using System;
using System.Collections.Generic;

namespace HomeWork___Task_1___Class_09
{
    internal class Program
    {
        public static object Que { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Numbers:");
            Queue<int> numbers = new Queue<int>();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();
            string input5 = Console.ReadLine();
            numbers.Enqueue(int.Parse(input1));
            numbers.Enqueue(int.Parse(input2));
            numbers.Enqueue(int.Parse(input3));
            numbers.Enqueue(int.Parse(input4));
            numbers.Enqueue(int.Parse(input5));
            foreach(int number in numbers)
            {
                Console.WriteLine($"The Numbers from input in Queue List: {number}");
            }
            


        }
    }
}
