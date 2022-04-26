using System;
using System.Collections.Generic;

namespace Solo_Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.\nEnter number: ");
            int userNumber = Int32.Parse(Console.ReadLine());
            numbers.Add(userNumber);
            if (userNumber != 0)
            {
                do
                {
                    Console.WriteLine("Enter number: ");
                    userNumber = Int32.Parse(Console.ReadLine());
                    numbers.Add(userNumber);
                } while (userNumber != 0);
            }
            int sum = 0;
            int largest = 0;

            foreach (int number in numbers)
            {
                if (largest < number)
                {
                    largest = number;
                }
                sum += number;
            }
            int average = sum / numbers.Count;

            Console.WriteLine($"The sum of the numbers is {sum}.");
            Console.WriteLine($"The average of the number is {average}.");
            Console.WriteLine($"The largest number is {largest}.");
        }
    }
}
