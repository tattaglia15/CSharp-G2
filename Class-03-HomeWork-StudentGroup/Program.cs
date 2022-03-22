using System;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] studentsGoOne = { "Zdravko", "Bojan", "Petko", "Milosh", "Kristijan" };
            string[] studentsGtTwo = { "Bojana", "Kristijan", "Tanja", "Marko", "Damjan" };
            Console.WriteLine("Please Enter Student Group from 1 - 2:");
            string number = Console.ReadLine();
            bool ifisValideNumber = int.TryParse(number, out int parsedNumber);
            if (!ifisValideNumber || parsedNumber > 2 || parsedNumber <= 0)
            {
                Console.WriteLine("Wrong Input");
            }
            if(parsedNumber == 1)
            {
                foreach (string student in studentsGoOne)
                {
                    Console.WriteLine(student);
                }
            } else if(parsedNumber == 2)
            {
                foreach(string secStudent in studentsGtTwo)
                {
                    Console.WriteLine(secStudent);
                }
            }
            
            
        }
    }
}
